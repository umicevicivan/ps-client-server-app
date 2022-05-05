using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domen;

namespace RecenzijaFilma
{
    public class Komunikacija
    {
        private static Komunikacija _instance;


        public static Komunikacija Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Komunikacija();
                return _instance;
            }
        }
        private Socket klijent;
        private NetworkStream tok;
        private BinaryFormatter formater = new BinaryFormatter();


        private Komunikacija()
        {
        }

        

        internal bool PoveziSe()
        {
            try
            {
                if (klijent == null || !klijent.Connected)
                {

                    klijent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijent.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    klijent.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
                    tok = new NetworkStream(klijent);
                }
                return true;
            }
            catch (SocketException e)
            {
                Debug.WriteLine(">>> " + e.Message);
                return false;
            }
        }

        internal object VratiUloge(Film film)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = film, Operacija = Operacija.VratiUloge };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Uloga>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao Glumce");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool DodajRecenziju(Recenzija recenzija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = recenzija, Operacija = Operacija.DodajRecenziju };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao film");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool DodajGlumca(Glumac glumac)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = glumac, Operacija = Operacija.DodajGlumca };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao glumca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal void Zavrsi()
        {
            klijent.Close();
        }

        internal Korisnik PrijaviKorisnika(string username, string pass)
        {
            try
            {
                Korisnik korisnik = new Korisnik { KorisnickoIme = username, Password = pass };
                Zahtev zahtev = new Zahtev { Objekat = korisnik, Operacija = Operacija.PrijaviKorisnika };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (Korisnik)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>" + ex.Message);
                throw;
                
            }

        }

        internal bool IzmeniFilm(Film filmZaIzmenu)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = filmZaIzmenu, Operacija = Operacija.IzmeniFilm };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio film");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal List<Glumac> vratiGlumce()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiGlumce };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Glumac>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao Glumce");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();

                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool ObrisiGlumca(Glumac glZaBrisnaje)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = glZaBrisnaje, Operacija = Operacija.ObrisiGlumca };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao Glumca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool DodajFilm(Film film)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = film, Operacija = Operacija.DodajFilm };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao film");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool IzmeniGlumca(Glumac glZaIzmenu)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = glZaIzmenu, Operacija = Operacija.IzmeniGlumca };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio Glumca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal object vratiFilmove()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiFilmove };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Film>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao Glumce");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }

        internal bool ObrisiFilm(Film filmZaBrisanje)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = filmZaBrisanje, Operacija = Operacija.ObrisiFilm };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao Film");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
    }
}
