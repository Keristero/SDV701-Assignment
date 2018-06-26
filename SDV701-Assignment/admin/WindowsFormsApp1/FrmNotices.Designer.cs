namespace SDV701AdminApplication
{
    partial class FrmNotices
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
            this.dgv_notices = new System.Windows.Forms.DataGridView();
            this.txt_noticeText = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_notices
            // 
            this.dgv_notices.AllowUserToAddRows = false;
            this.dgv_notices.AllowUserToDeleteRows = false;
            this.dgv_notices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notices.Location = new System.Drawing.Point(12, 12);
            this.dgv_notices.Name = "dgv_notices";
            this.dgv_notices.RowHeadersWidth = 20;
            this.dgv_notices.Size = new System.Drawing.Size(599, 215);
            this.dgv_notices.TabIndex = 0;
            this.dgv_notices.SelectionChanged += new System.EventHandler(this.dgv_notices_SelectionChanged);
            // 
            // txt_noticeText
            // 
            this.txt_noticeText.Location = new System.Drawing.Point(12, 270);
            this.txt_noticeText.Name = "txt_noticeText";
            this.txt_noticeText.Size = new System.Drawing.Size(501, 168);
            this.txt_noticeText.TabIndex = 1;
            this.txt_noticeText.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 233);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 31);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Add New";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(110, 233);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 31);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_notices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_noticeText);
            this.Controls.Add(this.dgv_notices);
            this.Name = "frm_notices";
            this.Text = "frm_notices";
            this.Load += new System.EventHandler(this.frm_notices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_notices;
        private System.Windows.Forms.RichTextBox txt_noticeText;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
    }
}