using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class ObrisiGlumcaSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            if(broker.Obrisi(objekat) != 1)
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
