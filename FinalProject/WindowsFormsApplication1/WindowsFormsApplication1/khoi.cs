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
    public partial class khoi : Form
    {
        public khoi()
        {
            InitializeComponent();
        }

        private void kHOILOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOILOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void khoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.finalProjectDataSet.KHOILOP);

        }
    }
}
        
