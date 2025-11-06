namespace saleAndBillingSystem
{
    partial class dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPro = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.z = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPro
            // 
            this.lbPro.AutoSize = true;
            this.lbPro.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPro.Location = new System.Drawing.Point(84, 91);
            this.lbPro.Name = "lbPro";
            this.lbPro.Size = new System.Drawing.Size(0, 60);
            this.lbPro.TabIndex = 3;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(84, 107);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(0, 60);
            this.lbProduct.TabIndex = 4;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalProducts.Location = new System.Drawing.Point(86, 97);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(47, 60);
            this.lblTotalProducts.TabIndex = 5;
            this.lblTotalProducts.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Violet;
            this.btnRefresh.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(961, 283);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalProducts);
            this.panel1.Location = new System.Drawing.Point(38, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 200);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTotalUsers);
            this.panel2.Location = new System.Drawing.Point(304, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 200);
            this.panel2.TabIndex = 11;
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsers.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalUsers.Location = new System.Drawing.Point(93, 97);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(47, 60);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTodaySales);
            this.panel3.Location = new System.Drawing.Point(578, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 200);
            this.panel3.TabIndex = 11;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.ForeColor = System.Drawing.Color.Transparent;
            this.lblTodaySales.Location = new System.Drawing.Point(58, 97);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(47, 60);
            this.lblTodaySales.TabIndex = 5;
            this.lblTodaySales.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.z);
            this.panel4.Location = new System.Drawing.Point(849, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 200);
            this.panel4.TabIndex = 12;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.z.ForeColor = System.Drawing.Color.Transparent;
            this.z.Location = new System.Drawing.Point(12, 97);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(47, 60);
            this.z.TabIndex = 5;
            this.z.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(62, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Sale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(44, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Income";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::saleAndBillingSystem.Properties.Resources.dash_bpard_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.lbPro);
            this.DoubleBuffered = true;
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1132, 653);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPro;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
