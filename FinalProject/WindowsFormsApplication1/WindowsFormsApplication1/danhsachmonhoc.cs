﻿using System;
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
    public partial class danhsachmonhoc : Form
    {
        public danhsachmonhoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDataSet);

        }

        private void danhsachmonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.finalProjectDataSet.MONHOC);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
