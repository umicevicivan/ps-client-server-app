using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace RecenzijaFilma
{
    class KBrisanjeIzmenaFilma
    {
        private FrmBrisanjeIzmenaFilma frmBrisanjeIzmenaFilma;

        public KBrisanjeIzmenaFilma(FrmBrisanjeIzmenaFilma frmBrisanjeIzmenaFilma)
        {
            this.frmBrisanjeIzmenaFilma = frmBrisanjeIzmenaFilma;
        }

        internal void srediFormu(ComboBox cmbFilmovi, GroupBox groupBox1)
        {
            groupBox1.Enabled = false;
            try
            {
                cmbFilmovi.DataSource = Komunikacija.Instance.vratiFilmove();
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje filmove ");
                frmBrisanjeIzmenaFilma.Close();
                
            }

        }

        internal bool ObrisiFilm(ComboBox cmbFilmovi)
        {
            try
            {
                if(cmbFilmovi.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite film za brisanje!");
                    return false;
                }
                Film filmZaBrisanje = (Film)cmbFilmovi.SelectedItem;
                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.ObrisiFilm(filmZaBrisanje);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Obrisan je film po imenu: {filmZaBrisanje.ImeFilma}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise film!");
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greska pri brisanju");
            }
        }

        internal bool IzmeniFilm(ComboBox cmbFilmovi, TextBox txtIme, TextBox txtMinutaza, TextBox txtOpis, TextBox txtBudzet, TextBox txtZarada)
        {
            try
            {
                if(cmbFilmovi.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite film koji zelite da izmenite");
                    return false;
                }
                Film filmZaIzmenu = (Film)cmbFilmovi.SelectedItem;

                if (!String.IsNullOrEmpty(txtIme.Text))
                {
                    filmZaIzmenu.ImeFilma = txtIme.Text;
                }
                if (!String.IsNullOrEmpty(txtOpis.Text))
                {
                    filmZaIzmenu.OpisFilma = txtOpis.Text;
                }
                if (!String.IsNullOrEmpty(txtMinutaza.Text))
                {
                    try
                    {
                        filmZaIzmenu.Minutaza = Convert.ToInt32(txtMinutaza.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Minutaza nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                if (!String.IsNullOrEmpty(txtZarada.Text))
                {
                    try
                    {
                        filmZaIzmenu.Zarada = double.Parse(txtZarada.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zarada nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                if (!String.IsNullOrEmpty(txtBudzet.Text))
                {
                    try
                    {
                        filmZaIzmenu.Budzet = double.Parse(txtBudzet.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Budzet nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.IzmeniFilm(filmZaIzmenu);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Napravljene su izmene nad filmom: {filmZaIzmenu.ImeFilma}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene nad filmom.");
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
