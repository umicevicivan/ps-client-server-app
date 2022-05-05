using BrokerBazePodataka;
using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Kontroler
    {
        private static Kontroler _instance;
        private Broker broker = new Broker();
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kontroler();
                return _instance;
            }
        }

        public Korisnik PrijaviKorisnika(Korisnik korisnik)
        {
            OpstaSistemskaOperacija operacija = new PrijaviKorisnikaSO();
            operacija.Izvrsi(korisnik);
            return ((PrijaviKorisnikaSO)operacija).Korisnik;
        }

        public object DodajGlumca(Glumac objekat)
        {
            OpstaSistemskaOperacija operacija = new DodajGlumcaSO();
            operacija.Izvrsi(objekat);
            return ((DodajGlumcaSO)operacija).Uspelo;
        }

        public object VratiGlumce()
        {
            OpstaSistemskaOperacija operacija = new VratiGlumceSO();
            operacija.Izvrsi(new Glumac());
            return ((VratiGlumceSO)operacija).Glumci;

        }

        public object ObrisiGlumca(Glumac glumac)
        {
            OpstaSistemskaOperacija operacija = new ObrisiGlumcaSO();
            operacija.Izvrsi(glumac);
            return ((ObrisiGlumcaSO)operacija).Uspelo;
        }

        public object IzmeniGlumca(Glumac glumac)
        {
            OpstaSistemskaOperacija operacija = new IzmeniGlumcaSO();
            operacija.Izvrsi(glumac);
            return ((IzmeniGlumcaSO)operacija).Uspelo;
        }

        public object DodajFilm(Film film)
        {
            OpstaSistemskaOperacija operacija = new DodajFilmSO();
            operacija.Izvrsi(film);
            return ((DodajFilmSO)operacija).Uspelo;
        }

        public object VratiFilmove()
        {
            OpstaSistemskaOperacija operacija = new VratiFimoveSO();
            operacija.Izvrsi(new Film());
            return ((VratiFimoveSO)operacija).Filmovi;
        }

        public object ObrisiFilm(Film film)
        {
            OpstaSistemskaOperacija operacija = new ObrisiFilmSO();
            operacija.Izvrsi(film);
            return ((ObrisiFilmSO)operacija).Uspelo;
        }

        public object IzmeniFilm(Film film)
        {
            OpstaSistemskaOperacija operacija = new IzmeniFilmSO();
            operacija.Izvrsi(film);
            return ((IzmeniFilmSO)operacija).Uspelo;
        }

        public object VratiUloge(Film film)
        {
            OpstaSistemskaOperacija operacija = new VratiUlogeSO();
            operacija.Izvrsi(film);
            return ((VratiUlogeSO)operacija).Uloge;
        }

        public object DodajRecenziju(Recenzija recenzija)
        {
            OpstaSistemskaOperacija operacija = new DodajRecenzijuSO();
            operacija.Izvrsi(recenzija);
            return ((DodajRecenzijuSO)operacija).Uspelo;
        }
    }

}
