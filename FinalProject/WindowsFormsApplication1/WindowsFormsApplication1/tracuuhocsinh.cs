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
    public partial class tracuuhocsinh : Form
    {
        public tracuuhocsinh()
        {
            InitializeComponent();
        }

        private void tracuuhocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProjectDataSet.tracuuhocsinh' table. You can move, or remove it, as needed.
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.tracuuhocsinhTableAdapter.Fill(this.FinalProjectDataSet.tracuuhocsinh,this.text_mahs.Text,this.text_hohs.Text,this.text_tenhs.Text,this.text_makhoihs.Text,this.text_tenlophs.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
