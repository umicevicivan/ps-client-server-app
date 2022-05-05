using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiFimoveSO : OpstaSistemskaOperacija
    {
        public List<Film> Filmovi { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Filmovi = new List<Film>(broker.VratiSve(objekat).Cast<Film>());
        }

        protected override void Validacija(IObjekat objekat)
        {
            if(!(objekat is Film))
            {
                throw new ArgumentException();
            }
        }
    }
}
