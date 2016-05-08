namespace WindowsFormsApplication1
{
    partial class hockynamhoc
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nAMHOCLabel;
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.hOCKY_NAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKY_NAMHOCTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.HOCKY_NAMHOCTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            this.hOCKY_NAMHOCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.hOCKYTextBox = new System.Windows.Forms.ComboBox();
            this.nAMHOCTextBox = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            hOCKYLabel = new System.Windows.Forms.Label();
            nAMHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKY_NAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKY_NAMHOCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.BackColor = System.Drawing.Color.Transparent;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(37, 46);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(60, 19);
            hOCKYLabel.TabIndex = 3;
            hOCKYLabel.Text = "Học Kỳ";
            hOCKYLabel.Click += new System.EventHandler(this.hOCKYLabel_Click);
            // 
            // nAMHOCLabel
            // 
            nAMHOCLabel.AutoSize = true;
            nAMHOCLabel.BackColor = System.Drawing.Color.Transparent;
            nAMHOCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMHOCLabel.Location = new System.Drawing.Point(37, 82);
            nAMHOCLabel.Name = "nAMHOCLabel";
            nAMHOCLabel.Size = new System.Drawing.Size(72, 19);
            nAMHOCLabel.TabIndex = 5;
            nAMHOCLabel.Text = "Năm Học";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Green;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(128, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Green;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(128, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCKY_NAMHOCBindingSource
            // 
            this.hOCKY_NAMHOCBindingSource.DataMember = "HOCKY_NAMHOC";
            this.hOCKY_NAMHOCBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // hOCKY_NAMHOCTableAdapter
            // 
            this.hOCKY_NAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKY_NAMHOCTableAdapter = this.hOCKY_NAMHOCTableAdapter;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOILOPTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = null;
            // 
            // hOCKY_NAMHOCDataGridView
            // 
            this.hOCKY_NAMHOCDataGridView.AllowUserToAddRows = false;
            this.hOCKY_NAMHOCDataGridView.AllowUserToDeleteRows = false;
            this.hOCKY_NAMHOCDataGridView.AutoGenerateColumns = false;
            this.hOCKY_NAMHOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOCKY_NAMHOCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.hOCKY_NAMHOCDataGridView.DataSource = this.hOCKY_NAMHOCBindingSource;
            this.hOCKY_NAMHOCDataGridView.Location = new System.Drawing.Point(244, 32);
            this.hOCKY_NAMHOCDataGridView.Name = "hOCKY_NAMHOCDataGridView";
            this.hOCKY_NAMHOCDataGridView.Size = new System.Drawing.Size(242, 198);
            this.hOCKY_NAMHOCDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HOCKY";
            this.dataGridViewTextBoxColumn1.HeaderText = "HOCKY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAMHOC";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAMHOC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(34, 182);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // hOCKYTextBox
            // 
            this.hOCKYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKY_NAMHOCBindingSource, "HOCKY", true));
            this.hOCKYTextBox.FormattingEnabled = true;
            this.hOCKYTextBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.hOCKYTextBox.Location = new System.Drawing.Point(112, 46);
            this.hOCKYTextBox.Name = "hOCKYTextBox";
            this.hOCKYTextBox.Size = new System.Drawing.Size(46, 21);
            this.hOCKYTextBox.TabIndex = 8;
            // 
            // nAMHOCTextBox
            // 
            this.nAMHOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKY_NAMHOCBindingSource, "NAMHOC", true));
            this.nAMHOCTextBox.FormattingEnabled = true;
            this.nAMHOCTextBox.Items.AddRange(new object[] {
            "2014-2015",
            "2015-2016"});
            this.nAMHOCTextBox.Location = new System.Drawing.Point(112, 82);
            this.nAMHOCTextBox.Name = "nAMHOCTextBox";
            this.nAMHOCTextBox.Size = new System.Drawing.Size(78, 21);
            this.nAMHOCTextBox.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(34, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // hockynamhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.giay_dan_tuong_tre_em_1248;
            this.ClientSize = new System.Drawing.Size(506, 254);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nAMHOCTextBox);
            this.Controls.Add(this.hOCKYTextBox);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.hOCKY_NAMHOCDataGridView);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(nAMHOCLabel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Name = "hockynamhoc";
            this.Text = "Học Kỳ - Năm Học";
            this.Load += new System.EventHandler(this.hockynamhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKY_NAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKY_NAMHOCDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource hOCKY_NAMHOCBindingSource;
        private FinalProjectDataSetTableAdapters.HOCKY_NAMHOCTableAdapter hOCKY_NAMHOCTableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hOCKY_NAMHOCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox hOCKYTextBox;
        private System.Windows.Forms.ComboBox nAMHOCTextBox;
        private System.Windows.Forms.Button btnThem;
    }
}