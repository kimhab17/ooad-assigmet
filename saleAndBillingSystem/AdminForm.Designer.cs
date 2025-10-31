namespace saleAndBillingSystem
{
    partial class AdminForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSide = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dashboard1 = new saleAndBillingSystem.dashboard();
            this.user1 = new saleAndBillingSystem.user();
            this.product1 = new saleAndBillingSystem.product();
            this.sale1 = new saleAndBillingSystem.sale();
            this.categories1 = new saleAndBillingSystem.categories();
            this.product2 = new saleAndBillingSystem.product();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSide.Controls.Add(this.label1);
            this.panelSide.Controls.Add(this.btnSale);
            this.panelSide.Controls.Add(this.btnCate);
            this.panelSide.Controls.Add(this.btnPro);
            this.panelSide.Controls.Add(this.btnUser);
            this.panelSide.Controls.Add(this.btnDash);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(250, 703);
            this.panelSide.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Dashbord";
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Blue;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::saleAndBillingSystem.Properties.Resources.sales;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(24, 350);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSale.Size = new System.Drawing.Size(200, 40);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnCate
            // 
            this.btnCate.BackColor = System.Drawing.Color.Blue;
            this.btnCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCate.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCate.ForeColor = System.Drawing.Color.White;
            this.btnCate.Image = global::saleAndBillingSystem.Properties.Resources.application;
            this.btnCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCate.Location = new System.Drawing.Point(24, 410);
            this.btnCate.Name = "btnCate";
            this.btnCate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCate.Size = new System.Drawing.Size(200, 40);
            this.btnCate.TabIndex = 3;
            this.btnCate.Text = "Categories";
            this.btnCate.UseVisualStyleBackColor = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.Blue;
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPro.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.White;
            this.btnPro.Image = global::saleAndBillingSystem.Properties.Resources.box;
            this.btnPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPro.Location = new System.Drawing.Point(24, 292);
            this.btnPro.Name = "btnPro";
            this.btnPro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPro.Size = new System.Drawing.Size(200, 40);
            this.btnPro.TabIndex = 2;
            this.btnPro.Text = "Product";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Blue;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::saleAndBillingSystem.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(24, 235);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(200, 40);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Blue;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Image = global::saleAndBillingSystem.Properties.Resources.dashboard;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(24, 176);
            this.btnDash.Name = "btnDash";
            this.btnDash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDash.Size = new System.Drawing.Size(200, 40);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDash_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 50);
            this.panel2.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dashboard1);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panelSide);
            this.panelMain.Controls.Add(this.user1);
            this.panelMain.Controls.Add(this.product1);
            this.panelMain.Controls.Add(this.sale1);
            this.panelMain.Controls.Add(this.categories1);
            this.panelMain.Controls.Add(this.product2);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1382, 703);
            this.panelMain.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(250, 50);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dashboard1.Size = new System.Drawing.Size(1132, 653);
            this.dashboard1.TabIndex = 3;
            // 
            // user1
            // 
            this.user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user1.Location = new System.Drawing.Point(0, 0);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(1382, 703);
            this.user1.TabIndex = 5;
            // 
            // product1
            // 
            this.product1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product1.Location = new System.Drawing.Point(0, 0);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(1382, 703);
            this.product1.TabIndex = 4;
            // 
            // sale1
            // 
            this.sale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sale1.Location = new System.Drawing.Point(0, 0);
            this.sale1.Name = "sale1";
            this.sale1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sale1.Size = new System.Drawing.Size(1382, 703);
            this.sale1.TabIndex = 8;
            // 
            // categories1
            // 
            this.categories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categories1.Location = new System.Drawing.Point(0, 0);
            this.categories1.Name = "categories1";
            this.categories1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categories1.Size = new System.Drawing.Size(1382, 703);
            this.categories1.TabIndex = 7;
            // 
            // product2
            // 
            this.product2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product2.Location = new System.Drawing.Point(0, 0);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(1382, 703);
            this.product2.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.panelMain);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private dashboard dashboard1;
        private product product1;
        private user user1;
        private product product2;
        private sale sale1;
        private categories categories1;
        private System.Windows.Forms.Label label1;
    }
}