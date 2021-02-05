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
    public partial class Snack_Beverages : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataReader dr;
        DataTable dt;
        int CustId;
        int stockId;
        int SubTotal;
        public Snack_Beverages()
        {
            InitializeComponent();
        }

        private void Snack_Beverages_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select MAX(Cust_ID) from Cutsomer", con);
            CustId = Convert.ToInt16(cmd.ExecuteScalar());
            lblCustID.Text = CustId.ToString();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from Product where Type='Snack_Beverages'", con);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
           
            con.Close();
        }

       

        private void Cart_Click(object sender, EventArgs e)
        {
            Cart c = new Cart();
            c.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stockId = Convert.ToInt16(txtPID.Text);
            if (stockId != 0)
            {
                con.Open();
                cmd = new SqlCommand("Select * from product where Product_ID='" + stockId + "'", con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                if (dt != null)
                {
                    txtPrize.Text = dt.Rows[0]["Prize"].ToString();

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("please select Stock ID");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd1 = new SqlCommand("insert into Carts (Product_Id,Product_Prize,Quantity,subTotal,CustID)values('" + stockId + "','" + txtPrize.Text + "','" + txtQuantity.Text + "','" + txtSubtotal.Text + "','" + CustId + "')", con);
            int i = cmd1.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Added to the Cart");
                txtQuantity.Text = "";
                txtPID.Text = "";
                txtPrize.Text = "";
                txtSubtotal.Text = "";
            }
            con.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                SubTotal = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrize.Text);
                txtSubtotal.Text = Convert.ToString(SubTotal);
            }
        }
    }
}
