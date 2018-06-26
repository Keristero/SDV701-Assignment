namespace SDV701AdminApplication
{
    partial class FrmHome
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
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_salesHistory = new System.Windows.Forms.Button();
            this.btn_notices = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_dbConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(45, 74);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(148, 35);
            this.btn_products.TabIndex = 0;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_salesHistory
            // 
            this.btn_salesHistory.Location = new System.Drawing.Point(45, 125);
            this.btn_salesHistory.Name = "btn_salesHistory";
            this.btn_salesHistory.Size = new System.Drawing.Size(148, 35);
            this.btn_salesHistory.TabIndex = 1;
            this.btn_salesHistory.Text = "Sales History";
            this.btn_salesHistory.UseVisualStyleBackColor = true;
            this.btn_salesHistory.Click += new System.EventHandler(this.btn_salesHistory_Click);
            // 
            // btn_notices
            // 
            this.btn_notices.Location = new System.Drawing.Point(45, 177);
            this.btn_notices.Name = "btn_notices";
            this.btn_notices.Size = new System.Drawing.Size(148, 35);
            this.btn_notices.TabIndex = 2;
            this.btn_notices.Text = "Notices";
            this.btn_notices.UseVisualStyleBackColor = true;
            this.btn_notices.Click += new System.EventHandler(this.btn_notices_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(45, 286);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(148, 35);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_dbConnection
            // 
            this.lbl_dbConnection.Location = new System.Drawing.Point(12, 35);
            this.lbl_dbConnection.Name = "lbl_dbConnection";
            this.lbl_dbConnection.Size = new System.Drawing.Size(216, 14);
            this.lbl_dbConnection.TabIndex = 4;
            this.lbl_dbConnection.Text = "Retrieving data...";
            this.lbl_dbConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 345);
            this.Controls.Add(this.lbl_dbConnection);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_notices);
            this.Controls.Add(this.btn_salesHistory);
            this.Controls.Add(this.btn_products);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_salesHistory;
        private System.Windows.Forms.Button btn_notices;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_dbConnection;
    }
}

