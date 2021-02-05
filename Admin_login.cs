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
    public partial class Admin_login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADITYA-123\SQLSERVER;Initial Catalog=Grocery_Management_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Adm_pg_Click(object sender, EventArgs e)
        {
            con.Open();
            if (cmdRole.Text == "staff")
            {
                cmd = new SqlCommand("select Emp_ID from Employee where Username='" + Adm_ID.Text + "' and Password ='" + Adm_pass.Text + "' and Role='" + cmdRole.Text + "'", con);
                int id = Convert.ToInt16(cmd.ExecuteScalar());
                if (id == null)
                {
                    MessageBox.Show("User Does Not Exist");
                }
                else
                {
                    MessageBox.Show("Welcome User");
                    Main_form main = new Main_form();
                    main.Show();
                    this.Hide();
                }
            }
            else if (cmdRole.Text == "manager")
            {
                cmd = new SqlCommand("select Emp_ID from Employee where Username='" + Adm_ID.Text + "' and Password ='" + Adm_pass.Text + "' and Role='" + cmdRole.Text + "'", con);
                int id = Convert.ToInt16(cmd.ExecuteScalar());
                if (id == null)
                {
                    MessageBox.Show("User Does Not Exist");
                }
                else
                {
                    MessageBox.Show("Welcome User");
                    Cart cart = new Cart();
                    cart.Show();
                    this.Hide();
                }
            }
            

            con.Close();
        }

        private void Add_Emp_Click(object sender, EventArgs e)
        {
            Employee_form emp1 = new Employee_form();
            emp1.Show();
            this.Hide();
        }
    }
}
