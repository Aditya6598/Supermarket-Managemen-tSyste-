namespace Grocery_Management_Shop
{
    partial class Employee_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_login));
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.Emp_pass = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Emp_ID
            // 
            this.Emp_ID.Location = new System.Drawing.Point(231, 130);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(172, 20);
            this.Emp_ID.TabIndex = 0;
            // 
            // Emp_pass
            // 
            this.Emp_pass.Location = new System.Drawing.Point(231, 191);
            this.Emp_pass.Name = "Emp_pass";
            this.Emp_pass.PasswordChar = '*';
            this.Emp_pass.Size = new System.Drawing.Size(100, 20);
            this.Emp_pass.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(12, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(193, 24);
            this.l1.TabIndex = 2;
            this.l1.Text = "For Office Use Only";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(120, 194);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(78, 20);
            this.l3.TabIndex = 3;
            this.l3.Text = "Password";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(120, 137);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(83, 20);
            this.l2.TabIndex = 4;
            this.l2.Text = "Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(242, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(544, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Emp_pass);
            this.Controls.Add(this.Emp_ID);
            this.DoubleBuffered = true;
            this.Name = "Employee_login";
            this.Text = "Employee_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.TextBox Emp_pass;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button button1;
    }
}