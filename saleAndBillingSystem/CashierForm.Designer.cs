namespace saleAndBillingSystem
{
    partial class CashierForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new saleAndBillingSystem.RoundedButton();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new saleAndBillingSystem.RoundedButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new saleAndBillingSystem.RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new saleAndBillingSystem.RoundedButton();
            this.btnPrintInvoice = new saleAndBillingSystem.RoundedButton();
            this.panelInput = new saleAndBillingSystem.RoundedPanel();
            this.panelCart = new saleAndBillingSystem.RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.BorderRadius = 30;
            this.panelInput.Controls.Add(this.lblTitle);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.cmbProduct);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtPrice);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.txtQuantity);
            this.panelInput.Controls.Add(this.btnAddToCart);
            this.panelInput.ForeColor = System.Drawing.Color.Black;
            this.panelInput.Location = new System.Drawing.Point(40, 40);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(400, 500);
            this.panelInput.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Poppins", 12F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(35, 130);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(320, 44);
            this.cmbProduct.TabIndex = 2;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtPrice.Location = new System.Drawing.Point(35, 230);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(320, 37);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(35, 330);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(320, 37);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddToCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddToCart.BorderRadius = 20;
            this.btnAddToCart.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = global::saleAndBillingSystem.Properties.Resources.add_icon;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.Location = new System.Drawing.Point(35, 410);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAddToCart.Size = new System.Drawing.Size(320, 45);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "ADD TO CART";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.White;
            this.panelCart.BorderRadius = 30;
            this.panelCart.Controls.Add(this.dgvCart);
            this.panelCart.Controls.Add(this.label3);
            this.panelCart.Controls.Add(this.lblTotal);
            this.panelCart.Controls.Add(this.btnCheckout);
            this.panelCart.Controls.Add(this.btnClear);
            this.panelCart.Controls.Add(this.btnPrintInvoice);
            this.panelCart.ForeColor = System.Drawing.Color.Black;
            this.panelCart.Location = new System.Drawing.Point(470, 40);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(840, 500);
            this.panelCart.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(30, 30);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(780, 330);
            this.dgvCart.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(520, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.lblTotal.Location = new System.Drawing.Point(620, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 40);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClear.BorderRadius = 20;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::saleAndBillingSystem.Properties.Resources.clear_icon;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(30, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnClear.Size = new System.Drawing.Size(140, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnPrintInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnPrintInvoice.BorderRadius = 20;
            this.btnPrintInvoice.BorderSize = 0;
            this.btnPrintInvoice.FlatAppearance.BorderSize = 0;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Image = global::saleAndBillingSystem.Properties.Resources.paper;
            this.btnPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintInvoice.Location = new System.Drawing.Point(190, 420);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPrintInvoice.Size = new System.Drawing.Size(200, 45);
            this.btnPrintInvoice.TabIndex = 4;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckout.BorderRadius = 20;
            this.btnCheckout.BorderSize = 0;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::saleAndBillingSystem.Properties.Resources.checkout;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.Location = new System.Drawing.Point(620, 420);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCheckout.Size = new System.Drawing.Size(190, 45);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::saleAndBillingSystem.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(40, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnExit.Size = new System.Drawing.Size(150, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::saleAndBillingSystem.Properties.Resources.cashire_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 656);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panelInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private saleAndBillingSystem.RoundedButton btnAddToCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private saleAndBillingSystem.RoundedButton btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private saleAndBillingSystem.RoundedButton btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private saleAndBillingSystem.RoundedButton btnExit;
        private saleAndBillingSystem.RoundedButton btnPrintInvoice;
        private saleAndBillingSystem.RoundedPanel panelInput;
        private saleAndBillingSystem.RoundedPanel panelCart;
        private System.Windows.Forms.Label lblTitle;
    }
}