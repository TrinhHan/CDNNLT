namespace WindowsFormsApplication1
{
    partial class tracuugiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tracuugiaovien));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tracuugiaovienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.text_tenlop = new System.Windows.Forms.TextBox();
            this.text_tenbomon = new System.Windows.Forms.TextBox();
            this.text_ten = new System.Windows.Forms.TextBox();
            this.text_ho = new System.Windows.Forms.TextBox();
            this.text_magiaovien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tracuugiaovienTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.tracuugiaovienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tracuugiaovienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tracuugiaovienBindingSource
            // 
            this.tracuugiaovienBindingSource.DataMember = "tracuugiaovien";
            this.tracuugiaovienBindingSource.DataSource = this.FinalProjectDataSet;
            // 
            // FinalProjectDataSet
            // 
            this.FinalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.FinalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.text_tenlop);
            this.groupBox1.Controls.Add(this.text_tenbomon);
            this.groupBox1.Controls.Add(this.text_ten);
            this.groupBox1.Controls.Add(this.text_ho);
            this.groupBox1.Controls.Add(this.text_magiaovien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Giáo Viên";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Green;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(420, 127);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(90, 32);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.Green;
            this.btntim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntim.Location = new System.Drawing.Point(313, 127);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(90, 32);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // text_tenlop
            // 
            this.text_tenlop.Location = new System.Drawing.Point(345, 26);
            this.text_tenlop.Name = "text_tenlop";
            this.text_tenlop.Size = new System.Drawing.Size(100, 26);
            this.text_tenlop.TabIndex = 9;
            // 
            // text_tenbomon
            // 
            this.text_tenbomon.Location = new System.Drawing.Point(345, 64);
            this.text_tenbomon.Name = "text_tenbomon";
            this.text_tenbomon.Size = new System.Drawing.Size(100, 26);
            this.text_tenbomon.TabIndex = 8;
            // 
            // text_ten
            // 
            this.text_ten.Location = new System.Drawing.Point(130, 104);
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(100, 26);
            this.text_ten.TabIndex = 7;
            // 
            // text_ho
            // 
            this.text_ho.Location = new System.Drawing.Point(130, 66);
            this.text_ho.Name = "text_ho";
            this.text_ho.Size = new System.Drawing.Size(100, 26);
            this.text_ho.TabIndex = 6;
            // 
            // text_magiaovien
            // 
            this.text_magiaovien.Location = new System.Drawing.Point(130, 27);
            this.text_magiaovien.Name = "text_magiaovien";
            this.text_magiaovien.Size = new System.Drawing.Size(100, 26);
            this.text_magiaovien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Bộ Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tracuugiaovien";
            reportDataSource1.Value = this.tracuugiaovienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 210);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(554, 141);
            this.reportViewer1.TabIndex = 1;
            // 
            // tracuugiaovienTableAdapter
            // 
            this.tracuugiaovienTableAdapter.ClearBeforeFill = true;
            // 
            // tracuugiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 363);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "tracuugiaovien";
            this.Text = "Tra Cứu Giáo Viên";
            this.Load += new System.EventHandler(this.tracuugiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tracuugiaovienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox text_tenlop;
        private System.Windows.Forms.TextBox text_tenbomon;
        private System.Windows.Forms.TextBox text_ten;
        private System.Windows.Forms.TextBox text_ho;
        private System.Windows.Forms.TextBox text_magiaovien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tracuugiaovienBindingSource;
        private FinalProjectDataSet FinalProjectDataSet;
        private FinalProjectDataSetTableAdapters.tracuugiaovienTableAdapter tracuugiaovienTableAdapter;
    }
}