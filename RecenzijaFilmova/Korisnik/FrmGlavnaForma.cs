using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecenzijaFilma
{
    public partial class FrmGlavnaForma : Form
    {
        KGlavnaForma kontoler;
        public FrmGlavnaForma()
        {
            InitializeComponent();
            kontoler = new KGlavnaForma();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnos();
        }

        private void izmenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuiBrisnaje();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnosFilma();
        }

        private void brisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izmenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuBrisanjeFilma();
        }

        private void novaRecenzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaRecenziju();
        }

        private void FrmGlavnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
