using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zion_Shuttle_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_cooldown_Tick(object sender, EventArgs e)
        {
            pb_cooldown.Value += 1;
            if (pb_cooldown.Value == pb_cooldown.Maximum)
            {
                pb_cooldown.Value = 0;
                tmr_cooldown.Stop();
                CheckForAvailableSlots();
            }
        }
        private void CheckForAvailableSlots()
        {
            int campgroundId = 300016;
            DateTime startDate = DateTime.Parse(dt_startDate.Value.ToShortDateString());
            DateTime endDate = DateTime.Parse(dt_endDate.Value.ToShortDateString());
            List<DateTime> datesToCamp = Enumerable.Range(0, 1 + endDate.Subtract(startDate).Days).Select(offset => startDate.AddDays(offset)).ToList();
            WebClient client = new WebClient();
            string urlBuilder = $"https://www.recreation.gov/api/ticket/availability/facility/{campgroundId}/monthlyAvailabilitySummaryView?year=2021&month=0{startDate.Month}&inventoryBucket=FIT";
            string response = client.DownloadString(urlBuilder);
            dynamic drecord = JsonConvert.DeserializeObject<dynamic>(response);
            JObject campsiteRecords = drecord["facility_availability_summary_view_by_local_date"];
            var hasSlots = false;
            foreach (var item in campsiteRecords)
            {
                DateTime dateToCheck = DateTime.Parse(item.Key);
                if (!datesToCamp.Contains(dateToCheck))
                {
                    continue;
                }
                List<string> dateSlots = item.Value.ToString().Split('\n').ToList();
                if (!dateSlots.Contains("      \"has_reservable\": false,\r"))
                {
                    logText(item.Key + " has available slots");
                    hasSlots = true;
                }
            }
            if (!hasSlots && !chk_ignore_empty.Checked)
            {
                logText("no slots found.");
            }
            tmr_cooldown.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForAvailableSlots();
            btn_end.Enabled = true;
            btn_start.Enabled = false;
        }
        private void logText(string item)
        {
            txt_log.AppendText(DateTime.Now.ToLongTimeString() + ": " + item + "\r\n");
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            btn_end.Enabled = false;
            btn_start.Enabled = true;
            tmr_cooldown.Stop();
            pb_cooldown.Value = 0;
        }

        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            txt_log.Clear();
        }
    }
}
