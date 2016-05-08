namespace WindowsFormsApplication1
{
    partial class baocaogiaovien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.baocaogiaovienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.text_makhoi = new System.Windows.Forms.TextBox();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baocaogiaovienTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.baocaogiaovienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baocaogiaovienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // baocaogiaovienBindingSource
            // 
            this.baocaogiaovienBindingSource.DataMember = "baocaogiaovien";
            this.baocaogiaovienBindingSource.DataSource = this.FinalProjectDataSet;
            // 
            // FinalProjectDataSet
            // 
            this.FinalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.FinalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khối";
            // 
            // text_makhoi
            // 
            this.text_makhoi.Location = new System.Drawing.Point(143, 32);
            this.text_makhoi.Name = "text_makhoi";
            this.text_makhoi.Size = new System.Drawing.Size(114, 20);
            this.text_makhoi.TabIndex = 1;
            // 
            // btnbaocao
            // 
            this.btnbaocao.BackColor = System.Drawing.Color.Green;
            this.btnbaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaocao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaocao.Location = new System.Drawing.Point(336, 24);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(87, 33);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "Báo Cáo";
            this.btnbaocao.UseVisualStyleBackColor = false;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Green;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(455, 24);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 33);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "baocaogiaovien";
            reportDataSource1.Value = this.baocaogiaovienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 298);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // baocaogiaovienTableAdapter
            // 
            this.baocaogiaovienTableAdapter.ClearBeforeFill = true;
            // 
            // baocaogiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._28_09_2013_10_10_21_6122501_1;
            this.ClientSize = new System.Drawing.Size(690, 415);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.text_makhoi);
            this.Controls.Add(this.label1);
            this.Name = "baocaogiaovien";
            this.Text = "Báo Cáo Giáo Viên";
            this.Load += new System.EventHandler(this.baocaogiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baocaogiaovienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_makhoi;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Button btnthoat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource baocaogiaovienBindingSource;
        private FinalProjectDataSet FinalProjectDataSet;
        private FinalProjectDataSetTableAdapters.baocaogiaovienTableAdapter baocaogiaovienTableAdapter;
    }
}