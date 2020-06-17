namespace HMU_Project_App
{
    partial class AdminTab
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
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnReadComplaints = new System.Windows.Forms.Button();
            this.tbRuleContent = new System.Windows.Forms.TextBox();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.tabPassChange = new HMU_Project_App.PassChange();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnDeleteRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRule.Location = new System.Drawing.Point(426, 102);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(152, 39);
            this.btnDeleteRule.TabIndex = 16;
            this.btnDeleteRule.Text = "Delete rule";
            this.btnDeleteRule.UseVisualStyleBackColor = false;
            this.btnDeleteRule.Click += new System.EventHandler(this.BtnDeleteRule_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnPassChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassChange.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPassChange.ForeColor = System.Drawing.Color.White;
            this.btnPassChange.Location = new System.Drawing.Point(426, 330);
            this.btnPassChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(152, 61);
            this.btnPassChange.TabIndex = 15;
            this.btnPassChange.Text = "Change password";
            this.btnPassChange.UseVisualStyleBackColor = false;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnReadComplaints
            // 
            this.btnReadComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnReadComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadComplaints.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadComplaints.ForeColor = System.Drawing.Color.White;
            this.btnReadComplaints.Location = new System.Drawing.Point(426, 242);
            this.btnReadComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadComplaints.Name = "btnReadComplaints";
            this.btnReadComplaints.Size = new System.Drawing.Size(152, 61);
            this.btnReadComplaints.TabIndex = 14;
            this.btnReadComplaints.Text = "Read Complaints";
            this.btnReadComplaints.UseVisualStyleBackColor = false;
            this.btnReadComplaints.Click += new System.EventHandler(this.BtnReadComplaints_Click);
            // 
            // tbRuleContent
            // 
            this.tbRuleContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRuleContent.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRuleContent.ForeColor = System.Drawing.Color.Gray;
            this.tbRuleContent.Location = new System.Drawing.Point(426, 19);
            this.tbRuleContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRuleContent.Name = "tbRuleContent";
            this.tbRuleContent.Size = new System.Drawing.Size(472, 23);
            this.tbRuleContent.TabIndex = 13;
            // 
            // btnEditRule
            // 
            this.btnEditRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnEditRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditRule.ForeColor = System.Drawing.Color.White;
            this.btnEditRule.Location = new System.Drawing.Point(426, 145);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(152, 38);
            this.btnEditRule.TabIndex = 12;
            this.btnEditRule.Text = "Replace rule";
            this.btnEditRule.UseVisualStyleBackColor = false;
            this.btnEditRule.Click += new System.EventHandler(this.BtnEditRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRule.ForeColor = System.Drawing.Color.White;
            this.btnAddRule.Location = new System.Drawing.Point(426, 59);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(152, 39);
            this.btnAddRule.TabIndex = 11;
            this.btnAddRule.Text = "Add new rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // lbComplaints
            // 
            this.lbComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbComplaints.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComplaints.ForeColor = System.Drawing.Color.Gray;
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 21;
            this.lbComplaints.Location = new System.Drawing.Point(33, 242);
            this.lbComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(360, 189);
            this.lbComplaints.TabIndex = 10;
            // 
            // lbRules
            // 
            this.lbRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRules.ForeColor = System.Drawing.Color.Gray;
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 20;
            this.lbRules.Location = new System.Drawing.Point(33, 19);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(360, 180);
            this.lbRules.TabIndex = 9;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = global::HMU_Project_App.Properties.Resources.icons8_database_administrator_96;
            this.pbAdmin.Location = new System.Drawing.Point(787, 302);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(170, 129);
            this.pbAdmin.TabIndex = 17;
            this.pbAdmin.TabStop = false;
            // 
            // tabPassChange
            // 
            this.tabPassChange.Location = new System.Drawing.Point(0, 0);
            this.tabPassChange.Name = "tabPassChange";
            this.tabPassChange.Size = new System.Drawing.Size(922, 460);
            this.tabPassChange.TabIndex = 18;
            this.tabPassChange.Enter += new System.EventHandler(this.tabPassChange_Enter);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Location = new System.Drawing.Point(3, 19);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(912, 441);
            this.pnlAdmin.TabIndex = 19;
            // 
            // AdminTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.btnDeleteRule);
            this.Controls.Add(this.btnPassChange);
            this.Controls.Add(this.btnReadComplaints);
            this.Controls.Add(this.tbRuleContent);
            this.Controls.Add(this.btnEditRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.lbComplaints);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.tabPassChange);
            this.Name = "AdminTab";
            this.Size = new System.Drawing.Size(918, 463);
            this.Load += new System.EventHandler(this.AdminTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnReadComplaints;
        private System.Windows.Forms.TextBox tbRuleContent;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.PictureBox pbAdmin;
        private PassChange tabPassChange;
        private System.Windows.Forms.Panel pnlAdmin;
    }
}
