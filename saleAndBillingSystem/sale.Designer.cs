namespace saleAndBillingSystem
{
    partial class sale
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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dgvSaleDetails = new System.Windows.Forms.DataGridView();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeight = 29;
            this.dgvSales.Location = new System.Drawing.Point(19, 73);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(617, 214);
            this.dgvSales.TabIndex = 0;
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Location = new System.Drawing.Point(19, 360);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSaleDetails.RowHeadersWidth = 51;
            this.dgvSaleDetails.RowTemplate.Height = 24;
            this.dgvSaleDetails.Size = new System.Drawing.Size(713, 264);
            this.dgvSaleDetails.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Poppins", 12F);
            this.dtFrom.Location = new System.Drawing.Point(699, 112);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(388, 37);
            this.dtFrom.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFilter.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(968, 288);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 42);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblTotalSales.Location = new System.Drawing.Point(764, 535);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(28, 36);
            this.lblTotalSales.TabIndex = 4;
            this.lblTotalSales.Text = "0";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Poppins", 12F);
            this.dtTo.Location = new System.Drawing.Point(699, 224);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(388, 37);
            this.dtTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(699, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(699, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choese Day For Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(699, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sale ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sale Detail :";
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::saleAndBillingSystem.Properties.Resources.selling_bg;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dgvSaleDetails);
            this.Controls.Add(this.dgvSales);
            this.Name = "sale";
            this.Size = new System.Drawing.Size(1132, 653);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
