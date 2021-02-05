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
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt=new DataTable();
        public Bill()
        {
            InitializeComponent();
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
           
            string dateTime = dateTimePicker1.Text;
            con.Open();
            cmd = new SqlCommand("select CS.Cname,CS.Address, Cart_ID,PD.Name,PD.Prize,Quantity,subTotal from Carts CA " +
                                 "inner join Product PD on PD.Product_ID=CA.Product_Id inner join Cutsomer CS on CS.Cust_ID=CA.CustID", con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
           
            con.Close();
        }
    }
}
