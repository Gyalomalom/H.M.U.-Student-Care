namespace HMU_Project_App
{
    partial class PassChange
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
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.btnSetNewPass = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.pbChangePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePass)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.FlatAppearance.BorderSize = 0;
            this.cbShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPass.Location = new System.Drawing.Point(568, 208);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(124, 21);
            this.cbShowPass.TabIndex = 11;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // btnSetNewPass
            // 
            this.btnSetNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnSetNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetNewPass.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetNewPass.ForeColor = System.Drawing.Color.White;
            this.btnSetNewPass.Location = new System.Drawing.Point(373, 347);
            this.btnSetNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetNewPass.Name = "btnSetNewPass";
            this.btnSetNewPass.Size = new System.Drawing.Size(152, 55);
            this.btnSetNewPass.TabIndex = 10;
            this.btnSetNewPass.Text = "Change password";
            this.btnSetNewPass.UseVisualStyleBackColor = false;
            this.btnSetNewPass.Click += new System.EventHandler(this.BtnSetNewPass_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPass.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNewPass.Location = new System.Drawing.Point(373, 304);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(152, 23);
            this.tbNewPass.TabIndex = 9;
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurrentPass.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCurrentPass.ForeColor = System.Drawing.Color.Gray;
            this.tbCurrentPass.Location = new System.Drawing.Point(373, 206);
            this.tbCurrentPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(152, 23);
            this.tbCurrentPass.TabIndex = 8;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPass.Location = new System.Drawing.Point(369, 263);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(181, 23);
            this.lblNewPass.TabIndex = 7;
            this.lblNewPass.Text = "Your new password:";
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOldPass.Location = new System.Drawing.Point(369, 166);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(208, 23);
            this.lblOldPass.TabIndex = 6;
            this.lblOldPass.Text = "Your current password:";
            // 
            // pictureBox1
            // 
            this.pbChangePass.Image = global::HMU_Project_App.Properties.Resources.icons8_administrative_tools_100;
            this.pbChangePass.Location = new System.Drawing.Point(396, 45);
            this.pbChangePass.Name = "pictureBox1";
            this.pbChangePass.Size = new System.Drawing.Size(117, 118);
            this.pbChangePass.TabIndex = 12;
            this.pbChangePass.TabStop = false;
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbChangePass);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.btnSetNewPass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurrentPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Name = "PassChange";
            this.Size = new System.Drawing.Size(918, 463);
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Button btnSetNewPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.PictureBox pbChangePass;
    }
}
