using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{

    [Serializable]
    public class Glumac : IObjekat
    {
        public int IDGlumca { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Drzava { get; set; }
        public int Pol { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public string PostaviVrednostAtributa()
        {
            return $"Ime = '{Ime}', Prezime = '{Prezime}', Drzava = '{Drzava}', Pol = {Pol}";
        }

        public string VratiImeKlase()
        {
            return "Glumac";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> glumci = new List<IObjekat>();
            while (reader.Read())
            {
                Glumac glumac = new Glumac
                {
                    IDGlumca = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Drzava = reader.GetString(3),
                    Pol = reader.GetInt32(4)

                };
                glumci.Add(glumac);
            }
            return glumci;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat glumac = null;
            while (reader.Read())
            {
                glumac = new Glumac
                {
                    IDGlumca = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Drzava = reader.GetString(3),
                    Pol = reader.GetInt32(4)

                };
            }
            return glumac;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDGlumca = {IDGlumca}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDGlumca}, '{Ime}', '{Prezime}', '{Drzava}', {Pol}";
        }

        public string VratiImeID()
        {
            return "IDGlumca";
        }
    }
}
