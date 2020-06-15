namespace HMU_Project_App
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbViewRules = new System.Windows.Forms.ListBox();
            this.btnViewRules = new System.Windows.Forms.Button();
            this.btnHideRules = new System.Windows.Forms.Button();
            this.pnlGarbage = new System.Windows.Forms.Panel();
            this.lblGarbage = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTrash = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.TempAndLightPort = new System.IO.Ports.SerialPort(this.components);
            this.pnlGarbage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbViewRules
            // 
            this.lbViewRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbViewRules.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbViewRules.ForeColor = System.Drawing.Color.Gray;
            this.lbViewRules.FormattingEnabled = true;
            this.lbViewRules.ItemHeight = 21;
            this.lbViewRules.Location = new System.Drawing.Point(75, 99);
            this.lbViewRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbViewRules.Name = "lbViewRules";
            this.lbViewRules.Size = new System.Drawing.Size(400, 273);
            this.lbViewRules.TabIndex = 2;
            this.lbViewRules.SelectedIndexChanged += new System.EventHandler(this.LbViewRules_SelectedIndexChanged);
            // 
            // btnViewRules
            // 
            this.btnViewRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnViewRules.FlatAppearance.BorderSize = 0;
            this.btnViewRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRules.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnViewRules.ForeColor = System.Drawing.Color.White;
            this.btnViewRules.Location = new System.Drawing.Point(75, 387);
            this.btnViewRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewRules.Name = "btnViewRules";
            this.btnViewRules.Size = new System.Drawing.Size(181, 52);
            this.btnViewRules.TabIndex = 3;
            this.btnViewRules.Text = "View Rules";
            this.btnViewRules.UseVisualStyleBackColor = false;
            this.btnViewRules.Click += new System.EventHandler(this.BtnViewRules_Click);
            // 
            // btnHideRules
            // 
            this.btnHideRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnHideRules.FlatAppearance.BorderSize = 0;
            this.btnHideRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideRules.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHideRules.ForeColor = System.Drawing.Color.White;
            this.btnHideRules.Location = new System.Drawing.Point(288, 387);
            this.btnHideRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHideRules.Name = "btnHideRules";
            this.btnHideRules.Size = new System.Drawing.Size(187, 52);
            this.btnHideRules.TabIndex = 4;
            this.btnHideRules.Text = "Hide Rules";
            this.btnHideRules.UseVisualStyleBackColor = false;
            this.btnHideRules.Click += new System.EventHandler(this.BtnHideRules_Click);
            // 
            // pnlGarbage
            // 
            this.pnlGarbage.Controls.Add(this.lblGarbage);
            this.pnlGarbage.Location = new System.Drawing.Point(511, 301);
            this.pnlGarbage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGarbage.Name = "pnlGarbage";
            this.pnlGarbage.Size = new System.Drawing.Size(234, 71);
            this.pnlGarbage.TabIndex = 5;
            this.pnlGarbage.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGarbage_Paint);
            // 
            // lblGarbage
            // 
            this.lblGarbage.AutoSize = true;
            this.lblGarbage.Location = new System.Drawing.Point(23, 30);
            this.lblGarbage.Name = "lblGarbage";
            this.lblGarbage.Size = new System.Drawing.Size(0, 17);
            this.lblGarbage.TabIndex = 5;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperature.ForeColor = System.Drawing.Color.Gray;
            this.lblTemperature.Location = new System.Drawing.Point(492, 99);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(86, 30);
            this.lblTemperature.TabIndex = 7;
            this.lblTemperature.Text = "label1";
            this.lblTemperature.Click += new System.EventHandler(this.LblTemperature_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(67, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 46);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Rules of the House";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(491, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Garbage status";
            // 
            // pbTrash
            // 
            this.pbTrash.Image = global::HMU_Project_App.Properties.Resources.icons8_trash_can_96;
            this.pbTrash.Location = new System.Drawing.Point(768, 244);
            this.pbTrash.Name = "pbTrash";
            this.pbTrash.Size = new System.Drawing.Size(135, 153);
            this.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrash.TabIndex = 12;
            this.pbTrash.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMU_Project_App.Properties.Resources.icons8_temperature_96;
            this.pictureBox1.Location = new System.Drawing.Point(768, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // TempAndLightPort
            // 
            this.TempAndLightPort.PortName = "COM5";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTrash);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnHideRules);
            this.Controls.Add(this.btnViewRules);
            this.Controls.Add(this.lbViewRules);
            this.Controls.Add(this.pnlGarbage);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(918, 463);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlGarbage.ResumeLayout(false);
            this.pnlGarbage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbViewRules;
        private System.Windows.Forms.Button btnViewRules;
        private System.Windows.Forms.Button btnHideRules;
        private System.Windows.Forms.Panel pnlGarbage;
        private System.Windows.Forms.Label lblGarbage;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTrash;
        private System.Windows.Forms.Timer timerUpdate;
        private System.IO.Ports.SerialPort TempAndLightPort;
    }
}
