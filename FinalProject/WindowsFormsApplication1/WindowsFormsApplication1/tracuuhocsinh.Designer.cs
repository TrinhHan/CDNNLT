namespace WindowsFormsApplication1
{
    partial class tracuuhocsinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tracuuhocsinh));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_ho = new System.Windows.Forms.TextBox();
            this.text_ten = new System.Windows.Forms.TextBox();
            this.text_makhoi = new System.Windows.Forms.TextBox();
            this.text_tenlop = new System.Windows.Forms.TextBox();
            this.text_mahocsinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_hohs = new System.Windows.Forms.TextBox();
            this.text_tenhs = new System.Windows.Forms.TextBox();
            this.text_makhoihs = new System.Windows.Forms.TextBox();
            this.text_tenlophs = new System.Windows.Forms.TextBox();
            this.text_mahs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tracuuhocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.tracuuhocsinhTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.tracuuhocsinhTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracuuhocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.text_ho);
            this.groupBox1.Controls.Add(this.text_ten);
            this.groupBox1.Controls.Add(this.text_makhoi);
            this.groupBox1.Controls.Add(this.text_tenlop);
            this.groupBox1.Controls.Add(this.text_mahocsinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Học sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // text_ho
            // 
            this.text_ho.Location = new System.Drawing.Point(298, 20);
            this.text_ho.Name = "text_ho";
            this.text_ho.Size = new System.Drawing.Size(100, 26);
            this.text_ho.TabIndex = 11;
            // 
            // text_ten
            // 
            this.text_ten.Location = new System.Drawing.Point(454, 21);
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(100, 26);
            this.text_ten.TabIndex = 10;
            // 
            // text_makhoi
            // 
            this.text_makhoi.Location = new System.Drawing.Point(112, 57);
            this.text_makhoi.Name = "text_makhoi";
            this.text_makhoi.Size = new System.Drawing.Size(100, 26);
            this.text_makhoi.TabIndex = 9;
            // 
            // text_tenlop
            // 
            this.text_tenlop.Location = new System.Drawing.Point(298, 61);
            this.text_tenlop.Name = "text_tenlop";
            this.text_tenlop.Size = new System.Drawing.Size(100, 26);
            this.text_tenlop.TabIndex = 8;
            // 
            // text_mahocsinh
            // 
            this.text_mahocsinh.Location = new System.Drawing.Point(112, 20);
            this.text_mahocsinh.Name = "text_mahocsinh";
            this.text_mahocsinh.Size = new System.Drawing.Size(100, 26);
            this.text_mahocsinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Lớp";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Khối";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Học Sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(303, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 40);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Green;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTim.Location = new System.Drawing.Point(142, 98);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 40);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tracuuhocsinh";
            reportDataSource1.Value = this.tracuuhocsinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 178);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(601, 205);
            this.reportViewer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.text_hohs);
            this.groupBox2.Controls.Add(this.text_tenhs);
            this.groupBox2.Controls.Add(this.text_makhoihs);
            this.groupBox2.Controls.Add(this.text_tenlophs);
            this.groupBox2.Controls.Add(this.text_mahs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Học sinh";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // text_hohs
            // 
            this.text_hohs.Location = new System.Drawing.Point(298, 20);
            this.text_hohs.Name = "text_hohs";
            this.text_hohs.Size = new System.Drawing.Size(100, 26);
            this.text_hohs.TabIndex = 11;
            // 
            // text_tenhs
            // 
            this.text_tenhs.Location = new System.Drawing.Point(454, 21);
            this.text_tenhs.Name = "text_tenhs";
            this.text_tenhs.Size = new System.Drawing.Size(100, 26);
            this.text_tenhs.TabIndex = 10;
            // 
            // text_makhoihs
            // 
            this.text_makhoihs.Location = new System.Drawing.Point(119, 59);
            this.text_makhoihs.Name = "text_makhoihs";
            this.text_makhoihs.Size = new System.Drawing.Size(100, 26);
            this.text_makhoihs.TabIndex = 9;
            // 
            // text_tenlophs
            // 
            this.text_tenlophs.Location = new System.Drawing.Point(298, 61);
            this.text_tenlophs.Name = "text_tenlophs";
            this.text_tenlophs.Size = new System.Drawing.Size(100, 26);
            this.text_tenlophs.TabIndex = 8;
            // 
            // text_mahs
            // 
            this.text_mahs.Location = new System.Drawing.Point(119, 22);
            this.text_mahs.Name = "text_mahs";
            this.text_mahs.Size = new System.Drawing.Size(100, 26);
            this.text_mahs.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Lớp";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Khối";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Họ";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Học Sinh";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(303, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(142, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tracuuhocsinhBindingSource
            // 
            this.tracuuhocsinhBindingSource.DataMember = "tracuuhocsinh";
            this.tracuuhocsinhBindingSource.DataSource = this.FinalProjectDataSet;
            // 
            // FinalProjectDataSet
            // 
            this.FinalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.FinalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tracuuhocsinhTableAdapter
            // 
            this.tracuuhocsinhTableAdapter.ClearBeforeFill = true;
            // 
            // tracuuhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 395);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "tracuuhocsinh";
            this.Text = "Tra Cứu Học Sinh";
            this.Load += new System.EventHandler(this.tracuuhocsinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracuuhocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tracuuhocsinhBindingSource;
        private FinalProjectDataSet FinalProjectDataSet;
        private FinalProjectDataSetTableAdapters.tracuuhocsinhTableAdapter tracuuhocsinhTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ho;
        private System.Windows.Forms.TextBox text_ten;
        private System.Windows.Forms.TextBox text_makhoi;
        private System.Windows.Forms.TextBox text_tenlop;
        private System.Windows.Forms.TextBox text_mahocsinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_hohs;
        private System.Windows.Forms.TextBox text_tenhs;
        private System.Windows.Forms.TextBox text_makhoihs;
        private System.Windows.Forms.TextBox text_tenlophs;
        private System.Windows.Forms.TextBox text_mahs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}