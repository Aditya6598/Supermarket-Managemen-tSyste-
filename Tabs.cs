using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_Management_Shop
{
    public partial class Tabs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;

        public Tabs()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Tabs_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select MAX(Cust_ID) from Cutsomer",con);
            lbl_ID.Text =Convert.ToString( cmd.ExecuteScalar());
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dairy_Bakery d_b = new Dairy_Bakery();
            d_b.Show();
        }

        private void f_b_Click(object sender, EventArgs e)
        {
            Fruits_Vegetables a1 = new Fruits_Vegetables();
            a1.Show();
        }

        private void s_b_Click(object sender, EventArgs e)
        {
            Snack_Beverages sb = new Snack_Beverages();
            sb.Show();
        }

        private void Non_veg_Click(object sender, EventArgs e)
        {
            Eggs_Fish_Meat efm = new Eggs_Fish_Meat();
            efm.Show();
        }

        private void s_Click(object sender, EventArgs e)
        {
            Spices ss = new Spices();
            ss.Show();
        }

        private void g_p_Click(object sender, EventArgs e)
        {
            Grains g = new Grains();
            g.Show();
        }
    }
}
