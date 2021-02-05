using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grocery_Management_Shop
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_form empForm = new Employee_form();
            empForm.MdiParent = this;
            empForm.Show();

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b1 = new Bill();
            b1.MdiParent = this;
            b1.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierDetails sup = new SupplierDetails();
            sup.MdiParent = this;
            sup.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails std = new StockDetails();
            std.MdiParent = this;
            std.Show();
        }
    }
}
