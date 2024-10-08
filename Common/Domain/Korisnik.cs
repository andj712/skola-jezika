using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Gmail { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public string TableName => "Korisnik";

        public string Values => KorisnickoIme;

        public object PrimaryKey => throw new NotImplementedException();

        public object ByIDAzuriraj()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Korisnik user &&
                   Id == user.Id &&
                   KorisnickoIme == user.KorisnickoIme &&
                   Lozinka == user.Lozinka &&
                   Ime == user.Ime &&
                   Prezime == user.Prezime &&
                   Gmail == user.Gmail &&
                   KontaktTelefon == user.KontaktTelefon &&
                   DatumRodjenja == user.DatumRodjenja;
                   
        }

        public string GetAttributesForSearch()
        {
            throw new NotImplementedException();
        }

        public string GetByID()
        {
            return $"korisnickoIme='{KorisnickoIme}' AND lozinka='{Lozinka}'";
        }

        public object GetByIDForDelete()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string GetParametres()
        {
            return "@ime,@prezime,@korisnickoIme,@lozinka,@mejl,@kontaktTelefon,@datumRodjenja";
        }

        public string GetQueryForSearch(string search)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Korisnik user = new Korisnik
                { 

                    Id = (int)reader["id"],
                    KorisnickoIme = (string)reader["korisnickoIme"],
                    Lozinka = (string)reader["lozinka"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    Gmail = (string)reader["mejl"],
                    KontaktTelefon = reader["kontaktTelefon"].ToString(),
                    DatumRodjenja = (DateTime)reader["datumRodjenja"]

                 };
                return user;
            }
            return null;
        }

        public string Join()
        {
            return "";
        }

        public void ParametersForCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@ime", Ime);
            cmd.Parameters.AddWithValue("@prezime", Prezime);
            cmd.Parameters.AddWithValue("@korisnickoIme", KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", Lozinka);
            cmd.Parameters.AddWithValue("@mejl", Gmail);
            cmd.Parameters.AddWithValue("@kontaktTelefon", KontaktTelefon);
            cmd.Parameters.AddWithValue("@datumRodjenja", DatumRodjenja);
        }

        public string QueryForUpdate()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
