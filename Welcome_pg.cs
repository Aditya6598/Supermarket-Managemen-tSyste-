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
    public partial class Welcome_pg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        public int BillId;
        public Welcome_pg()
        {
            InitializeComponent();
        }


        private void Adm_log_Click(object sender, EventArgs e)
        {
            Admin_login a1 = new Admin_login();
            a1.Show();
            this.Hide();
        }

        private void Cust_detail_Click(object sender, EventArgs e)
        {
            con.Open();
            BillId = 0;
            cmd = new SqlCommand("insert into Cutsomer values('"+Cus_name.Text+"','"+Cus_addr.Text+"','"+BillId+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Welcome User");
            this.Hide();
            Tabs Tb = new Tabs();
            Tb.Show();
            con.Close();

            Tabs t1 = new Tabs();
            t1.Show();
            this.Hide();
        }

        private void Welcome_pg_Load(object sender, EventArgs e)
        {

        }

        private void Addr_Click(object sender, EventArgs e)
        {

        }

        private void Cus_addr_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_login l = new Employee_login();
            l.Show();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart cc = new Cart();
            cc.Show();
        }

       
    }
}
