namespace WindowsFormsApplication1
{
    partial class diem
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
            System.Windows.Forms.Label mAHOCSINHLabel;
            System.Windows.Forms.Label mAMONHOCLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nAMHOCLabel;
            System.Windows.Forms.Label dIEMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diem));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dIEMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gr_Diem = new System.Windows.Forms.GroupBox();
            this.mAMONHOCTextBox = new System.Windows.Forms.ComboBox();
            this.nAMHOCTextBox = new System.Windows.Forms.ComboBox();
            this.hOCKYTextBox = new System.Windows.Forms.ComboBox();
            this.mAHOCSINHTextBox = new System.Windows.Forms.TextBox();
            this.dIEMTextBox = new System.Windows.Forms.TextBox();
            this.dIEMTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.DIEMTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            mAHOCSINHLabel = new System.Windows.Forms.Label();
            mAMONHOCLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nAMHOCLabel = new System.Windows.Forms.Label();
            dIEMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            this.gr_Diem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHOCSINHLabel
            // 
            mAHOCSINHLabel.AutoSize = true;
            mAHOCSINHLabel.BackColor = System.Drawing.Color.Transparent;
            mAHOCSINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHOCSINHLabel.Location = new System.Drawing.Point(48, 32);
            mAHOCSINHLabel.Name = "mAHOCSINHLabel";
            mAHOCSINHLabel.Size = new System.Drawing.Size(97, 19);
            mAHOCSINHLabel.TabIndex = 0;
            mAHOCSINHLabel.Text = "Mã Học Sinh";
            // 
            // mAMONHOCLabel
            // 
            mAMONHOCLabel.AutoSize = true;
            mAMONHOCLabel.BackColor = System.Drawing.Color.Transparent;
            mAMONHOCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMONHOCLabel.Location = new System.Drawing.Point(48, 65);
            mAMONHOCLabel.Name = "mAMONHOCLabel";
            mAMONHOCLabel.Size = new System.Drawing.Size(100, 19);
            mAMONHOCLabel.TabIndex = 2;
            mAMONHOCLabel.Text = "Mã Môn Học";
            mAMONHOCLabel.Click += new System.EventHandler(this.mAMONHOCLabel_Click);
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.BackColor = System.Drawing.Color.Transparent;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(48, 100);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(60, 19);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // nAMHOCLabel
            // 
            nAMHOCLabel.AutoSize = true;
            nAMHOCLabel.BackColor = System.Drawing.Color.Transparent;
            nAMHOCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMHOCLabel.Location = new System.Drawing.Point(48, 136);
            nAMHOCLabel.Name = "nAMHOCLabel";
            nAMHOCLabel.Size = new System.Drawing.Size(72, 19);
            nAMHOCLabel.TabIndex = 6;
            nAMHOCLabel.Text = "Năm Học";
            // 
            // dIEMLabel
            // 
            dIEMLabel.AutoSize = true;
            dIEMLabel.BackColor = System.Drawing.Color.Transparent;
            dIEMLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIEMLabel.Location = new System.Drawing.Point(48, 170);
            dIEMLabel.Name = "dIEMLabel";
            dIEMLabel.Size = new System.Drawing.Size(45, 19);
            dIEMLabel.TabIndex = 8;
            dIEMLabel.Text = "Điểm";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(115, 236);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Green;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(303, 236);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(113, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(303, 274);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 32);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dIEMDataGridView
            // 
            this.dIEMDataGridView.AllowUserToAddRows = false;
            this.dIEMDataGridView.AllowUserToDeleteRows = false;
            this.dIEMDataGridView.AutoGenerateColumns = false;
            this.dIEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dIEMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dIEMDataGridView.DataSource = this.dIEMBindingSource;
            this.dIEMDataGridView.Location = new System.Drawing.Point(323, 23);
            this.dIEMDataGridView.Name = "dIEMDataGridView";
            this.dIEMDataGridView.Size = new System.Drawing.Size(308, 175);
            this.dIEMDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHOCSINH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAHOCSINH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAMONHOC";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAMONHOC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOCKY";
            this.dataGridViewTextBoxColumn3.HeaderText = "HOCKY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAMHOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "NAMHOC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIEM";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIEM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(461, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Green;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(462, 236);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gr_Diem
            // 
            this.gr_Diem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gr_Diem.BackgroundImage")));
            this.gr_Diem.Controls.Add(this.mAMONHOCTextBox);
            this.gr_Diem.Controls.Add(this.nAMHOCTextBox);
            this.gr_Diem.Controls.Add(this.hOCKYTextBox);
            this.gr_Diem.Controls.Add(mAHOCSINHLabel);
            this.gr_Diem.Controls.Add(this.mAHOCSINHTextBox);
            this.gr_Diem.Controls.Add(mAMONHOCLabel);
            this.gr_Diem.Controls.Add(hOCKYLabel);
            this.gr_Diem.Controls.Add(nAMHOCLabel);
            this.gr_Diem.Controls.Add(dIEMLabel);
            this.gr_Diem.Controls.Add(this.dIEMTextBox);
            this.gr_Diem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Diem.Location = new System.Drawing.Point(12, 12);
            this.gr_Diem.Name = "gr_Diem";
            this.gr_Diem.Size = new System.Drawing.Size(294, 204);
            this.gr_Diem.TabIndex = 0;
            this.gr_Diem.TabStop = false;
            this.gr_Diem.Text = "Điểm";
            // 
            // mAMONHOCTextBox
            // 
            this.mAMONHOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIEMBindingSource, "MAMONHOC", true));
            this.mAMONHOCTextBox.FormattingEnabled = true;
            this.mAMONHOCTextBox.Items.AddRange(new object[] {
            "MAV3      ",
            "MAV3      ",
            "MAV5      ",
            "MH3       ",
            "MH4       ",
            "MT1       ",
            "MT2       ",
            "MT2       ",
            "MTV2      "});
            this.mAMONHOCTextBox.Location = new System.Drawing.Point(161, 62);
            this.mAMONHOCTextBox.Name = "mAMONHOCTextBox";
            this.mAMONHOCTextBox.Size = new System.Drawing.Size(100, 27);
            this.mAMONHOCTextBox.TabIndex = 12;
            // 
            // nAMHOCTextBox
            // 
            this.nAMHOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIEMBindingSource, "NAMHOC", true));
            this.nAMHOCTextBox.FormattingEnabled = true;
            this.nAMHOCTextBox.Items.AddRange(new object[] {
            "2014-2015",
            "2015-2016"});
            this.nAMHOCTextBox.Location = new System.Drawing.Point(161, 130);
            this.nAMHOCTextBox.Name = "nAMHOCTextBox";
            this.nAMHOCTextBox.Size = new System.Drawing.Size(100, 27);
            this.nAMHOCTextBox.TabIndex = 11;
            this.nAMHOCTextBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hOCKYTextBox
            // 
            this.hOCKYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIEMBindingSource, "HOCKY", true));
            this.hOCKYTextBox.FormattingEnabled = true;
            this.hOCKYTextBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.hOCKYTextBox.Location = new System.Drawing.Point(161, 95);
            this.hOCKYTextBox.Name = "hOCKYTextBox";
            this.hOCKYTextBox.Size = new System.Drawing.Size(100, 27);
            this.hOCKYTextBox.TabIndex = 10;
            // 
            // mAHOCSINHTextBox
            // 
            this.mAHOCSINHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIEMBindingSource, "MAHOCSINH", true));
            this.mAHOCSINHTextBox.Location = new System.Drawing.Point(161, 30);
            this.mAHOCSINHTextBox.Name = "mAHOCSINHTextBox";
            this.mAHOCSINHTextBox.Size = new System.Drawing.Size(100, 26);
            this.mAHOCSINHTextBox.TabIndex = 1;
            // 
            // dIEMTextBox
            // 
            this.dIEMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIEMBindingSource, "DIEM", true));
            this.dIEMTextBox.Location = new System.Drawing.Point(161, 163);
            this.dIEMTextBox.Name = "dIEMTextBox";
            this.dIEMTextBox.Size = new System.Drawing.Size(100, 26);
            this.dIEMTextBox.TabIndex = 9;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKY_NAMHOCTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOILOPTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = null;
            // 
            // diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 347);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dIEMDataGridView);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gr_Diem);
            this.Name = "diem";
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dIEMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            this.gr_Diem.ResumeLayout(false);
            this.gr_Diem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_Diem;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private FinalProjectDataSetTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mAHOCSINHTextBox;
        private System.Windows.Forms.TextBox dIEMTextBox;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dIEMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox nAMHOCTextBox;
        private System.Windows.Forms.ComboBox hOCKYTextBox;
        private System.Windows.Forms.ComboBox mAMONHOCTextBox;
    }
}