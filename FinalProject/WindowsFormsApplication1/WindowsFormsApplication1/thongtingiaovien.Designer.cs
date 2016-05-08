namespace WindowsFormsApplication1
{
    partial class thongtingiaovien
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
            System.Windows.Forms.Label mAGIAOVIENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mATOBOMONLabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongtingiaovien));
            this.gr_thongtingiaovien = new System.Windows.Forms.GroupBox();
            this.mATOBOMONTextBox = new System.Windows.Forms.ComboBox();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.gIOITINHTextBox = new System.Windows.Forms.ComboBox();
            this.mAGIAOVIENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.dIENTHOAITextBox = new System.Windows.Forms.TextBox();
            this.bt_daudanhsach = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bt_phiatruoc = new System.Windows.Forms.Button();
            this.bt_cuoidanhsach = new System.Windows.Forms.Button();
            this.bt_phiasau = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gIAOVIENTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gIAOVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAGIAOVIENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mATOBOMONLabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            this.gr_thongtingiaovien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGIAOVIENLabel
            // 
            mAGIAOVIENLabel.AutoSize = true;
            mAGIAOVIENLabel.BackColor = System.Drawing.Color.Transparent;
            mAGIAOVIENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGIAOVIENLabel.Location = new System.Drawing.Point(50, 31);
            mAGIAOVIENLabel.Name = "mAGIAOVIENLabel";
            mAGIAOVIENLabel.Size = new System.Drawing.Size(103, 19);
            mAGIAOVIENLabel.TabIndex = 0;
            mAGIAOVIENLabel.Text = "Mã Giáo Viên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.BackColor = System.Drawing.Color.Transparent;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(50, 60);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(29, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.BackColor = System.Drawing.Color.Transparent;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(50, 90);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(35, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.BackColor = System.Drawing.Color.Transparent;
            gIOITINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gIOITINHLabel.Location = new System.Drawing.Point(50, 121);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(72, 19);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "Giới Tính";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.BackColor = System.Drawing.Color.Transparent;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(342, 32);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(78, 19);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày Sinh";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.BackColor = System.Drawing.Color.Transparent;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(342, 62);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(60, 19);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa Chỉ";
            // 
            // mATOBOMONLabel
            // 
            mATOBOMONLabel.AutoSize = true;
            mATOBOMONLabel.BackColor = System.Drawing.Color.Transparent;
            mATOBOMONLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATOBOMONLabel.Location = new System.Drawing.Point(342, 91);
            mATOBOMONLabel.Name = "mATOBOMONLabel";
            mATOBOMONLabel.Size = new System.Drawing.Size(114, 19);
            mATOBOMONLabel.TabIndex = 12;
            mATOBOMONLabel.Text = "Mã Tổ Bộ Môn";
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.BackColor = System.Drawing.Color.Transparent;
            dIENTHOAILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIENTHOAILabel.Location = new System.Drawing.Point(342, 121);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(83, 19);
            dIENTHOAILabel.TabIndex = 14;
            dIENTHOAILabel.Text = "Điện Thoại";
            // 
            // gr_thongtingiaovien
            // 
            this.gr_thongtingiaovien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_thongtingiaovien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gr_thongtingiaovien.BackgroundImage")));
            this.gr_thongtingiaovien.Controls.Add(this.mATOBOMONTextBox);
            this.gr_thongtingiaovien.Controls.Add(this.gIOITINHTextBox);
            this.gr_thongtingiaovien.Controls.Add(mAGIAOVIENLabel);
            this.gr_thongtingiaovien.Controls.Add(this.mAGIAOVIENTextBox);
            this.gr_thongtingiaovien.Controls.Add(hOLabel);
            this.gr_thongtingiaovien.Controls.Add(this.hOTextBox);
            this.gr_thongtingiaovien.Controls.Add(tENLabel);
            this.gr_thongtingiaovien.Controls.Add(this.tENTextBox);
            this.gr_thongtingiaovien.Controls.Add(gIOITINHLabel);
            this.gr_thongtingiaovien.Controls.Add(nGAYSINHLabel);
            this.gr_thongtingiaovien.Controls.Add(this.nGAYSINHDateTimePicker);
            this.gr_thongtingiaovien.Controls.Add(dIACHILabel);
            this.gr_thongtingiaovien.Controls.Add(this.dIACHITextBox);
            this.gr_thongtingiaovien.Controls.Add(mATOBOMONLabel);
            this.gr_thongtingiaovien.Controls.Add(dIENTHOAILabel);
            this.gr_thongtingiaovien.Controls.Add(this.dIENTHOAITextBox);
            this.gr_thongtingiaovien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_thongtingiaovien.Location = new System.Drawing.Point(27, 12);
            this.gr_thongtingiaovien.Name = "gr_thongtingiaovien";
            this.gr_thongtingiaovien.Size = new System.Drawing.Size(741, 149);
            this.gr_thongtingiaovien.TabIndex = 0;
            this.gr_thongtingiaovien.TabStop = false;
            this.gr_thongtingiaovien.Text = "Thông Tin Giáo Viên";
            // 
            // mATOBOMONTextBox
            // 
            this.mATOBOMONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MATOBOMON", true));
            this.mATOBOMONTextBox.FormattingEnabled = true;
            this.mATOBOMONTextBox.Items.AddRange(new object[] {
            "MAV       ",
            "MH        ",
            "MT        ",
            "MTV "});
            this.mATOBOMONTextBox.Location = new System.Drawing.Point(461, 87);
            this.mATOBOMONTextBox.Name = "mATOBOMONTextBox";
            this.mATOBOMONTextBox.Size = new System.Drawing.Size(121, 27);
            this.mATOBOMONTextBox.TabIndex = 17;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIOITINHTextBox
            // 
            this.gIOITINHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "GIOITINH", true));
            this.gIOITINHTextBox.FormattingEnabled = true;
            this.gIOITINHTextBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gIOITINHTextBox.Location = new System.Drawing.Point(158, 118);
            this.gIOITINHTextBox.Name = "gIOITINHTextBox";
            this.gIOITINHTextBox.Size = new System.Drawing.Size(121, 27);
            this.gIOITINHTextBox.TabIndex = 16;
            // 
            // mAGIAOVIENTextBox
            // 
            this.mAGIAOVIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGIAOVIEN", true));
            this.mAGIAOVIENTextBox.Location = new System.Drawing.Point(158, 28);
            this.mAGIAOVIENTextBox.Name = "mAGIAOVIENTextBox";
            this.mAGIAOVIENTextBox.Size = new System.Drawing.Size(121, 26);
            this.mAGIAOVIENTextBox.TabIndex = 1;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(158, 58);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(121, 26);
            this.hOTextBox.TabIndex = 3;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(158, 88);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(121, 26);
            this.tENTextBox.TabIndex = 5;
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gIAOVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(461, 28);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(247, 26);
            this.nGAYSINHDateTimePicker.TabIndex = 9;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(461, 58);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(247, 26);
            this.dIACHITextBox.TabIndex = 11;
            // 
            // dIENTHOAITextBox
            // 
            this.dIENTHOAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "DIENTHOAI", true));
            this.dIENTHOAITextBox.Location = new System.Drawing.Point(461, 118);
            this.dIENTHOAITextBox.Name = "dIENTHOAITextBox";
            this.dIENTHOAITextBox.Size = new System.Drawing.Size(159, 26);
            this.dIENTHOAITextBox.TabIndex = 15;
            // 
            // bt_daudanhsach
            // 
            this.bt_daudanhsach.BackColor = System.Drawing.Color.Green;
            this.bt_daudanhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_daudanhsach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_daudanhsach.Location = new System.Drawing.Point(72, 175);
            this.bt_daudanhsach.Name = "bt_daudanhsach";
            this.bt_daudanhsach.Size = new System.Drawing.Size(131, 36);
            this.bt_daudanhsach.TabIndex = 1;
            this.bt_daudanhsach.Text = "<<";
            this.bt_daudanhsach.UseVisualStyleBackColor = false;
            this.bt_daudanhsach.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(72, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bt_phiatruoc
            // 
            this.bt_phiatruoc.BackColor = System.Drawing.Color.Green;
            this.bt_phiatruoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phiatruoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_phiatruoc.Location = new System.Drawing.Point(339, 175);
            this.bt_phiatruoc.Name = "bt_phiatruoc";
            this.bt_phiatruoc.Size = new System.Drawing.Size(131, 36);
            this.bt_phiatruoc.TabIndex = 3;
            this.bt_phiatruoc.Text = ">";
            this.bt_phiatruoc.UseVisualStyleBackColor = false;
            this.bt_phiatruoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_cuoidanhsach
            // 
            this.bt_cuoidanhsach.BackColor = System.Drawing.Color.Green;
            this.bt_cuoidanhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cuoidanhsach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_cuoidanhsach.Location = new System.Drawing.Point(472, 175);
            this.bt_cuoidanhsach.Name = "bt_cuoidanhsach";
            this.bt_cuoidanhsach.Size = new System.Drawing.Size(131, 36);
            this.bt_cuoidanhsach.TabIndex = 4;
            this.bt_cuoidanhsach.Text = ">>";
            this.bt_cuoidanhsach.UseVisualStyleBackColor = false;
            this.bt_cuoidanhsach.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_phiasau
            // 
            this.bt_phiasau.BackColor = System.Drawing.Color.Green;
            this.bt_phiasau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phiasau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_phiasau.Location = new System.Drawing.Point(207, 175);
            this.bt_phiasau.Name = "bt_phiasau";
            this.bt_phiasau.Size = new System.Drawing.Size(131, 36);
            this.bt_phiasau.TabIndex = 5;
            this.bt_phiasau.Text = "<";
            this.bt_phiasau.UseVisualStyleBackColor = false;
            this.bt_phiasau.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Green;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(207, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 41);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Green;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(339, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.HOCKY_NAMHOCTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOILOPTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = null;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(472, 221);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(131, 41);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(604, 173);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(604, 221);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 41);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.gIAOVIENDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(27, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 255);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // gIAOVIENDataGridView
            // 
            this.gIAOVIENDataGridView.AllowUserToAddRows = false;
            this.gIAOVIENDataGridView.AllowUserToDeleteRows = false;
            this.gIAOVIENDataGridView.AutoGenerateColumns = false;
            this.gIAOVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIAOVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gIAOVIENDataGridView.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENDataGridView.Enabled = false;
            this.gIAOVIENDataGridView.Location = new System.Drawing.Point(6, 23);
            this.gIAOVIENDataGridView.Name = "gIAOVIENDataGridView";
            this.gIAOVIENDataGridView.Size = new System.Drawing.Size(735, 213);
            this.gIAOVIENDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGIAOVIEN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGIAOVIEN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "GIOITINH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn6.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MATOBOMON";
            this.dataGridViewTextBoxColumn7.HeaderText = "MATOBOMON";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn8.HeaderText = "DIENTHOAI";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // thongtingiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bt_phiasau);
            this.Controls.Add(this.bt_cuoidanhsach);
            this.Controls.Add(this.bt_phiatruoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.bt_daudanhsach);
            this.Controls.Add(this.gr_thongtingiaovien);
            this.Name = "thongtingiaovien";
            this.Text = "Thông Tin Giáo Viên";
            this.Load += new System.EventHandler(this.thongtingiaovien_Load);
            this.gr_thongtingiaovien.ResumeLayout(false);
            this.gr_thongtingiaovien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_thongtingiaovien;
        private System.Windows.Forms.Button bt_daudanhsach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button bt_phiatruoc;
        private System.Windows.Forms.Button bt_cuoidanhsach;
        private System.Windows.Forms.Button bt_phiasau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private FinalProjectDataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mAGIAOVIENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox dIENTHOAITextBox;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gIAOVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox mATOBOMONTextBox;
        private System.Windows.Forms.ComboBox gIOITINHTextBox;
    }
}