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
    public partial class fRashod : Form
    {
        public fRashod()
        {
            InitializeComponent();
        }

        private void fRashod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladDataSet1.Klienti' table. You can move, or remove it, as needed.
            this.klientiTableAdapter.Fill(this.skladDataSet1.Klienti);
            // TODO: This line of code loads data into the 'skladDataSet1.Sotrudniki' table. You can move, or remove it, as needed.
            this.sotrudnikiTableAdapter.Fill(this.skladDataSet1.Sotrudniki);
            // TODO: This line of code loads data into the 'skladDataSet1.Rashod' table. You can move, or remove it, as needed.
            this.rashodTableAdapter.Fill(this.skladDataSet1.Rashod);
            // TODO: This line of code loads data into the 'skladDataSet1.Tovari' table. You can move, or remove it, as needed.
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);

            bsРасход.AddNew();
            datavidachiDateTimePicker.Value = DateTime.Now;


        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            DataRowView r;
            r = (DataRowView)bsКлиент.Current;
            (bsРасход.List[bsРасход.Position] as DataRowView)["idklienta"] = r["idklienta"].ToString();

            r = (DataRowView)bsТовар.Current;

            int cnt = 0;
            try 
            { 
                cnt=Convert.ToInt32(r["kolichestvo"].ToString());
                if (Convert.ToInt32(kolichestvoTextBox.Text)>cnt)
                {
                    MessageBox.Show("Недостаточно товара на складе!");
                    return;
                }
            }
            catch { }
            cnt -= Convert.ToInt32(kolichestvoTextBox.Text);

            (bsТовар.List[bsТовар.Position] as DataRowView)["kolichestvo"] = cnt.ToString();
            (bsРасход.List[bsРасход.Position] as DataRowView)["idtovara"] = r["idtovara"].ToString();

            bsТовар.EndEdit();
            tovariTableAdapter.Update(skladDataSet1.Tovari);

            r = (DataRowView)bsСотрудник.Current;
            (bsРасход.List[bsРасход.Position] as DataRowView)["idsotrudnika"] = r["idsotrudnika"].ToString();

            bsРасход.EndEdit();
            rashodTableAdapter.Update(skladDataSet1.Rashod);
            this.Close();
        }

    }
}
