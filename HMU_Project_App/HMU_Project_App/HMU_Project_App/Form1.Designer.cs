namespace HMU_Project_App
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
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tabAdminLogin = new System.Windows.Forms.TabPage();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.tbAdminPass = new System.Windows.Forms.TextBox();
            this.tabAdminPanel = new System.Windows.Forms.TabPage();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnReadComplaints = new System.Windows.Forms.Button();
            this.tbRuleContent = new System.Windows.Forms.TextBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tabPassChange = new System.Windows.Forms.TabPage();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.btnSetNewPass = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lbViewRules = new System.Windows.Forms.ListBox();
            this.btnViewRules = new System.Windows.Forms.Button();
            this.btnHideRules = new System.Windows.Forms.Button();
            this.tabGeneral.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabAdminLogin.SuspendLayout();
            this.tabAdminPanel.SuspendLayout();
            this.tabPassChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabDashboard);
            this.tabGeneral.Controls.Add(this.tabAdminLogin);
            this.tabGeneral.Controls.Add(this.tabAdminPanel);
            this.tabGeneral.Controls.Add(this.tabPassChange);
            this.tabGeneral.Location = new System.Drawing.Point(298, 0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1020, 527);
            this.tabGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGeneral.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.btnHideRules);
            this.tabDashboard.Controls.Add(this.btnViewRules);
            this.tabDashboard.Controls.Add(this.lbViewRules);
            this.tabDashboard.Controls.Add(this.btnAdmin);
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1012, 498);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(934, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tabAdminLogin
            // 
            this.tabAdminLogin.Controls.Add(this.btnAdminLogin);
            this.tabAdminLogin.Controls.Add(this.lblAdminPass);
            this.tabAdminLogin.Controls.Add(this.tbAdminPass);
            this.tabAdminLogin.Location = new System.Drawing.Point(4, 25);
            this.tabAdminLogin.Name = "tabAdminLogin";
            this.tabAdminLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminLogin.Size = new System.Drawing.Size(1012, 498);
            this.tabAdminLogin.TabIndex = 0;
            this.tabAdminLogin.Text = "Admin log-in";
            this.tabAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(401, 191);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(126, 36);
            this.btnAdminLogin.TabIndex = 3;
            this.btnAdminLogin.Text = "Log in";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(401, 143);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(73, 17);
            this.lblAdminPass.TabIndex = 2;
            this.lblAdminPass.Text = "Password:";
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Location = new System.Drawing.Point(401, 163);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.PasswordChar = '*';
            this.tbAdminPass.Size = new System.Drawing.Size(126, 22);
            this.tbAdminPass.TabIndex = 1;
            // 
            // tabAdminPanel
            // 
            this.tabAdminPanel.Controls.Add(this.btnPassChange);
            this.tabAdminPanel.Controls.Add(this.btnReadComplaints);
            this.tabAdminPanel.Controls.Add(this.tbRuleContent);
            this.tabAdminPanel.Controls.Add(this.btnEditRule);
            this.tabAdminPanel.Controls.Add(this.btnAddRule);
            this.tabAdminPanel.Controls.Add(this.lbComplaints);
            this.tabAdminPanel.Controls.Add(this.lbRules);
            this.tabAdminPanel.Location = new System.Drawing.Point(4, 25);
            this.tabAdminPanel.Name = "tabAdminPanel";
            this.tabAdminPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPanel.Size = new System.Drawing.Size(1012, 498);
            this.tabAdminPanel.TabIndex = 1;
            this.tabAdminPanel.Text = "Admin Panel";
            this.tabAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(6, 434);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(169, 23);
            this.btnPassChange.TabIndex = 6;
            this.btnPassChange.Text = "Change password";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnReadComplaints
            // 
            this.btnReadComplaints.Location = new System.Drawing.Point(364, 434);
            this.btnReadComplaints.Name = "btnReadComplaints";
            this.btnReadComplaints.Size = new System.Drawing.Size(234, 23);
            this.btnReadComplaints.TabIndex = 5;
            this.btnReadComplaints.Text = "Read Complaints";
            this.btnReadComplaints.UseVisualStyleBackColor = true;
            this.btnReadComplaints.Click += new System.EventHandler(this.btnReadComplaints_Click);
            // 
            // tbRuleContent
            // 
            this.tbRuleContent.Location = new System.Drawing.Point(364, 151);
            this.tbRuleContent.Name = "tbRuleContent";
            this.tbRuleContent.Size = new System.Drawing.Size(234, 22);
            this.tbRuleContent.TabIndex = 4;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(482, 178);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(116, 23);
            this.btnEditRule.TabIndex = 3;
            this.btnEditRule.Text = "Replace rule";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(364, 179);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(111, 23);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add new rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 16;
            this.lbComplaints.Location = new System.Drawing.Point(604, 261);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(360, 196);
            this.lbComplaints.TabIndex = 1;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(604, 22);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(360, 180);
            this.lbRules.TabIndex = 0;
            // 
            // tabPassChange
            // 
            this.tabPassChange.Controls.Add(this.cbShowPass);
            this.tabPassChange.Controls.Add(this.btnSetNewPass);
            this.tabPassChange.Controls.Add(this.tbNewPass);
            this.tabPassChange.Controls.Add(this.tbCurrentPass);
            this.tabPassChange.Controls.Add(this.lblNewPass);
            this.tabPassChange.Controls.Add(this.lblOldPass);
            this.tabPassChange.Location = new System.Drawing.Point(4, 25);
            this.tabPassChange.Name = "tabPassChange";
            this.tabPassChange.Size = new System.Drawing.Size(1012, 498);
            this.tabPassChange.TabIndex = 3;
            this.tabPassChange.Text = "Change password";
            this.tabPassChange.UseVisualStyleBackColor = true;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(220, 43);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(128, 21);
            this.cbShowPass.TabIndex = 5;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckStateChanged += new System.EventHandler(this.cbShowPass_CheckStateChanged);
            // 
            // btnSetNewPass
            // 
            this.btnSetNewPass.Location = new System.Drawing.Point(22, 158);
            this.btnSetNewPass.Name = "btnSetNewPass";
            this.btnSetNewPass.Size = new System.Drawing.Size(152, 23);
            this.btnSetNewPass.TabIndex = 4;
            this.btnSetNewPass.Text = "Change password";
            this.btnSetNewPass.UseVisualStyleBackColor = true;
            this.btnSetNewPass.Click += new System.EventHandler(this.btnSetNewPass_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(22, 110);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(152, 22);
            this.tbNewPass.TabIndex = 3;
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(22, 43);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(152, 22);
            this.tbCurrentPass.TabIndex = 2;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(19, 90);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(135, 17);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "Your new password:";
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(19, 23);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(155, 17);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Your current password:";
            // 
            // lbViewRules
            // 
            this.lbViewRules.FormattingEnabled = true;
            this.lbViewRules.ItemHeight = 16;
            this.lbViewRules.Location = new System.Drawing.Point(44, 39);
            this.lbViewRules.Name = "lbViewRules";
            this.lbViewRules.Size = new System.Drawing.Size(342, 340);
            this.lbViewRules.TabIndex = 1;
            // 
            // btnViewRules
            // 
            this.btnViewRules.Location = new System.Drawing.Point(44, 405);
            this.btnViewRules.Name = "btnViewRules";
            this.btnViewRules.Size = new System.Drawing.Size(92, 39);
            this.btnViewRules.TabIndex = 2;
            this.btnViewRules.Text = "View rules";
            this.btnViewRules.UseVisualStyleBackColor = true;
            this.btnViewRules.Click += new System.EventHandler(this.BtnViewRules_Click);
            // 
            // btnHideRules
            // 
            this.btnHideRules.Location = new System.Drawing.Point(154, 405);
            this.btnHideRules.Name = "btnHideRules";
            this.btnHideRules.Size = new System.Drawing.Size(94, 39);
            this.btnHideRules.TabIndex = 3;
            this.btnHideRules.Text = "Hide rules";
            this.btnHideRules.UseVisualStyleBackColor = true;
            this.btnHideRules.Click += new System.EventHandler(this.BtnHideRules_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 529);
            this.Controls.Add(this.tabGeneral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabAdminLogin.ResumeLayout(false);
            this.tabAdminLogin.PerformLayout();
            this.tabAdminPanel.ResumeLayout(false);
            this.tabAdminPanel.PerformLayout();
            this.tabPassChange.ResumeLayout(false);
            this.tabPassChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabAdminLogin;
        private System.Windows.Forms.TabPage tabAdminPanel;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.TextBox tbAdminPass;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox tbRuleContent;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Button btnReadComplaints;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TabPage tabPassChange;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Button btnSetNewPass;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Button btnHideRules;
        private System.Windows.Forms.Button btnViewRules;
        private System.Windows.Forms.ListBox lbViewRules;
    }
}

