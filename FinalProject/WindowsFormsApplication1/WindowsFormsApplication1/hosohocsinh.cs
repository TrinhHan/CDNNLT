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
    public partial class hosohocsinh : Form
    {
        public hosohocsinh()
        {
            InitializeComponent();
        }

        private void hOCSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCSINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void hosohocsinhcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.finalProjectDataSet.HOCSINH);
            xulybutton(true);

        }

        private void hOTENMELabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mAHOCSINHTextBox.Focus();
            this.hOCSINHBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            xulybutton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mAHOCSINHTextBox.Focus();
            xulybutton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
                qr.xoaxeploai_mahocsinh(this.mAHOCSINHTextBox.Text);
                qr.xoadiem_mahocsinh(this.mAHOCSINHTextBox.Text);
                this.hOCSINHBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
            if (mAHOCSINHTextBox.TextLength == 0)
                MessageBox.Show("Mã học sinh không được để trống");
            else if (mAHOCSINHTextBox.TextLength > 10)
                MessageBox.Show("Mã học sinh không được quá 10 kí tự");
            else
                if (hOTextBox.TextLength == 0)
                    MessageBox.Show("Họ học sinh không được để trống");
                else
                    if (tENTextBox.TextLength == 0)
                        MessageBox.Show(" Tên học sinh không được để trống");
                    else
                        if (qr.checkmalop(this.mALOPTextBox.Text) == 0)
                            MessageBox.Show("Mã lớp không tồn tại, bạn có thể thêm vào trong mục quản lý lớp học");
            else
                        try
                        {
                            this.Validate();
                            this.hOCSINHBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
                        }
                        catch
                        {
                            MessageBox.Show("Mã học sinh " + mAHOCSINHTextBox + " đã tồn tại");
            
                      }
            xulybutton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.hOCSINHBindingSource.CancelEdit();
            xulybutton(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.hOCSINHBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hOCSINHBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.hOCSINHBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hOCSINHBindingSource.MoveLast();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void xulybutton(bool b)
        {
            this.bt_daudanhsach.Enabled = bt_phiasau.Enabled = bt_phiatruoc.Enabled = bt_cuoidanhsach.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = gr_thongtinhocsinh.Enabled = !b;
        }
    }
}
