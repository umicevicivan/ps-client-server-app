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
    public class Film : IObjekat
    {

        public int IDFilm { get; set; }
        public string ImeFilma { get; set; }
        public int Minutaza { get; set; }
        public string OpisFilma { get; set; }
        public double Budzet { get; set; }
        public double Zarada { get; set; }
        public List<Uloga> uloge {get; set; }

        public Film()
        {
            uloge = new List<Uloga>();
        }

        public override string ToString()
        {
            return ImeFilma;
        }

        public string PostaviVrednostAtributa()
        {
            return $"ImeFilma = '{ImeFilma}', Minutaza = {Minutaza}, OpisFilma = '{OpisFilma}', Budzet = {Budzet.ToString(System.Globalization.CultureInfo.InvariantCulture)}, Zarada = {Zarada.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }

        public string VratiImeID()
        {
            return "IDFilm";
        }

        public string VratiImeKlase()
        {
            return "Film";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            List<IObjekat> filmovi = new List<IObjekat>();

            while (reader.Read())
            {
                Film film1 = new Film
                {
                    IDFilm = reader.GetInt32(0),
                    ImeFilma = reader.GetString(1),
                    Minutaza = reader.GetInt32(2),
                    OpisFilma = reader.GetString(3),
                    Budzet = (double)reader.GetDecimal(4),
                    Zarada = (double)reader.GetDecimal(5)

                };
                filmovi.Add(film1);
            }
            return filmovi;
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            Film film = new Film();
            while (reader.Read())
            {
                film = new Film
                {
                    IDFilm = reader.GetInt32(0),
                    ImeFilma = reader.GetString(1),
                    Minutaza = reader.GetInt32(2),
                    OpisFilma = reader.GetString(3),
                    Budzet = reader.GetDouble(4),
                    Zarada = reader.GetDouble(5)

                };
            }
            return film;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDFilm = {IDFilm}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDFilm}, '{ImeFilma}', {Minutaza}, '{OpisFilma}', {Budzet.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Zarada.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
