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
    public partial class fStuffs : Form
    {
        public fStuffs()
        {
            InitializeComponent();
        }

        private void fStuffs_Load(object sender, EventArgs e)
        {
            this.rashodTableAdapter.Fill(this.skladDataSet1.Rashod);
            this.prihodTableAdapter.Fill(this.skladDataSet1.Prihod);
            this.sotrudnikiTableAdapter.Fill(this.skladDataSet1.Sotrudniki);
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            bsСотрудники.AddNew();
        }

        private void bDelCurrent_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Удалить текущего сотрудника из списка?",
                "Внимание! Будут удалены все записи, связанные с текущим сотрудником!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                while (bsРасход.Count > 0) bsРасход.RemoveAt(0);
                while (bsПриход.Count > 0) bsПриход.RemoveAt(0);
                bsСотрудники.RemoveCurrent();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bsРасход.EndEdit();
            rashodTableAdapter.Update(skladDataSet1.Rashod);

            bsПриход.EndEdit();
            prihodTableAdapter.Update(skladDataSet1.Prihod);
            bsСотрудники.EndEdit();
            sotrudnikiTableAdapter.Update(skladDataSet1.Sotrudniki);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bsСотрудники_CurrentChanged(object sender, EventArgs e)
        {

        }

        
    }
}
