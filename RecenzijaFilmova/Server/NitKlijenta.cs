using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    internal class NitKlijenta
    {
        private Socket klijent;
        public Korisnik korisnik;
        private FrmServer frmServer;
        private NetworkStream tok;
        private BinaryFormatter formatter = new BinaryFormatter();
        private bool kraj;

        public NitKlijenta(Socket klijent, FrmServer frmServer)
        {
            this.klijent = klijent;
            this.frmServer = frmServer;
            this.tok = new NetworkStream(klijent);
        }

        internal void Obradjuj()
        {
            kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(tok);
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.PrijaviKorisnika:
                            odgovor = PrijaviKorisnika((Korisnik)zahtev.Objekat);
                            break;
                        case Operacija.DodajGlumca:
                            odgovor = DodajGlumca((Glumac)zahtev.Objekat);
                            break;
                        case Operacija.VratiGlumce:
                            odgovor = VratiGlumce();
                            break;
                        case Operacija.ObrisiGlumca:
                            odgovor = ObrisiGlumca((Glumac)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniGlumca:
                            odgovor = IzmeniGlumca((Glumac)zahtev.Objekat);
                            break;
                        case Operacija.DodajFilm:
                            odgovor = DodajFilm((Film)zahtev.Objekat);
                            break;
                        case Operacija.Kraj:
                            Zavrsi();
                            break;
                        case Operacija.VratiFilmove:
                            odgovor = VratiFilmove();
                            break;
                        case Operacija.ObrisiFilm:
                            odgovor = ObrisiFilm((Film)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniFilm:
                            odgovor = IzmeniFilm((Film)zahtev.Objekat);
                            break;
                        case Operacija.VratiUloge:
                            odgovor = VratiUloge((Film)zahtev.Objekat);
                            break;
                        case Operacija.DodajRecenziju:
                            odgovor = DodajRecenziju((Recenzija)zahtev.Objekat);
                            break;
                    }
                    Salji(odgovor);
                }
                catch (ThreadInterruptedException e)
                {
                    kraj = false;
                }
                catch (IOException e)
                {
                    kraj = false;
                }
            }
        }

        private Odgovor DodajRecenziju(Recenzija recenzija)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajRecenziju(recenzija);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor VratiUloge(Film film)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiUloge(film);
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor IzmeniFilm(Film film)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.IzmeniFilm(film);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor ObrisiFilm(Film objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiFilm(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiFilmove()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiFilmove();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor DodajFilm(Film objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajFilm(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor IzmeniGlumca(Glumac glumac)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.IzmeniGlumca(glumac);
            if((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor ObrisiGlumca(Glumac objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiGlumca(objekat);
            if((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiGlumce()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiGlumce();
            if(odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }

        private Odgovor DodajGlumca(Glumac objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajGlumca(objekat);
            if((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor PrijaviKorisnika(Korisnik objekat)
        {
            korisnik = Kontroler.Kontroler.Instance.PrijaviKorisnika(objekat);
            Odgovor odgovor = new Odgovor();
            if(korisnik == null)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = "Nije pronadjen korisnik";
                odgovor.Objekat = new Korisnik();
            }
            else
            {
                odgovor.Signal = Signal.Ok;
                odgovor.Poruka = "Pronadjen je korisnik";
                odgovor.Objekat = korisnik;               
            }
            return odgovor;
        }

        private void Salji(Odgovor odgovor)
        {
            formatter.Serialize(tok, odgovor);
        }
        internal void Ugasi()
        {
            Salji(new Odgovor { Signal = Signal.KrajServer });
            Zavrsi();
        }
        
        internal void Zavrsi()
        {
            kraj = true;
            if (klijent != null && klijent.Connected)
            {
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Disconnect(false);
                klijent.Close();
            }
        }
    }
}
