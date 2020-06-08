namespace HMU_Project_App
{
    partial class ComplaintsTab
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
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.tbComplaints = new System.Windows.Forms.TextBox();
            this.lblEnterComplaints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnAddComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComplaint.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddComplaint.ForeColor = System.Drawing.Color.White;
            this.btnAddComplaint.Location = new System.Drawing.Point(126, 285);
            this.btnAddComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(228, 46);
            this.btnAddComplaint.TabIndex = 5;
            this.btnAddComplaint.Text = "Send complaint";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // tbComplaints
            // 
            this.tbComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbComplaints.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbComplaints.ForeColor = System.Drawing.Color.Gray;
            this.tbComplaints.Location = new System.Drawing.Point(126, 199);
            this.tbComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.tbComplaints.Name = "tbComplaints";
            this.tbComplaints.Size = new System.Drawing.Size(228, 23);
            this.tbComplaints.TabIndex = 4;
            this.tbComplaints.TextChanged += new System.EventHandler(this.TbComplaints_TextChanged);
            // 
            // lblEnterComplaints
            // 
            this.lblEnterComplaints.AutoSize = true;
            this.lblEnterComplaints.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterComplaints.Location = new System.Drawing.Point(120, 95);
            this.lblEnterComplaints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterComplaints.Name = "lblEnterComplaints";
            this.lblEnterComplaints.Size = new System.Drawing.Size(237, 36);
            this.lblEnterComplaints.TabIndex = 3;
            this.lblEnterComplaints.Text = "Enter complaint:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMU_Project_App.Properties.Resources.icons8_document_512;
            this.pictureBox1.Location = new System.Drawing.Point(599, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ComplaintsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddComplaint);
            this.Controls.Add(this.tbComplaints);
            this.Controls.Add(this.lblEnterComplaints);
            this.Name = "ComplaintsTab";
            this.Size = new System.Drawing.Size(918, 463);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.TextBox tbComplaints;
        private System.Windows.Forms.Label lblEnterComplaints;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
