namespace XelevatorSimulation
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.lblAdminName = new System.Windows.Forms.Label();
            this.dbList_Box = new System.Windows.Forms.ListBox();
            this.btn_displayLog = new System.Windows.Forms.Button();
            this.btn_clearLog = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.admin_insidePanel = new System.Windows.Forms.PictureBox();
            this.admin_display = new System.Windows.Forms.PictureBox();
            this.admin_btn1 = new System.Windows.Forms.Button();
            this.admin_btn0 = new System.Windows.Forms.Button();
            this.admin_btnOpen = new System.Windows.Forms.Button();
            this.admin_btnClose = new System.Windows.Forms.Button();
            this.admin_btnAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admin_insidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_display)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdminName.Location = new System.Drawing.Point(12, 9);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(347, 25);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Welcome into the Administrator menu:";
            // 
            // dbList_Box
            // 
            this.dbList_Box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dbList_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbList_Box.FormattingEnabled = true;
            this.dbList_Box.HorizontalScrollbar = true;
            this.dbList_Box.ItemHeight = 17;
            this.dbList_Box.Location = new System.Drawing.Point(161, 59);
            this.dbList_Box.Name = "dbList_Box";
            this.dbList_Box.Size = new System.Drawing.Size(268, 276);
            this.dbList_Box.TabIndex = 1;
            // 
            // btn_displayLog
            // 
            this.btn_displayLog.BackColor = System.Drawing.Color.DarkGray;
            this.btn_displayLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_displayLog.Location = new System.Drawing.Point(161, 354);
            this.btn_displayLog.Name = "btn_displayLog";
            this.btn_displayLog.Size = new System.Drawing.Size(122, 30);
            this.btn_displayLog.TabIndex = 3;
            this.btn_displayLog.Text = "Display Log Events";
            this.btn_displayLog.UseVisualStyleBackColor = false;
            this.btn_displayLog.Click += new System.EventHandler(this.btn_displayLog_Click);
            // 
            // btn_clearLog
            // 
            this.btn_clearLog.BackColor = System.Drawing.Color.Silver;
            this.btn_clearLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clearLog.Location = new System.Drawing.Point(308, 354);
            this.btn_clearLog.Name = "btn_clearLog";
            this.btn_clearLog.Size = new System.Drawing.Size(121, 30);
            this.btn_clearLog.TabIndex = 5;
            this.btn_clearLog.Text = "Clear Log Events";
            this.btn_clearLog.UseVisualStyleBackColor = false;
            this.btn_clearLog.Click += new System.EventHandler(this.btn_clearLog_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.Color.Azure;
            this.btn_close.Location = new System.Drawing.Point(162, 403);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(121, 32);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close Admin Menu";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // admin_insidePanel
            // 
            this.admin_insidePanel.Image = ((System.Drawing.Image)(resources.GetObject("admin_insidePanel.Image")));
            this.admin_insidePanel.Location = new System.Drawing.Point(12, 82);
            this.admin_insidePanel.Name = "admin_insidePanel";
            this.admin_insidePanel.Size = new System.Drawing.Size(120, 354);
            this.admin_insidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_insidePanel.TabIndex = 7;
            this.admin_insidePanel.TabStop = false;
            // 
            // admin_display
            // 
            this.admin_display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_display.Image = ((System.Drawing.Image)(resources.GetObject("admin_display.Image")));
            this.admin_display.Location = new System.Drawing.Point(40, 104);
            this.admin_display.Name = "admin_display";
            this.admin_display.Size = new System.Drawing.Size(64, 60);
            this.admin_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_display.TabIndex = 8;
            this.admin_display.TabStop = false;
            // 
            // admin_btn1
            // 
            this.admin_btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btn1.BackgroundImage")));
            this.admin_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_btn1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.admin_btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_btn1.Location = new System.Drawing.Point(51, 179);
            this.admin_btn1.Name = "admin_btn1";
            this.admin_btn1.Size = new System.Drawing.Size(44, 40);
            this.admin_btn1.TabIndex = 9;
            this.admin_btn1.Text = "1";
            this.admin_btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.admin_btn1.UseVisualStyleBackColor = false;
            this.admin_btn1.Click += new System.EventHandler(this.admin_btn1_Click);
            // 
            // admin_btn0
            // 
            this.admin_btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btn0.BackgroundImage")));
            this.admin_btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_btn0.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.admin_btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_btn0.Location = new System.Drawing.Point(51, 225);
            this.admin_btn0.Name = "admin_btn0";
            this.admin_btn0.Size = new System.Drawing.Size(44, 40);
            this.admin_btn0.TabIndex = 10;
            this.admin_btn0.Text = "0";
            this.admin_btn0.UseVisualStyleBackColor = false;
            this.admin_btn0.Click += new System.EventHandler(this.admin_btn0_Click);
            // 
            // admin_btnOpen
            // 
            this.admin_btnOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btnOpen.BackgroundImage")));
            this.admin_btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_btnOpen.Location = new System.Drawing.Point(40, 280);
            this.admin_btnOpen.Name = "admin_btnOpen";
            this.admin_btnOpen.Size = new System.Drawing.Size(64, 38);
            this.admin_btnOpen.TabIndex = 11;
            this.admin_btnOpen.UseVisualStyleBackColor = false;
            this.admin_btnOpen.Click += new System.EventHandler(this.admin_btnOpen_Click);
            // 
            // admin_btnClose
            // 
            this.admin_btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btnClose.BackgroundImage")));
            this.admin_btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_btnClose.Location = new System.Drawing.Point(40, 324);
            this.admin_btnClose.Name = "admin_btnClose";
            this.admin_btnClose.Size = new System.Drawing.Size(64, 38);
            this.admin_btnClose.TabIndex = 12;
            this.admin_btnClose.UseVisualStyleBackColor = false;
            this.admin_btnClose.Click += new System.EventHandler(this.admin_btnClose_Click);
            // 
            // admin_btnAlarm
            // 
            this.admin_btnAlarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btnAlarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btnAlarm.BackgroundImage")));
            this.admin_btnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_btnAlarm.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.admin_btnAlarm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_btnAlarm.Location = new System.Drawing.Point(51, 377);
            this.admin_btnAlarm.Name = "admin_btnAlarm";
            this.admin_btnAlarm.Size = new System.Drawing.Size(44, 40);
            this.admin_btnAlarm.TabIndex = 13;
            this.admin_btnAlarm.Text = "A";
            this.admin_btnAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_btnAlarm.UseVisualStyleBackColor = false;
            this.admin_btnAlarm.Click += new System.EventHandler(this.admin_btnAlarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin Controller";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(308, 403);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 32);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete Log Events";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(444, 447);
            this.ControlBox = false;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_btnAlarm);
            this.Controls.Add(this.admin_btnClose);
            this.Controls.Add(this.admin_btnOpen);
            this.Controls.Add(this.admin_btn0);
            this.Controls.Add(this.admin_btn1);
            this.Controls.Add(this.admin_display);
            this.Controls.Add(this.admin_insidePanel);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clearLog);
            this.Controls.Add(this.btn_displayLog);
            this.Controls.Add(this.dbList_Box);
            this.Controls.Add(this.lblAdminName);
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_insidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button btn_clearLog;
        private System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.ListBox dbList_Box;
        public System.Windows.Forms.Button btn_displayLog;
        private System.Windows.Forms.Label label1;
      
        public System.Windows.Forms.PictureBox admin_display;
        public System.Windows.Forms.Button admin_btn1;
        public System.Windows.Forms.Button admin_btn0;
        public System.Windows.Forms.Button admin_btnOpen;
        public System.Windows.Forms.Button admin_btnClose;
        public System.Windows.Forms.Button admin_btnAlarm;
        public System.Windows.Forms.PictureBox admin_insidePanel;
        public System.Windows.Forms.Button btn_delete;
    }
}