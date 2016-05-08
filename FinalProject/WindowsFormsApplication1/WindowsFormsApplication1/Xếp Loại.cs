using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Xếp_Loại : Form
    {
        public Xếp_Loại()
        {
            InitializeComponent();
        }

        private void xEPLOAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xEPLOAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void Xếp_Loại_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.XEPLOAI' table. You can move, or remove it, as needed.
            this.xEPLOAITableAdapter.Fill(this.finalProjectDataSet.XEPLOAI);
            xulybutton(true);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mAHOCSINHTextBox.Focus();
            xulybutton(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mAHOCSINHTextBox.Focus();
            this.xEPLOAIBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            xulybutton(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
            if (mAHOCSINHTextBox.TextLength == 0)
                MessageBox.Show("Mã học sinh không được để trống");
            else
                if (hOCLUCTextBox.Text.Length == 0)
                    MessageBox.Show("Học lực không được để trống");
                else
                    if (hANHKIEMTextBox.Text.Length == 0)
                        MessageBox.Show("Hạnh kiểm không được để trống");

                    else
                        if (qr.check1hocsinh(this.mAHOCSINHTextBox.Text) == 0)
                            MessageBox.Show("Mã học sinh không tồn tại, bạn có thể thêm vào bảng xếp loại học sinh");
                        else
                            if (qr.checkxeploai_hs(this.mAHOCSINHTextBox.Text) >= 1)
                                MessageBox.Show("Mã học sinh đã tồn tại!");

                            else
                            {
                                this.Validate();
                                this.xEPLOAIBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
                            }

            xulybutton(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.xEPLOAIBindingSource.CancelEdit();
            xulybutton(true);
        }

        private void hOCLUCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void xulybutton(bool b)
        {
            this.btnThem.Enabled = btnSua.Enabled =b;
            btnLuu.Enabled = btnHuy.Enabled = gr_thongtinhocsinh.Enabled =!b;
        }
    }
}
