namespace SkladSUBD
{
    partial class fMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPostavschiki = new System.Windows.Forms.ToolStripButton();
            this.tsbKlienty = new System.Windows.Forms.ToolStripButton();
            this.tsbSotrudniki = new System.Windows.Forms.ToolStripButton();
            this.tsbTovar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGetTovar = new System.Windows.Forms.ToolStripButton();
            this.tsbIssueTovar = new System.Windows.Forms.ToolStripButton();
            this.tsbList = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nametovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edizmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primechanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsТовар = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet1 = new SkladSUBD.SkladDataSet();
            this.tovariTableAdapter = new SkladSUBD.SkladDataSetTableAdapters.TovariTableAdapter();
            this.просмотрИРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движениеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПолученйИВыдачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPostavschiki,
            this.tsbKlienty,
            this.tsbSotrudniki,
            this.tsbTovar,
            this.toolStripSeparator1,
            this.tsbGetTovar,
            this.tsbIssueTovar,
            this.tsbList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPostavschiki
            // 
            this.tsbPostavschiki.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPostavschiki.Image = global::SkladSUBD.Properties.Resources.postavshiki;
            this.tsbPostavschiki.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPostavschiki.Name = "tsbPostavschiki";
            this.tsbPostavschiki.Size = new System.Drawing.Size(28, 28);
            this.tsbPostavschiki.Text = "Поставщики";
            this.tsbPostavschiki.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // tsbKlienty
            // 
            this.tsbKlienty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKlienty.Image = global::SkladSUBD.Properties.Resources.Клиенты;
            this.tsbKlienty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKlienty.Name = "tsbKlienty";
            this.tsbKlienty.Size = new System.Drawing.Size(28, 28);
            this.tsbKlienty.Text = "Клиенты";
            this.tsbKlienty.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // tsbSotrudniki
            // 
            this.tsbSotrudniki.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSotrudniki.Image = global::SkladSUBD.Properties.Resources.Сотрудники;
            this.tsbSotrudniki.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSotrudniki.Name = "tsbSotrudniki";
            this.tsbSotrudniki.Size = new System.Drawing.Size(28, 28);
            this.tsbSotrudniki.Text = "Сотрудники";
            this.tsbSotrudniki.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // tsbTovar
            // 
            this.tsbTovar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTovar.Image = global::SkladSUBD.Properties.Resources.Товар;
            this.tsbTovar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTovar.Name = "tsbTovar";
            this.tsbTovar.Size = new System.Drawing.Size(28, 28);
            this.tsbTovar.Text = "Товары";
            this.tsbTovar.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbGetTovar
            // 
            this.tsbGetTovar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGetTovar.Image = global::SkladSUBD.Properties.Resources.Получить_товар;
            this.tsbGetTovar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetTovar.Name = "tsbGetTovar";
            this.tsbGetTovar.Size = new System.Drawing.Size(28, 28);
            this.tsbGetTovar.Text = "Получить товар";
            this.tsbGetTovar.Click += new System.EventHandler(this.получитьТоварToolStripMenuItem_Click);
            // 
            // tsbIssueTovar
            // 
            this.tsbIssueTovar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIssueTovar.Image = global::SkladSUBD.Properties.Resources.Выдать_товар;
            this.tsbIssueTovar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIssueTovar.Name = "tsbIssueTovar";
            this.tsbIssueTovar.Size = new System.Drawing.Size(28, 28);
            this.tsbIssueTovar.Text = "Выдать товар";
            this.tsbIssueTovar.Click += new System.EventHandler(this.выдатьТоварToolStripMenuItem_Click);
            // 
            // tsbList
            // 
            this.tsbList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbList.Image = global::SkladSUBD.Properties.Resources.Список_получений_и_выдачи;
            this.tsbList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbList.Name = "tsbList";
            this.tsbList.Size = new System.Drawing.Size(28, 28);
            this.tsbList.Text = "Список получений и выдачи";
            this.tsbList.Click += new System.EventHandler(this.списокПолученйИВыдачиToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nametovaraDataGridViewTextBoxColumn,
            this.edizmerDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kolichestvoDataGridViewTextBoxColumn,
            this.primechanieDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsТовар;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 59);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(992, 373);
            this.dgv.TabIndex = 2;
            // 
            // nametovaraDataGridViewTextBoxColumn
            // 
            this.nametovaraDataGridViewTextBoxColumn.DataPropertyName = "nametovara";
            this.nametovaraDataGridViewTextBoxColumn.HeaderText = "Название товара";
            this.nametovaraDataGridViewTextBoxColumn.Name = "nametovaraDataGridViewTextBoxColumn";
            this.nametovaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nametovaraDataGridViewTextBoxColumn.Width = 200;
            // 
            // edizmerDataGridViewTextBoxColumn
            // 
            this.edizmerDataGridViewTextBoxColumn.DataPropertyName = "edizmer";
            this.edizmerDataGridViewTextBoxColumn.HeaderText = "Ед. измер.";
            this.edizmerDataGridViewTextBoxColumn.Name = "edizmerDataGridViewTextBoxColumn";
            this.edizmerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolichestvoDataGridViewTextBoxColumn
            // 
            this.kolichestvoDataGridViewTextBoxColumn.DataPropertyName = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.kolichestvoDataGridViewTextBoxColumn.Name = "kolichestvoDataGridViewTextBoxColumn";
            this.kolichestvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primechanieDataGridViewTextBoxColumn
            // 
            this.primechanieDataGridViewTextBoxColumn.DataPropertyName = "primechanie";
            this.primechanieDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.primechanieDataGridViewTextBoxColumn.Name = "primechanieDataGridViewTextBoxColumn";
            this.primechanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.primechanieDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsТовар
            // 
            this.bsТовар.DataMember = "Tovari";
            this.bsТовар.DataSource = this.skladDataSet1;
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "SkladDataSet";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // просмотрИРедактированиеToolStripMenuItem
            // 
            this.просмотрИРедактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.товарToolStripMenuItem});
            this.просмотрИРедактированиеToolStripMenuItem.Name = "просмотрИРедактированиеToolStripMenuItem";
            this.просмотрИРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.просмотрИРедактированиеToolStripMenuItem.Text = "Просмотр и редактирование";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.postavshiki;
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.поставщикиToolStripMenuItem.Text = "Поставщики...";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Клиенты;
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.клиентыToolStripMenuItem.Text = "Клиенты...";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Сотрудники;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники...";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Товар;
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.товарToolStripMenuItem.Text = "Товар...";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // движениеТовараToolStripMenuItem
            // 
            this.движениеТовараToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьТоварToolStripMenuItem,
            this.выдатьТоварToolStripMenuItem,
            this.списокПолученйИВыдачиToolStripMenuItem});
            this.движениеТовараToolStripMenuItem.Name = "движениеТовараToolStripMenuItem";
            this.движениеТовараToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.движениеТовараToolStripMenuItem.Text = "Движение товара";
            // 
            // получитьТоварToolStripMenuItem
            // 
            this.получитьТоварToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Получить_товар;
            this.получитьТоварToolStripMenuItem.Name = "получитьТоварToolStripMenuItem";
            this.получитьТоварToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.получитьТоварToolStripMenuItem.Text = "Получить товар...";
            this.получитьТоварToolStripMenuItem.Click += new System.EventHandler(this.получитьТоварToolStripMenuItem_Click);
            // 
            // выдатьТоварToolStripMenuItem
            // 
            this.выдатьТоварToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Выдать_товар;
            this.выдатьТоварToolStripMenuItem.Name = "выдатьТоварToolStripMenuItem";
            this.выдатьТоварToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.выдатьТоварToolStripMenuItem.Text = "Выдать товар...";
            this.выдатьТоварToolStripMenuItem.Click += new System.EventHandler(this.выдатьТоварToolStripMenuItem_Click);
            // 
            // списокПолученйИВыдачиToolStripMenuItem
            // 
            this.списокПолученйИВыдачиToolStripMenuItem.Image = global::SkladSUBD.Properties.Resources.Список_получений_и_выдачи;
            this.списокПолученйИВыдачиToolStripMenuItem.Name = "списокПолученйИВыдачиToolStripMenuItem";
            this.списокПолученйИВыдачиToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.списокПолученйИВыдачиToolStripMenuItem.Text = "Список получений и выдачи...";
            this.списокПолученйИВыдачиToolStripMenuItem.Click += new System.EventHandler(this.списокПолученйИВыдачиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрИРедактированиеToolStripMenuItem,
            this.движениеТовараToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 432);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Склад";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsТовар)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv;
        private SkladDataSet skladDataSet1;
        private System.Windows.Forms.BindingSource bsТовар;
        private SkladDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbPostavschiki;
        private System.Windows.Forms.ToolStripButton tsbKlienty;
        private System.Windows.Forms.ToolStripButton tsbSotrudniki;
        private System.Windows.Forms.ToolStripButton tsbTovar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGetTovar;
        private System.Windows.Forms.ToolStripButton tsbIssueTovar;
        private System.Windows.Forms.ToolStripButton tsbList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edizmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primechanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem просмотрИРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движениеТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдатьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПолученйИВыдачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}

