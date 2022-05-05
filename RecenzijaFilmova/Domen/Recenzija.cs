using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Recenzija : IObjekat
    {

        public int IDRecenzijeFilma { get; set; }
        public Korisnik Korisnik { get; set; }
        public Film Film { get; set; }
        public string RecenzijaFilma { get; set; }
        public List<RecenzijaUloge> RecenzijeUloga { get; set; }

        public Recenzija()
        {
            RecenzijeUloga = new List<RecenzijaUloge>();
        }

        public string PostaviVrednostAtributa()
        {
            return $"IDKorisnika = {Korisnik.Id}, IDFilm = {Film.IDFilm}, RecenzijaFilma = '{RecenzijaFilma}'";
        }

        public string VratiImeID()
        {
            return "IDRecenzijeFilma";
        }

        public string VratiImeKlase()
        {
            return "RecenzijaFilma";
        }

        public List<IObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IObjekat VratiObjekat(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaTrazenje()
        {
            return $"IDRecenzijeFilma = {IDRecenzijeFilma}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDRecenzijeFilma}, '{RecenzijaFilma}', {Film.IDFilm}, {Korisnik.Id}";
        }
    }
}
