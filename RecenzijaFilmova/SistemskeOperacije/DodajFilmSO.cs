using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class DodajFilmSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Film f = (Film)objekat;
            int id = broker.DajSledeciID(objekat);
            f.IDFilm = id;
            if (broker.Sacuvaj(objekat) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
         
            if (Uspelo == true)
            {
                foreach (Uloga u in f.uloge)
                {

                    u.IDFilm = id;
                    if (broker.Sacuvaj(u) != 1)
                    {
                        Uspelo = false;
                    }
                    else
                    {
                        Uspelo = true;
                    }
                }

            }

        }

        protected override void Validacija(IObjekat objekat)
        {
            if (!(objekat is Film))
            {
                throw new ArgumentException();
            }
        }
    }
}
