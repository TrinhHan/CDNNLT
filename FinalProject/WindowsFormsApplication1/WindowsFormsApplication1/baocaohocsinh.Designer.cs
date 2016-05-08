namespace WindowsFormsApplication1
{
    partial class baocaohocsinh
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
            this.baocaohocsinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.text_tenlop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baocaohocsinhTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.baocaohocsinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.baocaohocsinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // baocaohocsinhBindingSource
            // 
            this.baocaohocsinhBindingSource.DataMember = "baocaohocsinh";
            this.baocaohocsinhBindingSource.DataSource = this.FinalProjectDataSet;
            // 
            // FinalProjectDataSet
            // 
            this.FinalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.FinalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // text_tenlop
            // 
            this.text_tenlop.Location = new System.Drawing.Point(144, 32);
            this.text_tenlop.Name = "text_tenlop";
            this.text_tenlop.Size = new System.Drawing.Size(114, 20);
            this.text_tenlop.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(483, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.BackColor = System.Drawing.Color.Green;
            this.btnbaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaocao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaocao.Location = new System.Drawing.Point(356, 16);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(102, 38);
            this.btnbaocao.TabIndex = 3;
            this.btnbaocao.Text = "Báo Cáo";
            this.btnbaocao.UseVisualStyleBackColor = false;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "baocaohocsinh";
            reportDataSource1.Value = this.baocaohocsinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(651, 281);
            this.reportViewer1.TabIndex = 4;
            // 
            // baocaohocsinhTableAdapter
            // 
            this.baocaohocsinhTableAdapter.ClearBeforeFill = true;
            // 
            // baocaohocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.giay_dan_tuong_han_quoc_art_deco_ma_8141_2_1082;
            this.ClientSize = new System.Drawing.Size(735, 385);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_tenlop);
            this.Controls.Add(this.label1);
            this.Name = "baocaohocsinh";
            this.Text = "Báo Cáo Học Sinh";
            this.Load += new System.EventHandler(this.baocaohocsinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baocaohocsinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_tenlop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbaocao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource baocaohocsinhBindingSource;
        private FinalProjectDataSet FinalProjectDataSet;
        private FinalProjectDataSetTableAdapters.baocaohocsinhTableAdapter baocaohocsinhTableAdapter;
    }
}