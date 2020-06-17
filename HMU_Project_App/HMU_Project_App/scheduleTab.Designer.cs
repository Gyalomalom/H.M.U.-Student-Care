namespace HMU_Project_App
{
    partial class ScheduleTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCleaned = new System.Windows.Forms.Button();
            this.lbCleaningTime = new System.Windows.Forms.ListBox();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.pbSchedule = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cleaning duties";
            // 
            // btnCleaned
            // 
            this.btnCleaned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnCleaned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleaned.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCleaned.ForeColor = System.Drawing.Color.White;
            this.btnCleaned.Location = new System.Drawing.Point(400, 175);
            this.btnCleaned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleaned.Name = "btnCleaned";
            this.btnCleaned.Size = new System.Drawing.Size(144, 76);
            this.btnCleaned.TabIndex = 25;
            this.btnCleaned.Text = "Cleaned";
            this.btnCleaned.UseVisualStyleBackColor = false;
            this.btnCleaned.Click += new System.EventHandler(this.BtnCleaned_Click);
            // 
            // lbCleaningTime
            // 
            this.lbCleaningTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCleaningTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCleaningTime.ForeColor = System.Drawing.Color.Gray;
            this.lbCleaningTime.FormattingEnabled = true;
            this.lbCleaningTime.ItemHeight = 21;
            this.lbCleaningTime.Location = new System.Drawing.Point(54, 175);
            this.lbCleaningTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCleaningTime.Name = "lbCleaningTime";
            this.lbCleaningTime.Size = new System.Drawing.Size(317, 252);
            this.lbCleaningTime.TabIndex = 20;
            // 
            // cbRooms
            // 
            this.cbRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRooms.FormattingEnabled = true;
            this.cbRooms.Items.AddRange(new object[] {
            "Room1",
            "Room2",
            "Room3",
            "Room4",
            "Room5",
            "Kitchen",
            "Bathroom",
            "Livingroom"});
            this.cbRooms.Location = new System.Drawing.Point(54, 108);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(317, 24);
            this.cbRooms.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pbSchedule.Image = global::HMU_Project_App.Properties.Resources.icons8_clean_64;
            this.pbSchedule.Location = new System.Drawing.Point(679, 175);
            this.pbSchedule.Name = "pictureBox1";
            this.pbSchedule.Size = new System.Drawing.Size(143, 143);
            this.pbSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSchedule.TabIndex = 30;
            this.pbSchedule.TabStop = false;
            // 
            // ScheduleTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbSchedule);
            this.Controls.Add(this.cbRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCleaned);
            this.Controls.Add(this.lbCleaningTime);
            this.Name = "ScheduleTab";
            this.Size = new System.Drawing.Size(918, 463);
            this.Load += new System.EventHandler(this.ScheduleTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCleaned;
        private System.Windows.Forms.ListBox lbCleaningTime;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.PictureBox pbSchedule;
    }
}
