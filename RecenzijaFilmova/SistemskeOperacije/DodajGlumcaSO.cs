using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class DodajGlumcaSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set;}
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            int id = broker.DajSledeciID(objekat);
            Glumac g = (Glumac)objekat;
            g.IDGlumca = id;

            if(broker.Sacuvaj(g) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
        }

        protected override void Validacija(IObjekat objekat)
        {
            if(!(objekat is Glumac))
            {
                throw new ArgumentException();
            }
        }
    }
}
