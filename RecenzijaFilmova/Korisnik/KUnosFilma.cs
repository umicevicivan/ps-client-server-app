using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace RecenzijaFilma
{
    public class KUnosFilma
    {
        public static Film film;
        BindingList<Uloga> listaUloga;
        FrmUnosFima frmUnosFima;
        public KUnosFilma(FrmUnosFima frmUnosFima)
        {
            film = new Film();
            this.frmUnosFima = frmUnosFima;

        }

        internal void UbaciUlogu(TextBox txtNazivUloge, TextBox txtZaradaUloge, ComboBox cmbGlumci)
        {
            Uloga uloga = new Uloga();
            Glumac gl = (Glumac)cmbGlumci.SelectedItem;
            uloga.IDGlumac = gl.IDGlumca;
            uloga.NazivUloge = txtNazivUloge.Text;
            try
            {
                uloga.Zarada = double.Parse(txtZaradaUloge.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                MessageBox.Show("Zarada mora bidi u odredjenom formatu!");
                return;
            }
            listaUloga.Add(uloga);
            txtNazivUloge.Clear();
            txtZaradaUloge.Clear();
        }

        internal void srediFormu(ComboBox cmbGlumci, DataGridView dataGridView1)
        {

            try
            {
                cmbGlumci.DataSource = Komunikacija.Instance.vratiGlumce();
                listaUloga = new BindingList<Uloga>();
                dataGridView1.DataSource = listaUloga;
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                frmUnosFima.Close();
            }
        }

        internal void ObrisiUlogu(DataGridView dataGridView1)
        {
            try
            {
                Uloga u = (Uloga)dataGridView1.CurrentRow.DataBoundItem;

                listaUloga.Remove(u);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool dodajFilm(TextBox txtIme, TextBox txtMinutaza, TextBox txtOpis, TextBox txtBudzet, TextBox txtZarada)
        {
            try
            {
                if (String.IsNullOrEmpty(txtIme.Text))
                {
                    MessageBox.Show("Niste uneli naziv filma!");
                    return false;
                }
                film.ImeFilma = txtIme.Text;
                film.OpisFilma = txtOpis.Text;
                try
                {
                    film.Minutaza = Convert.ToInt32(txtMinutaza.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Minutaza nije u odgovarajucem formatu!");
                    return false;
                }
                try
                {
                    
                    film.Zarada = double.Parse(txtZarada.Text, System.Globalization.CultureInfo.InvariantCulture);
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Zarada nije u odgovarajucem formatu");
                    return false;
                }
                try
                {
                    film.Budzet = double.Parse(txtBudzet.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {

                    MessageBox.Show("Budzet nije u odgovarajucem formatu!");
                    return false;
                }
                film.uloge = listaUloga.ToList<Uloga>();
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.DodajFilm(film);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show("Dodat je novi film po imenu: " + txtIme.Text);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti film");
                    return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
