using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SkladSUBD
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPostavshiki f = new fPostavshiki();
            f.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKlienti f = new fKlienti();
            f.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStuffs f = new fStuffs();
            f.ShowDialog();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTovari f = new fTovari();
            f.ShowDialog();
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);
            dgv.Refresh();
        }

        private void получитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPrihod f = new fPrihod();
            f.ShowDialog();
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);
            dgv.Refresh();
        }

        private void выдатьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRashod f = new fRashod();
            f.ShowDialog();
            this.tovariTableAdapter.Fill(this.skladDataSet1.Tovari);
            dgv.Refresh();
        }

        private void списокПолученйИВыдачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPrihodRashod f = new fPrihodRashod();
            f.pos = bsТовар.Position;
            f.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
