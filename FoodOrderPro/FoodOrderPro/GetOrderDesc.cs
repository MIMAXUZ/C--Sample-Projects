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
    public partial class GetOrderDesc : MetroForm
    {
        //Creating Global Variables
        public static string GetCountOfFood;

        public GetOrderDesc()
        {
            InitializeComponent();
        }
        private void GetOrderDesc_Load(object sender, EventArgs e)
        {
            GetById.Text = GetOrdersForm.GetFoodId;
            GetByName.Text = GetOrdersForm.GetFoodName;
            GetByCost.Text = GetOrdersForm.GetFoodCost;
        }

        private void GetById_Click(object sender, EventArgs e)
        {

        }

        private void OrderItBtn_Click(object sender, EventArgs e)
        {
            GetOrdersForm fm = new GetOrdersForm();
            int fc = Convert.ToInt32(this.QuantityBox.Text);
            //GetOrdersForm.GetFoodCost;
            int fcc = Convert.ToInt32(this.GetByCost.Text);
            int fcf = fc * fcc;
            //Get All Info Here
            GetCountOfFood = fcf.ToString();
            this.Visible = false;
            fm.Show(this);
        }
    }
}
