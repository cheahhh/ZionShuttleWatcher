
namespace Zion_Shuttle_Monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dt_startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_cooldown = new System.Windows.Forms.ProgressBar();
            this.tmr_cooldown = new System.Windows.Forms.Timer(this.components);
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.chk_ignore_empty = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dt_startDate
            // 
            this.dt_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_startDate.Location = new System.Drawing.Point(85, 12);
            this.dt_startDate.Name = "dt_startDate";
            this.dt_startDate.Size = new System.Drawing.Size(119, 23);
            this.dt_startDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Begin Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date:";
            // 
            // dt_endDate
            // 
            this.dt_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_endDate.Location = new System.Drawing.Point(273, 12);
            this.dt_endDate.Name = "dt_endDate";
            this.dt_endDate.Size = new System.Drawing.Size(119, 23);
            this.dt_endDate.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(398, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(95, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Begin Search";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_end
            // 
            this.btn_end.Enabled = false;
            this.btn_end.Location = new System.Drawing.Point(499, 12);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(95, 23);
            this.btn_end.TabIndex = 5;
            this.btn_end.Text = "Stop Search";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(13, 70);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(581, 396);
            this.txt_log.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cool down period:";
            // 
            // pb_cooldown
            // 
            this.pb_cooldown.Location = new System.Drawing.Point(124, 472);
            this.pb_cooldown.Maximum = 60;
            this.pb_cooldown.Name = "pb_cooldown";
            this.pb_cooldown.Size = new System.Drawing.Size(470, 23);
            this.pb_cooldown.TabIndex = 8;
            // 
            // tmr_cooldown
            // 
            this.tmr_cooldown.Interval = 1000;
            this.tmr_cooldown.Tick += new System.EventHandler(this.tmr_cooldown_Tick);
            // 
            // btn_clearlog
            // 
            this.btn_clearlog.Location = new System.Drawing.Point(499, 41);
            this.btn_clearlog.Name = "btn_clearlog";
            this.btn_clearlog.Size = new System.Drawing.Size(95, 23);
            this.btn_clearlog.TabIndex = 9;
            this.btn_clearlog.Text = "Clear Log";
            this.btn_clearlog.UseVisualStyleBackColor = true;
            this.btn_clearlog.Click += new System.EventHandler(this.btn_clearlog_Click);
            // 
            // chk_ignore_empty
            // 
            this.chk_ignore_empty.AutoSize = true;
            this.chk_ignore_empty.Location = new System.Drawing.Point(369, 44);
            this.chk_ignore_empty.Name = "chk_ignore_empty";
            this.chk_ignore_empty.Size = new System.Drawing.Size(124, 19);
            this.chk_ignore_empty.TabIndex = 10;
            this.chk_ignore_empty.Text = "Ignore empty slots";
            this.chk_ignore_empty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 508);
            this.Controls.Add(this.chk_ignore_empty);
            this.Controls.Add(this.btn_clearlog);
            this.Controls.Add(this.pb_cooldown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.dt_endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_startDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zion Shuttle Tickets Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_endDate;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_cooldown;
        private System.Windows.Forms.Timer tmr_cooldown;
        private System.Windows.Forms.Button btn_clearlog;
        private System.Windows.Forms.CheckBox chk_ignore_empty;
    }
}

