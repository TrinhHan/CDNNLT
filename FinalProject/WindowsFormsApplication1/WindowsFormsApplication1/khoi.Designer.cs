namespace WindowsFormsApplication1
{
    partial class khoi
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
            this.finalProjectDataSet = new WindowsFormsApplication1.FinalProjectDataSet();
            this.kHOILOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOILOPTableAdapter = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.KHOILOPTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager();
            this.kHOILOPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalProjectDataSet
            // 
            this.finalProjectDataSet.DataSetName = "FinalProjectDataSet";
            this.finalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOILOPBindingSource
            // 
            this.kHOILOPBindingSource.DataMember = "KHOILOP";
            this.kHOILOPBindingSource.DataSource = this.finalProjectDataSet;
            // 
            // kHOILOPTableAdapter
            // 
            this.kHOILOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKY_NAMHOCTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.KHOILOPTableAdapter = this.kHOILOPTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.TOBOMONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.FinalProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLOAITableAdapter = null;
            // 
            // kHOILOPDataGridView
            // 
            this.kHOILOPDataGridView.AllowUserToAddRows = false;
            this.kHOILOPDataGridView.AllowUserToDeleteRows = false;
            this.kHOILOPDataGridView.AutoGenerateColumns = false;
            this.kHOILOPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHOILOPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.kHOILOPDataGridView.DataSource = this.kHOILOPBindingSource;
            this.kHOILOPDataGridView.Enabled = false;
            this.kHOILOPDataGridView.Location = new System.Drawing.Point(6, 22);
            this.kHOILOPDataGridView.Name = "kHOILOPDataGridView";
            this.kHOILOPDataGridView.Size = new System.Drawing.Size(244, 253);
            this.kHOILOPDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKHOI";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAKHOI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKHOI";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENKHOI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.kHOILOPDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 281);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khối";
            // 
            // khoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.giay_dan_tuong_tre_em_1248;
            this.ClientSize = new System.Drawing.Size(397, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "khoi";
            this.Text = "Khối";
            this.Load += new System.EventHandler(this.khoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FinalProjectDataSet finalProjectDataSet;
        private System.Windows.Forms.BindingSource kHOILOPBindingSource;
        private FinalProjectDataSetTableAdapters.KHOILOPTableAdapter kHOILOPTableAdapter;
        private FinalProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHOILOPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}