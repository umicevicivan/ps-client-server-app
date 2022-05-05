using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class VratiUlogeSO : OpstaSistemskaOperacija
    {
        public List<Uloga> Uloge { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(IObjekat objekat)
        {
            Film f = (Film)objekat;
            Uloga u = new Uloga();
            u.IDFilm = f.IDFilm;
            Uloge = new List<Uloga>(broker.VratiSveSaUslovom(u).Cast<Uloga>());
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
