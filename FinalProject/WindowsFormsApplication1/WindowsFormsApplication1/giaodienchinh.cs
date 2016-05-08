using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class giaodienchinh : Form
    {
        Thread thr;
        public giaodienchinh()
        {
            InitializeComponent();
        }

        public void mo_giaodienchinh(object obj)
        {
            Application.Run(new Dangnhap());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void hồSơHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hosohocsinh _hosohocsinh = new hosohocsinh();
            _hosohocsinh.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diem _diem = new diem();
            _diem.Show();
        }

        private void xếpLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xếp_Loại _Xếp_Loại = new Xếp_Loại();
            _Xếp_Loại.Show();
        }

        private void thôngTinGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtingiaovien _thongtingiaovien = new thongtingiaovien();
            _thongtingiaovien.Show();
        }

        private void danhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachmonhoc _danhsachmonhoc = new danhsachmonhoc();
            _danhsachmonhoc.Show();
        }

        private void họcKìNămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hockynamhoc _hockynamhoc = new hockynamhoc();
            _hockynamhoc.Show();
        }

        private void khốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoi _khoi = new khoi();
            _khoi.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lop _lop = new lop();
            _lop.Show();
        }

        private void tìmKiếmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracuuhocsinh _tracuuhocsinh = new tracuuhocsinh();
            _tracuuhocsinh.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracuugiaovien _tracuugiaovien = new tracuugiaovien();
            _tracuugiaovien.Show();
        }

        private void báoCáoTổngHợpDanhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaohocsinh _baocaohocsinh = new baocaohocsinh();
            _baocaohocsinh.Show();
        }

        private void báoCáoTổngHợpGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaogiaovien _baocaogiaovien = new baocaogiaovien();
            _baocaogiaovien.Show();
        }


        public void DisableMenu()
        {
            thoátToolStripMenuItem.Enabled = false;
            hồSơHọcSinhToolStripMenuItem.Enabled = false;
            điểmToolStripMenuItem.Enabled = false;
            xếpLoạiToolStripMenuItem.Enabled = false;
            thôngTinGiáoViênToolStripMenuItem.Enabled = false;
            danhSáchMônHọcToolStripMenuItem.Enabled = false;
            họcKìNămHọcToolStripMenuItem.Enabled = false;
            khốiToolStripMenuItem.Enabled = false;
            lớpToolStripMenuItem.Enabled = false;
            tìmKiếmHọcSinhToolStripMenuItem.Enabled = false;
            tìmKiếmGiáoViênToolStripMenuItem.Enabled = false;
            báoCáoTổngHợpDanhSáchHọcSinhToolStripMenuItem.Enabled = false;
            báoCáoTổngHợpGiáoViênToolStripMenuItem.Enabled = false;
        }



        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableMenu();
            Dangnhap frm = new Dangnhap();
            frm.Show();
            this.Close();
            thr = new Thread(mo_giaodienchinh);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void giaodienchinh_Load(object sender, EventArgs e)
        {

        }
    }
}
