using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Uloga : IObjekat
    {
        [Browsable(false)]
        public int IDFilm { get; set; }
        public int IDGlumac {get; set; }
        public string NazivUloge {get; set; }
        public double Zarada { get; set; }
        public string PostaviVrednostAtributa()
        {
            return $"IDFilm = {IDFilm}, IDGlumac = {IDGlumac}, NazivUloge = '{NazivUloge}', Zarada = {Zarada}";
        }

        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Uloga";
        }

        public override string ToString()
        {
            return NazivUloge;
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> uloge = new List<IObjekat>();
            while (reader.Read())
            {
                Uloga uloga = new Uloga
                {
                    IDFilm = reader.GetInt32(0),
                    IDGlumac= reader.GetInt32(1),
                    NazivUloge = reader.GetString(2),
                    Zarada = (double)reader.GetDecimal(3)
                };
                uloge.Add(uloga);
            }
            return uloge;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            IObjekat uloga = null;
            while (reader.Read())
            {
                uloga = new Uloga
                {
                    IDFilm = reader.GetInt32(0),
                    IDGlumac = reader.GetInt32(1),
                    NazivUloge = reader.GetString(2),
                    Zarada = reader.GetInt32(3)
                };               
            }
            return uloga;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDFilm = {IDFilm}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDFilm}, {IDGlumac}, '{NazivUloge}', {Zarada.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
