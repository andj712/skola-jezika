using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Grupa : IEntity
    {
        public int Id { get; set; }

        public string NazivGrupe { get; set; }

        public DateTime DatumPocetka { get; set; }

        public Kurs Kurs { get; set; }

        public List<Raspored> Rasporedi { get; set; }
        public List<Raspored> StariRasporedi { get; set; }

        public Grupa()
        {
                Rasporedi=new List<Raspored>();
                
        }
        public string TableName => "Grupa";

       

        public string Values => NazivGrupe;

        public object PrimaryKey => "id";

        public string GetAttributesForSearch()
        {
            throw new NotImplementedException();
        }

        public string GetByID()
        {
            return $"g.Id={Id} ";

        }

        public string GetParametres()
        {
            return "@nazivGrupe,@datumPocetka,@idKursa";
        }

        public string GetQueryForSearch(string search)
        {
            return $"IdKursa={Kurs.Id} order by DatumPocetka";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Grupa grupa = new Grupa()
                {

                    Id = reader.GetInt32(0),
                    NazivGrupe = reader.GetString(1),
                    DatumPocetka = reader.GetDateTime(2),
                    Kurs = new Kurs
                    {
                        Id = reader.GetInt32(3),
                        NazivKursa = reader.GetString(5),
                        Trajanje = reader.GetString(6),
                        Jezik = new Jezik {
                            Id = reader.GetInt32(9),
                            NazivJezika=reader.GetString(11),
                        },
                        OpisKursa= reader.GetString(7),
                        UkupanBrojCasova = reader.GetInt32(8),


                    },
                    
                    

                };

                entities.Add(grupa);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                return new Grupa()
                {

                    Id = reader.GetInt32(0),
                    NazivGrupe = reader.GetString(1),
                    DatumPocetka = reader.GetDateTime(2),
                    Kurs = new Kurs
                    {
                        Id = reader.GetInt32(3),
                        NazivKursa = reader.GetString(5),
                        Trajanje = reader.GetString(6),
                        Jezik = new Jezik
                        {
                            Id = reader.GetInt32(9),
                            NazivJezika = reader.GetString(11),
                        },
                        OpisKursa = reader.GetString(7),
                        UkupanBrojCasova = reader.GetInt32(8),


                    },



                };
            }
             return null;
        }

        public string Join()
        {
            return " g join kurs k on (g.idKursa=k.id) join jezik j on (k.idjezika=j.id) ";
        }

        public void ParametersForCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nazivGrupe", NazivGrupe);
            cmd.Parameters.AddWithValue("@datumPocetka", DatumPocetka.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@idKursa", Kurs.Id);

        }

        public string QueryForUpdate()
        {
            return $"nazivGrupe='{NazivGrupe}',datumPocetka='{DatumPocetka.ToString("yyyy-MM-dd")}',idKursa={Kurs.Id}";
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public object ByIDAzuriraj()
        {
            return $"Id={Id} ";
        }

        public object GetByIDForDelete()
        {
            throw new NotImplementedException();
        }
    }
}
