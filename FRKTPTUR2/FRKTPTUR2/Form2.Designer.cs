namespace FRKTPTUR2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fRKTPTURDataSet = new FRKTPTUR2.FRKTPTURDataSet();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new FRKTPTUR2.FRKTPTURDataSetTableAdapters.PersonelTableAdapter();
            this.fRKTPTURDataSet1 = new FRKTPTUR2.FRKTPTURDataSet1();
            this.spSeferIptalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SeferIptalTableAdapter = new FRKTPTUR2.FRKTPTURDataSet1TableAdapters.sp_SeferIptalTableAdapter();
            this.busIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doluKoltukSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seferTableAdapter = new FRKTPTUR2.FRKTPTURDataSetTableAdapters.SeferTableAdapter();
            this.seferIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobüsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobüsTableAdapter = new FRKTPTUR2.FRKTPTURDataSetTableAdapters.OtobüsTableAdapter();
            this.busIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltukSayısıDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busMarkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subelerTableAdapter = new FRKTPTUR2.FRKTPTURDataSetTableAdapters.SubelerTableAdapter();
            this.subeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRKTPTURDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRKTPTURDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSeferIptalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobüsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busIDDataGridViewTextBoxColumn,
            this.subeIDDataGridViewTextBoxColumn,
            this.persIDDataGridViewTextBoxColumn,
            this.seferIDDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.koltukSayısıDataGridViewTextBoxColumn,
            this.busMarkaDataGridViewTextBoxColumn,
            this.doluKoltukSayısıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spSeferIptalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sefer Iptal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rotalar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otobüsler:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seferIDDataGridViewTextBoxColumn1,
            this.busIDDataGridViewTextBoxColumn1,
            this.sehirIDDataGridViewTextBoxColumn,
            this.rotaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.seferBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(800, 116);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busIDDataGridViewTextBoxColumn2,
            this.subeIDDataGridViewTextBoxColumn1,
            this.seferIDDataGridViewTextBoxColumn2,
            this.plakaDataGridViewTextBoxColumn1,
            this.koltukSayısıDataGridViewTextBoxColumn1,
            this.busMarkaDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.otobüsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 356);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(800, 116);
            this.dataGridView3.TabIndex = 6;
            // 
            // fRKTPTURDataSet
            // 
            this.fRKTPTURDataSet.DataSetName = "FRKTPTURDataSet";
            this.fRKTPTURDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.fRKTPTURDataSet;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // fRKTPTURDataSet1
            // 
            this.fRKTPTURDataSet1.DataSetName = "FRKTPTURDataSet1";
            this.fRKTPTURDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSeferIptalBindingSource
            // 
            this.spSeferIptalBindingSource.DataMember = "sp_SeferIptal";
            this.spSeferIptalBindingSource.DataSource = this.fRKTPTURDataSet1;
            // 
            // sp_SeferIptalTableAdapter
            // 
            this.sp_SeferIptalTableAdapter.ClearBeforeFill = true;
            // 
            // busIDDataGridViewTextBoxColumn
            // 
            this.busIDDataGridViewTextBoxColumn.DataPropertyName = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn.HeaderText = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busIDDataGridViewTextBoxColumn.Name = "busIDDataGridViewTextBoxColumn";
            this.busIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.busIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // persIDDataGridViewTextBoxColumn
            // 
            this.persIDDataGridViewTextBoxColumn.DataPropertyName = "Pers_ID";
            this.persIDDataGridViewTextBoxColumn.HeaderText = "Pers_ID";
            this.persIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persIDDataGridViewTextBoxColumn.Name = "persIDDataGridViewTextBoxColumn";
            this.persIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferIDDataGridViewTextBoxColumn
            // 
            this.seferIDDataGridViewTextBoxColumn.DataPropertyName = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn.HeaderText = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferIDDataGridViewTextBoxColumn.Name = "seferIDDataGridViewTextBoxColumn";
            this.seferIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // koltukSayısıDataGridViewTextBoxColumn
            // 
            this.koltukSayısıDataGridViewTextBoxColumn.DataPropertyName = "KoltukSayısı";
            this.koltukSayısıDataGridViewTextBoxColumn.HeaderText = "KoltukSayısı";
            this.koltukSayısıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koltukSayısıDataGridViewTextBoxColumn.Name = "koltukSayısıDataGridViewTextBoxColumn";
            this.koltukSayısıDataGridViewTextBoxColumn.Width = 125;
            // 
            // busMarkaDataGridViewTextBoxColumn
            // 
            this.busMarkaDataGridViewTextBoxColumn.DataPropertyName = "BusMarka";
            this.busMarkaDataGridViewTextBoxColumn.HeaderText = "BusMarka";
            this.busMarkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busMarkaDataGridViewTextBoxColumn.Name = "busMarkaDataGridViewTextBoxColumn";
            this.busMarkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // doluKoltukSayısıDataGridViewTextBoxColumn
            // 
            this.doluKoltukSayısıDataGridViewTextBoxColumn.DataPropertyName = "DoluKoltukSayısı";
            this.doluKoltukSayısıDataGridViewTextBoxColumn.HeaderText = "DoluKoltukSayısı";
            this.doluKoltukSayısıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doluKoltukSayısıDataGridViewTextBoxColumn.Name = "doluKoltukSayısıDataGridViewTextBoxColumn";
            this.doluKoltukSayısıDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferBindingSource
            // 
            this.seferBindingSource.DataMember = "Sefer";
            this.seferBindingSource.DataSource = this.fRKTPTURDataSet;
            // 
            // seferTableAdapter
            // 
            this.seferTableAdapter.ClearBeforeFill = true;
            // 
            // seferIDDataGridViewTextBoxColumn1
            // 
            this.seferIDDataGridViewTextBoxColumn1.DataPropertyName = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn1.HeaderText = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.seferIDDataGridViewTextBoxColumn1.Name = "seferIDDataGridViewTextBoxColumn1";
            this.seferIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.seferIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // busIDDataGridViewTextBoxColumn1
            // 
            this.busIDDataGridViewTextBoxColumn1.DataPropertyName = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn1.HeaderText = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.busIDDataGridViewTextBoxColumn1.Name = "busIDDataGridViewTextBoxColumn1";
            this.busIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sehirIDDataGridViewTextBoxColumn
            // 
            this.sehirIDDataGridViewTextBoxColumn.DataPropertyName = "Sehir_ID";
            this.sehirIDDataGridViewTextBoxColumn.HeaderText = "Sehir_ID";
            this.sehirIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirIDDataGridViewTextBoxColumn.Name = "sehirIDDataGridViewTextBoxColumn";
            this.sehirIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rotaDataGridViewTextBoxColumn
            // 
            this.rotaDataGridViewTextBoxColumn.DataPropertyName = "Rota";
            this.rotaDataGridViewTextBoxColumn.HeaderText = "Rota";
            this.rotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rotaDataGridViewTextBoxColumn.Name = "rotaDataGridViewTextBoxColumn";
            this.rotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // otobüsBindingSource
            // 
            this.otobüsBindingSource.DataMember = "Otobüs";
            this.otobüsBindingSource.DataSource = this.fRKTPTURDataSet;
            // 
            // otobüsTableAdapter
            // 
            this.otobüsTableAdapter.ClearBeforeFill = true;
            // 
            // busIDDataGridViewTextBoxColumn2
            // 
            this.busIDDataGridViewTextBoxColumn2.DataPropertyName = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn2.HeaderText = "Bus_ID";
            this.busIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.busIDDataGridViewTextBoxColumn2.Name = "busIDDataGridViewTextBoxColumn2";
            this.busIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.busIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // subeIDDataGridViewTextBoxColumn1
            // 
            this.subeIDDataGridViewTextBoxColumn1.DataPropertyName = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn1.HeaderText = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn1.Name = "subeIDDataGridViewTextBoxColumn1";
            this.subeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // seferIDDataGridViewTextBoxColumn2
            // 
            this.seferIDDataGridViewTextBoxColumn2.DataPropertyName = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn2.HeaderText = "Sefer_ID";
            this.seferIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.seferIDDataGridViewTextBoxColumn2.Name = "seferIDDataGridViewTextBoxColumn2";
            this.seferIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn1
            // 
            this.plakaDataGridViewTextBoxColumn1.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn1.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn1.Name = "plakaDataGridViewTextBoxColumn1";
            this.plakaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // koltukSayısıDataGridViewTextBoxColumn1
            // 
            this.koltukSayısıDataGridViewTextBoxColumn1.DataPropertyName = "KoltukSayısı";
            this.koltukSayısıDataGridViewTextBoxColumn1.HeaderText = "KoltukSayısı";
            this.koltukSayısıDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.koltukSayısıDataGridViewTextBoxColumn1.Name = "koltukSayısıDataGridViewTextBoxColumn1";
            this.koltukSayısıDataGridViewTextBoxColumn1.Width = 125;
            // 
            // busMarkaDataGridViewTextBoxColumn1
            // 
            this.busMarkaDataGridViewTextBoxColumn1.DataPropertyName = "BusMarka";
            this.busMarkaDataGridViewTextBoxColumn1.HeaderText = "BusMarka";
            this.busMarkaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.busMarkaDataGridViewTextBoxColumn1.Name = "busMarkaDataGridViewTextBoxColumn1";
            this.busMarkaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-1, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subeler:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn2,
            this.sehirIDDataGridViewTextBoxColumn1,
            this.subeAdDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.subelerBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 511);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(426, 181);
            this.dataGridView4.TabIndex = 8;
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.fRKTPTURDataSet;
            // 
            // subelerTableAdapter
            // 
            this.subelerTableAdapter.ClearBeforeFill = true;
            // 
            // subeIDDataGridViewTextBoxColumn2
            // 
            this.subeIDDataGridViewTextBoxColumn2.DataPropertyName = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn2.HeaderText = "Sube_ID";
            this.subeIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn2.Name = "subeIDDataGridViewTextBoxColumn2";
            this.subeIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.subeIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // sehirIDDataGridViewTextBoxColumn1
            // 
            this.sehirIDDataGridViewTextBoxColumn1.DataPropertyName = "Sehir_ID";
            this.sehirIDDataGridViewTextBoxColumn1.HeaderText = "Sehir_ID";
            this.sehirIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sehirIDDataGridViewTextBoxColumn1.Name = "sehirIDDataGridViewTextBoxColumn1";
            this.sehirIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subeAdDataGridViewTextBoxColumn
            // 
            this.subeAdDataGridViewTextBoxColumn.DataPropertyName = "SubeAd";
            this.subeAdDataGridViewTextBoxColumn.HeaderText = "SubeAd";
            this.subeAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeAdDataGridViewTextBoxColumn.Name = "subeAdDataGridViewTextBoxColumn";
            this.subeAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRKTPTURDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRKTPTURDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSeferIptalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobüsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FRKTPTURDataSet fRKTPTURDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private FRKTPTURDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private FRKTPTURDataSet1 fRKTPTURDataSet1;
        private System.Windows.Forms.BindingSource spSeferIptalBindingSource;
        private FRKTPTURDataSet1TableAdapters.sp_SeferIptalTableAdapter sp_SeferIptalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doluKoltukSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seferBindingSource;
        private FRKTPTURDataSetTableAdapters.SeferTableAdapter seferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource otobüsBindingSource;
        private FRKTPTURDataSetTableAdapters.OtobüsTableAdapter otobüsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn busIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukSayısıDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn busMarkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private FRKTPTURDataSetTableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdDataGridViewTextBoxColumn;
    }
}