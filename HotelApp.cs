using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBillingSystem
{
    public partial class HotelApp : Form
    {
        public HotelApp()
        {
            InitializeComponent();
        }


        private void NewEntry_Click(object sender, EventArgs e)
        {
            FoodEntry fe = new FoodEntry();
            fe.Show();
            this.Hide();
        }

        private void Billing_Click(object sender, EventArgs e)
        {
            SalesBilling sb = new SalesBilling();
            sb.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }
    }
}
