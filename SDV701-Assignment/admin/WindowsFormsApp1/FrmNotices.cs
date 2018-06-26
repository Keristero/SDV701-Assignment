using System;
using System.Linq;
using System.Windows.Forms;

namespace SDV701AdminApplication
{
    public partial class FrmNotices : Form
    {
        private ClsNotice _selectedNotice;

        public FrmNotices()
        {
            InitializeComponent();
        }

        private void frm_notices_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        //Display data
        public void updateDisplay() {
            //Notices
            dgv_notices.DataSource = ClsDataManager.Notices.Values.ToArray();
        }

        //Controls
        private void btn_save_Click(object sender, EventArgs e) {
            ClsNotice newNotice = new ClsNotice(txt_noticeText.Text);
            ClsDataManager.SetNotice(newNotice);
            updateDisplay();
        }

        private void btn_delete_Click(object sender, EventArgs e) {
            if (_selectedNotice != null) {
                ClsDataManager.DeleteNotice(_selectedNotice);
                updateDisplay();
            }
        }

        private void dgv_notices_SelectionChanged(object sender, EventArgs e) {
            ClsNotice copyOfSelectedNotice = (ClsNotice)dgv_notices.CurrentRow.DataBoundItem;
            if (ClsDataManager.Notices.ContainsKey(copyOfSelectedNotice.UID)) {
                _selectedNotice = ClsDataManager.Notices[copyOfSelectedNotice.UID];
            }
        }
    }
}
