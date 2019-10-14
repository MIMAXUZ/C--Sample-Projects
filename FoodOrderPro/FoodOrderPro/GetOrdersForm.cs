using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
namespace FoodOrderPro
{
    public partial class GetOrdersForm : MetroForm
    {
        //Creating Global Varibales
        public static string GetFoodId;
        public static string GetFoodName;
        public static string GetFoodCost;

        public GetOrdersForm()
        {
            InitializeComponent();

            
        }

        private void GetOrdersForm_Load(object sender, EventArgs e)
        {
            //Get value from another
            CostTextBox.Text = GetOrderDesc.GetCountOfFood;
        }

        private void ChooseFIleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChooseFileDBox = new OpenFileDialog();
            ChooseFileDBox.InitialDirectory = @"C:\";
            ChooseFileDBox.Title = "Browse Text  Files";
            ChooseFileDBox.CheckFileExists = true;
            ChooseFileDBox.CheckPathExists = true;
            ChooseFileDBox.DefaultExt = "txt";
            ChooseFileDBox.Filter = "Text  files(*.txt|*.txt";
            ChooseFileDBox.FilterIndex = 1;
            ChooseFileDBox.RestoreDirectory = true;
            ChooseFileDBox.ReadOnlyChecked = true;
            ChooseFileDBox.ShowReadOnly = true;
            if (ChooseFileDBox.ShowDialog() == DialogResult.OK)
            {
                GetFileUrlBox.Text = ChooseFileDBox.FileName;
            }

        }
        private void ShowFoodsBtn_Click(object sender, EventArgs e)
        {
            //Button locations 12; 104
            int x = 29, y = 216;
            int xn = 55, xc = 155, xb = 214;
            string[] lines = File.ReadAllLines(GetFileUrlBox.Text);
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    StringBuilder b = new StringBuilder(lines[i]);
                    string a = b.ToString();
                    string[] words = a.Split(new char[] { ',' }, StringSplitOptions.None);
                    //Creating Dynamic buttons
                    if (i == 0)
                    {
                        Label lb = new Label();
                        lb.Location = new Point(29, 216);
                        lb.Name = "IDButton_" + (i + 1).ToString();
                        lb.Text = words[0];
                        lb.Size = new Size(14, 15);
                        lb.Font = new Font("Microsoft Sans Serif", 9);
                        lb.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lb.Padding = new Padding(0);
                        this.Controls.Add(lb);

                        //Label For Names
                        Label lbName = new Label();
                        lbName.Location = new Point(55, 216);
                        lbName.Name = "NameButton_" + (i + 1).ToString();
                        lbName.Text = words[1];
                        lbName.Size = new Size(67, 15);
                        lbName.Font = new Font("Microsoft Sans Serif", 9);
                        lbName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lbName.Padding = new Padding(0);
                        this.Controls.Add(lbName);

                        //Label for costs
                        Label lblCost = new Label();
                        lblCost.Location = new Point(155, 216);
                        lblCost.Name = "CostButton_" + (i + 1).ToString();
                        lblCost.Text = words[2];
                        lblCost.Size = new Size(67, 15);
                        lblCost.Font = new Font("Microsoft Sans Serif", 9);
                        lblCost.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lblCost.Padding = new Padding(0);
                        this.Controls.Add(lblCost);

                        //Creating buttons
                        Button bt = new Button();
                        bt.Location = new Point(214, 216);
                        bt.Name = "OrderBtn_" + (i + 1).ToString();
                        bt.Text = "Get Order";
                        bt.Size = new Size(75, 15);
                        bt.Font = new Font("Microsoft Sans Serif", 4);
                        bt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        bt.Padding = new Padding(0);
                        //bt.Click += new EventHandler(this.FBtn_Click);
                        bt.Click += delegate
                        {
                            //Get All Info Here
                            GetFoodId = words[0];
                            GetFoodName = words[1];
                            GetFoodCost = words[2];
                            GetOrderDesc gfc = new GetOrderDesc();
                            gfc.ShowDialog();
                        };
                        this.Controls.Add(bt);
                    }
                    else
                    {
                        //Creating and adding with new location  s
                        x = x - 243;
                        y = y + 27;

                        Label lb = new Label();
                        lb.Location = new Point(x, y);
                        lb.Name = "IDButton_" + (i + 1).ToString();
                        lb.Text = words[0];
                        lb.Size = new Size(14, 15);
                        lb.Font = new Font("Microsoft Sans Serif", 9);
                        lb.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lb.Padding = new Padding(0);
                        this.Controls.Add(lb);

                        //Label For Names
                        Label lbName = new Label();
                        lbName.Location = new Point(xn, y);
                        lbName.Name = "NameButton_" + (i + 1).ToString();
                        lbName.Text = words[1];
                        lbName.Size = new Size(67, 15);
                        lbName.Font = new Font("Microsoft Sans Serif", 9);
                        lbName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lbName.Padding = new Padding(0);
                        this.Controls.Add(lbName);

                        //Label for costs
                        Label lblCost = new Label();
                        lblCost.Location = new Point(xc, y);
                        lblCost.Name = "CostButton_" + (i + 1).ToString();
                        lblCost.Text = words[2];
                        lblCost.Size = new Size(67, 15);
                        lblCost.Font = new Font("Microsoft Sans Serif", 9);
                        lblCost.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        lblCost.Padding = new Padding(0);
                        this.Controls.Add(lblCost);

                        //Creating buttons
                        Button bt = new Button();
                        bt.Location = new Point(xb, y);
                        bt.Name = "OrderBtn_" + (i + 1).ToString();
                        bt.Text = "Get Order";
                        bt.Size = new Size(75, 15);
                        bt.Font = new Font("Microsoft Sans Serif", 4);
                        bt.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                        //bt.Click += new EventHandler(this.FBtn_Click);
                        bt.Click += delegate
                        {
                            //Get All Info Here
                            GetFoodId = words[0];
                            GetFoodName = words[1];
                            GetFoodCost = words[2];
                            GetOrderDesc gfc = new GetOrderDesc();
                            gfc.ShowDialog();
                        };
                        bt.Padding = new Padding(0);
                        this.Controls.Add(bt);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "O'qishda Xatolik Mavjud!");
                }
            }
        }

    }
}
