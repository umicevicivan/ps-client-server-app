using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace RecenzijaFilma
{
    public class KGlavnaForma
    {

        public static Korisnik k;
        internal void OtvoriZaUnos()
        {
            FrmUnosGlumca unos = new FrmUnosGlumca();
            unos.ShowDialog();
        }

        internal void OtvoriZaIzmenuiBrisnaje()
        {
            FrmBrisanjeIzmenaGlumca izmena = new FrmBrisanjeIzmenaGlumca();
            izmena.ShowDialog();
        }

        internal void OtvoriZaUnosFilma()
        {
            FrmUnosFima unosFilma = new FrmUnosFima();
            unosFilma.ShowDialog();
        }

        internal void OtvoriZaIzmenuBrisanjeFilma()
        {
            FrmBrisanjeIzmenaFilma izmena = new FrmBrisanjeIzmenaFilma();
            izmena.ShowDialog();
        }

        internal void OtvoriZaRecenziju()
        {
            FrmUnosRecenzije recenzija = new FrmUnosRecenzije();
            KUnosRecenzije.k = k;
            recenzija.ShowDialog();
        }
    }
}
