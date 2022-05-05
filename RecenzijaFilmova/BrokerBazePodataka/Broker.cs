using Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;


        public int Izmeni(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"update {objekat.VratiImeKlase()} set {objekat.PostaviVrednostAtributa()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            return komanda.ExecuteNonQuery();
        }

        public List<IObjekat> VratiSveSaUslovom(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}";
            SqlDataReader reader = command.ExecuteReader();
            List<IObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public int Obrisi(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand($"delete from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            return komanda.ExecuteNonQuery();
        }

        public List<IObjekat> VratiSve(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.VratiImeKlase()} ";
            SqlDataReader reader = command.ExecuteReader();
            List<IObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();

            return rezultat;
        }

        public int Sacuvaj(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);
            
            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} values ({objekat.VratiVrednostAtributa()})";

            return komanda.ExecuteNonQuery();
        }

        /*public bool sacuvajFilm(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);

            int id = DajSledeciID(objekat);

            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} values ({id}, {objekat.VratiVrednostAtributa()})";
            komanda.ExecuteNonQuery();

            Film f = (Film)objekat;
            foreach(Uloga u in f.uloge)
            {
                u.IDFilm = id;
                SqlCommand komanda2 = new SqlCommand("", connection, transaction);
                komanda2.CommandText = $"insert into {u.VratiImeKlase()} values ({u.IDFilm}, {u.VratiVrednostAtributa()})";
                komanda2.ExecuteNonQuery();
            }
            return true;
        }
        */

        /*public bool SacuvajSlozen(IObjekat objekat)
        {
            SqlCommand command = new SqlCommand($"insert into {objekat.VratiImeKlase()} output {objekat.VratiImeID()} values ({objekat.PostaviVrednostAtributa()})", connection, transaction);
            Type t = objekat.GetType();
            int id = (int)command.ExecuteScalar();
            foreach (PropertyInfo o in t.GetProperties())
            {
                var tip = o.PropertyType.AssemblyQualifiedName;
                var nesto = Type.GetType(tip);
                if (nesto.IsGenericType && (nesto.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    var unos = (IList)o.GetValue(objekat);
                    foreach (IObjekat obj in unos)
                    {
                        SqlCommand command2 = new SqlCommand($"insert into {obj.VratiImeKlase()} values ({id}, {obj.PostaviVrednostAtributa()})", connection, transaction);
                        command2.ExecuteScalar();

                    }
                }
            }

            return true;

        }
        */
        /*public bool sacuvajRecenziju(IObjekat objekat)
        {
            SqlCommand komanda = new SqlCommand("", connection, transaction);
            int id = DajSledeciID(objekat);

            komanda.CommandText = $"insert into {objekat.VratiImeKlase()} values ({id}, {objekat.VratiVrednostAtributa()})";
            komanda.ExecuteNonQuery();

            Recenzija r = (Recenzija)objekat;
            foreach (RecenzijaUloge ru in r.RecenzijeUloga)
            {
                ru.IDRecenzijeFilma = id;
                SqlCommand komanda2 = new SqlCommand("", connection, transaction);
                komanda2.CommandText = $"insert into {ru.VratiImeKlase()} values ({ru.IDRecenzijeFilma}, {ru.VratiVrednostAtributa()})";
                komanda2.ExecuteNonQuery();
            }
            return true;
        }
        */
        public int DajSledeciID(IObjekat objekat)
        {
            try
            {
                SqlCommand komanda = new SqlCommand("", connection, transaction);
                komanda.CommandText = $"select max({objekat.VratiImeID()}) from {objekat.VratiImeKlase()}";
                try
                {
                    int id = Convert.ToInt32(komanda.ExecuteScalar());
                    return id + 1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecenzijaFilma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransakcije()
        {
            transaction.Commit();
        }

        public void RollbackTransakcije()
        {
            transaction.Rollback();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public IObjekat VratiJedan(IObjekat objekat)
        {
            IObjekat rezultat;

            SqlCommand command = new SqlCommand($"select * from {objekat.VratiImeKlase()} where {objekat.VratiUslovZaTrazenje()}", connection, transaction);
            SqlDataReader reader = command.ExecuteReader();
            rezultat = objekat.VratiObjekat(reader);
            reader.Close();
            return rezultat;
        }
    }
}
