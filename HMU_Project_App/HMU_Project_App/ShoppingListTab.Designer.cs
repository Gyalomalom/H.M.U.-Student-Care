namespace HMU_Project_App
{
    partial class ShoppingListTab
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
            this.btnRmvSelected = new System.Windows.Forms.Button();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.cbShowCateg = new System.Windows.Forms.ComboBox();
            this.btnTakeAmount = new System.Windows.Forms.Button();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbShoppingList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRmvSelected
            // 
            this.btnRmvSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnRmvSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvSelected.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRmvSelected.ForeColor = System.Drawing.Color.White;
            this.btnRmvSelected.Location = new System.Drawing.Point(64, 364);
            this.btnRmvSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRmvSelected.Name = "btnRmvSelected";
            this.btnRmvSelected.Size = new System.Drawing.Size(139, 65);
            this.btnRmvSelected.TabIndex = 20;
            this.btnRmvSelected.Text = "Remove selected";
            this.btnRmvSelected.UseVisualStyleBackColor = false;
            this.btnRmvSelected.Click += new System.EventHandler(this.btnRmvSelected_Click);
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCateg.ForeColor = System.Drawing.Color.Gray;
            this.lblCateg.Location = new System.Drawing.Point(61, 182);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(89, 21);
            this.lblCateg.TabIndex = 19;
            this.lblCateg.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCategory.ForeColor = System.Drawing.Color.Gray;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Fruit",
            "Dairy",
            "Meat",
            "Vegetable",
            "Breads",
            "Other"});
            this.cbCategory.Location = new System.Drawing.Point(207, 179);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(100, 29);
            this.cbCategory.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(61, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 21);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Item price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(61, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Item name";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(64, 297);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 63);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(64, 244);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrice.ForeColor = System.Drawing.Color.Gray;
            this.tbPrice.Location = new System.Drawing.Point(207, 139);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 21);
            this.tbPrice.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.Color.Gray;
            this.tbName.Location = new System.Drawing.Point(207, 99);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 12;
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCategory.Location = new System.Drawing.Point(696, 167);
            this.rbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(95, 23);
            this.rbCategory.TabIndex = 36;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            // 
            // cbShowCateg
            // 
            this.cbShowCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowCateg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbShowCateg.ForeColor = System.Drawing.Color.Gray;
            this.cbShowCateg.FormattingEnabled = true;
            this.cbShowCateg.Items.AddRange(new object[] {
            "Fruit",
            "Dairy",
            "Meat",
            "Vegetable",
            "Breads",
            "Other"});
            this.cbShowCateg.Location = new System.Drawing.Point(696, 206);
            this.cbShowCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowCateg.Name = "cbShowCateg";
            this.cbShowCateg.Size = new System.Drawing.Size(116, 29);
            this.cbShowCateg.TabIndex = 35;
            // 
            // btnTakeAmount
            // 
            this.btnTakeAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnTakeAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAmount.ForeColor = System.Drawing.Color.White;
            this.btnTakeAmount.Location = new System.Drawing.Point(527, 377);
            this.btnTakeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeAmount.Name = "btnTakeAmount";
            this.btnTakeAmount.Size = new System.Drawing.Size(43, 23);
            this.btnTakeAmount.TabIndex = 34;
            this.btnTakeAmount.Text = "-";
            this.btnTakeAmount.UseVisualStyleBackColor = false;
            this.btnTakeAmount.Click += new System.EventHandler(this.btnTakeAmount_Click);
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnAddAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAmount.ForeColor = System.Drawing.Color.White;
            this.btnAddAmount.Location = new System.Drawing.Point(526, 350);
            this.btnAddAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(43, 23);
            this.btnAddAmount.TabIndex = 33;
            this.btnAddAmount.Text = "+";
            this.btnAddAmount.UseVisualStyleBackColor = false;
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChangeAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblChangeAmount.Location = new System.Drawing.Point(350, 364);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(170, 22);
            this.lblChangeAmount.TabIndex = 32;
            this.lblChangeAmount.Text = "Change amount:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmount.Location = new System.Drawing.Point(348, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(178, 34);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Shopping list";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Location = new System.Drawing.Point(690, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 34);
            this.lblCategory.TabIndex = 31;
            this.lblCategory.Text = "Sort";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblItem.Location = new System.Drawing.Point(58, 38);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(86, 34);
            this.lblItem.TabIndex = 29;
            this.lblItem.Text = "Items";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAll.Location = new System.Drawing.Point(696, 89);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(45, 23);
            this.rbAll.TabIndex = 26;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(79)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(696, 289);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 59);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMax.Location = new System.Drawing.Point(696, 114);
            this.rbMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(135, 23);
            this.rbMax.TabIndex = 27;
            this.rbMax.Text = "Most expensive";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMin.Location = new System.Drawing.Point(696, 142);
            this.rbMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(98, 23);
            this.rbMin.TabIndex = 28;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Cheapest";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalPrice.Location = new System.Drawing.Point(582, 363);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 23);
            this.lblTotalPrice.TabIndex = 23;
            this.lblTotalPrice.Text = "label1";
            // 
            // lbShoppingList
            // 
            this.lbShoppingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbShoppingList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbShoppingList.ForeColor = System.Drawing.Color.Gray;
            this.lbShoppingList.FormattingEnabled = true;
            this.lbShoppingList.ItemHeight = 21;
            this.lbShoppingList.Location = new System.Drawing.Point(354, 89);
            this.lbShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbShoppingList.Name = "lbShoppingList";
            this.lbShoppingList.Size = new System.Drawing.Size(293, 252);
            this.lbShoppingList.TabIndex = 21;
            // 
            // ShoppingListTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbCategory);
            this.Controls.Add(this.cbShowCateg);
            this.Controls.Add(this.btnTakeAmount);
            this.Controls.Add(this.btnAddAmount);
            this.Controls.Add(this.lblChangeAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbMax);
            this.Controls.Add(this.rbMin);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbShoppingList);
            this.Controls.Add(this.btnRmvSelected);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Name = "ShoppingListTab";
            this.Size = new System.Drawing.Size(918, 463);
            this.Load += new System.EventHandler(this.ShoppingListTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRmvSelected;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.ComboBox cbShowCateg;
        private System.Windows.Forms.Button btnTakeAmount;
        private System.Windows.Forms.Button btnAddAmount;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ListBox lbShoppingList;
    }
}
