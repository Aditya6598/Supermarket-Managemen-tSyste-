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
    public partial class Update_emp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Update_emp()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Employee where Emp_ID ='"+Emp_ID.Text+"'",con);
            dr= cmd.ExecuteReader();
           while (dr.Read())
           {
               Txtname.Text = dr["Name"].ToString();
               txtadd.Text = dr["Address"].ToString();
               txtpan.Text = dr["PanCardNo"].ToString();
               txtmob.Text = dr["PhoneNo"].ToString();
               cmbrole.Text=dr["Role"].ToString();
           }
            con.Close();

        }
    }
}
