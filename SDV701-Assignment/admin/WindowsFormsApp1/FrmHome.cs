using System;
using System.Windows.Forms;

namespace SDV701AdminApplication
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private async void frm_home_Load(object sender, EventArgs e) {
            SetControl(false);
            await ClsDataManager.GetAllData();
            SetControl(true);
            lbl_dbConnection.Text = "Retreived all data from Database";
        }


        private void SetControl(bool enable) {
            foreach (Control c in this.Controls) {
                Console.WriteLine(c.Name);
                c.Enabled = enable;
            }
        }

        private void lbl_dbConnection_Click(object sender, EventArgs e)
        {

        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            FrmProducts productsForm = new FrmProducts();
            productsForm.Show();
        }

        private void btn_salesHistory_Click(object sender, EventArgs e)
        {
            FrmSales salesForm = new FrmSales();
            salesForm.Show();
        }

        private void btn_notices_Click(object sender, EventArgs e)
        {
            FrmNotices noticeForm = new FrmNotices();
            noticeForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
