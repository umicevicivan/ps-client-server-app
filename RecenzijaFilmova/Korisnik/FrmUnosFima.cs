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
    public partial class FrmUnosFima : Form
    {
        KUnosFilma kontroler;
        public FrmUnosFima()
        {
            kontroler = new KUnosFilma(this);
            InitializeComponent();
        }

        private void FrmUnosFima_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbGlumci, dataGridView1);
        }

        private void btnZapamtiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.UbaciUlogu(txtNazivUloge, txtZaradaUloge, cmbGlumci);
        }

        private void btnZapamtiFilm_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.dodajFilm(txtIme, txtMinutaza, txtOpis, txtBudzet, txtZarada);
            if(uspelo == true)
            {
                this.Close();
            }
        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiUlogu(dataGridView1);
        }
    }
}
