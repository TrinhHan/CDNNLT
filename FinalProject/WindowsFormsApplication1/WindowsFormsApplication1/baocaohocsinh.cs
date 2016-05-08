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
    public partial class baocaohocsinh : Form
    {
        public baocaohocsinh()
        {
            InitializeComponent();
        }
        // button thoát

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baocaohocsinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FinalProjectDataSet.baocaohocsinh' table. You can move, or remove it, as needed.
            
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            this.baocaohocsinhTableAdapter.Fill(this.FinalProjectDataSet.baocaohocsinh,this.text_tenlop.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
