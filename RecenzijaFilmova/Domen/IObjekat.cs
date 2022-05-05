using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IObjekat
    {
        string VratiVrednostAtributa();
        string VratiImeKlase();
        string PostaviVrednostAtributa();
        string VratiUslovZaTrazenje();
        string VratiImeID();
        List<IObjekat> VratiListu(SqlDataReader reader);
        IObjekat VratiObjekat(SqlDataReader reader);


    }
}
