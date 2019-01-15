using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace SkladSUBD
{
    public partial class fPrihodRashod : Form
    {
        public fPrihodRashod()
        {
            InitializeComponent();
        }
        public int pos;
        private void fPrihodRashod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladDataSet1.Rashod' table. You can move, or remove it, as needed.
            this.rashodTableAdapter.Fill(this.skladDataSet1.Rashod);
            // TODO: This line of code loads data into the 'skladDataSet1.Prihod' table. You can move, or remove it, as needed.
            this.prihodTableAdapter.Fill(this.skladDataSet1.Prihod);
            // TODO: This line of code loads data into the 'skladDataSet1.Klienti' table. You can move, or remove it, as needed.
            this.klientiTableAdapter.Fill(this.skladDataSet1.Klienti);
            // TODO: This line of code loads data into the 'skladDataSet1.Postavshiki' table. You can move, or remove it, as needed.
            this.postavshikiTableAdapter.Fill(this.skladDataSet1.Postavshiki);
            // TODO: This line of code loads data into the 'skladDataSet1.Sotrudniki' table. You can move, or remove it, as needed.
            this.sotrudnikiTableAdapter.Fill(this.skladDataSet1.Sotrudniki);
            // TODO: This line of code loads data into the 'skladDataSet1.Tovari' table. You can move, or remove it, as needed.
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);
            bsТовар.Position = pos;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) bMakeNaklad.Visible = true;
            else bMakeNaklad.Visible = false;
        }

        private void bMakeNaklad_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exapp = new Excel.Application();
                exapp.Visible = true;
                exapp.Workbooks.Open(Application.StartupPath + "\\blank.xls", Type.Missing, true);
                Excel.Worksheet list1 = (exapp.Worksheets.get_Item(1));

                DataRowView rrashod = (DataRowView)bsРасход.List[bsРасход.Position];
                bsКлиент.Filter = "idklienta =" + rrashod["idklienta"];
                DataRowView rklient = (DataRowView)bsКлиент.List[0];
                bsКлиент.RemoveFilter();

                string klient = rklient["nameklienta"] + ", г." + rklient["gorod"] + ", ул. " +
                    rklient["ulica"] + ", д." + rklient["dom"] +
                    ", тел. " + rklient["telefon"];
                list1.get_Range("L9").Value = klient;
                list1.get_Range("I13").Value = klient;

                list1.get_Range("CF18").Value = rrashod["nakladnaya"];
                list1.get_Range("CF19").Value = rrashod["datavidachi"];
                list1.get_Range("AX23").Value = rrashod["nakladnaya"];
                list1.get_Range("BI23").Value = rrashod["datavidachi"];

                list1.get_Range("A28").Value = "'1.";
                DataRowView rtovar = (DataRowView)bsТовар.List[bsТовар.Position];

                list1.get_Range("D28").Value = rtovar["nametovara"];
                list1.get_Range("X28").Value = rtovar["edizmer"];
                list1.get_Range("AM28").Value = rrashod["kolichestvo"];
                list1.get_Range("BH28").Value = rtovar["cena"];

                bsСотрудник.Filter = "idsotrudnika =" + rrashod["idsotrudnika"];
                DataRowView rsot = (DataRowView)bsСотрудник.List[0];
                bsСотрудник.RemoveFilter();

                list1.get_Range("L39").Value = rsot["dolzhnost"];
                list1.get_Range("AG39").Value = rsot["fio"];

            }
            catch
            {
                MessageBox.Show("Не возможно сформировать отчет с помощью Microsoft Excel.", "Внимание, ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
