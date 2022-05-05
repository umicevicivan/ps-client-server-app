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
    public partial class FrmBrisanjeIzmenaGlumca : Form
    {

        KBrisanjeiIzmenaGlumca kontroler;
        public FrmBrisanjeIzmenaGlumca()
        {
            InitializeComponent();
            kontroler = new KBrisanjeiIzmenaGlumca(this);
        }

        private void FrmBrisanjeIzmenaGlumca_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbGlumci, groupBox1);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiGlumca(cmbGlumci);
            if (uspelo)
            {
                this.Close();
            }

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.IzmeniGlumca(cmbGlumci, txtIme, txtPrezime, txtDrzava, cmbPol);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
