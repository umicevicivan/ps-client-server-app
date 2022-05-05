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
    class KUnosRecenzije
    {
        public static Korisnik k;

        public static Recenzija recenzija;
        BindingList<RecenzijaUloge> recenzijeUloga;
        FrmUnosRecenzije frmUnosRecenzije;


        public KUnosRecenzije(FrmUnosRecenzije frmUnosRecenzije)
        {
            recenzija = new Recenzija();
            this.frmUnosRecenzije = frmUnosRecenzije;
        }

        internal void srediFormu(ComboBox cmbUloge, GroupBox groupBox1, GroupBox groupBox2, Button btnPotvrdiFilm, ComboBox cmbFilmovi, Label lblKorisnik, DataGridView dataGridView1)
        {

            try
            {
                cmbUloge.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnPotvrdiFilm.Enabled = false;
                lblKorisnik.Text = k.Ime;
                cmbFilmovi.DataSource = Komunikacija.Instance.vratiFilmove();
                recenzijeUloga = new BindingList<RecenzijaUloge>();
                dataGridView1.DataSource = recenzijeUloga;
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                frmUnosRecenzije.Close();
            }
        }

        internal void srediFormu2(GroupBox groupBox2, ComboBox cmbUloge, ComboBox cmbFilmovi, GroupBox groupBox1, Button btnPotvrdiFilm)
        {
            groupBox2.Enabled = true;
            cmbUloge.Enabled = true;
            try
            {
                cmbUloge.DataSource = Komunikacija.Instance.VratiUloge((Film)cmbFilmovi.SelectedItem);

            }
            catch (Exception e)
            {
                MessageBox.Show("Server je prekinuo sa radom i ne mogu da se pronadju uloge");
                frmUnosRecenzije.Close();
                return;
            }
            groupBox1.Enabled = true;
            btnPotvrdiFilm.Enabled = true;
            MessageBox.Show("Sistem je pronasao film!");


        }

        internal void obrisiRecenzijuUloge(DataGridView dataGridView1)
        {
            try
            {
                RecenzijaUloge r = (RecenzijaUloge)dataGridView1.CurrentRow.DataBoundItem;

                recenzijeUloga.Remove(r);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool dodajRecenziju(TextBox txtRecenzijaFilma, ComboBox cmbFilmovi)
        {
            try
            {
                Film film = (Film)cmbFilmovi.SelectedItem;
                recenzija.Film = film;
                if (String.IsNullOrEmpty(txtRecenzijaFilma.Text))
                {
                    MessageBox.Show("Recenzija filma ne moze biti prazna");
                    return false;
                }
                recenzija.RecenzijaFilma = txtRecenzijaFilma.Text;
                recenzija.Korisnik = k;
                recenzija.RecenzijeUloga = recenzijeUloga.ToList<RecenzijaUloge>();
                bool uspesno = Komunikacija.Instance.DodajRecenziju(recenzija);
                if (uspesno)
                {
                    MessageBox.Show("Dodata je nova recenzija za film: " + film.ImeFilma);
                    return uspesno;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti recenziju!");
                    return uspesno;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal void UbaciRecenzijuUloge(ComboBox cmbUloge, TextBox txtRecenzijaUloge, ComboBox cmbFilmovi)
        {
            RecenzijaUloge ru = new RecenzijaUloge();
            Film f = (Film)cmbFilmovi.SelectedItem;
            Uloga uloga = (Uloga)cmbUloge.SelectedItem;
            if(uloga == null)
            {
                MessageBox.Show("Morate odabrati ulogu");
                return;
            } 

            ru.Film = f;
            ru.Glumac.IDGlumca = uloga.IDGlumac;
            if (String.IsNullOrEmpty(txtRecenzijaUloge.Text))
            {
                MessageBox.Show("Recenzija uloge ne moze biti prazna");
                return;
            }
            ru.Recenzija = txtRecenzijaUloge.Text;
            ru.IDRecenzijeUloge = recenzijeUloga.Count() + 1; 
            recenzijeUloga.Add(ru);
            txtRecenzijaUloge.Clear();
            

        }
    }
}
