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
    public partial class Dangnhap : Form
    {
        Thread thr;
        public Dangnhap()
        {
            InitializeComponent();
        }
        public void mo_giaodienchinh(object obj)
        {
            Application.Run(new giaodienchinh());
        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
            this.text_taikhoan.Text = "CB001";
            this.text_matkhau.Text = "CB001";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                    account ac = new account("CB001", "CB001");
            if (text_taikhoan.Text.Trim().Equals(ac.Username) && text_matkhau.Text.Trim().Equals(ac.Password))
            {
               giaodienchinh frm = new giaodienchinh();
               frm.Show();
               this.Close();
               thr = new Thread(mo_giaodienchinh);
               thr.SetApartmentState(ApartmentState.STA);
               thr.Start();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hay Mật khẩu đã sai!", "thong bao", MessageBoxButtons.OK);
            }

        }
        class account
        {
            private string _Username;
            public string Username
            {
                get { return _Username; }
                set { _Username = value; }
            }
            private string _Password;
            public string Password
            {
                get { return _Password; }
                set { _Password = value; }

            }
            public account(string username, string password)
            {
                this.Username = username;
                this.Password = password;
            }
        }
            
            
            
            /* FinalProjectDataSetTableAdapters.DANGNHAPTableAdapter qr = new FinalProjectDataSetTableAdapters.DANGNHAPTableAdapter();
            if (this.text_taikhoan.TextLength == 0 || this.text_matkhau.TextLength == 0)
            {
                this.label_dangnhap.ForeColor = Color.Red;
                this.label_dangnhap.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
            }
            else
             {
                 if (qr.checklog (this.text_taikhoan.Text, this.text_matkhau.Text) == 1)
                 {
                     this.Close();
                     thr = new Thread(mo_giaodienchinh);
                     thr.SetApartmentState(ApartmentState.STA);
                     thr.Start();
                 }
                 else
                 {
                     this.label_dangnhap.ForeColor = Color.Red;
                     this.label_dangnhap.Text = "Tài khoản hoặc mật khẩu sai";
                     this.text_taikhoan.Clear();
                     this.text_matkhau.Clear();
                     this.text_taikhoan.Focus();
                 }
            */
         //}
         
        //}
        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void text_matkhau_TextChanged(object sender, EventArgs e)
        {
            this.text_matkhau.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
