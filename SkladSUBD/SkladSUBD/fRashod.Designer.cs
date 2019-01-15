namespace SkladSUBD
{
    partial class fRashod
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
            System.Windows.Forms.Label datavidachiLabel;
            System.Windows.Forms.Label nakladnayaLabel;
            System.Windows.Forms.Label kolichestvoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.bsКлиент = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.cbTovar = new System.Windows.Forms.ComboBox();
            this.bsТовар = new System.Windows.Forms.BindingSource(this.components);
            this.cbStuff = new System.Windows.Forms.ComboBox();
            this.bsСотрудник = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.TovariTableAdapter();
            this.bsРасход = new System.Windows.Forms.BindingSource(this.components);
            this.rashodTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.RashodTableAdapter();
            this.sotrudnikiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.SotrudnikiTableAdapter();
            this.klientiTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.KlientiTableAdapter();
            this.tableAdapterManager = new SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager();
            this.datavidachiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nakladnayaTextBox = new System.Windows.Forms.TextBox();
            this.kolichestvoTextBox = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            datavidachiLabel = new System.Windows.Forms.Label();
            nakladnayaLabel = new System.Windows.Forms.Label();
            kolichestvoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).BeginInit();
            this.SuspendLayout();
            // 
            // datavidachiLabel
            // 
            datavidachiLabel.AutoSize = true;
            datavidachiLabel.Location = new System.Drawing.Point(279, 82);
            datavidachiLabel.Name = "datavidachiLabel";
            datavidachiLabel.Size = new System.Drawing.Size(76, 13);
            datavidachiLabel.TabIndex = 6;
            datavidachiLabel.Text = "Дата выдачи:";
            // 
            // nakladnayaLabel
            // 
            nakladnayaLabel.AutoSize = true;
            nakladnayaLabel.Location = new System.Drawing.Point(12, 155);
            nakladnayaLabel.Name = "nakladnayaLabel";
            nakladnayaLabel.Size = new System.Drawing.Size(101, 13);
            nakladnayaLabel.TabIndex = 8;
            nakladnayaLabel.Text = "Номер накладной:";
            // 
            // kolichestvoLabel
            // 
            kolichestvoLabel.AutoSize = true;
            kolichestvoLabel.Location = new System.Drawing.Point(279, 155);
            kolichestvoLabel.Name = "kolichestvoLabel";
            kolichestvoLabel.Size = new System.Drawing.Size(69, 13);
            kolichestvoLabel.TabIndex = 10;
            kolichestvoLabel.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите сотрудника, выдающего товар:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите название товара:";
            // 
            // cbKlient
            // 
            this.cbKlient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsКлиент, "idklienta", true));
            this.cbKlient.DataSource = this.bsКлиент;
            this.cbKlient.DisplayMember = "nameklienta";
            this.cbKlient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(12, 41);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(227, 21);
            this.cbKlient.TabIndex = 3;
            // 
            // bsКлиент
            // 
            this.bsКлиент.DataMember = "Klienti";
            this.bsКлиент.DataSource = this.skladDataSet1;
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTovar
            // 
            this.cbTovar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsТовар, "idtovara", true));
            this.cbTovar.DataSource = this.bsТовар;
            this.cbTovar.DisplayMember = "nametovara";
            this.cbTovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTovar.FormattingEnabled = true;
            this.cbTovar.Location = new System.Drawing.Point(282, 41);
            this.cbTovar.Name = "cbTovar";
            this.cbTovar.Size = new System.Drawing.Size(227, 21);
            this.cbTovar.TabIndex = 4;
            // 
            // bsТовар
            // 
            this.bsТовар.DataMember = "Tovari";
            this.bsТовар.DataSource = this.skladDataSet1;
            // 
            // cbStuff
            // 
            this.cbStuff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsСотрудник, "idsotrudnika", true));
            this.cbStuff.DataSource = this.bsСотрудник;
            this.cbStuff.DisplayMember = "fio";
            this.cbStuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStuff.FormattingEnabled = true;
            this.cbStuff.Location = new System.Drawing.Point(12, 108);
            this.cbStuff.Name = "cbStuff";
            this.cbStuff.Size = new System.Drawing.Size(227, 21);
            this.cbStuff.TabIndex = 5;
            // 
            // bsСотрудник
            // 
            this.bsСотрудник.DataMember = "Sotrudniki";
            this.bsСотрудник.DataSource = this.skladDataSet1;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // bsРасход
            // 
            this.bsРасход.DataMember = "Rashod";
            this.bsРасход.DataSource = this.skladDataSet1;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientiTableAdapter = this.klientiTableAdapter;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PrihodTableAdapter = null;
            this.tableAdapterManager.RashodTableAdapter = this.rashodTableAdapter;
            this.tableAdapterManager.SotrudnikiTableAdapter = this.sotrudnikiTableAdapter;
            this.tableAdapterManager.TovariTableAdapter = this.tovariTableAdapter;
            this.tableAdapterManager.UpdateOrder = SkladSUBD.SkladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datavidachiDateTimePicker
            // 
            this.datavidachiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsРасход, "datavidachi", true));
            this.datavidachiDateTimePicker.Location = new System.Drawing.Point(282, 108);
            this.datavidachiDateTimePicker.Name = "datavidachiDateTimePicker";
            this.datavidachiDateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.datavidachiDateTimePicker.TabIndex = 7;
            // 
            // nakladnayaTextBox
            // 
            this.nakladnayaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsРасход, "nakladnaya", true));
            this.nakladnayaTextBox.Location = new System.Drawing.Point(119, 152);
            this.nakladnayaTextBox.Name = "nakladnayaTextBox";
            this.nakladnayaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nakladnayaTextBox.TabIndex = 9;
            // 
            // kolichestvoTextBox
            // 
            this.kolichestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsРасход, "kolichestvo", true));
            this.kolichestvoTextBox.Location = new System.Drawing.Point(354, 152);
            this.kolichestvoTextBox.Name = "kolichestvoTextBox";
            this.kolichestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvoTextBox.TabIndex = 11;
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(15, 241);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(145, 23);
            this.bAccept.TabIndex = 12;
            this.bAccept.Text = "Выдать товар";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(364, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fRashod
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(529, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(kolichestvoLabel);
            this.Controls.Add(this.kolichestvoTextBox);
            this.Controls.Add(nakladnayaLabel);
            this.Controls.Add(this.nakladnayaTextBox);
            this.Controls.Add(datavidachiLabel);
            this.Controls.Add(this.datavidachiDateTimePicker);
            this.Controls.Add(this.cbStuff);
            this.Controls.Add(this.cbTovar);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fRashod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выдача товара";
            this.Load += new System.EventHandler(this.fRashod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsКлиент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsСотрудник)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsРасход)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.ComboBox cbTovar;
        private System.Windows.Forms.ComboBox cbStuff;
        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsТовар;
        private SkladDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.BindingSource bsРасход;
        private SkladDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.BindingSource bsСотрудник;
        private SkladDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.BindingSource bsКлиент;
        private SkladDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private SkladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker datavidachiDateTimePicker;
        private System.Windows.Forms.TextBox nakladnayaTextBox;
        private System.Windows.Forms.TextBox kolichestvoTextBox;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button button1;
    }
}