namespace WindowsFormsApplication1
{
    partial class Dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.label2_Matkhau = new System.Windows.Forms.Label();
            this.label1_Taikhoản = new System.Windows.Forms.Label();
            this.text_matkhau = new System.Windows.Forms.TextBox();
            this.text_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2_Matkhau
            // 
            this.label2_Matkhau.AutoSize = true;
            this.label2_Matkhau.BackColor = System.Drawing.Color.Transparent;
            this.label2_Matkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Matkhau.Location = new System.Drawing.Point(77, 92);
            this.label2_Matkhau.Name = "label2_Matkhau";
            this.label2_Matkhau.Size = new System.Drawing.Size(90, 22);
            this.label2_Matkhau.TabIndex = 5;
            this.label2_Matkhau.Text = "Mật khẩu";
            // 
            // label1_Taikhoản
            // 
            this.label1_Taikhoản.AutoSize = true;
            this.label1_Taikhoản.BackColor = System.Drawing.Color.Transparent;
            this.label1_Taikhoản.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Taikhoản.Location = new System.Drawing.Point(77, 50);
            this.label1_Taikhoản.Name = "label1_Taikhoản";
            this.label1_Taikhoản.Size = new System.Drawing.Size(94, 22);
            this.label1_Taikhoản.TabIndex = 4;
            this.label1_Taikhoản.Text = "Tài khoản";
            // 
            // text_matkhau
            // 
            this.text_matkhau.Location = new System.Drawing.Point(190, 94);
            this.text_matkhau.Name = "text_matkhau";
            this.text_matkhau.Size = new System.Drawing.Size(108, 29);
            this.text_matkhau.TabIndex = 3;
            this.text_matkhau.TextChanged += new System.EventHandler(this.text_matkhau_TextChanged);
            // 
            // text_taikhoan
            // 
            this.text_taikhoan.Location = new System.Drawing.Point(190, 46);
            this.text_taikhoan.Name = "text_taikhoan";
            this.text_taikhoan.Size = new System.Drawing.Size(108, 29);
            this.text_taikhoan.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Green;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Thoat.Location = new System.Drawing.Point(317, 272);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 33);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Green;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangNhap.Location = new System.Drawing.Point(189, 272);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(97, 33);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ HỌC SINH VÀ \r\n                                       GIÁO VIÊN T" +
    "IỂU HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1_Taikhoản);
            this.groupBox1.Controls.Add(this.label2_Matkhau);
            this.groupBox1.Controls.Add(this.text_taikhoan);
            this.groupBox1.Controls.Add(this.text_matkhau);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.giay_dan_tuong_han_quoc_zinnia_ma_zn004_6_3265;
            this.ClientSize = new System.Drawing.Size(592, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btnDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2_Matkhau;
        private System.Windows.Forms.Label label1_Taikhoản;
        private System.Windows.Forms.TextBox text_matkhau;
        private System.Windows.Forms.TextBox text_taikhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

