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
    public partial class Employee_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public Employee_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtname.Text != "" && txtadd.Text != "" && txtmob.Text != "" && txtpan.Text != "" && txtuser.Text != "" && txtpass.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into Employee values('" + Txtname.Text + "','" + txtadd.Text + "','" + txtmob.Text + "','" + txtpan.Text + "','" + txtuser.Text + "','" + txtpass.Text + "','" + cmbrole.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User Created");
                Refresh();
            }
            else
            {
                MessageBox.Show("Please Fill all the Employees Details");
            }

        }
        public void Refresh()
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter("select * from Employee", con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "Employee");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee";
            txtadd.Text = "";
            txtmob.Text = "";
            Txtname.Text = "";
            txtpan.Text = "";
            txtpass.Text = "";
            txtuser.Text = "";
        }
        private void Employee_form_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Employee", con);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int EmpId = Convert.ToInt16(txtID.Text);
            if (EmpId != null)
            {
                con.Open();
                dt.Clear();
                cmd = new SqlCommand("Select * from Employee where Emp_ID='" + EmpId + "'",con);
                dr = cmd.ExecuteReader();
                dt.Load(dr);

                Txtname.Text = dt.Rows[0]["Name"].ToString();
                txtadd.Text = dt.Rows[0]["Address"].ToString();
                txtmob.Text = dt.Rows[0]["PanCardNo"].ToString();
                txtpan.Text = dt.Rows[0]["PhoneNo"].ToString();
                cmbrole.Text = dt.Rows[0]["Role"].ToString();
                txtuser.Text = dt.Rows[0]["UserName"].ToString();
                txtpass.Text = dt.Rows[0]["Password"].ToString();

                con.Close();
            }
            else
            {
                MessageBox.Show("please select Employee ID");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int EmpID = Convert.ToInt16(txtID.Text);
            if (EmpID == 0)
            {
                MessageBox.Show("Please select Employee ID");
            }
            if (Txtname.Text != null && txtadd.Text != null && txtmob.Text != null && txtpass.Text != null && txtuser.Text != null && cmbrole.Text != null)
            {
                con.Open();
                cmd = new SqlCommand("Update Employee set Name='" + Txtname.Text + "',Address='" + txtadd.Text + "',PanCardNo='" + txtpan.Text + "',PhoneNo='" + txtmob.Text + "',UserName='" + txtuser.Text + "',Password='" + txtpass.Text + "',Role='" + cmbrole.Text + "' where Emp_ID='" + EmpID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Employee detail Updated");
            }
            else
            {
                MessageBox.Show("Please Fill all Details");
            }
        }
    }
}
