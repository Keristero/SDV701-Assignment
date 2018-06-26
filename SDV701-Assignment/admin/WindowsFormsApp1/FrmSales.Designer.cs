namespace SDV701AdminApplication
{
    partial class FrmSales
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
            this.lbl_dailyTotals = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.dgv_sold = new System.Windows.Forms.DataGridView();
            this.lbl_sold = new System.Windows.Forms.Label();
            this.btn_deleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dailyTotals
            // 
            this.lbl_dailyTotals.AutoSize = true;
            this.lbl_dailyTotals.Location = new System.Drawing.Point(12, 9);
            this.lbl_dailyTotals.Name = "lbl_dailyTotals";
            this.lbl_dailyTotals.Size = new System.Drawing.Size(175, 13);
            this.lbl_dailyTotals.TabIndex = 1;
            this.lbl_dailyTotals.Text = "Number of sales: 3, Income: $45.50";
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.Location = new System.Drawing.Point(9, 33);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(33, 13);
            this.lbl_sales.TabIndex = 3;
            this.lbl_sales.Text = "Sales";
            // 
            // dgv_sales
            // 
            this.dgv_sales.AllowUserToAddRows = false;
            this.dgv_sales.AllowUserToDeleteRows = false;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_sales.Location = new System.Drawing.Point(9, 52);
            this.dgv_sales.MultiSelect = false;
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 20;
            this.dgv_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sales.Size = new System.Drawing.Size(249, 370);
            this.dgv_sales.TabIndex = 4;
            this.dgv_sales.SelectionChanged += new System.EventHandler(this.dgv_sales_SelectionChanged);
            // 
            // dgv_sold
            // 
            this.dgv_sold.AllowUserToAddRows = false;
            this.dgv_sold.AllowUserToDeleteRows = false;
            this.dgv_sold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sold.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_sold.Location = new System.Drawing.Point(264, 52);
            this.dgv_sold.Name = "dgv_sold";
            this.dgv_sold.RowHeadersWidth = 20;
            this.dgv_sold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sold.Size = new System.Drawing.Size(425, 370);
            this.dgv_sold.TabIndex = 5;
            // 
            // lbl_sold
            // 
            this.lbl_sold.AutoSize = true;
            this.lbl_sold.Location = new System.Drawing.Point(264, 33);
            this.lbl_sold.Name = "lbl_sold";
            this.lbl_sold.Size = new System.Drawing.Size(73, 13);
            this.lbl_sold.TabIndex = 6;
            this.lbl_sold.Text = "Products Sold";
            // 
            // btn_deleteSale
            // 
            this.btn_deleteSale.Location = new System.Drawing.Point(9, 428);
            this.btn_deleteSale.Name = "btn_deleteSale";
            this.btn_deleteSale.Size = new System.Drawing.Size(249, 20);
            this.btn_deleteSale.TabIndex = 9;
            this.btn_deleteSale.Text = "Delete Selected Sale";
            this.btn_deleteSale.UseVisualStyleBackColor = true;
            this.btn_deleteSale.Click += new System.EventHandler(this.btn_deleteSale_Click);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 455);
            this.Controls.Add(this.btn_deleteSale);
            this.Controls.Add(this.lbl_sold);
            this.Controls.Add(this.dgv_sold);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.lbl_dailyTotals);
            this.Name = "FrmSales";
            this.Text = "frm_sales";
            this.Load += new System.EventHandler(this.frm_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_dailyTotals;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.DataGridView dgv_sold;
        private System.Windows.Forms.Label lbl_sold;
        private System.Windows.Forms.Button btn_deleteSale;
    }
}