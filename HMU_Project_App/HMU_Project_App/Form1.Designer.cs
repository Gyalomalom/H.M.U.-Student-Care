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
            this.components = new System.ComponentModel.Container();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pnlGarbage = new System.Windows.Forms.Panel();
            this.lblGarbage = new System.Windows.Forms.Label();
            this.btnHideRules = new System.Windows.Forms.Button();
            this.btnViewRules = new System.Windows.Forms.Button();
            this.lbViewRules = new System.Windows.Forms.ListBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tabAdminLogin = new System.Windows.Forms.TabPage();
            this.btnReturnToDash = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.tbAdminPass = new System.Windows.Forms.TextBox();
            this.tabAdminPanel = new System.Windows.Forms.TabPage();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnReadComplaints = new System.Windows.Forms.Button();
            this.tbRuleContent = new System.Windows.Forms.TextBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tabPassChange = new System.Windows.Forms.TabPage();
            this.btnBackToAdmin = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.btnSetNewPass = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.tbComplaints = new System.Windows.Forms.TextBox();
            this.lblEnterComplaints = new System.Windows.Forms.Label();
            this.tabShoppingList = new System.Windows.Forms.TabPage();
            this.bgEdit = new System.Windows.Forms.GroupBox();
            this.btnRmvSelected = new System.Windows.Forms.Button();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bgList = new System.Windows.Forms.GroupBox();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.cbShowCateg = new System.Windows.Forms.ComboBox();
            this.btnTakeAmount = new System.Windows.Forms.Button();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbShoppingList = new System.Windows.Forms.ListBox();
            this.timerTempAndLight = new System.Windows.Forms.Timer(this.components);
            this.TempAndLightPort = new System.IO.Ports.SerialPort(this.components);
            this.tabAgreements = new System.Windows.Forms.TabPage();
            this.gbAddAgreement = new System.Windows.Forms.GroupBox();
            this.btnRemoveAgreement = new System.Windows.Forms.Button();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.btnAcceptAgreement = new System.Windows.Forms.Button();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.tbAgreementInfo = new System.Windows.Forms.TextBox();
            this.gbViewAgreements = new System.Windows.Forms.GroupBox();
            this.btnShowAllAgreements = new System.Windows.Forms.Button();
            this.lbAgreements = new System.Windows.Forms.ListBox();
            this.btnShowAcceptedAgreement = new System.Windows.Forms.Button();
            this.tabGeneral.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.pnlGarbage.SuspendLayout();
            this.tabAdminLogin.SuspendLayout();
            this.tabAdminPanel.SuspendLayout();
            this.tabPassChange.SuspendLayout();
            this.tabComplaints.SuspendLayout();
            this.tabShoppingList.SuspendLayout();
            this.bgEdit.SuspendLayout();
            this.bgList.SuspendLayout();
            this.tabAgreements.SuspendLayout();
            this.gbAddAgreement.SuspendLayout();
            this.gbViewAgreements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabDashboard);
            this.tabGeneral.Controls.Add(this.tabAdminLogin);
            this.tabGeneral.Controls.Add(this.tabAdminPanel);
            this.tabGeneral.Controls.Add(this.tabPassChange);
            this.tabGeneral.Controls.Add(this.tabComplaints);
            this.tabGeneral.Controls.Add(this.tabShoppingList);
            this.tabGeneral.Controls.Add(this.tabAgreements);
            this.tabGeneral.Location = new System.Drawing.Point(224, 0);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(765, 428);
            this.tabGeneral.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGeneral.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblTemperature);
            this.tabDashboard.Controls.Add(this.lblTemp);
            this.tabDashboard.Controls.Add(this.pnlGarbage);
            this.tabDashboard.Controls.Add(this.btnHideRules);
            this.tabDashboard.Controls.Add(this.btnViewRules);
            this.tabDashboard.Controls.Add(this.lbViewRules);
            this.tabDashboard.Controls.Add(this.btnAdmin);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(757, 402);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(537, 296);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(35, 13);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "label1";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(619, 309);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 5;
            // 
            // pnlGarbage
            // 
            this.pnlGarbage.Controls.Add(this.lblGarbage);
            this.pnlGarbage.Location = new System.Drawing.Point(539, 223);
            this.pnlGarbage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGarbage.Name = "pnlGarbage";
            this.pnlGarbage.Size = new System.Drawing.Size(215, 59);
            this.pnlGarbage.TabIndex = 4;
            this.pnlGarbage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGarbage_Paint);
            // 
            // lblGarbage
            // 
            this.lblGarbage.AutoSize = true;
            this.lblGarbage.Location = new System.Drawing.Point(17, 24);
            this.lblGarbage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGarbage.Name = "lblGarbage";
            this.lblGarbage.Size = new System.Drawing.Size(0, 13);
            this.lblGarbage.TabIndex = 5;
            // 
            // btnHideRules
            // 
            this.btnHideRules.Location = new System.Drawing.Point(131, 347);
            this.btnHideRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHideRules.Name = "btnHideRules";
            this.btnHideRules.Size = new System.Drawing.Size(92, 40);
            this.btnHideRules.TabIndex = 3;
            this.btnHideRules.Text = "Hide Rules";
            this.btnHideRules.UseVisualStyleBackColor = true;
            this.btnHideRules.Click += new System.EventHandler(this.btnHideRules_Click);
            // 
            // btnViewRules
            // 
            this.btnViewRules.Location = new System.Drawing.Point(20, 347);
            this.btnViewRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewRules.Name = "btnViewRules";
            this.btnViewRules.Size = new System.Drawing.Size(92, 40);
            this.btnViewRules.TabIndex = 2;
            this.btnViewRules.Text = "View Rules";
            this.btnViewRules.UseVisualStyleBackColor = true;
            this.btnViewRules.Click += new System.EventHandler(this.btnViewRules_Click);
            // 
            // lbViewRules
            // 
            this.lbViewRules.FormattingEnabled = true;
            this.lbViewRules.Location = new System.Drawing.Point(20, 20);
            this.lbViewRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbViewRules.Name = "lbViewRules";
            this.lbViewRules.Size = new System.Drawing.Size(205, 316);
            this.lbViewRules.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(703, 2);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(56, 19);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tabAdminLogin
            // 
            this.tabAdminLogin.Controls.Add(this.btnReturnToDash);
            this.tabAdminLogin.Controls.Add(this.btnAdminLogin);
            this.tabAdminLogin.Controls.Add(this.lblAdminPass);
            this.tabAdminLogin.Controls.Add(this.tbAdminPass);
            this.tabAdminLogin.Location = new System.Drawing.Point(4, 22);
            this.tabAdminLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdminLogin.Name = "tabAdminLogin";
            this.tabAdminLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdminLogin.Size = new System.Drawing.Size(757, 402);
            this.tabAdminLogin.TabIndex = 0;
            this.tabAdminLogin.Text = "Admin log-in";
            this.tabAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnReturnToDash
            // 
            this.btnReturnToDash.Location = new System.Drawing.Point(640, 373);
            this.btnReturnToDash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnToDash.Name = "btnReturnToDash";
            this.btnReturnToDash.Size = new System.Drawing.Size(105, 19);
            this.btnReturnToDash.TabIndex = 4;
            this.btnReturnToDash.Text = "Back to dashboard";
            this.btnReturnToDash.UseVisualStyleBackColor = true;
            this.btnReturnToDash.Click += new System.EventHandler(this.btnReturnToDash_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(301, 155);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(94, 29);
            this.btnAdminLogin.TabIndex = 3;
            this.btnAdminLogin.Text = "Log in";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(301, 116);
            this.lblAdminPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(56, 13);
            this.lblAdminPass.TabIndex = 2;
            this.lblAdminPass.Text = "Password:";
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Location = new System.Drawing.Point(301, 132);
            this.tbAdminPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.PasswordChar = '*';
            this.tbAdminPass.Size = new System.Drawing.Size(96, 20);
            this.tbAdminPass.TabIndex = 1;
            // 
            // tabAdminPanel
            // 
            this.tabAdminPanel.Controls.Add(this.btnDeleteRule);
            this.tabAdminPanel.Controls.Add(this.btnLogOut);
            this.tabAdminPanel.Controls.Add(this.btnPassChange);
            this.tabAdminPanel.Controls.Add(this.btnReadComplaints);
            this.tabAdminPanel.Controls.Add(this.tbRuleContent);
            this.tabAdminPanel.Controls.Add(this.btnEditRule);
            this.tabAdminPanel.Controls.Add(this.btnAddRule);
            this.tabAdminPanel.Controls.Add(this.lbComplaints);
            this.tabAdminPanel.Controls.Add(this.lbRules);
            this.tabAdminPanel.Location = new System.Drawing.Point(4, 22);
            this.tabAdminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdminPanel.Name = "tabAdminPanel";
            this.tabAdminPanel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdminPanel.Size = new System.Drawing.Size(757, 402);
            this.tabAdminPanel.TabIndex = 1;
            this.tabAdminPanel.Text = "Admin Panel";
            this.tabAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(354, 145);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(94, 19);
            this.btnDeleteRule.TabIndex = 8;
            this.btnDeleteRule.Text = "Delete rule";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(14, 5);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 19);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(4, 353);
            this.btnPassChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(127, 19);
            this.btnPassChange.TabIndex = 6;
            this.btnPassChange.Text = "Change password";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnReadComplaints
            // 
            this.btnReadComplaints.Location = new System.Drawing.Point(273, 353);
            this.btnReadComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReadComplaints.Name = "btnReadComplaints";
            this.btnReadComplaints.Size = new System.Drawing.Size(176, 19);
            this.btnReadComplaints.TabIndex = 5;
            this.btnReadComplaints.Text = "Read Complaints";
            this.btnReadComplaints.UseVisualStyleBackColor = true;
            this.btnReadComplaints.Click += new System.EventHandler(this.btnReadComplaints_Click);
            // 
            // tbRuleContent
            // 
            this.tbRuleContent.Location = new System.Drawing.Point(175, 123);
            this.tbRuleContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRuleContent.Name = "tbRuleContent";
            this.tbRuleContent.Size = new System.Drawing.Size(274, 20);
            this.tbRuleContent.TabIndex = 4;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(262, 145);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(87, 19);
            this.btnEditRule.TabIndex = 3;
            this.btnEditRule.Text = "Replace rule";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(175, 145);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(83, 19);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Add new rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.Location = new System.Drawing.Point(453, 212);
            this.lbComplaints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(271, 160);
            this.lbComplaints.TabIndex = 1;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(453, 18);
            this.lbRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(271, 147);
            this.lbRules.TabIndex = 0;
            // 
            // tabPassChange
            // 
            this.tabPassChange.Controls.Add(this.btnBackToAdmin);
            this.tabPassChange.Controls.Add(this.cbShowPass);
            this.tabPassChange.Controls.Add(this.btnSetNewPass);
            this.tabPassChange.Controls.Add(this.tbNewPass);
            this.tabPassChange.Controls.Add(this.tbCurrentPass);
            this.tabPassChange.Controls.Add(this.lblNewPass);
            this.tabPassChange.Controls.Add(this.lblOldPass);
            this.tabPassChange.Location = new System.Drawing.Point(4, 22);
            this.tabPassChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPassChange.Name = "tabPassChange";
            this.tabPassChange.Size = new System.Drawing.Size(757, 402);
            this.tabPassChange.TabIndex = 3;
            this.tabPassChange.Text = "Change password";
            this.tabPassChange.UseVisualStyleBackColor = true;
            // 
            // btnBackToAdmin
            // 
            this.btnBackToAdmin.Location = new System.Drawing.Point(16, 381);
            this.btnBackToAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToAdmin.Name = "btnBackToAdmin";
            this.btnBackToAdmin.Size = new System.Drawing.Size(114, 19);
            this.btnBackToAdmin.TabIndex = 6;
            this.btnBackToAdmin.Text = "Back to admin...";
            this.btnBackToAdmin.UseVisualStyleBackColor = true;
            this.btnBackToAdmin.Click += new System.EventHandler(this.btnBackToAdmin_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(165, 35);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(101, 17);
            this.cbShowPass.TabIndex = 5;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckStateChanged += new System.EventHandler(this.cbShowPass_CheckStateChanged);
            // 
            // btnSetNewPass
            // 
            this.btnSetNewPass.Location = new System.Drawing.Point(16, 128);
            this.btnSetNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetNewPass.Name = "btnSetNewPass";
            this.btnSetNewPass.Size = new System.Drawing.Size(114, 19);
            this.btnSetNewPass.TabIndex = 4;
            this.btnSetNewPass.Text = "Change password";
            this.btnSetNewPass.UseVisualStyleBackColor = true;
            this.btnSetNewPass.Click += new System.EventHandler(this.btnSetNewPass_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(16, 89);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(115, 20);
            this.tbNewPass.TabIndex = 3;
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(16, 35);
            this.tbCurrentPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(115, 20);
            this.tbCurrentPass.TabIndex = 2;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(14, 73);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(103, 13);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "Your new password:";
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(14, 19);
            this.lblOldPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(116, 13);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Your current password:";
            // 
            // tabComplaints
            // 
            this.tabComplaints.Controls.Add(this.btnAddComplaint);
            this.tabComplaints.Controls.Add(this.tbComplaints);
            this.tabComplaints.Controls.Add(this.lblEnterComplaints);
            this.tabComplaints.Location = new System.Drawing.Point(4, 22);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Size = new System.Drawing.Size(757, 402);
            this.tabComplaints.TabIndex = 4;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Location = new System.Drawing.Point(291, 87);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(76, 23);
            this.btnAddComplaint.TabIndex = 2;
            this.btnAddComplaint.Text = "Add";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // tbComplaints
            // 
            this.tbComplaints.Location = new System.Drawing.Point(75, 87);
            this.tbComplaints.Name = "tbComplaints";
            this.tbComplaints.Size = new System.Drawing.Size(172, 20);
            this.tbComplaints.TabIndex = 1;
            // 
            // lblEnterComplaints
            // 
            this.lblEnterComplaints.AutoSize = true;
            this.lblEnterComplaints.Location = new System.Drawing.Point(73, 58);
            this.lblEnterComplaints.Name = "lblEnterComplaints";
            this.lblEnterComplaints.Size = new System.Drawing.Size(176, 13);
            this.lblEnterComplaints.TabIndex = 0;
            this.lblEnterComplaints.Text = "Please enter your complaint bellow: ";
            this.lblEnterComplaints.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabShoppingList
            // 
            this.tabShoppingList.Controls.Add(this.bgEdit);
            this.tabShoppingList.Controls.Add(this.bgList);
            this.tabShoppingList.Location = new System.Drawing.Point(4, 22);
            this.tabShoppingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabShoppingList.Name = "tabShoppingList";
            this.tabShoppingList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabShoppingList.Size = new System.Drawing.Size(757, 402);
            this.tabShoppingList.TabIndex = 5;
            this.tabShoppingList.Text = "Shopping list";
            this.tabShoppingList.UseVisualStyleBackColor = true;
            this.tabShoppingList.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // bgEdit
            // 
            this.bgEdit.Controls.Add(this.btnRmvSelected);
            this.bgEdit.Controls.Add(this.lblCateg);
            this.bgEdit.Controls.Add(this.cbCategory);
            this.bgEdit.Controls.Add(this.lblPrice);
            this.bgEdit.Controls.Add(this.lblName);
            this.bgEdit.Controls.Add(this.btnRemove);
            this.bgEdit.Controls.Add(this.btnAdd);
            this.bgEdit.Controls.Add(this.tbPrice);
            this.bgEdit.Controls.Add(this.tbName);
            this.bgEdit.Location = new System.Drawing.Point(22, 41);
            this.bgEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgEdit.Name = "bgEdit";
            this.bgEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgEdit.Size = new System.Drawing.Size(242, 317);
            this.bgEdit.TabIndex = 6;
            this.bgEdit.TabStop = false;
            this.bgEdit.Text = "Edit shopping list";
            // 
            // btnRmvSelected
            // 
            this.btnRmvSelected.Location = new System.Drawing.Point(104, 141);
            this.btnRmvSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRmvSelected.Name = "btnRmvSelected";
            this.btnRmvSelected.Size = new System.Drawing.Size(70, 40);
            this.btnRmvSelected.TabIndex = 11;
            this.btnRmvSelected.Text = "Remove selected";
            this.btnRmvSelected.UseVisualStyleBackColor = true;
            this.btnRmvSelected.Click += new System.EventHandler(this.BtnRmvSelected_Click);
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(19, 106);
            this.lblCateg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(49, 13);
            this.lblCateg.TabIndex = 10;
            this.lblCateg.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Fruit",
            "Dairy",
            "Meat",
            "Vegetable",
            "Breads",
            "Other"});
            this.cbCategory.Location = new System.Drawing.Point(99, 101);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(76, 21);
            this.cbCategory.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 68);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Item price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Item name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(21, 186);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(99, 68);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 36);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 2;
            // 
            // bgList
            // 
            this.bgList.Controls.Add(this.rbCategory);
            this.bgList.Controls.Add(this.cbShowCateg);
            this.bgList.Controls.Add(this.btnTakeAmount);
            this.bgList.Controls.Add(this.btnAddAmount);
            this.bgList.Controls.Add(this.lblChangeAmount);
            this.bgList.Controls.Add(this.lblAmount);
            this.bgList.Controls.Add(this.lblCategory);
            this.bgList.Controls.Add(this.lblPrice1);
            this.bgList.Controls.Add(this.lblItem);
            this.bgList.Controls.Add(this.rbAll);
            this.bgList.Controls.Add(this.btnShow);
            this.bgList.Controls.Add(this.rbMax);
            this.bgList.Controls.Add(this.rbMin);
            this.bgList.Controls.Add(this.lblTotalPrice);
            this.bgList.Controls.Add(this.lblTotal);
            this.bgList.Controls.Add(this.lbShoppingList);
            this.bgList.Location = new System.Drawing.Point(284, 41);
            this.bgList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgList.Name = "bgList";
            this.bgList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgList.Size = new System.Drawing.Size(433, 317);
            this.bgList.TabIndex = 5;
            this.bgList.TabStop = false;
            this.bgList.Text = "Shopping List";
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(286, 110);
            this.rbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(67, 17);
            this.rbCategory.TabIndex = 15;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            // 
            // cbShowCateg
            // 
            this.cbShowCateg.FormattingEnabled = true;
            this.cbShowCateg.Items.AddRange(new object[] {
            "Fruit",
            "Dairy",
            "Meat",
            "Vegetable",
            "Breads",
            "Other"});
            this.cbShowCateg.Location = new System.Drawing.Point(286, 141);
            this.cbShowCateg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbShowCateg.Name = "cbShowCateg";
            this.cbShowCateg.Size = new System.Drawing.Size(88, 21);
            this.cbShowCateg.TabIndex = 14;
            // 
            // btnTakeAmount
            // 
            this.btnTakeAmount.Location = new System.Drawing.Point(124, 280);
            this.btnTakeAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTakeAmount.Name = "btnTakeAmount";
            this.btnTakeAmount.Size = new System.Drawing.Size(32, 19);
            this.btnTakeAmount.TabIndex = 13;
            this.btnTakeAmount.Text = "-";
            this.btnTakeAmount.UseVisualStyleBackColor = true;
            this.btnTakeAmount.Click += new System.EventHandler(this.BtnTakeAmount_Click);
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.Location = new System.Drawing.Point(124, 262);
            this.btnAddAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(32, 19);
            this.btnAddAmount.TabIndex = 12;
            this.btnAddAmount.Text = "+";
            this.btnAddAmount.UseVisualStyleBackColor = true;
            this.btnAddAmount.Click += new System.EventHandler(this.BtnAddAmount_Click);
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Location = new System.Drawing.Point(27, 270);
            this.lblChangeAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(85, 13);
            this.lblChangeAmount.TabIndex = 11;
            this.lblChangeAmount.Text = "Change amount:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(64, 22);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(169, 22);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(122, 22);
            this.lblPrice1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(31, 13);
            this.lblPrice1.TabIndex = 9;
            this.lblPrice1.Text = "Price";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(27, 22);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(286, 46);
            this.rbAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(286, 209);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 48);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(286, 67);
            this.rbMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(99, 17);
            this.rbMax.TabIndex = 6;
            this.rbMax.Text = "Most expensive";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(286, 89);
            this.rbMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(70, 17);
            this.rbMin.TabIndex = 7;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Cheapest";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(214, 270);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(177, 270);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lbShoppingList
            // 
            this.lbShoppingList.FormattingEnabled = true;
            this.lbShoppingList.Location = new System.Drawing.Point(29, 46);
            this.lbShoppingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbShoppingList.Name = "lbShoppingList";
            this.lbShoppingList.Size = new System.Drawing.Size(221, 212);
            this.lbShoppingList.TabIndex = 0;
            // 
            // timerTempAndLight
            // 
            this.timerTempAndLight.Tick += new System.EventHandler(this.timerTempAndLight_Tick);
            // 
            // TempAndLightPort
            // 
            this.TempAndLightPort.PortName = "COM5";
            // 
            // tabAgreements
            // 
            this.tabAgreements.Controls.Add(this.gbAddAgreement);
            this.tabAgreements.Controls.Add(this.gbViewAgreements);
            this.tabAgreements.Location = new System.Drawing.Point(4, 22);
            this.tabAgreements.Name = "tabAgreements";
            this.tabAgreements.Size = new System.Drawing.Size(757, 402);
            this.tabAgreements.TabIndex = 6;
            this.tabAgreements.Text = "Agreements";
            this.tabAgreements.UseVisualStyleBackColor = true;
            // 
            // gbAddAgreement
            // 
            this.gbAddAgreement.Controls.Add(this.btnRemoveAgreement);
            this.gbAddAgreement.Controls.Add(this.lblAgreement);
            this.gbAddAgreement.Controls.Add(this.btnAcceptAgreement);
            this.gbAddAgreement.Controls.Add(this.btnAddAgreement);
            this.gbAddAgreement.Controls.Add(this.tbAgreementInfo);
            this.gbAddAgreement.Location = new System.Drawing.Point(484, 33);
            this.gbAddAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.gbAddAgreement.Name = "gbAddAgreement";
            this.gbAddAgreement.Padding = new System.Windows.Forms.Padding(2);
            this.gbAddAgreement.Size = new System.Drawing.Size(242, 317);
            this.gbAddAgreement.TabIndex = 8;
            this.gbAddAgreement.TabStop = false;
            this.gbAddAgreement.Text = "Add new agreement";
            // 
            // btnRemoveAgreement
            // 
            this.btnRemoveAgreement.Location = new System.Drawing.Point(128, 255);
            this.btnRemoveAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAgreement.Name = "btnRemoveAgreement";
            this.btnRemoveAgreement.Size = new System.Drawing.Size(108, 49);
            this.btnRemoveAgreement.TabIndex = 11;
            this.btnRemoveAgreement.Text = "Remove selected";
            this.btnRemoveAgreement.UseVisualStyleBackColor = true;
            this.btnRemoveAgreement.Click += new System.EventHandler(this.BtnRemoveAgreement_Click_1);
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Location = new System.Drawing.Point(13, 46);
            this.lblAgreement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(114, 13);
            this.lblAgreement.TabIndex = 7;
            this.lblAgreement.Text = "Agreement Description";
            // 
            // btnAcceptAgreement
            // 
            this.btnAcceptAgreement.Location = new System.Drawing.Point(16, 255);
            this.btnAcceptAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptAgreement.Name = "btnAcceptAgreement";
            this.btnAcceptAgreement.Size = new System.Drawing.Size(108, 49);
            this.btnAcceptAgreement.TabIndex = 6;
            this.btnAcceptAgreement.Text = "Accept selected";
            this.btnAcceptAgreement.UseVisualStyleBackColor = true;
            this.btnAcceptAgreement.Click += new System.EventHandler(this.BtnAcceptAgreement_Click_1);
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(16, 94);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(108, 48);
            this.btnAddAgreement.TabIndex = 5;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.BtnAddAgreement_Click_1);
            // 
            // tbAgreementInfo
            // 
            this.tbAgreementInfo.Location = new System.Drawing.Point(16, 61);
            this.tbAgreementInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbAgreementInfo.Name = "tbAgreementInfo";
            this.tbAgreementInfo.Size = new System.Drawing.Size(205, 20);
            this.tbAgreementInfo.TabIndex = 2;
            // 
            // gbViewAgreements
            // 
            this.gbViewAgreements.Controls.Add(this.btnShowAcceptedAgreement);
            this.gbViewAgreements.Controls.Add(this.btnShowAllAgreements);
            this.gbViewAgreements.Controls.Add(this.lbAgreements);
            this.gbViewAgreements.Location = new System.Drawing.Point(27, 33);
            this.gbViewAgreements.Margin = new System.Windows.Forms.Padding(2);
            this.gbViewAgreements.Name = "gbViewAgreements";
            this.gbViewAgreements.Padding = new System.Windows.Forms.Padding(2);
            this.gbViewAgreements.Size = new System.Drawing.Size(433, 317);
            this.gbViewAgreements.TabIndex = 7;
            this.gbViewAgreements.TabStop = false;
            this.gbViewAgreements.Text = "View Agreements";
            // 
            // btnShowAllAgreements
            // 
            this.btnShowAllAgreements.Location = new System.Drawing.Point(285, 46);
            this.btnShowAllAgreements.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAllAgreements.Name = "btnShowAllAgreements";
            this.btnShowAllAgreements.Size = new System.Drawing.Size(108, 48);
            this.btnShowAllAgreements.TabIndex = 4;
            this.btnShowAllAgreements.Text = "Show all";
            this.btnShowAllAgreements.UseVisualStyleBackColor = true;
            this.btnShowAllAgreements.Click += new System.EventHandler(this.BtnShowAllAgreements_Click_1);
            // 
            // lbAgreements
            // 
            this.lbAgreements.FormattingEnabled = true;
            this.lbAgreements.Location = new System.Drawing.Point(29, 46);
            this.lbAgreements.Margin = new System.Windows.Forms.Padding(2);
            this.lbAgreements.Name = "lbAgreements";
            this.lbAgreements.Size = new System.Drawing.Size(221, 212);
            this.lbAgreements.TabIndex = 0;
            // 
            // btnShowAcceptedAgreement
            // 
            this.btnShowAcceptedAgreement.Location = new System.Drawing.Point(285, 98);
            this.btnShowAcceptedAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAcceptedAgreement.Name = "btnShowAcceptedAgreement";
            this.btnShowAcceptedAgreement.Size = new System.Drawing.Size(108, 48);
            this.btnShowAcceptedAgreement.TabIndex = 5;
            this.btnShowAcceptedAgreement.Text = "Show accepted";
            this.btnShowAcceptedAgreement.UseVisualStyleBackColor = true;
            this.btnShowAcceptedAgreement.Click += new System.EventHandler(this.BtnShowAcceptedAgreement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 430);
            this.Controls.Add(this.tabGeneral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.pnlGarbage.ResumeLayout(false);
            this.pnlGarbage.PerformLayout();
            this.tabAdminLogin.ResumeLayout(false);
            this.tabAdminLogin.PerformLayout();
            this.tabAdminPanel.ResumeLayout(false);
            this.tabAdminPanel.PerformLayout();
            this.tabPassChange.ResumeLayout(false);
            this.tabPassChange.PerformLayout();
            this.tabComplaints.ResumeLayout(false);
            this.tabComplaints.PerformLayout();
            this.tabShoppingList.ResumeLayout(false);
            this.bgEdit.ResumeLayout(false);
            this.bgEdit.PerformLayout();
            this.bgList.ResumeLayout(false);
            this.bgList.PerformLayout();
            this.tabAgreements.ResumeLayout(false);
            this.gbAddAgreement.ResumeLayout(false);
            this.gbAddAgreement.PerformLayout();
            this.gbViewAgreements.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.TextBox tbComplaints;
        private System.Windows.Forms.Label lblEnterComplaints;
        private System.Windows.Forms.Button btnHideRules;
        private System.Windows.Forms.Button btnViewRules;
        private System.Windows.Forms.ListBox lbViewRules;
        private System.Windows.Forms.Button btnReturnToDash;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBackToAdmin;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.TabPage tabShoppingList;
        private System.Windows.Forms.GroupBox bgEdit;
        private System.Windows.Forms.Button btnRmvSelected;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox bgList;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.ComboBox cbShowCateg;
        private System.Windows.Forms.Button btnTakeAmount;
        private System.Windows.Forms.Button btnAddAmount;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbShoppingList;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Panel pnlGarbage;
        private System.Windows.Forms.Label lblGarbage;
        private System.Windows.Forms.Timer timerTempAndLight;
        private System.IO.Ports.SerialPort TempAndLightPort;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TabPage tabAgreements;
        private System.Windows.Forms.GroupBox gbAddAgreement;
        private System.Windows.Forms.Button btnRemoveAgreement;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Button btnAcceptAgreement;
        private System.Windows.Forms.Button btnAddAgreement;
        private System.Windows.Forms.TextBox tbAgreementInfo;
        private System.Windows.Forms.GroupBox gbViewAgreements;
        private System.Windows.Forms.Button btnShowAcceptedAgreement;
        private System.Windows.Forms.Button btnShowAllAgreements;
        private System.Windows.Forms.ListBox lbAgreements;
    }
}

