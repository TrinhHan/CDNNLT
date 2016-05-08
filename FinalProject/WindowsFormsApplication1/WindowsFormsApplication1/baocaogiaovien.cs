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
    public partial class baocaogiaovien : Form
    {
        public baocaogiaovien()
        {
            InitializeComponent();
        }

        private void baocaogiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProjectDataSet.baocaogiaovien' table. You can move, or remove it, as needed.
            
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            this.baocaogiaovienTableAdapter.Fill(this.FinalProjectDataSet.baocaogiaovien,this.text_makhoi.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
