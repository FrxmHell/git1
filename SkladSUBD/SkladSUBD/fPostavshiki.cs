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
    public partial class fPostavshiki : Form
    {
        public fPostavshiki()
        {
            InitializeComponent();
        }

        private void fPostavshiki_Load(object sender, EventArgs e)
        {
            
            this.prihodTableAdapter.Fill(this.skladDataSet1.Prihod);
            
            this.postavshikiTableAdapter.Fill(this.skladDataSet1.Postavshiki);

        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            bsПоставщики.AddNew();
        }

        private void bDelCurrent_Click(object sender, EventArgs e)
        {
            DialogResult rez=MessageBox.Show("Удалить текущего поставщика из списка?",
                "Внимание! Будут удалены все записи, связанные с текущим поставщиком!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                while (bsПриход.Count > 0) bsПриход.RemoveAt(0);
                bsПоставщики.RemoveCurrent();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bsПриход.EndEdit();
            prihodTableAdapter.Update(skladDataSet1.Prihod);

            bsПоставщики.EndEdit();
            postavshikiTableAdapter.Update(skladDataSet1.Postavshiki);
        }
    }
}
