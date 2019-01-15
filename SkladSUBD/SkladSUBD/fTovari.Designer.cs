namespace SkladSUBD
{
    partial class fTovari
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
            System.Windows.Forms.Label nametovaraLabel;
            System.Windows.Forms.Label edizmerLabel;
            System.Windows.Forms.Label kolichestvoLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label primechanieLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.bsТовары = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.TovariTableAdapter();
            this.nametovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsПриходТовары = new System.Windows.Forms.BindingSource(this.components);
            this.prihodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PrihodTableAdapter();
            this.bsРасходТовары = new System.Windows.Forms.BindingSource(this.components);
            this.rashodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.RashodTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            this.nametovaraTextBox = new System.Windows.Forms.TextBox();
            this.edizmerTextBox = new System.Windows.Forms.TextBox();
            this.kolichestvoTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.primechanieTextBox = new System.Windows.Forms.TextBox();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bDelCurrent = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            nametovaraLabel = new System.Windows.Forms.Label();
            edizmerLabel = new System.Windows.Forms.Label();
            kolichestvoLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            primechanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовары)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриходТовары)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасходТовары)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nametovaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsТовары;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsТовары
            // 
            this.bsТовары.DataMember = "Tovari";
            this.bsТовары.DataSource = this.skladDataSet1;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // nametovaraDataGridViewTextBoxColumn
            // 
            this.nametovaraDataGridViewTextBoxColumn.DataPropertyName = "nametovara";
            this.nametovaraDataGridViewTextBoxColumn.HeaderText = "Список товаров";
            this.nametovaraDataGridViewTextBoxColumn.Name = "nametovaraDataGridViewTextBoxColumn";
            this.nametovaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nametovaraDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsПриходТовары
            // 
            this.bsПриходТовары.DataMember = "TovariPrihod";
            this.bsПриходТовары.DataSource = this.bsТовары;
            // 
            // prihodTableAdapter
            // 
            this.prihodTableAdapter.ClearBeforeFill = true;
            // 
            // bsРасходТовары
            // 
            this.bsРасходТовары.DataMember = "TovariRashod";
            this.bsРасходТовары.DataSource = this.bsТовары;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDelCurrent);
            this.groupBox1.Controls.Add(this.bAddNew);
            this.groupBox1.Controls.Add(primechanieLabel);
            this.groupBox1.Controls.Add(this.primechanieTextBox);
            this.groupBox1.Controls.Add(cenaLabel);
            this.groupBox1.Controls.Add(this.cenaTextBox);
            this.groupBox1.Controls.Add(kolichestvoLabel);
            this.groupBox1.Controls.Add(this.kolichestvoTextBox);
            this.groupBox1.Controls.Add(edizmerLabel);
            this.groupBox1.Controls.Add(this.edizmerTextBox);
            this.groupBox1.Controls.Add(nametovaraLabel);
            this.groupBox1.Controls.Add(this.nametovaraTextBox);
            this.groupBox1.Location = new System.Drawing.Point(262, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PrihodTableAdapter = this.prihodTableAdapter;
            this.tableAdapterManager.RashodTableAdapter = this.rashodTableAdapter;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.TovariTableAdapter = this.tovariTableAdapter;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nametovaraLabel
            // 
            nametovaraLabel.AutoSize = true;
            nametovaraLabel.Location = new System.Drawing.Point(6, 25);
            nametovaraLabel.Name = "nametovaraLabel";
            nametovaraLabel.Size = new System.Drawing.Size(98, 13);
            nametovaraLabel.TabIndex = 0;
            nametovaraLabel.Text = "Название товара:";
            // 
            // nametovaraTextBox
            // 
            this.nametovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовары, "nametovara", true));
            this.nametovaraTextBox.Location = new System.Drawing.Point(110, 22);
            this.nametovaraTextBox.Name = "nametovaraTextBox";
            this.nametovaraTextBox.Size = new System.Drawing.Size(255, 20);
            this.nametovaraTextBox.TabIndex = 1;
            // 
            // edizmerLabel
            // 
            edizmerLabel.AutoSize = true;
            edizmerLabel.Location = new System.Drawing.Point(6, 61);
            edizmerLabel.Name = "edizmerLabel";
            edizmerLabel.Size = new System.Drawing.Size(112, 13);
            edizmerLabel.TabIndex = 2;
            edizmerLabel.Text = "Единица измерения:";
            // 
            // edizmerTextBox
            // 
            this.edizmerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовары, "edizmer", true));
            this.edizmerTextBox.Location = new System.Drawing.Point(119, 58);
            this.edizmerTextBox.Name = "edizmerTextBox";
            this.edizmerTextBox.Size = new System.Drawing.Size(246, 20);
            this.edizmerTextBox.TabIndex = 3;
            // 
            // kolichestvoLabel
            // 
            kolichestvoLabel.AutoSize = true;
            kolichestvoLabel.Location = new System.Drawing.Point(6, 94);
            kolichestvoLabel.Name = "kolichestvoLabel";
            kolichestvoLabel.Size = new System.Drawing.Size(69, 13);
            kolichestvoLabel.TabIndex = 4;
            kolichestvoLabel.Text = "Количество:";
            // 
            // kolichestvoTextBox
            // 
            this.kolichestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовары, "kolichestvo", true));
            this.kolichestvoTextBox.Location = new System.Drawing.Point(78, 91);
            this.kolichestvoTextBox.Name = "kolichestvoTextBox";
            this.kolichestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvoTextBox.TabIndex = 5;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(185, 94);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(36, 13);
            cenaLabel.TabIndex = 6;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовары, "cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(227, 91);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(138, 20);
            this.cenaTextBox.TabIndex = 7;
            // 
            // primechanieLabel
            // 
            primechanieLabel.AutoSize = true;
            primechanieLabel.Location = new System.Drawing.Point(8, 137);
            primechanieLabel.Name = "primechanieLabel";
            primechanieLabel.Size = new System.Drawing.Size(73, 13);
            primechanieLabel.TabIndex = 8;
            primechanieLabel.Text = "Примечание:";
            // 
            // primechanieTextBox
            // 
            this.primechanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовары, "primechanie", true));
            this.primechanieTextBox.Location = new System.Drawing.Point(87, 134);
            this.primechanieTextBox.Name = "primechanieTextBox";
            this.primechanieTextBox.Size = new System.Drawing.Size(278, 20);
            this.primechanieTextBox.TabIndex = 9;
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(11, 249);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(147, 23);
            this.bAddNew.TabIndex = 10;
            this.bAddNew.Text = "Добавить новый товар";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bDelCurrent
            // 
            this.bDelCurrent.Location = new System.Drawing.Point(218, 249);
            this.bDelCurrent.Name = "bDelCurrent";
            this.bDelCurrent.Size = new System.Drawing.Size(147, 23);
            this.bDelCurrent.TabIndex = 11;
            this.bDelCurrent.Text = "Удалить этот товар";
            this.bDelCurrent.UseVisualStyleBackColor = true;
            this.bDelCurrent.Click += new System.EventHandler(this.bDelCurrent_Click);
            // 
            // bSave
            // 
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Location = new System.Drawing.Point(43, 301);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(138, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(480, 301);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(138, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // fTovari
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(645, 333);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTovari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.fTovari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовары)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриходТовары)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасходТовары)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsТовары;
        private SkladDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsПриходТовары;
        private SkladDataSetTableAdapters.PrihodTableAdapter prihodTableAdapter;
        private System.Windows.Forms.BindingSource bsРасходТовары;
        private SkladDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDelCurrent;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.TextBox primechanieTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox kolichestvoTextBox;
        private System.Windows.Forms.TextBox edizmerTextBox;
        private System.Windows.Forms.TextBox nametovaraTextBox;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
    }
}