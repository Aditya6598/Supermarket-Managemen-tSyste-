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
    public partial class StockDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        public StockDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtStockName.Text = "";
            txtStockQuantity.Text = "";
            txtPrice.Text = "";
            int stockId = Convert.ToInt16(txtID.Text);
            if (stockId != null)
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand("Select * from Stock where Stock_ID='" + txtID.Text + "'", con);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    txtStockName.Text = dt.Rows[0]["Name"].ToString();
                    txtStockQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    cmbType.Text = dt.Rows[0]["Type"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("please select Stock ID");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStockQuantity.Text != "" && txtStockName.Text != "" && txtPrice.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Stock values('" + txtStockName.Text + "','" + txtStockQuantity.Text + "','" + txtPrice.Text + "','" + cmbType.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Stock Added");
                Refresh();
            }
            else
            {
                MessageBox.Show("Please Fill all Details");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int StockID = Convert.ToInt16(txtID.Text);
            if (txtID.Text == null)
            {
                MessageBox.Show("Please select Stock ID");
            }
            if (txtStockQuantity.Text != null && txtStockName.Text != null && txtPrice.Text != null)
            {
                con.Open();
                cmd = new SqlCommand("Update Stock set Name='" + txtStockName.Text + "',Quantity='" + txtStockQuantity.Text + "',Price='" + txtPrice.Text + "',Type='" + cmbType.Text + "' where Stock_ID='" + StockID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Stock Updated");
                Refresh();
            }
            else
            {
                MessageBox.Show("Please Fill all Details");
            }

        }
        public void Refresh()
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter("select * from Stock", con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "Stock");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Stock";
            txtStockName.Text = "";
            txtStockQuantity.Text = "";
            txtPrice.Text = "";
        }
        private void StockDetails_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
