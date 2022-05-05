using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace RecenzijaFilma
{
    public class KUnosGlumca
    {

        internal void dodajGlumca(TextBox txtIme, TextBox txtPrezime, TextBox txtDrzava, ComboBox cmbPol)
        {
            try
            {
                Glumac glumac = new Glumac
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Drzava = txtDrzava.Text,
                };
                if (cmbPol.Text == "Muski")
                {
                    glumac.Pol = 0;
                }
                else
                {
                    glumac.Pol = 1;
                }
                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.DodajGlumca(glumac);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                if (uspesno)
                {
                    MessageBox.Show("Dodat je novi glumac po imenu " + glumac.Ime + " !");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti glumca");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
