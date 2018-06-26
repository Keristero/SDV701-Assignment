using System;
using System.Linq;
using System.Windows.Forms;

namespace SDV701AdminApplication
{
    public partial class FrmSales : Form
    {
        private ClsSale _selectedSale;

        public FrmSales()
        {
            InitializeComponent();
        }

        private void frm_sales_Load(object sender, EventArgs e) {
            updateDisplay();
        }

        private double sumDisplayedSales() {
            double total = 0;
            foreach(DataGridViewRow dgvr in dgv_sales.Rows) {
                ClsSale sale = (ClsSale)dgvr.DataBoundItem;
                total += sale.Total;
            }
            return total;
        }

        //Display data
        public void updateDisplay() {
            //Products
            dgv_sales.DataSource = ClsDataManager.Sales.Values.ToArray();
            //Product Groups
            updateSoldDisplay();
            //Calculate totals
            lbl_dailyTotals.Text = "Total of displayed sales $"+sumDisplayedSales().ToString();
        }

        public void updateSoldDisplay() {
            dgv_sold.DataSource = _selectedSale.Sold.Values.ToArray();
        }

        //Controls
        private void dgv_sales_SelectionChanged(object sender, EventArgs e) {
            ClsSale copyOfSale = (ClsSale)dgv_sales.CurrentRow.DataBoundItem;
            if (ClsDataManager.Sales.ContainsKey(copyOfSale.UID)) {
                _selectedSale = ClsDataManager.Sales[copyOfSale.UID];
                updateSoldDisplay();
            }
        }

        private void btn_deleteSale_Click(object sender, EventArgs e) {
            if(_selectedSale != null) {
                var confirmResult = MessageBox.Show("Delete selected Sale?","Confirm Deletion",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    ClsDataManager.DeleteSale(_selectedSale);
                    updateDisplay();
                }
            }
        }
    }
}
