namespace SkladSUBD
{
    partial class fStuffs
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
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label bdayLabel;
            System.Windows.Forms.Label dolzhnostLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsСотрудники = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDelCurrent = new System.Windows.Forms.Button();
            this.bAddNew = new System.Windows.Forms.Button();
            this.dolzhnostTextBox = new System.Windows.Forms.TextBox();
            this.bdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otchTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.sotrudnikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.SotrudnikiTableAdapter();
            this.bsПриход = new System.Windows.Forms.BindingSource(this.components);
            this.bsРасход = new System.Windows.Forms.BindingSource(this.components);
            this.prihodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PrihodTableAdapter();
            this.rashodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.RashodTableAdapter();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            bdayLabel = new System.Windows.Forms.Label();
            dolzhnostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудники)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(6, 16);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 0;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(6, 75);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(57, 13);
            otchLabel.TabIndex = 4;
            otchLabel.Text = "Отчество:";
            // 
            // bdayLabel
            // 
            bdayLabel.AutoSize = true;
            bdayLabel.Location = new System.Drawing.Point(6, 111);
            bdayLabel.Name = "bdayLabel";
            bdayLabel.Size = new System.Drawing.Size(89, 13);
            bdayLabel.TabIndex = 6;
            bdayLabel.Text = "Дата рождения:";
            // 
            // dolzhnostLabel
            // 
            dolzhnostLabel.AutoSize = true;
            dolzhnostLabel.Location = new System.Drawing.Point(6, 146);
            dolzhnostLabel.Name = "dolzhnostLabel";
            dolzhnostLabel.Size = new System.Drawing.Size(68, 13);
            dolzhnostLabel.TabIndex = 8;
            dolzhnostLabel.Text = "Должность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsСотрудники;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Список сотрудников";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsСотрудники
            // 
            this.bsСотрудники.DataMember = "Sotrudniki";
            this.bsСотрудники.DataSource = this.skladDataSet1;
            this.bsСотрудники.CurrentChanged += new System.EventHandler(this.bsСотрудники_CurrentChanged);
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDelCurrent);
            this.groupBox1.Controls.Add(this.bAddNew);
            this.groupBox1.Controls.Add(dolzhnostLabel);
            this.groupBox1.Controls.Add(this.dolzhnostTextBox);
            this.groupBox1.Controls.Add(bdayLabel);
            this.groupBox1.Controls.Add(this.bdayDateTimePicker);
            this.groupBox1.Controls.Add(otchLabel);
            this.groupBox1.Controls.Add(this.otchTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(famLabel);
            this.groupBox1.Controls.Add(this.famTextBox);
            this.groupBox1.Location = new System.Drawing.Point(262, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bDelCurrent
            // 
            this.bDelCurrent.Location = new System.Drawing.Point(165, 235);
            this.bDelCurrent.Name = "bDelCurrent";
            this.bDelCurrent.Size = new System.Drawing.Size(133, 37);
            this.bDelCurrent.TabIndex = 15;
            this.bDelCurrent.Text = "Удалить этого сотрудника";
            this.bDelCurrent.UseVisualStyleBackColor = true;
            this.bDelCurrent.Click += new System.EventHandler(this.bDelCurrent_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(6, 235);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(123, 37);
            this.bAddNew.TabIndex = 14;
            this.bAddNew.Text = "Добавить нового сотрудника";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // dolzhnostTextBox
            // 
            this.dolzhnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудники, "dolzhnost", true));
            this.dolzhnostTextBox.Location = new System.Drawing.Point(80, 143);
            this.dolzhnostTextBox.Name = "dolzhnostTextBox";
            this.dolzhnostTextBox.Size = new System.Drawing.Size(211, 20);
            this.dolzhnostTextBox.TabIndex = 9;
            // 
            // bdayDateTimePicker
            // 
            this.bdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsСотрудники, "bday", true));
            this.bdayDateTimePicker.Location = new System.Drawing.Point(101, 105);
            this.bdayDateTimePicker.Name = "bdayDateTimePicker";
            this.bdayDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.bdayDateTimePicker.TabIndex = 7;
            // 
            // otchTextBox
            // 
            this.otchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудники, "otch", true));
            this.otchTextBox.Location = new System.Drawing.Point(67, 72);
            this.otchTextBox.Name = "otchTextBox";
            this.otchTextBox.Size = new System.Drawing.Size(224, 20);
            this.otchTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудники, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(67, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудники, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(67, 13);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(224, 20);
            this.famTextBox.TabIndex = 1;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // bsПриход
            // 
            this.bsПриход.DataMember = "SotrudnikPrihod";
            this.bsПриход.DataSource = this.bsСотрудники;
            // 
            // bsРасход
            // 
            this.bsРасход.DataMember = "SotrudnikiRashod";
            this.bsРасход.DataSource = this.bsСотрудники;
            // 
            // prihodTableAdapter
            // 
            this.prihodTableAdapter.ClearBeforeFill = true;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PrihodTableAdapter = this.prihodTableAdapter;
            this.tableAdapterManager.RashodTableAdapter = this.rashodTableAdapter;
            this.tableAdapterManager.SotrudnikiTableAdapter = this.sotrudnikiTableAdapter;
            this.tableAdapterManager.TovariTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bSave
            // 
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Location = new System.Drawing.Point(12, 298);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(145, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCancel.Location = new System.Drawing.Point(408, 298);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(145, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // fStuffs
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(572, 333);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fStuffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.fStuffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудники)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bsСотрудники;
        private SkladDataSet skladDataSet1;
        private SkladDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsПриход;
        private System.Windows.Forms.BindingSource bsРасход;
        private SkladDataSetTableAdapters.PrihodTableAdapter prihodTableAdapter;
        private SkladDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.TextBox dolzhnostTextBox;
        private System.Windows.Forms.DateTimePicker bdayDateTimePicker;
        private System.Windows.Forms.TextBox otchTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bDelCurrent;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}