using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace RecenzijaFilma
{
    public class KBrisanjeiIzmenaGlumca
    {
        private FrmBrisanjeIzmenaGlumca frmBrisanjeIzmenaGlumca;

        public KBrisanjeiIzmenaGlumca(FrmBrisanjeIzmenaGlumca frmBrisanjeIzmenaGlumca)
        {
            this.frmBrisanjeIzmenaGlumca = frmBrisanjeIzmenaGlumca;
        }

        internal void srediFormu(ComboBox cmbGlumci, GroupBox groupBox1)
        {
            groupBox1.Enabled = false;
            try
            {
                cmbGlumci.DataSource = Komunikacija.Instance.vratiGlumce();

            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje glumce!");
                frmBrisanjeIzmenaGlumca.Close();
            }
        }

        internal bool ObrisiGlumca(ComboBox cmbGlumci)
        {
            try
            {
                if(cmbGlumci.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite glumca koga zelite da obrisete!");
                    return false;
                }
                Glumac glZaBrisnaje = (Glumac)cmbGlumci.SelectedItem;
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.ObrisiGlumca(glZaBrisnaje);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Obrisan je glumac po imenu: {glZaBrisnaje.Ime}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise glumca");
                    return false;
                }
            }
            catch (Exception)
            {

                throw new Exception("Greska pri brisanju");
            }
        }

        internal bool IzmeniGlumca(ComboBox cmbGlumci, TextBox txtIme, TextBox txtPrezime, TextBox txtDrzava, ComboBox cmbPol)
        {
            try
            {
                if (cmbGlumci.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite glumca koga zelite da izmenite!");
                    return false;
                }
                Glumac glZaIzmenu = (Glumac)cmbGlumci.SelectedItem;

                if (cmbPol.Text == "Muski")
                {
                    glZaIzmenu.Pol = 0;
                }
                else
                {
                    glZaIzmenu.Pol = 1;
                }
                if (!String.IsNullOrEmpty(txtIme.Text))
                {
                    glZaIzmenu.Ime = txtIme.Text;
                }
                if (!String.IsNullOrEmpty(txtPrezime.Text))
                {
                    glZaIzmenu.Prezime = txtPrezime.Text;
                }
                if (!String.IsNullOrEmpty(txtDrzava.Text))
                {
                    glZaIzmenu.Drzava = txtDrzava.Text;
                }
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.IzmeniGlumca(glZaIzmenu);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad glumcem: {glZaIzmenu.Ime} !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene glumca.");
                    return false;
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
