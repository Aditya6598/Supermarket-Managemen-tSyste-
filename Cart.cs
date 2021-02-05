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
    public partial class Cart : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataReader dr;
        DataTable dt;
        int CustId;
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
           
            dt = new DataTable();
            con.Open();
            cmd = new SqlCommand("select MAX(Cust_ID) from Cutsomer", con);
            CustId = Convert.ToInt16(cmd.ExecuteScalar());
            lblCustID.Text = CustId.ToString();
            cmd1 = new SqlCommand("Select Product_Id,Product_Prize,Quantity,subTotal from Carts where CustID='" + CustId + "'", con);
            dr = cmd1.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select sum(CAST((subTotal)as int)) from Carts where CustID='" + CustId + "'", con);
            int TotalAmount = Convert.ToInt16(cmd.ExecuteScalar());
            textBox1.Text = TotalAmount.ToString();
            con.Close();
        }
        public void billingTable()
        {
            DateTime datetime=DateTime.Now;
            datetime.ToString();
            
            con.Open();
           // cmd = new SqlCommand("insert into Billing values('"+cartID+"','"+CustId+"','"+Subtotal+"','"+Total+"','"+datetime+"')");
            con.Close();
        }
    }
}
