namespace WindowsFormsApplication1
{
    partial class lop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAKHOILabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label sISOLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nAMHOCLabel;
            System.Windows.Forms.Label mAGIAOVIENLabel;
            this.gr_thongtinlop = new System.Windows.Forms.GroupBox();
            this.nAMHOCTextBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.hOCKYTextBox = new System.Windows.Forms.ComboBox();
            this.mALOPTextBox = new System.Windows.Forms.ComboBox();
            this.mAKHOITextBox = new System.Windows.Forms.ComboBox();
            this.tENLOPTextBox = new System.Windows.Forms.TextBox();
            this.sISOTextBox = new System.Windows.Forms.TextBox();
            this.mAGIAOVIENTextBox = new System.Windows.Forms.TextBox();
            this.lOPTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            this.lOPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            mALOPLabel = new System.Windows.Forms.Label();
            mAKHOILabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            sISOLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nAMHOCLabel = new System.Windows.Forms.Label();
            mAGIAOVIENLabel = new System.Windows.Forms.Label();
            this.gr_thongtinlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.BackColor = System.Drawing.Color.Transparent;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(32, 31);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(64, 19);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã Lớp";
            // 
            // mAKHOILabel
            // 
            mAKHOILabel.AutoSize = true;
            mAKHOILabel.BackColor = System.Drawing.Color.Transparent;
            mAKHOILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOILabel.Location = new System.Drawing.Point(32, 60);
            mAKHOILabel.Name = "mAKHOILabel";
            mAKHOILabel.Size = new System.Drawing.Size(69, 19);
            mAKHOILabel.TabIndex = 2;
            mAKHOILabel.Text = "Mã Khối";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.BackColor = System.Drawing.Color.Transparent;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(32, 90);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(66, 19);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "Tên Lớp";
            // 
            // sISOLabel
            // 
            sISOLabel.AutoSize = true;
            sISOLabel.BackColor = System.Drawing.Color.Transparent;
            sISOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sISOLabel.Location = new System.Drawing.Point(32, 122);
            sISOLabel.Name = "sISOLabel";
            sISOLabel.Size = new System.Drawing.Size(43, 19);
            sISOLabel.TabIndex = 6;
            sISOLabel.Text = "Sỉ Số";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.BackColor = System.Drawing.Color.Transparent;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(223, 31);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(60, 19);
            hOCKYLabel.TabIndex = 8;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // nAMHOCLabel
            // 
            nAMHOCLabel.AutoSize = true;
            nAMHOCLabel.BackColor = System.Drawing.Color.Transparent;
            nAMHOCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMHOCLabel.Location = new System.Drawing.Point(223, 57);
            nAMHOCLabel.Name = "nAMHOCLabel";
            nAMHOCLabel.Size = new System.Drawing.Size(72, 19);
            nAMHOCLabel.TabIndex = 10;
            nAMHOCLabel.Text = "Năm Học";
            // 
            // mAGIAOVIENLabel
            // 
            mAGIAOVIENLabel.AutoSize = true;
            mAGIAOVIENLabel.BackColor = System.Drawing.Color.Transparent;
            mAGIAOVIENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGIAOVIENLabel.Location = new System.Drawing.Point(222, 90);
            mAGIAOVIENLabel.Name = "mAGIAOVIENLabel";
            mAGIAOVIENLabel.Size = new System.Drawing.Size(103, 19);
            mAGIAOVIENLabel.TabIndex = 12;
            mAGIAOVIENLabel.Text = "Mã Giáo Viên";
            // 
            // gr_thongtinlop
            // 
            this.gr_thongtinlop.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._28_09_2013_10_10_21_6122501_1;
            this.gr_thongtinlop.Controls.Add(this.nAMHOCTextBox);
            this.gr_thongtinlop.Controls.Add(this.hOCKYTextBox);
            this.gr_thongtinlop.Controls.Add(this.mALOPTextBox);
            this.gr_thongtinlop.Controls.Add(this.mAKHOITextBox);
            this.gr_thongtinlop.Controls.Add(mALOPLabel);
            this.gr_thongtinlop.Controls.Add(mAKHOILabel);
            this.gr_thongtinlop.Controls.Add(tENLOPLabel);
            this.gr_thongtinlop.Controls.Add(this.tENLOPTextBox);
            this.gr_thongtinlop.Controls.Add(sISOLabel);
            this.gr_thongtinlop.Controls.Add(this.sISOTextBox);
            this.gr_thongtinlop.Controls.Add(hOCKYLabel);
            this.gr_thongtinlop.Controls.Add(nAMHOCLabel);
            this.gr_thongtinlop.Controls.Add(mAGIAOVIENLabel);
            this.gr_thongtinlop.Controls.Add(this.mAGIAOVIENTextBox);
            this.gr_thongtinlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_thongtinlop.Location = new System.Drawing.Point(25, 12);
            this.gr_thongtinlop.Name = "gr_thongtinlop";
            this.gr_thongtinlop.Size = new System.Drawing.Size(444, 152);
            this.gr_thongtinlop.TabIndex = 0;
            this.gr_thongtinlop.TabStop = false;
            this.gr_thongtinlop.Text = "Thông Tin Lớp";
            // 
            // nAMHOCTextBox
            // 
            this.nAMHOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "NAMHOC", true));
            this.nAMHOCTextBox.FormattingEnabled = true;
            this.nAMHOCTextBox.Items.AddRange(new object[] {
            "2014-2015",
            "2016-2016"});
            this.nAMHOCTextBox.Location = new System.Drawing.Point(329, 53);
            this.nAMHOCTextBox.Name = "nAMHOCTextBox";
            this.nAMHOCTextBox.Size = new System.Drawing.Size(104, 27);
            this.nAMHOCTextBox.TabIndex = 17;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCKYTextBox
            // 
            this.hOCKYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "HOCKY", true));
            this.hOCKYTextBox.FormattingEnabled = true;
            this.hOCKYTextBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.hOCKYTextBox.Location = new System.Drawing.Point(329, 23);
            this.hOCKYTextBox.Name = "hOCKYTextBox";
            this.hOCKYTextBox.Size = new System.Drawing.Size(55, 27);
            this.hOCKYTextBox.TabIndex = 16;
            // 
            // mALOPTextBox
            // 
            this.mALOPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextBox.FormattingEnabled = true;
            this.mALOPTextBox.Items.AddRange(new object[] {
            "M1A       ",
            "M1B       ",
            "M2A       ",
            "M3A       ",
            "M4A       ",
            "M4B       "});
            this.mALOPTextBox.Location = new System.Drawing.Point(108, 23);
            this.mALOPTextBox.Name = "mALOPTextBox";
            this.mALOPTextBox.Size = new System.Drawing.Size(100, 27);
            this.mALOPTextBox.TabIndex = 15;
            // 
            // mAKHOITextBox
            // 
            this.mAKHOITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MAKHOI", true));
            this.mAKHOITextBox.FormattingEnabled = true;
            this.mAKHOITextBox.Items.AddRange(new object[] {
            "A1        ",
            "A2        ",
            "M1        ",
            "M2        ",
            "M3        ",
            "M4        ",
            "M5        "});
            this.mAKHOITextBox.Location = new System.Drawing.Point(108, 54);
            this.mAKHOITextBox.Name = "mAKHOITextBox";
            this.mAKHOITextBox.Size = new System.Drawing.Size(100, 27);
            this.mAKHOITextBox.TabIndex = 14;
            // 
            // tENLOPTextBox
            // 
            this.tENLOPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPTextBox.Location = new System.Drawing.Point(108, 87);
            this.tENLOPTextBox.Name = "tENLOPTextBox";
            this.tENLOPTextBox.Size = new System.Drawing.Size(100, 26);
            this.tENLOPTextBox.TabIndex = 5;
            // 
            // sISOTextBox
            // 
            this.sISOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "SISO", true));
            this.sISOTextBox.Location = new System.Drawing.Point(108, 118);
            this.sISOTextBox.Name = "sISOTextBox";
            this.sISOTextBox.Size = new System.Drawing.Size(100, 26);
            this.sISOTextBox.TabIndex = 7;
            // 
            // mAGIAOVIENTextBox
            // 
            this.mAGIAOVIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MAGIAOVIEN", true));
            this.mAGIAOVIENTextBox.Location = new System.Drawing.Point(329, 85);
            this.mAGIAOVIENTextBox.Name = "mAGIAOVIENTextBox";
            this.mAGIAOVIENTextBox.Size = new System.Drawing.Size(100, 26);
            this.mAGIAOVIENTextBox.TabIndex = 13;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKY_NAMHOCTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOILOPTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = null;
            // 
            // lOPDataGridView
            // 
            this.lOPDataGridView.AllowUserToAddRows = false;
            this.lOPDataGridView.AllowUserToDeleteRows = false;
            this.lOPDataGridView.AutoGenerateColumns = false;
            this.lOPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lOPDataGridView.DataSource = this.lOPBindingSource;
            this.lOPDataGridView.Location = new System.Drawing.Point(25, 190);
            this.lOPDataGridView.Name = "lOPDataGridView";
            this.lOPDataGridView.Size = new System.Drawing.Size(626, 186);
            this.lOPDataGridView.TabIndex = 1;
            this.lOPDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lOPDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAKHOI";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAKHOI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENLOP";
            this.dataGridViewTextBoxColumn3.HeaderText = "TENLOP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SISO";
            this.dataGridViewTextBoxColumn4.HeaderText = "SISO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HOCKY";
            this.dataGridViewTextBoxColumn5.HeaderText = "HOCKY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NAMHOC";
            this.dataGridViewTextBoxColumn6.HeaderText = "NAMHOC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAGIAOVIEN";
            this.dataGridViewTextBoxColumn7.HeaderText = "MAGIAOVIEN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(479, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Green;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(576, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(576, 72);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 29);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(479, 72);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 29);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(500, 112);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._28_09_2013_10_10_21_6122501_1;
            this.ClientSize = new System.Drawing.Size(681, 406);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lOPDataGridView);
            this.Controls.Add(this.gr_thongtinlop);
            this.Name = "lop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.lop_Load);
            this.gr_thongtinlop.ResumeLayout(false);
            this.gr_thongtinlop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_thongtinlop;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private FinalProjectDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tENLOPTextBox;
        private System.Windows.Forms.TextBox sISOTextBox;
        private System.Windows.Forms.TextBox mAGIAOVIENTextBox;
        private System.Windows.Forms.DataGridView lOPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox nAMHOCTextBox;
        private System.Windows.Forms.ComboBox hOCKYTextBox;
        private System.Windows.Forms.ComboBox mALOPTextBox;
        private System.Windows.Forms.ComboBox mAKHOITextBox;
    }
}