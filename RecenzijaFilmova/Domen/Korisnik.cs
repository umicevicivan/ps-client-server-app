using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : IObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }

        public string PostaviVrednostAtributa()
        {
            throw new NotImplementedException();
        }

        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Korisnik";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            Korisnik k = null;
            while (reader.Read())
            {
                k = new Korisnik
                {
                    Id = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    KorisnickoIme = reader.GetString(3),
                    Password = reader.GetString(4),
                };
            }
            return k;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"KorisnickoIme = '{KorisnickoIme}' and Pass = '{Password}'";
        }

        public string VratiVrednostAtributa()
        {
            throw new NotImplementedException();
        }
    }
}
