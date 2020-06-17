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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pnlGarbage = new System.Windows.Forms.Panel();
            this.lblGarbage = new System.Windows.Forms.Label();
            this.btnHideRules = new System.Windows.Forms.Button();
            this.btnViewRules = new System.Windows.Forms.Button();
            this.lbViewRules = new System.Windows.Forms.ListBox();
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
            this.tabAgreements = new System.Windows.Forms.TabPage();
            this.gbAddAgreement = new System.Windows.Forms.GroupBox();
            this.btnRemoveAgreement = new System.Windows.Forms.Button();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.btnAcceptAgreement = new System.Windows.Forms.Button();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.tbAgreementInfo = new System.Windows.Forms.TextBox();
            this.gbViewAgreements = new System.Windows.Forms.GroupBox();
            this.btnShowAcceptedAgreement = new System.Windows.Forms.Button();
            this.btnShowAllAgreements = new System.Windows.Forms.Button();
            this.lbAgreements = new System.Windows.Forms.ListBox();
            this.timerTempAndLight = new System.Windows.Forms.Timer(this.components);
            this.TempAndLightPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.Navigation = new System.Windows.Forms.Panel();
            this.plBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnShoppingList = new System.Windows.Forms.Button();
            this.btnAgreements = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.scheduleTab1 = new HMU_Project_App.ScheduleTab();
            this.adminTab1 = new HMU_Project_App.AdminTab();
            this.loginTab1 = new HMU_Project_App.LoginTab();
            this.shoppingListTab1 = new HMU_Project_App.ShoppingListTab();
            this.agreementsTab1 = new HMU_Project_App.AgreementsTab();
            this.complaintsTab1 = new HMU_Project_App.ComplaintsTab();
            this.dashboard1 = new HMU_Project_App.Dashboard();
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
            this.panel1.SuspendLayout();
            this.plBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabGeneral.Location = new System.Drawing.Point(316, 391);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1111, 512);
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
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1103, 483);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            this.tabDashboard.Click += new System.EventHandler(this.TabDashboard_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(509, 339);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(46, 17);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "label1";
            this.lblTemperature.Click += new System.EventHandler(this.LblTemperature_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(825, 380);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 17);
            this.lblTemp.TabIndex = 5;
            // 
            // pnlGarbage
            // 
            this.pnlGarbage.Controls.Add(this.lblGarbage);
            this.pnlGarbage.Location = new System.Drawing.Point(486, 231);
            this.pnlGarbage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGarbage.Name = "pnlGarbage";
            this.pnlGarbage.Size = new System.Drawing.Size(287, 73);
            this.pnlGarbage.TabIndex = 4;
            this.pnlGarbage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGarbage_Paint);
            // 
            // lblGarbage
            // 
            this.lblGarbage.AutoSize = true;
            this.lblGarbage.Location = new System.Drawing.Point(23, 30);
            this.lblGarbage.Name = "lblGarbage";
            this.lblGarbage.Size = new System.Drawing.Size(0, 17);
            this.lblGarbage.TabIndex = 5;
            // 
            // btnHideRules
            // 
            this.btnHideRules.Location = new System.Drawing.Point(175, 427);
            this.btnHideRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHideRules.Name = "btnHideRules";
            this.btnHideRules.Size = new System.Drawing.Size(123, 49);
            this.btnHideRules.TabIndex = 3;
            this.btnHideRules.Text = "Hide Rules";
            this.btnHideRules.UseVisualStyleBackColor = true;
            this.btnHideRules.Click += new System.EventHandler(this.btnHideRules_Click);
            // 
            // btnViewRules
            // 
            this.btnViewRules.Location = new System.Drawing.Point(27, 427);
            this.btnViewRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewRules.Name = "btnViewRules";
            this.btnViewRules.Size = new System.Drawing.Size(123, 49);
            this.btnViewRules.TabIndex = 2;
            this.btnViewRules.Text = "View Rules";
            this.btnViewRules.UseVisualStyleBackColor = true;
            this.btnViewRules.Click += new System.EventHandler(this.btnViewRules_Click);
            // 
            // lbViewRules
            // 
            this.lbViewRules.FormattingEnabled = true;
            this.lbViewRules.ItemHeight = 16;
            this.lbViewRules.Location = new System.Drawing.Point(27, 25);
            this.lbViewRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbViewRules.Name = "lbViewRules";
            this.lbViewRules.Size = new System.Drawing.Size(272, 388);
            this.lbViewRules.TabIndex = 1;
            // 
            // tabAdminLogin
            // 
            this.tabAdminLogin.Controls.Add(this.btnReturnToDash);
            this.tabAdminLogin.Controls.Add(this.btnAdminLogin);
            this.tabAdminLogin.Controls.Add(this.lblAdminPass);
            this.tabAdminLogin.Controls.Add(this.tbAdminPass);
            this.tabAdminLogin.Location = new System.Drawing.Point(4, 25);
            this.tabAdminLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminLogin.Name = "tabAdminLogin";
            this.tabAdminLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminLogin.Size = new System.Drawing.Size(1103, 483);
            this.tabAdminLogin.TabIndex = 0;
            this.tabAdminLogin.Text = "Admin log-in";
            this.tabAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnReturnToDash
            // 
            this.btnReturnToDash.Location = new System.Drawing.Point(853, 459);
            this.btnReturnToDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToDash.Name = "btnReturnToDash";
            this.btnReturnToDash.Size = new System.Drawing.Size(140, 23);
            this.btnReturnToDash.TabIndex = 4;
            this.btnReturnToDash.Text = "Back to dashboard";
            this.btnReturnToDash.UseVisualStyleBackColor = true;
            this.btnReturnToDash.Click += new System.EventHandler(this.btnReturnToDash_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(401, 191);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(125, 36);
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
            this.lblAdminPass.Click += new System.EventHandler(this.LblAdminPass_Click);
            // 
            // tbAdminPass
            // 
            this.tbAdminPass.Location = new System.Drawing.Point(401, 162);
            this.tbAdminPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdminPass.Name = "tbAdminPass";
            this.tbAdminPass.PasswordChar = '*';
            this.tbAdminPass.Size = new System.Drawing.Size(127, 22);
            this.tbAdminPass.TabIndex = 1;
            this.tbAdminPass.TextChanged += new System.EventHandler(this.TbAdminPass_TextChanged);
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
            this.tabAdminPanel.Location = new System.Drawing.Point(4, 25);
            this.tabAdminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminPanel.Name = "tabAdminPanel";
            this.tabAdminPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminPanel.Size = new System.Drawing.Size(1103, 483);
            this.tabAdminPanel.TabIndex = 1;
            this.tabAdminPanel.Text = "Admin Panel";
            this.tabAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(472, 178);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteRule.TabIndex = 8;
            this.btnDeleteRule.Text = "Delete rule";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(19, 6);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(5, 434);
            this.btnPassChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnReadComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadComplaints.Name = "btnReadComplaints";
            this.btnReadComplaints.Size = new System.Drawing.Size(235, 23);
            this.btnReadComplaints.TabIndex = 5;
            this.btnReadComplaints.Text = "Read Complaints";
            this.btnReadComplaints.UseVisualStyleBackColor = true;
            this.btnReadComplaints.Click += new System.EventHandler(this.btnReadComplaints_Click);
            // 
            // tbRuleContent
            // 
            this.tbRuleContent.Location = new System.Drawing.Point(233, 151);
            this.tbRuleContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRuleContent.Name = "tbRuleContent";
            this.tbRuleContent.Size = new System.Drawing.Size(364, 22);
            this.tbRuleContent.TabIndex = 4;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(349, 178);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(116, 23);
            this.btnEditRule.TabIndex = 3;
            this.btnEditRule.Text = "Replace rule";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(233, 178);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lbComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(360, 196);
            this.lbComplaints.TabIndex = 1;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(604, 22);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(360, 180);
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
            this.tabPassChange.Location = new System.Drawing.Point(4, 25);
            this.tabPassChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPassChange.Name = "tabPassChange";
            this.tabPassChange.Size = new System.Drawing.Size(1103, 483);
            this.tabPassChange.TabIndex = 3;
            this.tabPassChange.Text = "Change password";
            this.tabPassChange.UseVisualStyleBackColor = true;
            // 
            // btnBackToAdmin
            // 
            this.btnBackToAdmin.Location = new System.Drawing.Point(21, 469);
            this.btnBackToAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToAdmin.Name = "btnBackToAdmin";
            this.btnBackToAdmin.Size = new System.Drawing.Size(152, 23);
            this.btnBackToAdmin.TabIndex = 6;
            this.btnBackToAdmin.Text = "Back to admin...";
            this.btnBackToAdmin.UseVisualStyleBackColor = true;
            this.btnBackToAdmin.Click += new System.EventHandler(this.btnBackToAdmin_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(220, 43);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(128, 21);
            this.cbShowPass.TabIndex = 5;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckStateChanged += new System.EventHandler(this.cbShowPass_CheckStateChanged);
            // 
            // btnSetNewPass
            // 
            this.btnSetNewPass.Location = new System.Drawing.Point(21, 158);
            this.btnSetNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetNewPass.Name = "btnSetNewPass";
            this.btnSetNewPass.Size = new System.Drawing.Size(152, 23);
            this.btnSetNewPass.TabIndex = 4;
            this.btnSetNewPass.Text = "Change password";
            this.btnSetNewPass.UseVisualStyleBackColor = true;
            this.btnSetNewPass.Click += new System.EventHandler(this.btnSetNewPass_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(21, 110);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(152, 22);
            this.tbNewPass.TabIndex = 3;
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(21, 43);
            this.tbCurrentPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // tabComplaints
            // 
            this.tabComplaints.Controls.Add(this.btnAddComplaint);
            this.tabComplaints.Controls.Add(this.tbComplaints);
            this.tabComplaints.Controls.Add(this.lblEnterComplaints);
            this.tabComplaints.Location = new System.Drawing.Point(4, 25);
            this.tabComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Size = new System.Drawing.Size(1103, 483);
            this.tabComplaints.TabIndex = 4;
            this.tabComplaints.Text = "Complaints";
            this.tabComplaints.UseVisualStyleBackColor = true;
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.Location = new System.Drawing.Point(388, 107);
            this.btnAddComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(101, 28);
            this.btnAddComplaint.TabIndex = 2;
            this.btnAddComplaint.Text = "Add";
            this.btnAddComplaint.UseVisualStyleBackColor = true;
            this.btnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // tbComplaints
            // 
            this.tbComplaints.Location = new System.Drawing.Point(100, 107);
            this.tbComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.tbComplaints.Name = "tbComplaints";
            this.tbComplaints.Size = new System.Drawing.Size(228, 22);
            this.tbComplaints.TabIndex = 1;
            this.tbComplaints.TextChanged += new System.EventHandler(this.TbComplaints_TextChanged);
            // 
            // lblEnterComplaints
            // 
            this.lblEnterComplaints.AutoSize = true;
            this.lblEnterComplaints.Location = new System.Drawing.Point(97, 71);
            this.lblEnterComplaints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterComplaints.Name = "lblEnterComplaints";
            this.lblEnterComplaints.Size = new System.Drawing.Size(235, 17);
            this.lblEnterComplaints.TabIndex = 0;
            this.lblEnterComplaints.Text = "Please enter your complaint bellow: ";
            this.lblEnterComplaints.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabShoppingList
            // 
            this.tabShoppingList.Controls.Add(this.bgEdit);
            this.tabShoppingList.Controls.Add(this.bgList);
            this.tabShoppingList.Location = new System.Drawing.Point(4, 25);
            this.tabShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabShoppingList.Name = "tabShoppingList";
            this.tabShoppingList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabShoppingList.Size = new System.Drawing.Size(1103, 483);
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
            this.bgEdit.Location = new System.Drawing.Point(29, 50);
            this.bgEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgEdit.Name = "bgEdit";
            this.bgEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgEdit.Size = new System.Drawing.Size(323, 390);
            this.bgEdit.TabIndex = 6;
            this.bgEdit.TabStop = false;
            this.bgEdit.Text = "Edit shopping list";
            // 
            // btnRmvSelected
            // 
            this.btnRmvSelected.Location = new System.Drawing.Point(139, 174);
            this.btnRmvSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRmvSelected.Name = "btnRmvSelected";
            this.btnRmvSelected.Size = new System.Drawing.Size(93, 49);
            this.btnRmvSelected.TabIndex = 11;
            this.btnRmvSelected.Text = "Remove selected";
            this.btnRmvSelected.UseVisualStyleBackColor = true;
            this.btnRmvSelected.Click += new System.EventHandler(this.BtnRmvSelected_Click);
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(25, 130);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(65, 17);
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
            this.cbCategory.Location = new System.Drawing.Point(132, 124);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(100, 24);
            this.cbCategory.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Item price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Item name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(28, 229);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 49);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 49);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(132, 84);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(132, 44);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
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
            this.bgList.Location = new System.Drawing.Point(379, 50);
            this.bgList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgList.Name = "bgList";
            this.bgList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgList.Size = new System.Drawing.Size(577, 390);
            this.bgList.TabIndex = 5;
            this.bgList.TabStop = false;
            this.bgList.Text = "Shopping List";
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(381, 135);
            this.rbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(86, 21);
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
            this.cbShowCateg.Location = new System.Drawing.Point(381, 174);
            this.cbShowCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowCateg.Name = "cbShowCateg";
            this.cbShowCateg.Size = new System.Drawing.Size(116, 24);
            this.cbShowCateg.TabIndex = 14;
            // 
            // btnTakeAmount
            // 
            this.btnTakeAmount.Location = new System.Drawing.Point(165, 345);
            this.btnTakeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeAmount.Name = "btnTakeAmount";
            this.btnTakeAmount.Size = new System.Drawing.Size(43, 23);
            this.btnTakeAmount.TabIndex = 13;
            this.btnTakeAmount.Text = "-";
            this.btnTakeAmount.UseVisualStyleBackColor = true;
            this.btnTakeAmount.Click += new System.EventHandler(this.BtnTakeAmount_Click);
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.Location = new System.Drawing.Point(165, 322);
            this.btnAddAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(43, 23);
            this.btnAddAmount.TabIndex = 12;
            this.btnAddAmount.Text = "+";
            this.btnAddAmount.UseVisualStyleBackColor = true;
            this.btnAddAmount.Click += new System.EventHandler(this.BtnAddAmount_Click);
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Location = new System.Drawing.Point(36, 332);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(112, 17);
            this.lblChangeAmount.TabIndex = 11;
            this.lblChangeAmount.Text = "Change amount:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(85, 27);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(225, 27);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(163, 27);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(40, 17);
            this.lblPrice1.TabIndex = 9;
            this.lblPrice1.Text = "Price";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(36, 27);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(34, 17);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(381, 57);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 21);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(381, 257);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 59);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(381, 82);
            this.rbMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(126, 21);
            this.rbMax.TabIndex = 6;
            this.rbMax.Text = "Most expensive";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(381, 110);
            this.rbMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(89, 21);
            this.rbMin.TabIndex = 7;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Cheapest";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(285, 332);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 17);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(236, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lbShoppingList
            // 
            this.lbShoppingList.FormattingEnabled = true;
            this.lbShoppingList.ItemHeight = 16;
            this.lbShoppingList.Location = new System.Drawing.Point(39, 57);
            this.lbShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbShoppingList.Name = "lbShoppingList";
            this.lbShoppingList.Size = new System.Drawing.Size(293, 260);
            this.lbShoppingList.TabIndex = 0;
            // 
            // tabAgreements
            // 
            this.tabAgreements.Controls.Add(this.gbAddAgreement);
            this.tabAgreements.Controls.Add(this.gbViewAgreements);
            this.tabAgreements.Location = new System.Drawing.Point(4, 25);
            this.tabAgreements.Margin = new System.Windows.Forms.Padding(4);
            this.tabAgreements.Name = "tabAgreements";
            this.tabAgreements.Size = new System.Drawing.Size(1103, 483);
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
            this.gbAddAgreement.Location = new System.Drawing.Point(645, 41);
            this.gbAddAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddAgreement.Name = "gbAddAgreement";
            this.gbAddAgreement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAddAgreement.Size = new System.Drawing.Size(323, 390);
            this.gbAddAgreement.TabIndex = 8;
            this.gbAddAgreement.TabStop = false;
            this.gbAddAgreement.Text = "Add new agreement";
            // 
            // btnRemoveAgreement
            // 
            this.btnRemoveAgreement.Location = new System.Drawing.Point(171, 314);
            this.btnRemoveAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAgreement.Name = "btnRemoveAgreement";
            this.btnRemoveAgreement.Size = new System.Drawing.Size(144, 60);
            this.btnRemoveAgreement.TabIndex = 11;
            this.btnRemoveAgreement.Text = "Remove selected";
            this.btnRemoveAgreement.UseVisualStyleBackColor = true;
            this.btnRemoveAgreement.Click += new System.EventHandler(this.BtnRemoveAgreement_Click_1);
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Location = new System.Drawing.Point(17, 57);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(152, 17);
            this.lblAgreement.TabIndex = 7;
            this.lblAgreement.Text = "Agreement Description";
            // 
            // btnAcceptAgreement
            // 
            this.btnAcceptAgreement.Location = new System.Drawing.Point(21, 314);
            this.btnAcceptAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcceptAgreement.Name = "btnAcceptAgreement";
            this.btnAcceptAgreement.Size = new System.Drawing.Size(144, 60);
            this.btnAcceptAgreement.TabIndex = 6;
            this.btnAcceptAgreement.Text = "Accept selected";
            this.btnAcceptAgreement.UseVisualStyleBackColor = true;
            this.btnAcceptAgreement.Click += new System.EventHandler(this.BtnAcceptAgreement_Click_1);
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(21, 116);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(144, 59);
            this.btnAddAgreement.TabIndex = 5;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.BtnAddAgreement_Click_1);
            // 
            // tbAgreementInfo
            // 
            this.tbAgreementInfo.Location = new System.Drawing.Point(21, 75);
            this.tbAgreementInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAgreementInfo.Name = "tbAgreementInfo";
            this.tbAgreementInfo.Size = new System.Drawing.Size(272, 22);
            this.tbAgreementInfo.TabIndex = 2;
            // 
            // gbViewAgreements
            // 
            this.gbViewAgreements.Controls.Add(this.btnShowAcceptedAgreement);
            this.gbViewAgreements.Controls.Add(this.btnShowAllAgreements);
            this.gbViewAgreements.Controls.Add(this.lbAgreements);
            this.gbViewAgreements.Location = new System.Drawing.Point(36, 41);
            this.gbViewAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbViewAgreements.Name = "gbViewAgreements";
            this.gbViewAgreements.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbViewAgreements.Size = new System.Drawing.Size(577, 390);
            this.gbViewAgreements.TabIndex = 7;
            this.gbViewAgreements.TabStop = false;
            this.gbViewAgreements.Text = "View Agreements";
            // 
            // btnShowAcceptedAgreement
            // 
            this.btnShowAcceptedAgreement.Location = new System.Drawing.Point(380, 121);
            this.btnShowAcceptedAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAcceptedAgreement.Name = "btnShowAcceptedAgreement";
            this.btnShowAcceptedAgreement.Size = new System.Drawing.Size(144, 59);
            this.btnShowAcceptedAgreement.TabIndex = 5;
            this.btnShowAcceptedAgreement.Text = "Show accepted";
            this.btnShowAcceptedAgreement.UseVisualStyleBackColor = true;
            this.btnShowAcceptedAgreement.Click += new System.EventHandler(this.BtnShowAcceptedAgreement_Click);
            // 
            // btnShowAllAgreements
            // 
            this.btnShowAllAgreements.Location = new System.Drawing.Point(380, 57);
            this.btnShowAllAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAllAgreements.Name = "btnShowAllAgreements";
            this.btnShowAllAgreements.Size = new System.Drawing.Size(144, 59);
            this.btnShowAllAgreements.TabIndex = 4;
            this.btnShowAllAgreements.Text = "Show all";
            this.btnShowAllAgreements.UseVisualStyleBackColor = true;
            this.btnShowAllAgreements.Click += new System.EventHandler(this.BtnShowAllAgreements_Click_1);
            // 
            // lbAgreements
            // 
            this.lbAgreements.FormattingEnabled = true;
            this.lbAgreements.ItemHeight = 16;
            this.lbAgreements.Location = new System.Drawing.Point(39, 57);
            this.lbAgreements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAgreements.Name = "lbAgreements";
            this.lbAgreements.Size = new System.Drawing.Size(293, 260);
            this.lbAgreements.TabIndex = 0;
            // 
            // timerTempAndLight
            // 
            this.timerTempAndLight.Tick += new System.EventHandler(this.timerTempAndLight_Tick);
            // 
            // TempAndLightPort
            // 
            this.TempAndLightPort.PortName = "COM5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.Navigation);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnShoppingList);
            this.panel1.Controls.Add(this.btnAgreements);
            this.panel1.Controls.Add(this.btnComplaints);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 586);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(80, 544);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(39, 22);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // Navigation
            // 
            this.Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(252)))), ((int)(((byte)(136)))));
            this.Navigation.Location = new System.Drawing.Point(25, 500);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(167, 1);
            this.Navigation.TabIndex = 5;
            // 
            // plBorder
            // 
            this.plBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(252)))), ((int)(((byte)(136)))));
            this.plBorder.Controls.Add(this.btnMax);
            this.plBorder.Controls.Add(this.btnMin);
            this.plBorder.Controls.Add(this.btnClose);
            this.plBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBorder.Location = new System.Drawing.Point(211, 0);
            this.plBorder.Name = "plBorder";
            this.plBorder.Size = new System.Drawing.Size(921, 35);
            this.plBorder.TabIndex = 0;
            this.plBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlBorder_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "STUDENT HOUSE SYSTEM";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::HMU_Project_App.Properties.Resources.noun_maximize_2042437;
            this.btnMax.Location = new System.Drawing.Point(823, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(49, 35);
            this.btnMax.TabIndex = 19;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::HMU_Project_App.Properties.Resources.noun_minimize_1269338;
            this.btnMin.Location = new System.Drawing.Point(777, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(49, 35);
            this.btnMin.TabIndex = 18;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::HMU_Project_App.Properties.Resources.noun_X_25001111;
            this.btnClose.Location = new System.Drawing.Point(872, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = global::HMU_Project_App.Properties.Resources.icons8_settings_50;
            this.btnAdmin.Location = new System.Drawing.Point(1083, 44);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(50, 45);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = global::HMU_Project_App.Properties.Resources.icons8_trash_48;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(25, 361);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(186, 55);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "   Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnShoppingList
            // 
            this.btnShoppingList.FlatAppearance.BorderSize = 0;
            this.btnShoppingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShoppingList.ForeColor = System.Drawing.Color.White;
            this.btnShoppingList.Image = global::HMU_Project_App.Properties.Resources.icons8_buying_48;
            this.btnShoppingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoppingList.Location = new System.Drawing.Point(25, 300);
            this.btnShoppingList.Name = "btnShoppingList";
            this.btnShoppingList.Size = new System.Drawing.Size(186, 55);
            this.btnShoppingList.TabIndex = 3;
            this.btnShoppingList.Text = "        Shopping list";
            this.btnShoppingList.UseVisualStyleBackColor = true;
            this.btnShoppingList.Click += new System.EventHandler(this.BtnShoppingList_Click);
            // 
            // btnAgreements
            // 
            this.btnAgreements.FlatAppearance.BorderSize = 0;
            this.btnAgreements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgreements.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAgreements.ForeColor = System.Drawing.Color.White;
            this.btnAgreements.Image = global::HMU_Project_App.Properties.Resources.icons8_handshake_60;
            this.btnAgreements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgreements.Location = new System.Drawing.Point(25, 239);
            this.btnAgreements.Name = "btnAgreements";
            this.btnAgreements.Size = new System.Drawing.Size(186, 55);
            this.btnAgreements.TabIndex = 2;
            this.btnAgreements.Text = "        Agreements";
            this.btnAgreements.UseVisualStyleBackColor = true;
            this.btnAgreements.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnComplaints
            // 
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnComplaints.ForeColor = System.Drawing.Color.White;
            this.btnComplaints.Image = global::HMU_Project_App.Properties.Resources.icons8_document_26;
            this.btnComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaints.Location = new System.Drawing.Point(25, 178);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(186, 55);
            this.btnComplaints.TabIndex = 1;
            this.btnComplaints.Text = "      Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.BtnComplaints_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::HMU_Project_App.Properties.Resources.icons8_home_32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(25, 117);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "      Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMU_Project_App.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::HMU_Project_App.Properties.Resources.icons8_exit_52;
            this.button6.Location = new System.Drawing.Point(25, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // scheduleTab1
            // 
            this.scheduleTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleTab1.Location = new System.Drawing.Point(214, 123);
            this.scheduleTab1.Name = "scheduleTab1";
            this.scheduleTab1.Size = new System.Drawing.Size(918, 463);
            this.scheduleTab1.TabIndex = 15;
            this.scheduleTab1.Load += new System.EventHandler(this.ScheduleTab1_Load);
            // 
            // adminTab1
            // 
            this.adminTab1.Location = new System.Drawing.Point(214, 123);
            this.adminTab1.Name = "adminTab1";
            this.adminTab1.Size = new System.Drawing.Size(918, 463);
            this.adminTab1.TabIndex = 14;
            // 
            // loginTab1
            // 
            this.loginTab1.ForeColor = System.Drawing.Color.Gray;
            this.loginTab1.Location = new System.Drawing.Point(214, 123);
            this.loginTab1.Name = "loginTab1";
            this.loginTab1.Size = new System.Drawing.Size(918, 463);
            this.loginTab1.TabIndex = 13;
            // 
            // shoppingListTab1
            // 
            this.shoppingListTab1.Location = new System.Drawing.Point(211, 123);
            this.shoppingListTab1.Name = "shoppingListTab1";
            this.shoppingListTab1.Size = new System.Drawing.Size(918, 463);
            this.shoppingListTab1.TabIndex = 12;
            // 
            // agreementsTab1
            // 
            this.agreementsTab1.Location = new System.Drawing.Point(211, 123);
            this.agreementsTab1.Name = "agreementsTab1";
            this.agreementsTab1.Size = new System.Drawing.Size(918, 463);
            this.agreementsTab1.TabIndex = 11;
            // 
            // complaintsTab1
            // 
            this.complaintsTab1.Location = new System.Drawing.Point(211, 123);
            this.complaintsTab1.Name = "complaintsTab1";
            this.complaintsTab1.Size = new System.Drawing.Size(918, 463);
            this.complaintsTab1.TabIndex = 10;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(214, 123);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(918, 463);
            this.dashboard1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 586);
            this.Controls.Add(this.scheduleTab1);
            this.Controls.Add(this.plBorder);
            this.Controls.Add(this.adminTab1);
            this.Controls.Add(this.loginTab1);
            this.Controls.Add(this.shoppingListTab1);
            this.Controls.Add(this.agreementsTab1);
            this.Controls.Add(this.complaintsTab1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabGeneral);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plBorder;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnShoppingList;
        private System.Windows.Forms.Button btnAgreements;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Dashboard dashboard1;
        private ComplaintsTab complaintsTab1;
        private AgreementsTab agreementsTab1;
        private ShoppingListTab shoppingListTab1;
        private LoginTab loginTab1;
        private AdminTab adminTab1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblExit;
        private ScheduleTab scheduleTab1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
    }
}

