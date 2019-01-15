using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkladSUBD
{
    public partial class fPrihod : Form
    {
        public fPrihod()
        {
            InitializeComponent();
        }

        private void fPrihod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladDataSet1.Postavshiki' table. You can move, or remove it, as needed.
            this.postavshikiTableAdapter.Fill(this.skladDataSet1.Postavshiki);
            // TODO: This line of code loads data into the 'skladDataSet1.Sotrudniki' table. You can move, or remove it, as needed.
            this.sotrudnikiTableAdapter.Fill(this.skladDataSet1.Sotrudniki);
            // TODO: This line of code loads data into the 'skladDataSet1.Prihod' table. You can move, or remove it, as needed.
            this.prihodTableAdapter.Fill(this.skladDataSet1.Prihod);
            // TODO: This line of code loads data into the 'skladDataSet1.Tovari' table. You can move, or remove it, as needed.
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);

            bsПриход.AddNew();
            datapolucheniyaDateTimePicker.Value = DateTime.Now;

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            DataRowView r;
            r = (DataRowView)bsПоставщик.Current;
            (bsПриход.List[bsПриход.Position] as DataRowView)["idpostavshik"] = r["idpostavshik"].ToString();

            r = (DataRowView)bsТовар.Current;

            int cnt = 0;
            try { cnt = Convert.ToInt32(r["kolichestvo"].ToString()); }
            catch { }
            cnt += Convert.ToInt32(kolichestvoTextBox.Text);
            (bsТовар.List[bsТовар.Position] as DataRowView)["kolichestvo"] = cnt.ToString();
            (bsПриход.List[bsПриход.Position] as DataRowView)["idtovara"] = r["idtovara"].ToString();

            bsТовар.EndEdit();
            tovariTableAdapter.Update(skladDataSet1.Tovari);

            r = (DataRowView)bsСотрудник.Current;
            (bsПриход.List[bsПриход.Position] as DataRowView)["idsotrudnika"]= r["idsotrudnika"].ToString(); //

            bsПриход.EndEdit();
            prihodTableAdapter.Update(skladDataSet1.Prihod);

        }
    }
}
