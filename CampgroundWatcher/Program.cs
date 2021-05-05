using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace CampgroundWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            int campgroundId = 300016;
            DateTime startDate = new DateTime(2021, 5, 21);
            DateTime endDate = new DateTime(2021, 5, 22);
            List<DateTime> datesToCamp = Enumerable.Range(0, 1 + endDate.Subtract(startDate).Days).Select(offset => startDate.AddDays(offset)).ToList();
            WebClient client = new WebClient();
            string urlBuilder = $"https://www.recreation.gov/api/ticket/availability/facility/{campgroundId}/monthlyAvailabilitySummaryView?year=2021&month=0{startDate.Month}&inventoryBucket=FIT";
            string response = client.DownloadString(urlBuilder);
            dynamic drecord = JsonConvert.DeserializeObject<dynamic>(response);
            JObject campsiteRecords = drecord["facility_availability_summary_view_by_local_date"];
            bool restart = true;
            var hasSlots = false;
            foreach (var item in campsiteRecords)
            {
                List<string> dateSlots = item.Value.ToString().Split('\n').ToList();
                if (!dateSlots.Contains("      \"has_reservable\": false,\r"))
                {
                    Console.WriteLine(item.Key + " has available slots");
                    hasSlots = true;
                }
            }
            if (!hasSlots)
            {
                Console.WriteLine("no slots found.");
            }
            if (restart)
            {
                Console.WriteLine("checking again in a minute");
                System.Threading.Thread.Sleep(60000);
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
            } else
            {
                Console.ReadLine();
            }
        }
    }
}
