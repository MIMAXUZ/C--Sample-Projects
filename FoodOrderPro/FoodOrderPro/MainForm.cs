using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace FoodOrderPro
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            GetOrdersForm fm = new GetOrdersForm()
            { };
            this.Visible = false;
            fm.Show(this);
        }
    }
}
