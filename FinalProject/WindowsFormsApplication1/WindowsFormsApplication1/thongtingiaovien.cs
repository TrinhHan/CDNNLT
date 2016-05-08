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
    public partial class thongtingiaovien : Form
    {
        public thongtingiaovien()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void thongtingiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.finalProjectDataSet.GIAOVIEN);
            xulybutton(true);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MovePrevious();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mAGIAOVIENTextBox.Focus();
            this.gIAOVIENBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            xulybutton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mAGIAOVIENTextBox.Focus();
            xulybutton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
                qr.xoadangnhap_magiaovien(this.mAGIAOVIENTextBox.Text);
                qr.capnhatbanglop(this.mAGIAOVIENTextBox.Text);
                this.gIAOVIENBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(mAGIAOVIENTextBox.TextLength == 0)
                MessageBox.Show("Mã giáo viên không được để trống");
            else if (mAGIAOVIENTextBox.TextLength > 10)
                MessageBox.Show("Mã giáo viên không được quá 10 kí tự");
            else
                if (hOTextBox.TextLength == 0)
                    MessageBox.Show("Họ giáo viên không được để trống");
                else
                    if (tENTextBox.TextLength == 0)
                        MessageBox.Show(" Tên giáo viên không được để trống");
            else
                        try {
      
                                this.Validate();
                                this.gIAOVIENBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
                            }
                        catch
                        {
                            MessageBox.Show("Mã giáo viên " + mAGIAOVIENTextBox + " đã tồn tại");
                        }
            xulybutton(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.CancelEdit();
            xulybutton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveLast();

        }
        public void xulybutton(bool b)
        {
            this.bt_daudanhsach.Enabled = bt_phiasau.Enabled = bt_phiatruoc.Enabled = bt_cuoidanhsach.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = gr_thongtingiaovien.Enabled = !b;
        }
    }
}
