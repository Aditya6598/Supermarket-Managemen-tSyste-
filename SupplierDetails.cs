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
    public partial class SupplierDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt=new DataTable();
        public SupplierDetails()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int SupplierId = Convert.ToInt16(txtID.Text);
            if (txtID.Text != null)
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand("Select * from Supplier where Sup_ID='" + txtID.Text + "'",con);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
               
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtComName.Text = dt.Rows[0]["Company_name"].ToString();

                    txtprice.Text = dt.Rows[0]["prize"].ToString();
                    txtQuantity.Text = dt.Rows[0]["quentity"].ToString();
                
                con.Close();
            }
            else
            {
                MessageBox.Show("please select Supplier ID");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtComName.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Supplier values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtComName.Text + "','" + txtprice.Text + "','" + txtQuantity.Text + "')", con);
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
            int SupplierID = Convert.ToInt16(txtID.Text);
            if (txtID.Text == null)
            {
                MessageBox.Show("Please select Supplier ID");
            }
            if (txtName.Text != null && txtAddress.Text != null && txtprice.Text != null && txtComName.Text != null && txtQuantity.Text != null )
            {
                con.Open();
                cmd = new SqlCommand("Update Supplier set Name='" + txtName.Text + "',Address='" + txtAddress.Text + "',Company_name='" + txtComName.Text + "',prize='" + txtprice.Text + "',quentity='" + txtQuantity.Text + "' where Sup_ID='" + SupplierID + "'", con);
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
            SqlDataAdapter dataadapter = new SqlDataAdapter("select * from supplier", con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "supplier");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "supplier";
            txtAddress.Text = "";
            txtComName.Text = "";
            txtName.Text = "";
            txtprice.Text = "";
            txtQuantity.Text = "";
        }
        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
