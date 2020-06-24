namespace HMU_Project_App
{
    partial class LoginTab
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.tbAdminPass = new System.Windows.Forms.TextBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(413, 323);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(106, 36);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.Text = "Log in";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click);
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdminPass.ForeColor = System.Drawing.Color.Black;
            this.lblAdminPass.Location = new System.Drawing.Point(409, 215);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(124, 29);
            this.lblAdminPass.TabIndex = 5;
            this.lblAdminPass.Text = "Password:";
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdminPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdminPass.ForeColor = System.Drawing.Color.Gray;
            this.tbAdminPass.Location = new System.Drawing.Point(413, 270);
            this.tbAdminPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.PasswordChar = '*';
            this.tbAdminPass.Size = new System.Drawing.Size(106, 21);
            this.tbAdminPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pbLogin.Image = global::HMU_Project_App.Properties.Resources.icons8_administrative_tools_100;
            this.pbLogin.Location = new System.Drawing.Point(413, 68);
            this.pbLogin.Name = "pictureBox1";
            this.pbLogin.Size = new System.Drawing.Size(129, 131);
            this.pbLogin.TabIndex = 7;
            this.pbLogin.TabStop = false;
            // 
            // LoginTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.lblAdminPass);
            this.Controls.Add(this.tbAdminPass);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "LoginTab";
            this.Size = new System.Drawing.Size(918, 463);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.TextBox tbAdminPass;
        private System.Windows.Forms.PictureBox pbLogin;
    }
}
