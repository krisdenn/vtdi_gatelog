namespace vtdi_gatelog
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnusers = new System.Windows.Forms.ToolStripMenuItem();
            this.btngateLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnreports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnuserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnscheduling = new System.Windows.Forms.ToolStripMenuItem();
            this.btnguestList = new System.Windows.Forms.ToolStripMenuItem();
            this.btngateInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btngateReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnuserLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnusers,
            this.btngateLogs,
            this.btnreports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnusers
            // 
            this.btnusers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnlogin,
            this.btnuserManagement,
            this.btnscheduling});
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(47, 20);
            this.btnusers.Text = "Users";
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btngateLogs
            // 
            this.btngateLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnguestList,
            this.btngateInOut});
            this.btngateLogs.Name = "btngateLogs";
            this.btngateLogs.Size = new System.Drawing.Size(71, 20);
            this.btngateLogs.Text = "Gate Logs";
            this.btngateLogs.Click += new System.EventHandler(this.btngateLogs_Click);
            // 
            // btnreports
            // 
            this.btnreports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btngateReports,
            this.btnuserLogs});
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(59, 20);
            this.btnreports.Text = "Reports";
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(180, 22);
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnuserManagement
            // 
            this.btnuserManagement.Name = "btnuserManagement";
            this.btnuserManagement.Size = new System.Drawing.Size(180, 22);
            this.btnuserManagement.Text = "User Management";
            this.btnuserManagement.Click += new System.EventHandler(this.btnuserManagement_Click);
            // 
            // btnscheduling
            // 
            this.btnscheduling.Name = "btnscheduling";
            this.btnscheduling.Size = new System.Drawing.Size(180, 22);
            this.btnscheduling.Text = "Scheduling";
            this.btnscheduling.Click += new System.EventHandler(this.btnscheduling_Click);
            // 
            // btnguestList
            // 
            this.btnguestList.Name = "btnguestList";
            this.btnguestList.Size = new System.Drawing.Size(180, 22);
            this.btnguestList.Text = "Guest List";
            this.btnguestList.Click += new System.EventHandler(this.btnguestList_Click);
            // 
            // btngateInOut
            // 
            this.btngateInOut.Name = "btngateInOut";
            this.btngateInOut.Size = new System.Drawing.Size(180, 22);
            this.btngateInOut.Text = "Gate In/Out";
            this.btngateInOut.Click += new System.EventHandler(this.btngateInOut_Click);
            // 
            // btngateReports
            // 
            this.btngateReports.Name = "btngateReports";
            this.btngateReports.Size = new System.Drawing.Size(180, 22);
            this.btngateReports.Text = "Gate Reports";
            this.btngateReports.Click += new System.EventHandler(this.btngateReports_Click);
            // 
            // btnuserLogs
            // 
            this.btnuserLogs.Name = "btnuserLogs";
            this.btnuserLogs.Size = new System.Drawing.Size(180, 22);
            this.btnuserLogs.Text = "User Logs";
            this.btnuserLogs.Click += new System.EventHandler(this.btnuserLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VTDI Gate Log Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnusers;
        private System.Windows.Forms.ToolStripMenuItem btnlogin;
        private System.Windows.Forms.ToolStripMenuItem btnuserManagement;
        private System.Windows.Forms.ToolStripMenuItem btnscheduling;
        private System.Windows.Forms.ToolStripMenuItem btngateLogs;
        private System.Windows.Forms.ToolStripMenuItem btnguestList;
        private System.Windows.Forms.ToolStripMenuItem btngateInOut;
        private System.Windows.Forms.ToolStripMenuItem btnreports;
        private System.Windows.Forms.ToolStripMenuItem btngateReports;
        private System.Windows.Forms.ToolStripMenuItem btnuserLogs;
    }
}

