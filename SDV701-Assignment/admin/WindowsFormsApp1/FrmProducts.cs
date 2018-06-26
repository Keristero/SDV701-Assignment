using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SDV701AdminApplication
{
    public partial class FrmProducts : Form
    {
        private FrmEditProduct _editProductForm = new FrmEditProduct();
        private ClsProduct _selectedProduct;
        private ClsProductGroup _selectedProductGroup;
        private string _selectedProductGroupProductUID;

        public FrmProducts(){
            InitializeComponent();
        }

        private void frm_products_Load(object sender, EventArgs e) {
            updateDisplay();
        }

        //Display data
        public void updateDisplay() {
            //Products
            dgv_products.DataSource = ClsDataManager.Products.Values.ToArray();
            //Product Groups
            dgv_productGroups.DataSource = ClsDataManager.ProductGroups.Values.ToArray();
            //Update product group products
            updateProductGroupProducts();
        }

        public void updateProductGroupProducts() {
            //Selected Product Group Products
            if (_selectedProductGroup != null) {
                dgv_productGroupProducts.DataSource = _selectedProductGroup.ProductUIDs.ToList().Select(x => new { Name = ClsDataManager.Products.ContainsKey(x) ? ClsDataManager.Products[x].Name : "deleted", Value = x }).ToList();
            }
        }

        //Controls
        private void dgv_products_SelectionChanged(object sender, EventArgs e) {
            //Display the product prices in the product type data grid
            ClsProduct copyOfSelectedProduct = (ClsProduct)dgv_products.CurrentRow.DataBoundItem;
            if (ClsDataManager.Products.ContainsKey(copyOfSelectedProduct.UID)) {
                _selectedProduct = ClsDataManager.Products[copyOfSelectedProduct.UID];
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e) {
            if (_selectedProduct != null && _editProductForm.ShowDialog(_selectedProduct)) {
                _selectedProduct.UpdateLastModified();
                ClsDataManager.SetProduct(_selectedProduct);
            }
        }

        private void btn_newProduct_Click(object sender, EventArgs e) {
            ClsProduct newProduct = new ClsProduct();
            if (newProduct != null && _editProductForm.ShowDialog(newProduct)) {
                newProduct.UpdateLastModified();
                ClsDataManager.SetProduct(newProduct);
                updateDisplay();
            }
        }

        private void dgv_productGroups_SelectionChanged(object sender, EventArgs e) {
            ClsProductGroup copyOfSelectedProductGroup = (ClsProductGroup)dgv_productGroups.CurrentRow.DataBoundItem;
            if (ClsDataManager.ProductGroups.ContainsKey(copyOfSelectedProductGroup.UID)) {
                _selectedProductGroup = ClsDataManager.ProductGroups[copyOfSelectedProductGroup.UID];
                updateProductGroupProducts();
            }
        }

        private void btn_addToGroup_Click(object sender, EventArgs e) {
            if (_selectedProductGroup != null && _selectedProduct != null && !_selectedProductGroup.ProductUIDs.Contains(_selectedProduct.UID)) {
                _selectedProductGroup.ProductUIDs.Add(_selectedProduct.UID);
                ClsDataManager.SetProductGroup(_selectedProductGroup);
                updateProductGroupProducts();
            }
        }

        private void btn_removeFromGroup_Click(object sender, EventArgs e) {
            if(_selectedProductGroup != null && _selectedProductGroupProductUID != null) {
                _selectedProductGroup.ProductUIDs.Remove(_selectedProductGroupProductUID);
                ClsDataManager.SetProductGroup(_selectedProductGroup);
                updateProductGroupProducts();
            }
        }

        private void dgv_productGroupProducts_SelectionChanged(object sender, EventArgs e) {
            _selectedProductGroupProductUID = (string)dgv_productGroupProducts.CurrentRow.Cells[1].Value;
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e) {
            if(_selectedProduct != null) {
                ClsDataManager.DeleteProduct(_selectedProduct);
                updateDisplay();
            }
        }

        private void btn_newProductGroup_Click(object sender, EventArgs e) {
            if(txt_newGroupName.TextLength < 2) {
                MessageBox.Show("New Group Name should be atleast two characters long", "Invalid Input");
                return;
            }
            ClsProductGroup newProductGroup = new ClsProductGroup(txt_newGroupName.Text);
            ClsDataManager.SetProductGroup(newProductGroup);
            _selectedProductGroup = newProductGroup;
            updateDisplay();
        }

        private void btn_deleteProductGroup_Click(object sender, EventArgs e) {
            if(_selectedProductGroup != null) {
                ClsDataManager.DeleteProductGroup(_selectedProductGroup);
                updateDisplay();
            }
        }
    }
}
