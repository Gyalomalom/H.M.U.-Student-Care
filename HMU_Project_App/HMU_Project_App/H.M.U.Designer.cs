namespace HMU_Project_App
{
    partial class HMU_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMU_MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.Navigation = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnShoppingList = new System.Windows.Forms.Button();
            this.btnAgreements = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.plBorder = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.scheduleTab = new HMU_Project_App.ScheduleTab();
            this.adminTab = new HMU_Project_App.AdminTab();
            this.loginTab = new HMU_Project_App.LoginTab();
            this.shoppingListTab = new HMU_Project_App.ShoppingListTab();
            this.agreementsTab = new HMU_Project_App.AgreementsTab();
            this.complaintsTab = new HMU_Project_App.ComplaintsTab();
            this.dashboardTab = new HMU_Project_App.Dashboard();
            this.TempAndLightPort = new System.IO.Ports.SerialPort(this.components);
            this.timerTempAndLight = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plBorder.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 586);
            this.panel1.TabIndex = 1;
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
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
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
            this.btnAgreements.Click += new System.EventHandler(this.btnAgreements_Click);
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
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::HMU_Project_App.Properties.Resources.icons8_exit_52;
            this.btnExit.Location = new System.Drawing.Point(25, 534);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_click);
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
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            // scheduleTab1
            // 
            this.scheduleTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleTab.Location = new System.Drawing.Point(214, 123);
            this.scheduleTab.Name = "scheduleTab1";
            this.scheduleTab.Size = new System.Drawing.Size(918, 463);
            this.scheduleTab.TabIndex = 15;
            // 
            // adminTab
            // 
            this.adminTab.Location = new System.Drawing.Point(214, 123);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(918, 463);
            this.adminTab.TabIndex = 14;
            // 
            // loginTab
            // 
            this.loginTab.ForeColor = System.Drawing.Color.Gray;
            this.loginTab.Location = new System.Drawing.Point(214, 123);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(918, 463);
            this.loginTab.TabIndex = 13;
            // 
            // shoppingListTab
            // 
            this.shoppingListTab.Location = new System.Drawing.Point(211, 123);
            this.shoppingListTab.Name = "shoppingListTab";
            this.shoppingListTab.Size = new System.Drawing.Size(918, 463);
            this.shoppingListTab.TabIndex = 12;
            // 
            // agreementsTab
            // 
            this.agreementsTab.Location = new System.Drawing.Point(211, 123);
            this.agreementsTab.Name = "agreementsTab";
            this.agreementsTab.Size = new System.Drawing.Size(918, 463);
            this.agreementsTab.TabIndex = 11;
            // 
            // complaintsTab
            // 
            this.complaintsTab.Location = new System.Drawing.Point(211, 123);
            this.complaintsTab.Name = "complaintsTab";
            this.complaintsTab.Size = new System.Drawing.Size(918, 463);
            this.complaintsTab.TabIndex = 10;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Location = new System.Drawing.Point(214, 123);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Size = new System.Drawing.Size(918, 463);
            this.dashboardTab.TabIndex = 9;
            // 
            // TempAndLightPort
            // 
            this.TempAndLightPort.PortName = "COM5";
            // 
            // HMU_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 586);
            this.Controls.Add(this.plBorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scheduleTab);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.loginTab);
            this.Controls.Add(this.shoppingListTab);
            this.Controls.Add(this.agreementsTab);
            this.Controls.Add(this.complaintsTab);
            this.Controls.Add(this.dashboardTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HMU_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H.M.U";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HMU_Mainform_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plBorder;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnShoppingList;
        private System.Windows.Forms.Button btnAgreements;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Dashboard dashboardTab;
        private ComplaintsTab complaintsTab;
        private AgreementsTab agreementsTab;
        private ShoppingListTab shoppingListTab;
        private LoginTab loginTab;
        private AdminTab adminTab;
        private System.Windows.Forms.Label lblExit;
        private ScheduleTab scheduleTab;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.IO.Ports.SerialPort TempAndLightPort;
        private System.Windows.Forms.Timer timerTempAndLight;
    }
}

