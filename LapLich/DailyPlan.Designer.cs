
namespace LapLich
{
    partial class DailyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDay = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpD = new System.Windows.Forms.DateTimePicker();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mnsMain);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 710);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPreviousDay);
            this.panel2.Controls.Add(this.btnNextDay);
            this.panel2.Controls.Add(this.dtpD);
            this.panel2.Location = new System.Drawing.Point(4, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 68);
            this.panel2.TabIndex = 0;
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(4, 105);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(1171, 605);
            this.pnlJob.TabIndex = 1;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddJob,
            this.mnsDay});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1178, 28);
            this.mnsMain.TabIndex = 2;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsAddJob
            // 
            this.mnsAddJob.Name = "mnsAddJob";
            this.mnsAddJob.Size = new System.Drawing.Size(90, 24);
            this.mnsAddJob.Text = "Thêm việc";
            // 
            // mnsDay
            // 
            this.mnsDay.Name = "mnsDay";
            this.mnsDay.Size = new System.Drawing.Size(83, 24);
            this.mnsDay.Text = "Hôm nay";
            // 
            // dtpD
            // 
            this.dtpD.Location = new System.Drawing.Point(463, 17);
            this.dtpD.Name = "dtpD";
            this.dtpD.Size = new System.Drawing.Size(250, 27);
            this.dtpD.TabIndex = 0;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(1074, 17);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(94, 29);
            this.btnNextDay.TabIndex = 0;
            this.btnNextDay.Text = "Ngày mai";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(8, 18);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(94, 29);
            this.btnPreviousDay.TabIndex = 1;
            this.btnPreviousDay.Text = "Hôm qua";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 743);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "DailyPlan";
            this.Text = "Lịch trong ngày";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsDay;
        private System.Windows.Forms.DateTimePicker dtpD;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
    }
}