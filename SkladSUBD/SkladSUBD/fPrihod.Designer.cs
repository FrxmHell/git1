namespace SkladSUBD
{
    partial class fPrihod
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
            System.Windows.Forms.Label datapolucheniyaLabel;
            System.Windows.Forms.Label nakladnayaLabel;
            System.Windows.Forms.Label kolichestvoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.bsТовар = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.TovariTableAdapter();
            this.bsПриход = new System.Windows.Forms.BindingSource(this.components);
            this.prihodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PrihodTableAdapter();
            this.bsСотрудник = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.SotrudnikiTableAdapter();
            this.bsПоставщик = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.PostavshikiTableAdapter();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            this.datapolucheniyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nakladnayaTextBox = new System.Windows.Forms.TextBox();
            this.kolichestvoTextBox = new System.Windows.Forms.TextBox();
            this.cbPostavshik = new System.Windows.Forms.ComboBox();
            this.cbTovar = new System.Windows.Forms.ComboBox();
            this.cbStuff = new System.Windows.Forms.ComboBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            datapolucheniyaLabel = new System.Windows.Forms.Label();
            nakladnayaLabel = new System.Windows.Forms.Label();
            kolichestvoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщик)).BeginInit();
            this.SuspendLayout();
            // 
            // datapolucheniyaLabel
            // 
            datapolucheniyaLabel.AutoSize = true;
            datapolucheniyaLabel.Location = new System.Drawing.Point(311, 101);
            datapolucheniyaLabel.Name = "datapolucheniyaLabel";
            datapolucheniyaLabel.Size = new System.Drawing.Size(91, 13);
            datapolucheniyaLabel.TabIndex = 0;
            datapolucheniyaLabel.Text = "Дата получения:";
            // 
            // nakladnayaLabel
            // 
            nakladnayaLabel.AutoSize = true;
            nakladnayaLabel.Location = new System.Drawing.Point(9, 188);
            nakladnayaLabel.Name = "nakladnayaLabel";
            nakladnayaLabel.Size = new System.Drawing.Size(101, 13);
            nakladnayaLabel.TabIndex = 2;
            nakladnayaLabel.Text = "Номер накладной:";
            // 
            // kolichestvoLabel
            // 
            kolichestvoLabel.AutoSize = true;
            kolichestvoLabel.Location = new System.Drawing.Point(311, 188);
            kolichestvoLabel.Name = "kolichestvoLabel";
            kolichestvoLabel.Size = new System.Drawing.Size(69, 13);
            kolichestvoLabel.TabIndex = 4;
            kolichestvoLabel.Text = "Количество:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 13);
            label1.TabIndex = 9;
            label1.Text = "Выберите поставщика:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(311, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 13);
            label2.TabIndex = 10;
            label2.Text = "Выберите название товара:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(234, 13);
            label3.TabIndex = 13;
            label3.Text = "Выберите сотрудника принимающего товар:";
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
            // bsПриход
            // 
            this.bsПриход.DataMember = "Prihod";
            this.bsПриход.DataSource = this.skladDataSet1;
            // 
            // prihodTableAdapter
            // 
            this.prihodTableAdapter.ClearBeforeFill = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.PrihodTableAdapter = this.prihodTableAdapter;
            this.tableAdapterManager.RashodTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = this.sotrudnikiTableAdapter;
            this.tableAdapterManager.TovariTableAdapter = this.tovariTableAdapter;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datapolucheniyaDateTimePicker
            // 
            this.datapolucheniyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsПриход, "datapolucheniya", true));
            this.datapolucheniyaDateTimePicker.Location = new System.Drawing.Point(314, 130);
            this.datapolucheniyaDateTimePicker.Name = "datapolucheniyaDateTimePicker";
            this.datapolucheniyaDateTimePicker.Size = new System.Drawing.Size(262, 20);
            this.datapolucheniyaDateTimePicker.TabIndex = 1;
            // 
            // nakladnayaTextBox
            // 
            this.nakladnayaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПриход, "nakladnaya", true));
            this.nakladnayaTextBox.Location = new System.Drawing.Point(116, 185);
            this.nakladnayaTextBox.Name = "nakladnayaTextBox";
            this.nakladnayaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nakladnayaTextBox.TabIndex = 3;
            // 
            // kolichestvoTextBox
            // 
            this.kolichestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПриход, "kolichestvo", true));
            this.kolichestvoTextBox.Location = new System.Drawing.Point(381, 185);
            this.kolichestvoTextBox.Name = "kolichestvoTextBox";
            this.kolichestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvoTextBox.TabIndex = 5;
            // 
            // cbPostavshik
            // 
            this.cbPostavshik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsПоставщик, "idpostavshik", true));
            this.cbPostavshik.DataSource = this.bsПоставщик;
            this.cbPostavshik.DisplayMember = "namepostavshik";
            this.cbPostavshik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostavshik.FormattingEnabled = true;
            this.cbPostavshik.Location = new System.Drawing.Point(12, 50);
            this.cbPostavshik.Name = "cbPostavshik";
            this.cbPostavshik.Size = new System.Drawing.Size(262, 21);
            this.cbPostavshik.TabIndex = 6;
            // 
            // cbTovar
            // 
            this.cbTovar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовар, "idtovara", true));
            this.cbTovar.DataSource = this.bsТовар;
            this.cbTovar.DisplayMember = "nametovara";
            this.cbTovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTovar.FormattingEnabled = true;
            this.cbTovar.Location = new System.Drawing.Point(314, 50);
            this.cbTovar.Name = "cbTovar";
            this.cbTovar.Size = new System.Drawing.Size(262, 21);
            this.cbTovar.TabIndex = 11;
            // 
            // cbStuff
            // 
            this.cbStuff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудник, "idsotrudnika", true));
            this.cbStuff.DataSource = this.bsСотрудник;
            this.cbStuff.DisplayMember = "fio";
            this.cbStuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStuff.FormattingEnabled = true;
            this.cbStuff.Location = new System.Drawing.Point(12, 129);
            this.cbStuff.Name = "cbStuff";
            this.cbStuff.Size = new System.Drawing.Size(262, 21);
            this.cbStuff.TabIndex = 12;
            // 
            // bAccept
            // 
            this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAccept.Location = new System.Drawing.Point(47, 254);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(153, 23);
            this.bAccept.TabIndex = 14;
            this.bAccept.Text = "Принять товар";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(396, 254);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(162, 23);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // fPrihod
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(611, 289);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbStuff);
            this.Controls.Add(this.cbTovar);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbPostavshik);
            this.Controls.Add(kolichestvoLabel);
            this.Controls.Add(this.kolichestvoTextBox);
            this.Controls.Add(nakladnayaLabel);
            this.Controls.Add(this.nakladnayaTextBox);
            this.Controls.Add(datapolucheniyaLabel);
            this.Controls.Add(this.datapolucheniyaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPrihod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Получение товара";
            this.Load += new System.EventHandler(this.fPrihod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПриход)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsПоставщик)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsТовар;
        private SkladDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.BindingSource bsПриход;
        private SkladDataSetTableAdapters.PrihodTableAdapter prihodTableAdapter;
        private System.Windows.Forms.BindingSource bsСотрудник;
        private SkladDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource bsПоставщик;
        private SkladDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker datapolucheniyaDateTimePicker;
        private System.Windows.Forms.TextBox nakladnayaTextBox;
        private System.Windows.Forms.TextBox kolichestvoTextBox;
        private System.Windows.Forms.ComboBox cbPostavshik;
        private System.Windows.Forms.ComboBox cbTovar;
        private System.Windows.Forms.ComboBox cbStuff;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
    }
}