namespace FoodOrderPro
{
    partial class GetOrderDesc
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.FoodCost = new MetroFramework.Controls.MetroLabel();
            this.FoodName = new MetroFramework.Controls.MetroLabel();
            this.FoodId = new MetroFramework.Controls.MetroLabel();
            this.ListOfFood = new MetroFramework.Controls.MetroLabel();
            this.LineLbl = new MetroFramework.Controls.MetroLabel();
            this.GetByCost = new MetroFramework.Controls.MetroLabel();
            this.GetByName = new MetroFramework.Controls.MetroLabel();
            this.GetById = new MetroFramework.Controls.MetroLabel();
            this.QuantityBox = new MetroFramework.Controls.MetroTextBox();
            this.OrderItBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(369, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "____________________________________________________________";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodCost
            // 
            this.FoodCost.AutoSize = true;
            this.FoodCost.Location = new System.Drawing.Point(143, 41);
            this.FoodCost.Name = "FoodCost";
            this.FoodCost.Size = new System.Drawing.Size(35, 19);
            this.FoodCost.TabIndex = 15;
            this.FoodCost.Text = "Cost";
            this.FoodCost.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Location = new System.Drawing.Point(43, 41);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(80, 19);
            this.FoodName.TabIndex = 14;
            this.FoodName.Text = "Food Name";
            this.FoodName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodId
            // 
            this.FoodId.AutoSize = true;
            this.FoodId.Location = new System.Drawing.Point(8, 41);
            this.FoodId.Name = "FoodId";
            this.FoodId.Size = new System.Drawing.Size(20, 19);
            this.FoodId.TabIndex = 13;
            this.FoodId.Text = "Id";
            this.FoodId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ListOfFood
            // 
            this.ListOfFood.AutoSize = true;
            this.ListOfFood.Location = new System.Drawing.Point(162, 13);
            this.ListOfFood.Name = "ListOfFood";
            this.ListOfFood.Size = new System.Drawing.Size(81, 19);
            this.ListOfFood.TabIndex = 12;
            this.ListOfFood.Text = "Make Order";
            this.ListOfFood.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LineLbl
            // 
            this.LineLbl.AutoSize = true;
            this.LineLbl.Location = new System.Drawing.Point(9, 13);
            this.LineLbl.Name = "LineLbl";
            this.LineLbl.Size = new System.Drawing.Size(369, 19);
            this.LineLbl.TabIndex = 11;
            this.LineLbl.Text = "____________________________________________________________";
            this.LineLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetByCost
            // 
            this.GetByCost.AutoSize = true;
            this.GetByCost.Location = new System.Drawing.Point(143, 92);
            this.GetByCost.Name = "GetByCost";
            this.GetByCost.Size = new System.Drawing.Size(35, 19);
            this.GetByCost.TabIndex = 19;
            this.GetByCost.Text = "Cost";
            this.GetByCost.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetByName
            // 
            this.GetByName.AutoSize = true;
            this.GetByName.Location = new System.Drawing.Point(43, 92);
            this.GetByName.Name = "GetByName";
            this.GetByName.Size = new System.Drawing.Size(80, 19);
            this.GetByName.TabIndex = 18;
            this.GetByName.Text = "Food Name";
            this.GetByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetById
            // 
            this.GetById.AutoSize = true;
            this.GetById.Location = new System.Drawing.Point(8, 92);
            this.GetById.Name = "GetById";
            this.GetById.Size = new System.Drawing.Size(20, 19);
            this.GetById.TabIndex = 17;
            this.GetById.Text = "Id";
            this.GetById.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GetById.Click += new System.EventHandler(this.GetById_Click);
            // 
            // QuantityBox
            // 
            // 
            // 
            // 
            this.QuantityBox.CustomButton.Image = null;
            this.QuantityBox.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.QuantityBox.CustomButton.Name = "";
            this.QuantityBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityBox.CustomButton.TabIndex = 1;
            this.QuantityBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityBox.CustomButton.UseSelectable = true;
            this.QuantityBox.CustomButton.Visible = false;
            this.QuantityBox.Lines = new string[] {
        "1"};
            this.QuantityBox.Location = new System.Drawing.Point(197, 88);
            this.QuantityBox.MaxLength = 32767;
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.PasswordChar = '\0';
            this.QuantityBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityBox.SelectedText = "";
            this.QuantityBox.SelectionLength = 0;
            this.QuantityBox.SelectionStart = 0;
            this.QuantityBox.ShortcutsEnabled = true;
            this.QuantityBox.Size = new System.Drawing.Size(34, 23);
            this.QuantityBox.TabIndex = 20;
            this.QuantityBox.Text = "1";
            this.QuantityBox.UseSelectable = true;
            this.QuantityBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OrderItBtn
            // 
            this.OrderItBtn.Location = new System.Drawing.Point(237, 88);
            this.OrderItBtn.Name = "OrderItBtn";
            this.OrderItBtn.Size = new System.Drawing.Size(75, 23);
            this.OrderItBtn.TabIndex = 21;
            this.OrderItBtn.Text = "Order It";
            this.OrderItBtn.UseSelectable = true;
            this.OrderItBtn.Click += new System.EventHandler(this.OrderItBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(369, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "____________________________________________________________";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetOrderDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 166);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.OrderItBtn);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.GetByCost);
            this.Controls.Add(this.GetByName);
            this.Controls.Add(this.GetById);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.FoodCost);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.FoodId);
            this.Controls.Add(this.ListOfFood);
            this.Controls.Add(this.LineLbl);
            this.DisplayHeader = false;
            this.Name = "GetOrderDesc";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "GetOrderDesc";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GetOrderDesc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel FoodCost;
        public MetroFramework.Controls.MetroLabel FoodName;
        public MetroFramework.Controls.MetroLabel FoodId;
        public MetroFramework.Controls.MetroLabel ListOfFood;
        public MetroFramework.Controls.MetroLabel LineLbl;
        public MetroFramework.Controls.MetroLabel GetByCost;
        public MetroFramework.Controls.MetroLabel GetByName;
        public MetroFramework.Controls.MetroLabel GetById;
        public MetroFramework.Controls.MetroTextBox QuantityBox;
        public MetroFramework.Controls.MetroButton OrderItBtn;
        public MetroFramework.Controls.MetroLabel metroLabel1;
    }
}