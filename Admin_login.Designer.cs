namespace Grocery_Management_Shop
{
    partial class Admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            this.Adm = new System.Windows.Forms.Label();
            this.Adm1 = new System.Windows.Forms.Label();
            this.Adm_pg = new System.Windows.Forms.Button();
            this.Adm_pass = new System.Windows.Forms.TextBox();
            this.Adm_ID = new System.Windows.Forms.TextBox();
            this.Adm2 = new System.Windows.Forms.Label();
            this.Add_Emp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Adm
            // 
            this.Adm.AutoSize = true;
            this.Adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm.Location = new System.Drawing.Point(86, 89);
            this.Adm.Name = "Adm";
            this.Adm.Size = new System.Drawing.Size(83, 20);
            this.Adm.TabIndex = 0;
            this.Adm.Text = "Username";
            // 
            // Adm1
            // 
            this.Adm1.AutoSize = true;
            this.Adm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm1.Location = new System.Drawing.Point(80, 165);
            this.Adm1.Name = "Adm1";
            this.Adm1.Size = new System.Drawing.Size(78, 20);
            this.Adm1.TabIndex = 1;
            this.Adm1.Text = "Password";
            // 
            // Adm_pg
            // 
            this.Adm_pg.BackColor = System.Drawing.Color.White;
            this.Adm_pg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm_pg.Location = new System.Drawing.Point(74, 285);
            this.Adm_pg.Name = "Adm_pg";
            this.Adm_pg.Size = new System.Drawing.Size(84, 32);
            this.Adm_pg.TabIndex = 2;
            this.Adm_pg.Text = "Submit";
            this.Adm_pg.UseVisualStyleBackColor = false;
            this.Adm_pg.Click += new System.EventHandler(this.Adm_pg_Click);
            // 
            // Adm_pass
            // 
            this.Adm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm_pass.Location = new System.Drawing.Point(182, 165);
            this.Adm_pass.Name = "Adm_pass";
            this.Adm_pass.PasswordChar = '*';
            this.Adm_pass.Size = new System.Drawing.Size(121, 21);
            this.Adm_pass.TabIndex = 3;
            // 
            // Adm_ID
            // 
            this.Adm_ID.Location = new System.Drawing.Point(182, 91);
            this.Adm_ID.Name = "Adm_ID";
            this.Adm_ID.Size = new System.Drawing.Size(121, 20);
            this.Adm_ID.TabIndex = 4;
            // 
            // Adm2
            // 
            this.Adm2.AutoSize = true;
            this.Adm2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm2.Location = new System.Drawing.Point(86, 20);
            this.Adm2.Name = "Adm2";
            this.Adm2.Size = new System.Drawing.Size(185, 23);
            this.Adm2.TabIndex = 5;
            this.Adm2.Text = "For Office Use Only";
            // 
            // Add_Emp
            // 
            this.Add_Emp.BackColor = System.Drawing.Color.White;
            this.Add_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Emp.Location = new System.Drawing.Point(193, 285);
            this.Add_Emp.Name = "Add_Emp";
            this.Add_Emp.Size = new System.Drawing.Size(84, 32);
            this.Add_Emp.TabIndex = 6;
            this.Add_Emp.Text = "Add Employee";
            this.Add_Emp.UseVisualStyleBackColor = false;
            this.Add_Emp.Click += new System.EventHandler(this.Add_Emp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Role";
            // 
            // cmdRole
            // 
            this.cmdRole.FormattingEnabled = true;
            this.cmdRole.Items.AddRange(new object[] {
            "staff",
            "manager"});
            this.cmdRole.Location = new System.Drawing.Point(182, 218);
            this.cmdRole.Name = "cmdRole";
            this.cmdRole.Size = new System.Drawing.Size(121, 21);
            this.cmdRole.TabIndex = 8;
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 341);
            this.Controls.Add(this.cmdRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Emp);
            this.Controls.Add(this.Adm2);
            this.Controls.Add(this.Adm_ID);
            this.Controls.Add(this.Adm_pass);
            this.Controls.Add(this.Adm_pg);
            this.Controls.Add(this.Adm1);
            this.Controls.Add(this.Adm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_login";
            this.Text = "Admin_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adm;
        private System.Windows.Forms.Label Adm1;
        private System.Windows.Forms.Button Adm_pg;
        private System.Windows.Forms.TextBox Adm_pass;
        private System.Windows.Forms.TextBox Adm_ID;
        private System.Windows.Forms.Label Adm2;
        private System.Windows.Forms.Button Add_Emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdRole;
    }
}