namespace XelevatorSimulation
{
    partial class ElevatorButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorButtons));
            this.inside_panel = new System.Windows.Forms.PictureBox();
            this.display_inside = new System.Windows.Forms.PictureBox();
            this.btn_inside_1 = new System.Windows.Forms.Button();
            this.btn_inside_0 = new System.Windows.Forms.Button();
            this.btn_inside_close = new System.Windows.Forms.Button();
            this.btn_inside_open = new System.Windows.Forms.Button();
            this.btn_inside_alarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inside_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_inside)).BeginInit();
            this.SuspendLayout();
            // 
            // inside_panel
            // 
            this.inside_panel.Image = ((System.Drawing.Image)(resources.GetObject("inside_panel.Image")));
            this.inside_panel.Location = new System.Drawing.Point(0, 0);
            this.inside_panel.Name = "inside_panel";
            this.inside_panel.Size = new System.Drawing.Size(170, 460);
            this.inside_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inside_panel.TabIndex = 0;
            this.inside_panel.TabStop = false;
            // 
            // display_inside
            // 
            this.display_inside.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_inside.Image = ((System.Drawing.Image)(resources.GetObject("display_inside.Image")));
            this.display_inside.Location = new System.Drawing.Point(35, 25);
            this.display_inside.Name = "display_inside";
            this.display_inside.Size = new System.Drawing.Size(100, 80);
            this.display_inside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_inside.TabIndex = 1;
            this.display_inside.TabStop = false;
            // 
            // btn_inside_1
            // 
            this.btn_inside_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inside_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inside_1.BackgroundImage")));
            this.btn_inside_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inside_1.Font = new System.Drawing.Font("Arial", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_inside_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inside_1.Location = new System.Drawing.Point(52, 125);
            this.btn_inside_1.Name = "btn_inside_1";
            this.btn_inside_1.Size = new System.Drawing.Size(65, 60);
            this.btn_inside_1.TabIndex = 2;
            this.btn_inside_1.Text = "1";
            this.btn_inside_1.UseVisualStyleBackColor = false;
            this.btn_inside_1.Click += new System.EventHandler(this.btn_inside_1_Click);
            // 
            // btn_inside_0
            // 
            this.btn_inside_0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inside_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inside_0.BackgroundImage")));
            this.btn_inside_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inside_0.Font = new System.Drawing.Font("Arial", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_inside_0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inside_0.Location = new System.Drawing.Point(52, 191);
            this.btn_inside_0.Name = "btn_inside_0";
            this.btn_inside_0.Size = new System.Drawing.Size(65, 60);
            this.btn_inside_0.TabIndex = 3;
            this.btn_inside_0.Text = "0";
            this.btn_inside_0.UseVisualStyleBackColor = false;
            this.btn_inside_0.Click += new System.EventHandler(this.btn_inside_0_Click);
            // 
            // btn_inside_close
            // 
            this.btn_inside_close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inside_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inside_close.BackgroundImage")));
            this.btn_inside_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inside_close.Location = new System.Drawing.Point(47, 308);
            this.btn_inside_close.Name = "btn_inside_close";
            this.btn_inside_close.Size = new System.Drawing.Size(75, 45);
            this.btn_inside_close.TabIndex = 4;
            this.btn_inside_close.UseVisualStyleBackColor = false;
            this.btn_inside_close.Click += new System.EventHandler(this.btn_inside_close_Click);
            // 
            // btn_inside_open
            // 
            this.btn_inside_open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inside_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inside_open.BackgroundImage")));
            this.btn_inside_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inside_open.Location = new System.Drawing.Point(47, 257);
            this.btn_inside_open.Name = "btn_inside_open";
            this.btn_inside_open.Size = new System.Drawing.Size(75, 45);
            this.btn_inside_open.TabIndex = 5;
            this.btn_inside_open.UseVisualStyleBackColor = false;
            this.btn_inside_open.Click += new System.EventHandler(this.btn_inside_open_Click);
            // 
            // btn_inside_alarm
            // 
            this.btn_inside_alarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inside_alarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inside_alarm.BackgroundImage")));
            this.btn_inside_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inside_alarm.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inside_alarm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inside_alarm.Location = new System.Drawing.Point(52, 378);
            this.btn_inside_alarm.Name = "btn_inside_alarm";
            this.btn_inside_alarm.Size = new System.Drawing.Size(65, 60);
            this.btn_inside_alarm.TabIndex = 6;
            this.btn_inside_alarm.Text = "A";
            this.btn_inside_alarm.UseVisualStyleBackColor = false;
            this.btn_inside_alarm.Click += new System.EventHandler(this.btn_inside_alarm_Click);
            // 
            // ElevatorButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(169, 459);
            this.ControlBox = false;
            this.Controls.Add(this.btn_inside_alarm);
            this.Controls.Add(this.btn_inside_open);
            this.Controls.Add(this.btn_inside_close);
            this.Controls.Add(this.btn_inside_0);
            this.Controls.Add(this.btn_inside_1);
            this.Controls.Add(this.display_inside);
            this.Controls.Add(this.inside_panel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ElevatorButtons";
            this.Tag = "";
            this.Text = "Comand Panel";
            ((System.ComponentModel.ISupportInitialize)(this.inside_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_inside)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox inside_panel;
        public System.Windows.Forms.PictureBox display_inside;
        public System.Windows.Forms.Button btn_inside_1;
        public System.Windows.Forms.Button btn_inside_0;
        public System.Windows.Forms.Button btn_inside_close;
        public System.Windows.Forms.Button btn_inside_open;
        public System.Windows.Forms.Button btn_inside_alarm;
    }
}