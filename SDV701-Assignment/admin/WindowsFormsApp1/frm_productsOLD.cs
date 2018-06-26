using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_products : Form
    {
        private frm_editProduct _editProductForm = new frm_editProduct();

        private Dictionary<string, clsProduct> _products;
        private Dictionary<string, clsProductGroup> _productGroups;

        private clsProduct _selectedProduct;
        private clsProductGroup _selectedProductGroup;
        private string _selectedProductGroupProductUID;

        public frm_products(){
            InitializeComponent();
        }

        private void frm_products_Load(object sender, EventArgs e) {
            //createTestData();
            getProducts();
            getProductGroups();
            updateDisplay();
        }

        //Get data
        public async void getProducts() {
            DatabaseResponse dbres = await DatabaseConnector.getDataAsync("/products");
            _products = JsonConvert.DeserializeObject<Dictionary<string, clsProduct>>(dbres.jsonData);
        }

        public async void getProductGroups() {
            DatabaseResponse dbres = await DatabaseConnector.getDataAsync("/productGroups");
            _productGroups = JsonConvert.DeserializeObject<Dictionary<string, clsProductGroup>>(dbres.jsonData);
        }

        //Set data
        public async void setProductInDB(clsProduct pProduct) {
            DatabaseResponse dbres = await DatabaseConnector.putDataAsync("/products", pProduct.UID, pProduct);
        }
        public async void setProductGroupInDB(clsProductGroup pProductGroup) {
            DatabaseResponse dbres = await DatabaseConnector.putDataAsync("/productGroups", pProductGroup.UID, pProductGroup);
        }

        //Delete data
        public async void deleteProductFromDB(clsProduct pProduct) {
            DatabaseResponse dbres = await DatabaseConnector.deleteDataAsync("/products", pProduct.UID, pProduct);
        }
        public async void deleteProductGroupFromDB(clsProductGroup pProductGroup) {
            DatabaseResponse dbres = await DatabaseConnector.deleteDataAsync("/productGroups", pProductGroup.UID, pProductGroup);
        }

        //Display data
        public void updateDisplay() {
            //Products
            dgv_products.DataSource = _products.Values.ToArray();
            //Product Groups
            dgv_productGroups.DataSource = _productGroups.Values.ToArray();
        }

        public void updateProductGroupProducts() {
            //Selected Product Group Products
            if (_selectedProductGroup != null) {
                dgv_productGroupProducts.DataSource = _selectedProductGroup.ProductUIDs.ToList().Select(x => new { Name = _products.ContainsKey(x) ? _products[x].Name : "deleted", Value = x, }).ToList();
            }
        }

        //Controls
        private void dgv_products_SelectionChanged(object sender, EventArgs e) {
            //Display the product prices in the product type data grid
            clsProduct copyOfSelectedProduct = (clsProduct)dgv_products.CurrentRow.DataBoundItem;
            if (_products.ContainsKey(copyOfSelectedProduct.UID)) {
                _selectedProduct = _products[copyOfSelectedProduct.UID];
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e) {
            if (_selectedProduct != null && _editProductForm.ShowDialog(_selectedProduct)) {
                _selectedProduct.UpdateLastModified();
                setProductInDB(_selectedProduct);
                updateDisplay();
            }
        }

        private void btn_newProduct_Click(object sender, EventArgs e) {
            clsProduct newProduct = new clsProduct();
            if (newProduct != null && _editProductForm.ShowDialog(newProduct)) {
                newProduct.UpdateLastModified();
                setProductInDB(newProduct);
                _products.Add(newProduct.UID, newProduct);
                updateDisplay();
            }
        }

        private void dgv_productGroups_SelectionChanged(object sender, EventArgs e) {
            clsProductGroup copyOfSelectedProductGroup = (clsProductGroup)dgv_productGroups.CurrentRow.DataBoundItem;
            if (_productGroups.ContainsKey(copyOfSelectedProductGroup.UID)) {
                _selectedProductGroup = _productGroups[copyOfSelectedProductGroup.UID];
                updateProductGroupProducts();
            }
        }

        private void btn_addToGroup_Click(object sender, EventArgs e) {
            if (_selectedProductGroup != null && !_selectedProductGroup.ProductUIDs.Contains(_selectedProduct.UID)) {
                _selectedProductGroup.ProductUIDs.Add(_selectedProduct.UID);
                setProductGroupInDB(_selectedProductGroup);
                updateProductGroupProducts();
            }
        }

        private void btn_removeFromGroup_Click(object sender, EventArgs e) {
            if(_selectedProductGroupProductUID != null) {
                _selectedProductGroup.ProductUIDs.Remove(_selectedProductGroupProductUID);
                setProductGroupInDB(_selectedProductGroup);
                updateProductGroupProducts();
            }
        }

        private void dgv_productGroupProducts_SelectionChanged(object sender, EventArgs e) {
            _selectedProductGroupProductUID = (string)dgv_productGroupProducts.CurrentRow.Cells[1].Value;
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e) {
            if(_selectedProduct != null) {
                _products.Remove(_selectedProduct.UID);
                deleteProductFromDB(_selectedProduct);
                updateDisplay();
            }
        }

        private void btn_newProductGroup_Click(object sender, EventArgs e) {
            if(txt_newGroupName.TextLength < 2) {
                MessageBox.Show("New Group Name should be atleast two characters long", "Invalid Input");
                return;
            }
            clsProductGroup newProductGroup = new clsProductGroup(txt_newGroupName.Text);
            _selectedProductGroup = newProductGroup;
            _productGroups.Add(newProductGroup.UID, newProductGroup);
            setProductGroupInDB(newProductGroup);
            updateDisplay();
        }

        private void btn_deleteProductGroup_Click(object sender, EventArgs e) {
            if(_selectedProductGroup != null) {
                _productGroups.Remove(_selectedProductGroup.UID);
                deleteProductGroupFromDB(_selectedProductGroup);
                updateDisplay();
            }
        }
    }
}
