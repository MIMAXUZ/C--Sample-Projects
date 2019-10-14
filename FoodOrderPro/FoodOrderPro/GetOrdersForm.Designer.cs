namespace FoodOrderPro
{
    partial class GetOrdersForm
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
            this.FileNameLbl = new MetroFramework.Controls.MetroLabel();
            this.GetFileUrlBox = new MetroFramework.Controls.MetroTextBox();
            this.ChooseFIleBtn = new MetroFramework.Controls.MetroButton();
            this.LineLbl = new MetroFramework.Controls.MetroLabel();
            this.LineBottom = new MetroFramework.Controls.MetroLabel();
            this.ListOfFood = new MetroFramework.Controls.MetroLabel();
            this.FoodId = new MetroFramework.Controls.MetroLabel();
            this.FoodName = new MetroFramework.Controls.MetroLabel();
            this.FoodCost = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ChooseFileDBox = new System.Windows.Forms.OpenFileDialog();
            this.ShowFoodsBtn = new MetroFramework.Controls.MetroButton();
            this.CostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FullCostLbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Location = new System.Drawing.Point(24, 79);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(76, 19);
            this.FileNameLbl.TabIndex = 0;
            this.FileNameLbl.Text = "File Name: ";
            this.FileNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetFileUrlBox
            // 
            // 
            // 
            // 
            this.GetFileUrlBox.CustomButton.Image = null;
            this.GetFileUrlBox.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.GetFileUrlBox.CustomButton.Name = "";
            this.GetFileUrlBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GetFileUrlBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GetFileUrlBox.CustomButton.TabIndex = 1;
            this.GetFileUrlBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GetFileUrlBox.CustomButton.UseSelectable = true;
            this.GetFileUrlBox.CustomButton.Visible = false;
            this.GetFileUrlBox.Lines = new string[] {
        "Choose file or paste URL here"};
            this.GetFileUrlBox.Location = new System.Drawing.Point(106, 79);
            this.GetFileUrlBox.MaxLength = 32767;
            this.GetFileUrlBox.Name = "GetFileUrlBox";
            this.GetFileUrlBox.PasswordChar = '\0';
            this.GetFileUrlBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GetFileUrlBox.SelectedText = "";
            this.GetFileUrlBox.SelectionLength = 0;
            this.GetFileUrlBox.SelectionStart = 0;
            this.GetFileUrlBox.ShortcutsEnabled = true;
            this.GetFileUrlBox.Size = new System.Drawing.Size(207, 23);
            this.GetFileUrlBox.TabIndex = 1;
            this.GetFileUrlBox.Text = "Choose file or paste URL here";
            this.GetFileUrlBox.UseSelectable = true;
            this.GetFileUrlBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GetFileUrlBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChooseFIleBtn
            // 
            this.ChooseFIleBtn.Location = new System.Drawing.Point(320, 79);
            this.ChooseFIleBtn.Name = "ChooseFIleBtn";
            this.ChooseFIleBtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseFIleBtn.TabIndex = 2;
            this.ChooseFIleBtn.Text = "Choose File";
            this.ChooseFIleBtn.UseSelectable = true;
            this.ChooseFIleBtn.Click += new System.EventHandler(this.ChooseFIleBtn_Click);
            // 
            // LineLbl
            // 
            this.LineLbl.AutoSize = true;
            this.LineLbl.Location = new System.Drawing.Point(24, 131);
            this.LineLbl.Name = "LineLbl";
            this.LineLbl.Size = new System.Drawing.Size(369, 19);
            this.LineLbl.TabIndex = 3;
            this.LineLbl.Text = "____________________________________________________________";
            this.LineLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LineBottom
            // 
            this.LineBottom.AutoSize = true;
            this.LineBottom.Location = new System.Drawing.Point(24, 411);
            this.LineBottom.Name = "LineBottom";
            this.LineBottom.Size = new System.Drawing.Size(369, 19);
            this.LineBottom.TabIndex = 4;
            this.LineBottom.Text = "____________________________________________________________";
            this.LineBottom.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ListOfFood
            // 
            this.ListOfFood.AutoSize = true;
            this.ListOfFood.Location = new System.Drawing.Point(177, 131);
            this.ListOfFood.Name = "ListOfFood";
            this.ListOfFood.Size = new System.Drawing.Size(81, 19);
            this.ListOfFood.TabIndex = 5;
            this.ListOfFood.Text = "List Of Food";
            this.ListOfFood.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodId
            // 
            this.FoodId.AutoSize = true;
            this.FoodId.Location = new System.Drawing.Point(23, 159);
            this.FoodId.Name = "FoodId";
            this.FoodId.Size = new System.Drawing.Size(20, 19);
            this.FoodId.TabIndex = 6;
            this.FoodId.Text = "Id";
            this.FoodId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Location = new System.Drawing.Point(58, 159);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(80, 19);
            this.FoodName.TabIndex = 7;
            this.FoodName.Text = "Food Name";
            this.FoodName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FoodCost
            // 
            this.FoodCost.AutoSize = true;
            this.FoodCost.Location = new System.Drawing.Point(158, 159);
            this.FoodCost.Name = "FoodCost";
            this.FoodCost.Size = new System.Drawing.Size(35, 19);
            this.FoodCost.TabIndex = 8;
            this.FoodCost.Text = "Cost";
            this.FoodCost.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 178);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(369, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "____________________________________________________________";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ChooseFileDBox
            // 
            this.ChooseFileDBox.FileName = "ChooseFileDBox";
            // 
            // ShowFoodsBtn
            // 
            this.ShowFoodsBtn.Location = new System.Drawing.Point(320, 108);
            this.ShowFoodsBtn.Name = "ShowFoodsBtn";
            this.ShowFoodsBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowFoodsBtn.TabIndex = 13;
            this.ShowFoodsBtn.Text = "Show Foods";
            this.ShowFoodsBtn.UseSelectable = true;
            this.ShowFoodsBtn.Click += new System.EventHandler(this.ShowFoodsBtn_Click);
            // 
            // CostTextBox
            // 
            // 
            // 
            // 
            this.CostTextBox.CustomButton.Image = null;
            this.CostTextBox.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.CostTextBox.CustomButton.Name = "";
            this.CostTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CostTextBox.CustomButton.TabIndex = 1;
            this.CostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CostTextBox.CustomButton.UseSelectable = true;
            this.CostTextBox.CustomButton.Visible = false;
            this.CostTextBox.Lines = new string[] {
        "0"};
            this.CostTextBox.Location = new System.Drawing.Point(106, 433);
            this.CostTextBox.MaxLength = 32767;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.PasswordChar = '\0';
            this.CostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CostTextBox.SelectedText = "";
            this.CostTextBox.SelectionLength = 0;
            this.CostTextBox.SelectionStart = 0;
            this.CostTextBox.ShortcutsEnabled = true;
            this.CostTextBox.Size = new System.Drawing.Size(207, 23);
            this.CostTextBox.TabIndex = 15;
            this.CostTextBox.Text = "0";
            this.CostTextBox.UseSelectable = true;
            this.CostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FullCostLbl
            // 
            this.FullCostLbl.AutoSize = true;
            this.FullCostLbl.Location = new System.Drawing.Point(24, 433);
            this.FullCostLbl.Name = "FullCostLbl";
            this.FullCostLbl.Size = new System.Drawing.Size(79, 19);
            this.FullCostLbl.TabIndex = 14;
            this.FullCostLbl.Text = "Finaly Cost: ";
            this.FullCostLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GetOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 496);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.FullCostLbl);
            this.Controls.Add(this.ShowFoodsBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.FoodCost);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.FoodId);
            this.Controls.Add(this.ListOfFood);
            this.Controls.Add(this.LineBottom);
            this.Controls.Add(this.LineLbl);
            this.Controls.Add(this.ChooseFIleBtn);
            this.Controls.Add(this.GetFileUrlBox);
            this.Controls.Add(this.FileNameLbl);
            this.Name = "GetOrdersForm";
            this.Text = "Start Ordering Food";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GetOrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel FileNameLbl;
        public MetroFramework.Controls.MetroTextBox GetFileUrlBox;
        public MetroFramework.Controls.MetroButton ChooseFIleBtn;
        public MetroFramework.Controls.MetroLabel LineLbl;
        public MetroFramework.Controls.MetroLabel LineBottom;
        public MetroFramework.Controls.MetroLabel ListOfFood;
        public MetroFramework.Controls.MetroLabel FoodId;
        public MetroFramework.Controls.MetroLabel FoodName;
        public MetroFramework.Controls.MetroLabel FoodCost;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.OpenFileDialog ChooseFileDBox;
        public MetroFramework.Controls.MetroButton ShowFoodsBtn;
        public MetroFramework.Controls.MetroTextBox CostTextBox;
        public MetroFramework.Controls.MetroLabel FullCostLbl;
    }
}