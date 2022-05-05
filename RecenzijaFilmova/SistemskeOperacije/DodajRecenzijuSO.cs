using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class DodajRecenzijuSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Recenzija r = (Recenzija)objekat;
            int id = broker.DajSledeciID(objekat);
            r.IDRecenzijeFilma = id;
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
                foreach (RecenzijaUloge ru in r.RecenzijeUloga)
                {

                    ru.IDRecenzijeFilma = id;
                    if (broker.Sacuvaj(ru) != 1)
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
            if(!(objekat is Recenzija))
            {
                throw new ArgumentException();
            }
        }
    }
}
