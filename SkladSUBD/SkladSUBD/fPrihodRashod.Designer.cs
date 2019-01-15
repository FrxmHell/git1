namespace SkladSUBD
{
    partial class fPrihodRashod
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
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.bsТовар = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.TovariTableAdapter();
            this.bsСотрудник = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.SotrudnikiTableAdapter();
            this.bsПоставщик = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PostavshikiTableAdapter();
            this.bsКлиент = new System.Windows.Forms.BindingSource(this.components);
            this.klientiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.KlientiTableAdapter();
            this.bsПриход = new System.Windows.Forms.BindingSource(this.components);
            this.prihodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PrihodTableAdapter();
            this.bsРасход = new System.Windows.Forms.BindingSource(this.components);
            this.rashodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.RashodTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPrihod = new System.Windows.Forms.DataGridView();
            this.dgvRashod = new System.Windows.Forms.DataGridView();
            this.idpostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idsotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nakladnayaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapolucheniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMakeNaklad = new System.Windows.Forms.Button();
            this.idklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idsotrudnikaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nakladnayaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavidachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщик)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrihod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRashod)).BeginInit();
            this.SuspendLayout();
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsТовар
            // 
            this.bsТовар.DataMember = "Tovari";
            this.bsТовар.DataSource = this.skladDataSet1;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // bsСотрудник
            // 
            this.bsСотрудник.DataMember = "Sotrudniki";
            this.bsСотрудник.DataSource = this.skladDataSet1;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // bsПоставщик
            // 
            this.bsПоставщик.DataMember = "Postavshiki";
            this.bsПоставщик.DataSource = this.skladDataSet1;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // bsКлиент
            // 
            this.bsКлиент.DataMember = "Klienti";
            this.bsКлиент.DataSource = this.skladDataSet1;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // bsПриход
            // 
            this.bsПриход.DataMember = "TovariPrihod";
            this.bsПриход.DataSource = this.bsТовар;
            // 
            // prihodTableAdapter
            // 
            this.prihodTableAdapter.ClearBeforeFill = true;
            // 
            // bsРасход
            // 
            this.bsРасход.DataMember = "TovariRashod";
            this.bsРасход.DataSource = this.bsТовар;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о получении и выдаче товара:";
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовар, "nametovara", true));
            this.lText.Location = new System.Drawing.Point(245, 18);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(47, 13);
            this.lText.TabIndex = 1;
            this.lText.Text = "textHere";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 317);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPrihod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Получение товара";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRashod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выдача товара";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPrihod
            // 
            this.dgvPrihod.AllowUserToAddRows = false;
            this.dgvPrihod.AllowUserToDeleteRows = false;
            this.dgvPrihod.AutoGenerateColumns = false;
            this.dgvPrihod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrihod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpostavshikDataGridViewTextBoxColumn,
            this.idsotrudnikaDataGridViewTextBoxColumn,
            this.nakladnayaDataGridViewTextBoxColumn,
            this.kolichestvoDataGridViewTextBoxColumn,
            this.datapolucheniyaDataGridViewTextBoxColumn});
            this.dgvPrihod.DataSource = this.bsПриход;
            this.dgvPrihod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrihod.Location = new System.Drawing.Point(3, 3);
            this.dgvPrihod.MultiSelect = false;
            this.dgvPrihod.Name = "dgvPrihod";
            this.dgvPrihod.ReadOnly = true;
            this.dgvPrihod.Size = new System.Drawing.Size(650, 285);
            this.dgvPrihod.TabIndex = 1;
            // 
            // dgvRashod
            // 
            this.dgvRashod.AllowUserToAddRows = false;
            this.dgvRashod.AllowUserToDeleteRows = false;
            this.dgvRashod.AutoGenerateColumns = false;
            this.dgvRashod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRashod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklientaDataGridViewTextBoxColumn,
            this.idsotrudnikaDataGridViewTextBoxColumn1,
            this.nakladnayaDataGridViewTextBoxColumn1,
            this.kolichestvoDataGridViewTextBoxColumn1,
            this.datavidachiDataGridViewTextBoxColumn});
            this.dgvRashod.DataSource = this.bsРасход;
            this.dgvRashod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRashod.Location = new System.Drawing.Point(3, 3);
            this.dgvRashod.MultiSelect = false;
            this.dgvRashod.Name = "dgvRashod";
            this.dgvRashod.ReadOnly = true;
            this.dgvRashod.Size = new System.Drawing.Size(650, 285);
            this.dgvRashod.TabIndex = 2;
            // 
            // idpostavshikDataGridViewTextBoxColumn
            // 
            this.idpostavshikDataGridViewTextBoxColumn.DataPropertyName = "idpostavshik";
            this.idpostavshikDataGridViewTextBoxColumn.DataSource = this.bsПоставщик;
            this.idpostavshikDataGridViewTextBoxColumn.DisplayMember = "namepostavshik";
            this.idpostavshikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idpostavshikDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.idpostavshikDataGridViewTextBoxColumn.Name = "idpostavshikDataGridViewTextBoxColumn";
            this.idpostavshikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpostavshikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpostavshikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpostavshikDataGridViewTextBoxColumn.ValueMember = "idpostavshik";
            this.idpostavshikDataGridViewTextBoxColumn.Width = 150;
            // 
            // idsotrudnikaDataGridViewTextBoxColumn
            // 
            this.idsotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "idsotrudnika";
            this.idsotrudnikaDataGridViewTextBoxColumn.DataSource = this.bsСотрудник;
            this.idsotrudnikaDataGridViewTextBoxColumn.DisplayMember = "fio";
            this.idsotrudnikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idsotrudnikaDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.idsotrudnikaDataGridViewTextBoxColumn.Name = "idsotrudnikaDataGridViewTextBoxColumn";
            this.idsotrudnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsotrudnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsotrudnikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsotrudnikaDataGridViewTextBoxColumn.ValueMember = "idsotrudnika";
            this.idsotrudnikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nakladnayaDataGridViewTextBoxColumn
            // 
            this.nakladnayaDataGridViewTextBoxColumn.DataPropertyName = "nakladnaya";
            this.nakladnayaDataGridViewTextBoxColumn.HeaderText = "Номер накладной";
            this.nakladnayaDataGridViewTextBoxColumn.Name = "nakladnayaDataGridViewTextBoxColumn";
            this.nakladnayaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolichestvoDataGridViewTextBoxColumn
            // 
            this.kolichestvoDataGridViewTextBoxColumn.DataPropertyName = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.kolichestvoDataGridViewTextBoxColumn.Name = "kolichestvoDataGridViewTextBoxColumn";
            this.kolichestvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datapolucheniyaDataGridViewTextBoxColumn
            // 
            this.datapolucheniyaDataGridViewTextBoxColumn.DataPropertyName = "datapolucheniya";
            this.datapolucheniyaDataGridViewTextBoxColumn.HeaderText = "Дата получения";
            this.datapolucheniyaDataGridViewTextBoxColumn.Name = "datapolucheniyaDataGridViewTextBoxColumn";
            this.datapolucheniyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datapolucheniyaDataGridViewTextBoxColumn.Width = 105;
            // 
            // bMakeNaklad
            // 
            this.bMakeNaklad.Location = new System.Drawing.Point(397, 13);
            this.bMakeNaklad.Name = "bMakeNaklad";
            this.bMakeNaklad.Size = new System.Drawing.Size(237, 23);
            this.bMakeNaklad.TabIndex = 3;
            this.bMakeNaklad.Text = "Сформировать накладную для получателя";
            this.bMakeNaklad.UseVisualStyleBackColor = true;
            this.bMakeNaklad.Visible = false;
            this.bMakeNaklad.Click += new System.EventHandler(this.bMakeNaklad_Click);
            // 
            // idklientaDataGridViewTextBoxColumn
            // 
            this.idklientaDataGridViewTextBoxColumn.DataPropertyName = "idklienta";
            this.idklientaDataGridViewTextBoxColumn.DataSource = this.bsКлиент;
            this.idklientaDataGridViewTextBoxColumn.DisplayMember = "nameklienta";
            this.idklientaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idklientaDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.idklientaDataGridViewTextBoxColumn.Name = "idklientaDataGridViewTextBoxColumn";
            this.idklientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idklientaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idklientaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idklientaDataGridViewTextBoxColumn.ValueMember = "idklienta";
            this.idklientaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idsotrudnikaDataGridViewTextBoxColumn1
            // 
            this.idsotrudnikaDataGridViewTextBoxColumn1.DataPropertyName = "idsotrudnika";
            this.idsotrudnikaDataGridViewTextBoxColumn1.DataSource = this.bsСотрудник;
            this.idsotrudnikaDataGridViewTextBoxColumn1.DisplayMember = "fio";
            this.idsotrudnikaDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idsotrudnikaDataGridViewTextBoxColumn1.HeaderText = "Сотрудник";
            this.idsotrudnikaDataGridViewTextBoxColumn1.Name = "idsotrudnikaDataGridViewTextBoxColumn1";
            this.idsotrudnikaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idsotrudnikaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsotrudnikaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsotrudnikaDataGridViewTextBoxColumn1.ValueMember = "idsotrudnika";
            this.idsotrudnikaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nakladnayaDataGridViewTextBoxColumn1
            // 
            this.nakladnayaDataGridViewTextBoxColumn1.DataPropertyName = "nakladnaya";
            this.nakladnayaDataGridViewTextBoxColumn1.HeaderText = "Номер накладной";
            this.nakladnayaDataGridViewTextBoxColumn1.Name = "nakladnayaDataGridViewTextBoxColumn1";
            this.nakladnayaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kolichestvoDataGridViewTextBoxColumn1
            // 
            this.kolichestvoDataGridViewTextBoxColumn1.DataPropertyName = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.kolichestvoDataGridViewTextBoxColumn1.Name = "kolichestvoDataGridViewTextBoxColumn1";
            this.kolichestvoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datavidachiDataGridViewTextBoxColumn
            // 
            this.datavidachiDataGridViewTextBoxColumn.DataPropertyName = "datavidachi";
            this.datavidachiDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.datavidachiDataGridViewTextBoxColumn.Name = "datavidachiDataGridViewTextBoxColumn";
            this.datavidachiDataGridViewTextBoxColumn.ReadOnly = true;
            this.datavidachiDataGridViewTextBoxColumn.Width = 105;
            // 
            // fPrihodRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 360);
            this.Controls.Add(this.bMakeNaklad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPrihodRashod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Получение и выдача товаров";
            this.Load += new System.EventHandler(this.fPrihodRashod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщик)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrihod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRashod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsТовар;
        private SkladDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.BindingSource bsСотрудник;
        private SkladDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource bsПоставщик;
        private SkladDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.BindingSource bsКлиент;
        private SkladDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.BindingSource bsПриход;
        private SkladDataSetTableAdapters.PrihodTableAdapter prihodTableAdapter;
        private System.Windows.Forms.BindingSource bsРасход;
        private SkladDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPrihod;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsotrudnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakladnayaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapolucheniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvRashod;
        private System.Windows.Forms.Button bMakeNaklad;
        private System.Windows.Forms.DataGridViewComboBoxColumn idklientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsotrudnikaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakladnayaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavidachiDataGridViewTextBoxColumn;
    }
}