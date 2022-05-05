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
    public partial class FrmBrisanjeIzmenaFilma : Form
    {
        KBrisanjeIzmenaFilma kontroler;

        public FrmBrisanjeIzmenaFilma()
        {
            InitializeComponent();
            kontroler = new KBrisanjeIzmenaFilma(this);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmBrisanjeIzmenaFilma_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbFilmovi, groupBox1);

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiFilm(cmbFilmovi);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            MessageBox.Show("Sistem je pronasao film");
        }

        private void btnPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.IzmeniFilm(cmbFilmovi, txtIme, txtMinutaza, txtOpis, txtBudzet, txtZarada);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
