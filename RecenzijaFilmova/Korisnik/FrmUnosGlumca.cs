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
    public partial class FrmUnosGlumca : Form
    {
        KUnosGlumca kontroler;
        public FrmUnosGlumca()
        {
            InitializeComponent();
            kontroler = new KUnosGlumca();
        }

        private void FrmUnosGlumca_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.dodajGlumca(txtIme, txtPrezime, txtDrzava, cmbPol);
            this.Close();
        }
    }
}
