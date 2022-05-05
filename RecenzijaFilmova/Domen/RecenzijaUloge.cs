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
    public class RecenzijaUloge : IObjekat
    {
        [Browsable(false)]
        public int IDRecenzijeFilma { get; set; }
        public int IDRecenzijeUloge { get; set; }
        public string Recenzija { get; set; }

        public Film Film { get; set; }
        [Browsable(false)]
        public Glumac Glumac { get; set; }

        public RecenzijaUloge()
        {
            Film = new Film();
            Glumac = new Glumac();
        }

        public string PostaviVrednostAtributa()
        {
            return $"IDRecenzijeFilma = {IDRecenzijeFilma}, IDRecenzijeUloge = {IDRecenzijeUloge}, IDFilm = {Film.IDFilm}, IDGlumac = {Glumac.IDGlumca}, Recenzija = '{Recenzija}'";
        }

        public string VratiImeID()
        {
            return "IDRecenzijeUloge";
        }

        public string VratiImeKlase()
        {
            return "RecenzijaUloge";
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
            throw new NotImplementedException();
        }

        public string VratiVrednostAtributa()
        {
            return $"{IDRecenzijeFilma}, {IDRecenzijeUloge}, '{Recenzija}', {Film.IDFilm}, {Glumac.IDGlumca}";
        }
    }
}
