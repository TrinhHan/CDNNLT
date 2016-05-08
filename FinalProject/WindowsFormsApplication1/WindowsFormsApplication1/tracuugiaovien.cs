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
    public partial class tracuugiaovien : Form
    {
        public tracuugiaovien()
        {
            InitializeComponent();
        }

        private void tracuugiaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProjectDataSet.tracuugiaovien' table. You can move, or remove it, as needed.
            //this.text_magiaovien.Text = "null";
            //this.text_ho.Text = "null";
            //this.text_ten.Text = "null";
            //this.text_tenbomon.Text = "null";
            //this.text_tenlop.Text = "null";
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            this.tracuugiaovienTableAdapter.Fill(this.FinalProjectDataSet.tracuugiaovien,this.text_magiaovien.Text,this.text_ho.Text,this.text_ten.Text,this.text_tenlop.Text,this.text_tenbomon.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
