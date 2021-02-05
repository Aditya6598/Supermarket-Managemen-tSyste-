namespace Grocery_Management_Shop
{
    partial class Welcome_pg
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
            this.Cust_detail = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.Label();
            this.Addr = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Adm_log = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cus_name = new System.Windows.Forms.TextBox();
            this.Cus_addr = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cust_detail
            // 
            this.Cust_detail.BackColor = System.Drawing.Color.Transparent;
            this.Cust_detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cust_detail.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_detail.Location = new System.Drawing.Point(187, 296);
            this.Cust_detail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cust_detail.Name = "Cust_detail";
            this.Cust_detail.Size = new System.Drawing.Size(138, 37);
            this.Cust_detail.TabIndex = 0;
            this.Cust_detail.Text = "Submit";
            this.Cust_detail.UseVisualStyleBackColor = false;
            this.Cust_detail.Click += new System.EventHandler(this.Cust_detail_Click);
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.BackColor = System.Drawing.Color.Transparent;
            this.CName.Location = new System.Drawing.Point(15, 141);
            this.CName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(151, 21);
            this.CName.TabIndex = 1;
            this.CName.Text = "Customer Name";
            // 
            // Addr
            // 
            this.Addr.AutoSize = true;
            this.Addr.BackColor = System.Drawing.Color.Transparent;
            this.Addr.Location = new System.Drawing.Point(56, 205);
            this.Addr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Addr.Name = "Addr";
            this.Addr.Size = new System.Drawing.Size(80, 21);
            this.Addr.TabIndex = 2;
            this.Addr.Text = "Address";
            this.Addr.Click += new System.EventHandler(this.Addr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Adm_log,
            this.toolStripMenuItem1,
            this.homeToolStripMenuItem,
            this.employeeLoginToolStripMenuItem,
            this.cartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(540, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Adm_log
            // 
            this.Adm_log.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adm_log.Name = "Adm_log";
            this.Adm_log.Size = new System.Drawing.Size(93, 19);
            this.Adm_log.Text = "Admin Login";
            this.Adm_log.Click += new System.EventHandler(this.Adm_log_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 19);
            this.toolStripMenuItem1.Text = "                                  ";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.homeToolStripMenuItem.Text = "Home ";
            // 
            // employeeLoginToolStripMenuItem
            // 
            this.employeeLoginToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLoginToolStripMenuItem.Name = "employeeLoginToolStripMenuItem";
            this.employeeLoginToolStripMenuItem.Size = new System.Drawing.Size(109, 19);
            this.employeeLoginToolStripMenuItem.Text = "Employee Login";
            this.employeeLoginToolStripMenuItem.Click += new System.EventHandler(this.employeeLoginToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // Cus_name
            // 
            this.Cus_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cus_name.Location = new System.Drawing.Point(175, 132);
            this.Cus_name.Name = "Cus_name";
            this.Cus_name.Size = new System.Drawing.Size(211, 30);
            this.Cus_name.TabIndex = 4;
            // 
            // Cus_addr
            // 
            this.Cus_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cus_addr.Location = new System.Drawing.Point(175, 205);
            this.Cus_addr.Name = "Cus_addr";
            this.Cus_addr.Size = new System.Drawing.Size(211, 30);
            this.Cus_addr.TabIndex = 5;
            this.Cus_addr.TextChanged += new System.EventHandler(this.Cus_addr_TextChanged);
            // 
            // Welcome_pg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.Cus_addr);
            this.Controls.Add(this.Cus_name);
            this.Controls.Add(this.Addr);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.Cust_detail);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Welcome_pg";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_pg_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cust_detail;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label Addr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox Cus_name;
        private System.Windows.Forms.TextBox Cus_addr;
        private System.Windows.Forms.ToolStripMenuItem Adm_log;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
    }
}