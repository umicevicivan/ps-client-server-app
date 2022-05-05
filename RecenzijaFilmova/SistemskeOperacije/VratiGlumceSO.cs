using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiGlumceSO : OpstaSistemskaOperacija
    {
        public List<Glumac> Glumci { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Glumci = new List<Glumac>(broker.VratiSve(objekat).Cast<Glumac>());
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
