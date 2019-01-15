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
    public partial class fKlienti : Form
    {
        public fKlienti()
        {
            InitializeComponent();
        }

        private void fKlienti_Load(object sender, EventArgs e)
        {   
            this.rashodTableAdapter.Fill(this.skladDataSet1.Rashod);
            this.klientiTableAdapter.Fill(this.skladDataSet1.Klienti);
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            bsКлиенты.AddNew();
        }

        private void bDelCurrent_Click(object sender, EventArgs e)
        {
            DialogResult rez=MessageBox.Show("Удалить этого клиента из списка?",
                "Внимание! Будут удалены все записи, связанные с текущим клиентом!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (rez == DialogResult.Yes)
            {
                while (bsРасход.Count > 0) bsРасход.RemoveAt(0);
                bsКлиенты.RemoveCurrent();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bsРасход.EndEdit();
            rashodTableAdapter.Update(skladDataSet1.Rashod);
            bsКлиенты.EndEdit();
            klientiTableAdapter.Update(skladDataSet1.Klienti);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsКлиенты_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
