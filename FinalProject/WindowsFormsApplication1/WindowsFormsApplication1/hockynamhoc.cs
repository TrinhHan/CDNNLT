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
    public partial class hockynamhoc : Form
    {
        public hockynamhoc()
        {
            InitializeComponent();
        }

        private void hOCKY_NAMHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCKY_NAMHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void hockynamhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.HOCKY_NAMHOC' table. You can move, or remove it, as needed.
            this.hOCKY_NAMHOCTableAdapter.Fill(this.finalProjectDataSet.HOCKY_NAMHOC);
            xulybutton(true);

        }

        private void hOCKYLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hOCKYTextBox.Focus();
            xulybutton(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FinalProjectDataSetTableAdapters.QueriesTableAdapter qr = new FinalProjectDataSetTableAdapters.QueriesTableAdapter();
            if(hOCKYTextBox.Text.Length == 0)
                MessageBox.Show("Học kỳ không được để trống");
            else 
                if(nAMHOCTextBox.Text.Length == 0)
                   MessageBox.Show(" Năm học không được để trống");
            else
                if (qr.checkhockynamhoc(this.hOCKYTextBox.Text, this.nAMHOCTextBox.Text) == 0)
                   MessageBox.Show("Học kỳ và năm học không tồn tại, bạn có thể thêm vào!");
            else
                  try
                        {
                            this.Validate();
                            this.hOCKY_NAMHOCBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
                      }
                 catch
                      {
                          MessageBox.Show("Mã lớp " + nAMHOCTextBox + " đã tồn tại");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            hOCKYTextBox.Focus();
            this.hOCKY_NAMHOCBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);
            xulybutton(false);

        }
        public void xulybutton(bool b)
        {
            this.btnThem.Enabled = btnSua.Enabled = b;
            btnLuu.Enabled = !b;
        }
    }
}
