namespace SkladSUBD
{
    partial class fPostavshiki
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
            System.Windows.Forms.Label namepostavshikLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label domLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label primechanieLabel;
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.bsПоставщики = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PostavshikiTableAdapter();
            this.bsПриход = new System.Windows.Forms.BindingSource(this.components);
            this.prihodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PrihodTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namepostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bDelCurrent = new System.Windows.Forms.Button();
            this.bAddNew = new System.Windows.Forms.Button();
            this.primechanieTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.namepostavshikTextBox = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            namepostavshikLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            primechanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщики)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namepostavshikLabel
            // 
            namepostavshikLabel.AutoSize = true;
            namepostavshikLabel.Location = new System.Drawing.Point(6, 16);
            namepostavshikLabel.Name = "namepostavshikLabel";
            namepostavshikLabel.Size = new System.Drawing.Size(151, 13);
            namepostavshikLabel.TabIndex = 0;
            namepostavshikLabel.Text = "Наименование поставщика:";
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(5, 66);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(40, 13);
            gorodLabel.TabIndex = 2;
            gorodLabel.Text = "Город:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(5, 94);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(42, 13);
            ulicaLabel.TabIndex = 4;
            ulicaLabel.Text = "Улица:";
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(245, 94);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(33, 13);
            domLabel.TabIndex = 6;
            domLabel.Text = "Дом:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(5, 124);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(55, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Телефон:";
            // 
            // primechanieLabel
            // 
            primechanieLabel.AutoSize = true;
            primechanieLabel.Location = new System.Drawing.Point(5, 156);
            primechanieLabel.Name = "primechanieLabel";
            primechanieLabel.Size = new System.Drawing.Size(73, 13);
            primechanieLabel.TabIndex = 14;
            primechanieLabel.Text = "Примечание:";
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsПоставщики
            // 
            this.bsПоставщики.DataMember = "Postavshiki";
            this.bsПоставщики.DataSource = this.skladDataSet1;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // bsПриход
            // 
            this.bsПриход.DataMember = "PostavshikiPrihod";
            this.bsПриход.DataSource = this.bsПоставщики;
            // 
            // prihodTableAdapter
            // 
            this.prihodTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namepostavshikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsПоставщики;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // namepostavshikDataGridViewTextBoxColumn
            // 
            this.namepostavshikDataGridViewTextBoxColumn.DataPropertyName = "namepostavshik";
            this.namepostavshikDataGridViewTextBoxColumn.HeaderText = "Список поставщиков";
            this.namepostavshikDataGridViewTextBoxColumn.Name = "namepostavshikDataGridViewTextBoxColumn";
            this.namepostavshikDataGridViewTextBoxColumn.ReadOnly = true;
            this.namepostavshikDataGridViewTextBoxColumn.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bDelCurrent);
            this.groupBox1.Controls.Add(this.bAddNew);
            this.groupBox1.Controls.Add(primechanieLabel);
            this.groupBox1.Controls.Add(this.primechanieTextBox);
            this.groupBox1.Controls.Add(telefonLabel);
            this.groupBox1.Controls.Add(this.telefonTextBox);
            this.groupBox1.Controls.Add(domLabel);
            this.groupBox1.Controls.Add(this.domTextBox);
            this.groupBox1.Controls.Add(ulicaLabel);
            this.groupBox1.Controls.Add(this.ulicaTextBox);
            this.groupBox1.Controls.Add(gorodLabel);
            this.groupBox1.Controls.Add(this.gorodTextBox);
            this.groupBox1.Controls.Add(namepostavshikLabel);
            this.groupBox1.Controls.Add(this.namepostavshikTextBox);
            this.groupBox1.Location = new System.Drawing.Point(262, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bDelCurrent
            // 
            this.bDelCurrent.Location = new System.Drawing.Point(189, 207);
            this.bDelCurrent.Name = "bDelCurrent";
            this.bDelCurrent.Size = new System.Drawing.Size(173, 23);
            this.bDelCurrent.TabIndex = 17;
            this.bDelCurrent.Text = "Удалить этого поставщика";
            this.bDelCurrent.UseVisualStyleBackColor = true;
            this.bDelCurrent.Click += new System.EventHandler(this.bDelCurrent_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(9, 207);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(173, 23);
            this.bAddNew.TabIndex = 16;
            this.bAddNew.Text = "Добавить нового поставщика";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // primechanieTextBox
            // 
            this.primechanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "primechanie", true));
            this.primechanieTextBox.Location = new System.Drawing.Point(84, 153);
            this.primechanieTextBox.Name = "primechanieTextBox";
            this.primechanieTextBox.Size = new System.Drawing.Size(278, 20);
            this.primechanieTextBox.TabIndex = 15;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(66, 121);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(157, 20);
            this.telefonTextBox.TabIndex = 13;
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "dom", true));
            this.domTextBox.Location = new System.Drawing.Point(281, 91);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(79, 20);
            this.domTextBox.TabIndex = 7;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(49, 91);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(190, 20);
            this.ulicaTextBox.TabIndex = 5;
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(49, 63);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(313, 20);
            this.gorodTextBox.TabIndex = 3;
            // 
            // namepostavshikTextBox
            // 
            this.namepostavshikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщики, "namepostavshik", true));
            this.namepostavshikTextBox.Location = new System.Drawing.Point(8, 34);
            this.namepostavshikTextBox.Name = "namepostavshikTextBox";
            this.namepostavshikTextBox.Size = new System.Drawing.Size(354, 20);
            this.namepostavshikTextBox.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Location = new System.Drawing.Point(12, 250);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(141, 23);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(492, 250);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(141, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.PrihodTableAdapter = this.prihodTableAdapter;
            this.tableAdapterManager.RashodTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.TovariTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fPostavshiki
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(645, 280);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPostavshiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.fPostavshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщики)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsПоставщики;
        private SkladDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.BindingSource bsПриход;
        private SkladDataSetTableAdapters.PrihodTableAdapter prihodTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox namepostavshikTextBox;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bDelCurrent;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.TextBox primechanieTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox domTextBox;
    }
}