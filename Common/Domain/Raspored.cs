using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Raspored:IEntity
    {

        public Dan Dan { get; set; }
        public string Trajanje { get; set; }
        public string VremePocetka { get; set; }
        public string BrojSale { get; set; }
        public Grupa Grupa { get; set; }

        public Stanje Stanje { get; set; }
        public string TableName => "Raspored";

        public string Values => Dan.ToString();

        public object PrimaryKey => Dan;

        public object ByIDAzuriraj()
        {
            return $"idGrupe={Grupa.Id} and dan='{Dan.ToString()}'";
        }

        public override bool Equals(object obj)
        {
            return obj is Raspored raspored &&
                   Dan.ToString() == raspored.Dan.ToString() &&
                   Trajanje == raspored.Trajanje &&
                   VremePocetka == raspored.VremePocetka &&
                   BrojSale == raspored.BrojSale ;
                   
        }

        public string GetAttributesForSearch()
        {
            throw new NotImplementedException();
        }

        public string GetByID()
        {
            return $"idGrupe={Grupa.Id} and dan='{Dan.ToString()}'";
        }

        public object GetByIDForDelete()
        {
            return $"idGrupe={Grupa.Id} and dan='{Dan.ToString()}'";
        }

        public override int GetHashCode()
        {
            int hashCode = -1129010746;
            hashCode = hashCode * -1521134295 + Dan.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Trajanje);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VremePocetka);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BrojSale);
            hashCode = hashCode * -1521134295 + EqualityComparer<Grupa>.Default.GetHashCode(Grupa);
            return hashCode;
        }

        public string GetParametres()
        {
            return "@idGrupe,@Dan,@Trajanje,@BrojSale,@VremePocetka";
        }

        public string GetQueryForSearch(string search)
        {
            return $"idGrupe={Grupa.Id}";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Raspored raspored = new Raspored()
                {
                    Grupa = new Grupa()
                    {
                        Id = reader.GetInt32(0),
                        NazivGrupe = reader.GetString(6),
                        DatumPocetka = reader.GetDateTime(7)
                    },
                    Dan = (Dan)Enum.Parse(typeof(Dan), reader.GetString(1)),
                    Trajanje = reader.GetString(2),
                    BrojSale = reader.GetString(3),
                    VremePocetka = reader.GetString(4),

                };

                    entities.Add(raspored);

        }     
            return entities;
        }


        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string Join()
        {
            return " r join grupa g on r.idGrupe=g.id";
        }

        public void ParametersForCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idGrupe", Grupa.Id);
            cmd.Parameters.AddWithValue("@Dan", Dan.ToString());
            cmd.Parameters.AddWithValue("@Trajanje", Trajanje);
            cmd.Parameters.AddWithValue("@VremePocetka", VremePocetka);
            cmd.Parameters.AddWithValue("@BrojSale", BrojSale);

        }

        public string QueryForUpdate()
        {
            return $"idGrupe={Grupa.Id},dan='{Dan}',Trajanje='{Trajanje}',brojSale='{BrojSale}',vremePocetka='{VremePocetka}'";
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
