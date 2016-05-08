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
    public partial class lop : Form
    {
        public lop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.finalProjectDataSet.LOP);
            xulybutton(true);

        }
        // button HUY
        private void button3_Click(object sender, EventArgs e)
        {
            this.lOPBindingSource.CancelEdit();
            xulybutton(true);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mALOPTextBox.Focus();
            this.lOPBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            xulybutton(false);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
               
                this.lOPBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mALOPTextBox.Focus();
            xulybutton(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
            if (mALOPTextBox.Text.Length == 0)
                    MessageBox.Show("Mã lớp không được để trống");
            else
                if (mAKHOITextBox.Text.Length == 0)
                    MessageBox.Show("Mã khối không được để trống");
            else
                if (tENLOPTextBox.TextLength == 0)
                    MessageBox.Show("Tên lớp không được để trống");
            else
                if (hOCKYTextBox.Text.Length == 0)
                    MessageBox.Show("Học kỳ không được để trống");
            else
                if (nAMHOCTextBox.Text.Length == 0)
                    MessageBox.Show("Năm học không được để trống");
            else
                if (qr.checkmalop(this.mALOPTextBox.Text) == 0)
                    MessageBox.Show("Mã lớp không tồn tại, bạn có thể thêm vào trong bảng lớp học");
            else
                if (qr.checkmakhoi(this.mAKHOITextBox.Text) == 0)
                    MessageBox.Show("Mã khối không tồn tại, bạn có thể thêm vào trong bảng lớp học");
            else
                if (qr.checkhockynamhoc(this.hOCKYTextBox.Text, this.nAMHOCTextBox.Text) == 0)
                    MessageBox.Show("Học kỳ và năm học không tồn tại, bạn có thể thêm vào trong bảng lớp học");
            else
                    try
                        {
                            this.Validate();
                            this.lOPBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
                       }
                    catch
                        {
                            MessageBox.Show("Mã lớp " + mALOPTextBox + " đã tồn tại");
                        }
            xulybutton(true);
            
        }

        private void lOPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void xulybutton(bool b)
        {
            this.btnThem.Enabled = btnSua.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = gr_thongtinlop.Enabled = !b;
        }
    }
}
