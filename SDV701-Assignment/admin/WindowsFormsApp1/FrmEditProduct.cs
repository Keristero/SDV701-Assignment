using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SDV701AdminApplication {
    public partial class FrmEditProduct : Form {

        private ClsProduct _product;
        private string _selectedPriceUID;

        public FrmEditProduct() {
            InitializeComponent();
        }

        public bool ShowDialog(ClsProduct pProduct) {
            _product = pProduct;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay() {
            //Refresh displayed information
            txt_productName.Text = _product.Name;
            chk_inStock.Checked = _product.InStock;
            txt_priceType.Text = "";
            txt_priceAmount.Text = "";

            dgv_prices.DataSource = _product.Prices.ToList().Select(x => new { priceType = x.Value.priceType, priceAmount = x.Value.priceAmount, UID = x.Value.UID, }).ToList();
        }

        private bool ValidateTxtBoxLength(TextBox txt, int length, string title) {
            if(txt.TextLength < length) {
                MessageBox.Show(title+" should be atleast two characters long", "Invalid Input");
                return false;
            }
            return true;
        }

        private bool SaveDetails() {
            //Performs input validation and saves variables to product object
            if (ValidateTxtBoxLength(txt_productName, 2, "Product Name")) {
                _product.Name = txt_productName.Text;
            } else {
                return false;
            }

            //Check if a product with the same name already exists
            foreach(ClsProduct product in ClsDataManager.Products.Values) {
                if(product.Name.ToLower() == _product.Name.ToLower()) {
                    var confirmResult = MessageBox.Show("A product with this name already exists, are you sure you want to use this name?", "Confirm Name", MessageBoxButtons.YesNo);
                    if (confirmResult != DialogResult.Yes ) {
                        return false;
                    }
                }
            }

            _product.InStock = chk_inStock.Checked;

            return true;
        }

        private bool AddPrice(ClsPrice price) {
            if (SaveDetails() && ValidateTxtBoxLength(txt_priceType, 2, "Price Type")) {
                price.priceType = txt_priceType.Text;
            } else {
                return false;
            }
            if (!Double.TryParse(txt_priceAmount.Text, out price.priceAmount)) {
                return false;
            }
            return true;
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            if (SaveDetails()) {
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_addPrice_Click(object sender, EventArgs e) {
            ClsPrice newPrice = new ClsPrice();
            if (AddPrice(newPrice)) {
                _product.Prices.Add(newPrice.UID, newPrice);
                UpdateDisplay();
            }
        }

        private void btn_deletePrice_Click(object sender, EventArgs e) {
            if(_selectedPriceUID != null) {
                _product.Prices.Remove(_selectedPriceUID);
                UpdateDisplay();
            }
        }

        private void dgv_prices_SelectionChanged(object sender, EventArgs e) {
            _selectedPriceUID = (string)dgv_prices.CurrentRow.Cells[2].Value;
        }
    }
}
