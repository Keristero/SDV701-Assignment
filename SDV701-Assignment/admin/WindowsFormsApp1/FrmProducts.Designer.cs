namespace SDV701AdminApplication
{
    partial class FrmProducts
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
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_newProduct = new System.Windows.Forms.Button();
            this.dgv_productGroups = new System.Windows.Forms.DataGridView();
            this.dgv_productGroupProducts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_removeFromGroup = new System.Windows.Forms.Button();
            this.btn_addToGroup = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.txt_newGroupName = new System.Windows.Forms.TextBox();
            this.lbl_newGroupName = new System.Windows.Forms.Label();
            this.btn_newProductGroup = new System.Windows.Forms.Button();
            this.btn_deleteProductGroup = new System.Windows.Forms.Button();
            this.box_products = new System.Windows.Forms.GroupBox();
            this.box_productGrouops = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productGroupProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_products.Location = new System.Drawing.Point(32, 102);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 20;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(319, 434);
            this.dgv_products.TabIndex = 0;
            this.dgv_products.VirtualMode = true;
            this.dgv_products.SelectionChanged += new System.EventHandler(this.dgv_products_SelectionChanged);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(32, 65);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(84, 31);
            this.btn_editProduct.TabIndex = 13;
            this.btn_editProduct.Text = "Edit";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_newProduct
            // 
            this.btn_newProduct.Location = new System.Drawing.Point(122, 65);
            this.btn_newProduct.Name = "btn_newProduct";
            this.btn_newProduct.Size = new System.Drawing.Size(87, 31);
            this.btn_newProduct.TabIndex = 14;
            this.btn_newProduct.Text = "New";
            this.btn_newProduct.UseVisualStyleBackColor = true;
            this.btn_newProduct.Click += new System.EventHandler(this.btn_newProduct_Click);
            // 
            // dgv_productGroups
            // 
            this.dgv_productGroups.AllowUserToAddRows = false;
            this.dgv_productGroups.AllowUserToDeleteRows = false;
            this.dgv_productGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productGroups.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_productGroups.Location = new System.Drawing.Point(394, 102);
            this.dgv_productGroups.MultiSelect = false;
            this.dgv_productGroups.Name = "dgv_productGroups";
            this.dgv_productGroups.ReadOnly = true;
            this.dgv_productGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productGroups.Size = new System.Drawing.Size(150, 434);
            this.dgv_productGroups.TabIndex = 15;
            this.dgv_productGroups.VirtualMode = true;
            this.dgv_productGroups.SelectionChanged += new System.EventHandler(this.dgv_productGroups_SelectionChanged);
            // 
            // dgv_productGroupProducts
            // 
            this.dgv_productGroupProducts.AllowUserToAddRows = false;
            this.dgv_productGroupProducts.AllowUserToDeleteRows = false;
            this.dgv_productGroupProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productGroupProducts.Location = new System.Drawing.Point(550, 102);
            this.dgv_productGroupProducts.Name = "dgv_productGroupProducts";
            this.dgv_productGroupProducts.ReadOnly = true;
            this.dgv_productGroupProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productGroupProducts.Size = new System.Drawing.Size(190, 434);
            this.dgv_productGroupProducts.TabIndex = 16;
            this.dgv_productGroupProducts.VirtualMode = true;
            this.dgv_productGroupProducts.SelectionChanged += new System.EventHandler(this.dgv_productGroupProducts_SelectionChanged);
            // 
            // btn_removeFromGroup
            // 
            this.btn_removeFromGroup.Location = new System.Drawing.Point(646, 65);
            this.btn_removeFromGroup.Name = "btn_removeFromGroup";
            this.btn_removeFromGroup.Size = new System.Drawing.Size(94, 31);
            this.btn_removeFromGroup.TabIndex = 17;
            this.btn_removeFromGroup.Text = "Remove";
            this.btn_removeFromGroup.UseVisualStyleBackColor = true;
            this.btn_removeFromGroup.Click += new System.EventHandler(this.btn_removeFromGroup_Click);
            // 
            // btn_addToGroup
            // 
            this.btn_addToGroup.Location = new System.Drawing.Point(550, 65);
            this.btn_addToGroup.Name = "btn_addToGroup";
            this.btn_addToGroup.Size = new System.Drawing.Size(90, 31);
            this.btn_addToGroup.TabIndex = 18;
            this.btn_addToGroup.Text = "Add";
            this.btn_addToGroup.UseVisualStyleBackColor = true;
            this.btn_addToGroup.Click += new System.EventHandler(this.btn_addToGroup_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(215, 65);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(136, 31);
            this.btn_deleteProduct.TabIndex = 19;
            this.btn_deleteProduct.Text = "Delete";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // txt_newGroupName
            // 
            this.txt_newGroupName.Location = new System.Drawing.Point(394, 39);
            this.txt_newGroupName.Name = "txt_newGroupName";
            this.txt_newGroupName.Size = new System.Drawing.Size(100, 20);
            this.txt_newGroupName.TabIndex = 20;
            // 
            // lbl_newGroupName
            // 
            this.lbl_newGroupName.AutoSize = true;
            this.lbl_newGroupName.Location = new System.Drawing.Point(500, 42);
            this.lbl_newGroupName.Name = "lbl_newGroupName";
            this.lbl_newGroupName.Size = new System.Drawing.Size(92, 13);
            this.lbl_newGroupName.TabIndex = 21;
            this.lbl_newGroupName.Text = "New Group Name";
            // 
            // btn_newProductGroup
            // 
            this.btn_newProductGroup.Location = new System.Drawing.Point(394, 65);
            this.btn_newProductGroup.Name = "btn_newProductGroup";
            this.btn_newProductGroup.Size = new System.Drawing.Size(75, 31);
            this.btn_newProductGroup.TabIndex = 22;
            this.btn_newProductGroup.Text = "New";
            this.btn_newProductGroup.UseVisualStyleBackColor = true;
            this.btn_newProductGroup.Click += new System.EventHandler(this.btn_newProductGroup_Click);
            // 
            // btn_deleteProductGroup
            // 
            this.btn_deleteProductGroup.Location = new System.Drawing.Point(475, 65);
            this.btn_deleteProductGroup.Name = "btn_deleteProductGroup";
            this.btn_deleteProductGroup.Size = new System.Drawing.Size(69, 31);
            this.btn_deleteProductGroup.TabIndex = 23;
            this.btn_deleteProductGroup.Text = "Delete";
            this.btn_deleteProductGroup.UseVisualStyleBackColor = true;
            this.btn_deleteProductGroup.Click += new System.EventHandler(this.btn_deleteProductGroup_Click);
            // 
            // box_products
            // 
            this.box_products.Location = new System.Drawing.Point(21, 12);
            this.box_products.Name = "box_products";
            this.box_products.Size = new System.Drawing.Size(342, 535);
            this.box_products.TabIndex = 24;
            this.box_products.TabStop = false;
            this.box_products.Text = "Products";
            // 
            // box_productGrouops
            // 
            this.box_productGrouops.Location = new System.Drawing.Point(382, 12);
            this.box_productGrouops.Name = "box_productGrouops";
            this.box_productGrouops.Size = new System.Drawing.Size(369, 535);
            this.box_productGrouops.TabIndex = 25;
            this.box_productGrouops.TabStop = false;
            this.box_productGrouops.Text = "Product Groups";
            // 
            // frm_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.btn_deleteProductGroup);
            this.Controls.Add(this.btn_newProductGroup);
            this.Controls.Add(this.lbl_newGroupName);
            this.Controls.Add(this.txt_newGroupName);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_addToGroup);
            this.Controls.Add(this.btn_removeFromGroup);
            this.Controls.Add(this.dgv_productGroupProducts);
            this.Controls.Add(this.dgv_productGroups);
            this.Controls.Add(this.btn_newProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.box_products);
            this.Controls.Add(this.box_productGrouops);
            this.Name = "frm_products";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.frm_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productGroupProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_newProduct;
        private System.Windows.Forms.DataGridView dgv_productGroups;
        private System.Windows.Forms.DataGridView dgv_productGroupProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_removeFromGroup;
        private System.Windows.Forms.Button btn_addToGroup;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.TextBox txt_newGroupName;
        private System.Windows.Forms.Label lbl_newGroupName;
        private System.Windows.Forms.Button btn_newProductGroup;
        private System.Windows.Forms.Button btn_deleteProductGroup;
        private System.Windows.Forms.GroupBox box_products;
        private System.Windows.Forms.GroupBox box_productGrouops;
    }
}