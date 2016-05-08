namespace WindowsFormsApplication1
{
    partial class Xếp_Loại
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
            System.Windows.Forms.Label hOCLUCLabel;
            System.Windows.Forms.Label hANHKIEMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xếp_Loại));
            this.gr_thongtinhocsinh = new System.Windows.Forms.GroupBox();
            this.hANHKIEMTextBox = new System.Windows.Forms.ComboBox();
            this.xEPLOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.hOCLUCTextBox = new System.Windows.Forms.ComboBox();
            this.mAHOCSINHTextBox = new System.Windows.Forms.TextBox();
            this.xEPLOAITableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.XEPLOAITableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.xEPLOAIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAHOCSINHLabel = new System.Windows.Forms.Label();
            hOCLUCLabel = new System.Windows.Forms.Label();
            hANHKIEMLabel = new System.Windows.Forms.Label();
            this.gr_thongtinhocsinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEPLOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEPLOAIDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHOCSINHLabel
            // 
            mAHOCSINHLabel.AutoSize = true;
            mAHOCSINHLabel.BackColor = System.Drawing.Color.Transparent;
            mAHOCSINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHOCSINHLabel.Location = new System.Drawing.Point(39, 45);
            mAHOCSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAHOCSINHLabel.Name = "mAHOCSINHLabel";
            mAHOCSINHLabel.Size = new System.Drawing.Size(97, 19);
            mAHOCSINHLabel.TabIndex = 0;
            mAHOCSINHLabel.Text = "Mã Học Sinh";
            // 
            // hOCLUCLabel
            // 
            hOCLUCLabel.AutoSize = true;
            hOCLUCLabel.BackColor = System.Drawing.Color.Transparent;
            hOCLUCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCLUCLabel.Location = new System.Drawing.Point(39, 86);
            hOCLUCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOCLUCLabel.Name = "hOCLUCLabel";
            hOCLUCLabel.Size = new System.Drawing.Size(67, 19);
            hOCLUCLabel.TabIndex = 2;
            hOCLUCLabel.Text = "Học Lực";
            // 
            // hANHKIEMLabel
            // 
            hANHKIEMLabel.AutoSize = true;
            hANHKIEMLabel.BackColor = System.Drawing.Color.Transparent;
            hANHKIEMLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hANHKIEMLabel.Location = new System.Drawing.Point(39, 130);
            hANHKIEMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hANHKIEMLabel.Name = "hANHKIEMLabel";
            hANHKIEMLabel.Size = new System.Drawing.Size(85, 19);
            hANHKIEMLabel.TabIndex = 4;
            hANHKIEMLabel.Text = "Hạnh Kiểm";
            // 
            // gr_thongtinhocsinh
            // 
            this.gr_thongtinhocsinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gr_thongtinhocsinh.BackgroundImage")));
            this.gr_thongtinhocsinh.Controls.Add(this.hANHKIEMTextBox);
            this.gr_thongtinhocsinh.Controls.Add(this.hOCLUCTextBox);
            this.gr_thongtinhocsinh.Controls.Add(mAHOCSINHLabel);
            this.gr_thongtinhocsinh.Controls.Add(this.mAHOCSINHTextBox);
            this.gr_thongtinhocsinh.Controls.Add(hOCLUCLabel);
            this.gr_thongtinhocsinh.Controls.Add(hANHKIEMLabel);
            this.gr_thongtinhocsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_thongtinhocsinh.Location = new System.Drawing.Point(27, 14);
            this.gr_thongtinhocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.gr_thongtinhocsinh.Name = "gr_thongtinhocsinh";
            this.gr_thongtinhocsinh.Padding = new System.Windows.Forms.Padding(4);
            this.gr_thongtinhocsinh.Size = new System.Drawing.Size(303, 199);
            this.gr_thongtinhocsinh.TabIndex = 0;
            this.gr_thongtinhocsinh.TabStop = false;
            this.gr_thongtinhocsinh.Text = "Thông tin xếp loại";
            this.gr_thongtinhocsinh.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hANHKIEMTextBox
            // 
            this.hANHKIEMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xEPLOAIBindingSource, "HANHKIEM", true));
            this.hANHKIEMTextBox.FormattingEnabled = true;
            this.hANHKIEMTextBox.Items.AddRange(new object[] {
            "yếu",
            "khá",
            "tốt"});
            this.hANHKIEMTextBox.Location = new System.Drawing.Point(147, 126);
            this.hANHKIEMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hANHKIEMTextBox.Name = "hANHKIEMTextBox";
            this.hANHKIEMTextBox.Size = new System.Drawing.Size(116, 27);
            this.hANHKIEMTextBox.TabIndex = 7;
            // 
            // xEPLOAIBindingSource
            // 
            this.xEPLOAIBindingSource.DataMember = "XEPLOAI";
            this.xEPLOAIBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCLUCTextBox
            // 
            this.hOCLUCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xEPLOAIBindingSource, "HOCLUC", true));
            this.hOCLUCTextBox.FormattingEnabled = true;
            this.hOCLUCTextBox.Items.AddRange(new object[] {
            "yếu",
            "trung bình",
            "khá ",
            "giỏi"});
            this.hOCLUCTextBox.Location = new System.Drawing.Point(147, 82);
            this.hOCLUCTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hOCLUCTextBox.Name = "hOCLUCTextBox";
            this.hOCLUCTextBox.Size = new System.Drawing.Size(116, 27);
            this.hOCLUCTextBox.TabIndex = 6;
            // 
            // mAHOCSINHTextBox
            // 
            this.mAHOCSINHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xEPLOAIBindingSource, "MAHOCSINH", true));
            this.mAHOCSINHTextBox.Location = new System.Drawing.Point(147, 41);
            this.mAHOCSINHTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mAHOCSINHTextBox.Name = "mAHOCSINHTextBox";
            this.mAHOCSINHTextBox.Size = new System.Drawing.Size(116, 26);
            this.mAHOCSINHTextBox.TabIndex = 1;
            // 
            // xEPLOAITableAdapter
            // 
            this.xEPLOAITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = this.xEPLOAITableAdapter;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(42, 231);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 42);
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
            this.btnSua.Location = new System.Drawing.Point(186, 231);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(320, 300);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(42, 300);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(186, 300);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // xEPLOAIDataGridView
            // 
            this.xEPLOAIDataGridView.AllowUserToAddRows = false;
            this.xEPLOAIDataGridView.AllowUserToDeleteRows = false;
            this.xEPLOAIDataGridView.AutoGenerateColumns = false;
            this.xEPLOAIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xEPLOAIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.xEPLOAIDataGridView.DataSource = this.xEPLOAIBindingSource;
            this.xEPLOAIDataGridView.Enabled = false;
            this.xEPLOAIDataGridView.Location = new System.Drawing.Point(350, 19);
            this.xEPLOAIDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.xEPLOAIDataGridView.Name = "xEPLOAIDataGridView";
            this.xEPLOAIDataGridView.Size = new System.Drawing.Size(344, 259);
            this.xEPLOAIDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHOCSINH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAHOCSINH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOCLUC";
            this.dataGridViewTextBoxColumn2.HeaderText = "HOCLUC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HANHKIEM";
            this.dataGridViewTextBoxColumn3.HeaderText = "HANHKIEM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Xếp_Loại
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 376);
            this.Controls.Add(this.xEPLOAIDataGridView);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gr_thongtinhocsinh);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Xếp_Loại";
            this.Text = "Xếp Loại";
            this.Load += new System.EventHandler(this.Xếp_Loại_Load);
            this.gr_thongtinhocsinh.ResumeLayout(false);
            this.gr_thongtinhocsinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xEPLOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEPLOAIDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_thongtinhocsinh;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource xEPLOAIBindingSource;
        private FinalProjectDataSetTableAdapters.XEPLOAITableAdapter xEPLOAITableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mAHOCSINHTextBox;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView xEPLOAIDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox hANHKIEMTextBox;
        private System.Windows.Forms.ComboBox hOCLUCTextBox;
    }
}