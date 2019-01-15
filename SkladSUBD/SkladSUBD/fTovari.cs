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
    public partial class fTovari : Form
    {
        public fTovari()
        {
            InitializeComponent();
        }

        private void fTovari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladDataSet1.Rashod' table. You can move, or remove it, as needed.
            this.rashodTableAdapter.Fill(this.skladDataSet1.Rashod);
            // TODO: This line of code loads data into the 'skladDataSet1.Prihod' table. You can move, or remove it, as needed.
            this.prihodTableAdapter.Fill(this.skladDataSet1.Prihod);
            // TODO: This line of code loads data into the 'skladDataSet1.Tovari' table. You can move, or remove it, as needed.
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);

        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            bsТовары.AddNew();
        }

        private void bDelCurrent_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Удалить текущий товар из списка?",
                "Внимание! Будут удалены все записи, связанные с текущим товаром!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rez == DialogResult.Yes)
            {
                while (bsРасходТовары.Count > 0) bsРасходТовары.RemoveAt(0);
                while (bsПриходТовары.Count > 0) bsПриходТовары.RemoveAt(0);
                bsТовары.RemoveCurrent();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bsРасходТовары.EndEdit();
            rashodTableAdapter.Update(skladDataSet1.Rashod);

            bsПриходТовары.EndEdit();
            prihodTableAdapter.Update(skladDataSet1.Prihod);

            bsТовары.EndEdit();
            tovariTableAdapter.Update(skladDataSet1.Tovari);
        }
    }
}
