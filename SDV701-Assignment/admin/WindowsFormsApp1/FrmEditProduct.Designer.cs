namespace SDV701AdminApplication {
    partial class FrmEditProduct {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dgv_prices = new System.Windows.Forms.DataGridView();
            this.chk_inStock = new System.Windows.Forms.CheckBox();
            this.btn_addPrice = new System.Windows.Forms.Button();
            this.txt_priceType = new System.Windows.Forms.TextBox();
            this.txt_priceAmount = new System.Windows.Forms.TextBox();
            this.lbl_priceType = new System.Windows.Forms.Label();
            this.lbl_priceAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deletePrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(30, 33);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(132, 20);
            this.txt_productName.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(168, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(177, 345);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 25);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dgv_prices
            // 
            this.dgv_prices.AllowUserToAddRows = false;
            this.dgv_prices.AllowUserToDeleteRows = false;
            this.dgv_prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prices.Location = new System.Drawing.Point(15, 208);
            this.dgv_prices.Name = "dgv_prices";
            this.dgv_prices.ReadOnly = true;
            this.dgv_prices.Size = new System.Drawing.Size(256, 126);
            this.dgv_prices.TabIndex = 4;
            this.dgv_prices.SelectionChanged += new System.EventHandler(this.dgv_prices_SelectionChanged);
            // 
            // chk_inStock
            // 
            this.chk_inStock.AutoSize = true;
            this.chk_inStock.Location = new System.Drawing.Point(30, 59);
            this.chk_inStock.Name = "chk_inStock";
            this.chk_inStock.Size = new System.Drawing.Size(66, 17);
            this.chk_inStock.TabIndex = 6;
            this.chk_inStock.Text = "In Stock";
            this.chk_inStock.UseVisualStyleBackColor = true;
            // 
            // btn_addPrice
            // 
            this.btn_addPrice.Location = new System.Drawing.Point(15, 84);
            this.btn_addPrice.Name = "btn_addPrice";
            this.btn_addPrice.Size = new System.Drawing.Size(75, 23);
            this.btn_addPrice.TabIndex = 8;
            this.btn_addPrice.Text = "Add Price";
            this.btn_addPrice.UseVisualStyleBackColor = true;
            this.btn_addPrice.Click += new System.EventHandler(this.btn_addPrice_Click);
            // 
            // txt_priceType
            // 
            this.txt_priceType.Location = new System.Drawing.Point(15, 22);
            this.txt_priceType.Name = "txt_priceType";
            this.txt_priceType.Size = new System.Drawing.Size(100, 20);
            this.txt_priceType.TabIndex = 9;
            // 
            // txt_priceAmount
            // 
            this.txt_priceAmount.Location = new System.Drawing.Point(15, 48);
            this.txt_priceAmount.Name = "txt_priceAmount";
            this.txt_priceAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_priceAmount.TabIndex = 10;
            // 
            // lbl_priceType
            // 
            this.lbl_priceType.AutoSize = true;
            this.lbl_priceType.Location = new System.Drawing.Point(121, 22);
            this.lbl_priceType.Name = "lbl_priceType";
            this.lbl_priceType.Size = new System.Drawing.Size(58, 13);
            this.lbl_priceType.TabIndex = 11;
            this.lbl_priceType.Text = "Price Type";
            // 
            // lbl_priceAmount
            // 
            this.lbl_priceAmount.AutoSize = true;
            this.lbl_priceAmount.Location = new System.Drawing.Point(121, 48);
            this.lbl_priceAmount.Name = "lbl_priceAmount";
            this.lbl_priceAmount.Size = new System.Drawing.Size(70, 13);
            this.lbl_priceAmount.TabIndex = 12;
            this.lbl_priceAmount.Text = "Price Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deletePrice);
            this.groupBox1.Controls.Add(this.btn_addPrice);
            this.groupBox1.Controls.Add(this.txt_priceAmount);
            this.groupBox1.Controls.Add(this.lbl_priceAmount);
            this.groupBox1.Controls.Add(this.txt_priceType);
            this.groupBox1.Controls.Add(this.lbl_priceType);
            this.groupBox1.Location = new System.Drawing.Point(15, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // btn_deletePrice
            // 
            this.btn_deletePrice.Location = new System.Drawing.Point(102, 84);
            this.btn_deletePrice.Name = "btn_deletePrice";
            this.btn_deletePrice.Size = new System.Drawing.Size(134, 23);
            this.btn_deletePrice.TabIndex = 13;
            this.btn_deletePrice.Text = "Delete Selected Price";
            this.btn_deletePrice.UseVisualStyleBackColor = true;
            this.btn_deletePrice.Click += new System.EventHandler(this.btn_deletePrice_Click);
            // 
            // frm_editProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 379);
            this.Controls.Add(this.chk_inStock);
            this.Controls.Add(this.dgv_prices);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_editProduct";
            this.Text = "frm_editProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv_prices;
        private System.Windows.Forms.CheckBox chk_inStock;
        private System.Windows.Forms.Button btn_addPrice;
        private System.Windows.Forms.TextBox txt_priceType;
        private System.Windows.Forms.TextBox txt_priceAmount;
        private System.Windows.Forms.Label lbl_priceType;
        private System.Windows.Forms.Label lbl_priceAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deletePrice;
    }
}