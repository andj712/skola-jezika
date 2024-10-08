using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Kurs:IEntity
    {
        public int Id { get; set; }
        public String NazivKursa { get; set; }
        public String Trajanje { get; set; }
        public String OpisKursa { get; set; }
        public int UkupanBrojCasova { get; set; }

        public Jezik Jezik { get; set; }

        public string TableName => "Kurs";

        public string Values => NazivKursa;

        public object PrimaryKey => "id";

        public object ByIDAzuriraj()
        {
            return $"Id={Id}";
        }

        public string GetAttributesForSearch()
        {
            return $"Id,NazivKursa";
        }

        public string GetByID()
        {
            return $"k.Id={Id}";
        }

        public object GetByIDForDelete()
        {
            return $"Id={Id}";
        }

        public string GetParametres()
        {
            return "@NazivKursa,@trajanje,@opisKursa,@ukupanBrojCasova,@idjezika";
        }

        public string GetQueryForSearch(string search)
        {
            return $"LOWER(NazivKursa) LIKE CONCAT('%',LOWER('{search}'),'%') order by nazivKursa;";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Kurs kurs = new Kurs()
                {
                    Id = (int)reader["id"],
                    NazivKursa = (string)reader["nazivKursa"],
                    Trajanje = (string)reader["trajanje"],
                    OpisKursa = (string)reader["opisKursa"],
                    UkupanBrojCasova = int.Parse(reader["ukupanBrojCasova"].ToString()),
                    Jezik = new Jezik {
                        Id = (int)reader["idjezika"],
                        NazivJezika = (string)reader["nazivJezika"]
                    },


                };
              
                entities.Add(kurs);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                return new Kurs()
                {
                    Id = (int)reader["id"],
                    NazivKursa = (string)reader["nazivKursa"],
                    Trajanje = (string)reader["trajanje"],
                    OpisKursa = (string)reader["opisKursa"],
                    UkupanBrojCasova = int.Parse(reader["ukupanBrojCasova"].ToString()),
                    Jezik = new Jezik
                    {
                        Id = (int)reader["idjezika"],
                        NazivJezika = (string)reader["nazivJezika"]
                    },
                };
            }
            else return null;
        }

        public string Join()
        {
            return " k join jezik j on k.idjezika=j.id";
        }

        public void ParametersForCommand(SqlCommand cmd)
        {

            cmd.Parameters.AddWithValue("@nazivKursa", NazivKursa);
            cmd.Parameters.AddWithValue("@trajanje", Trajanje);
            cmd.Parameters.AddWithValue("@opisKursa", OpisKursa);
            cmd.Parameters.AddWithValue("@ukupanBrojCasova", UkupanBrojCasova);
            cmd.Parameters.AddWithValue("@idjezika", Jezik.Id);
        }

        public string QueryForUpdate()
        {
            return $"NazivKursa='{NazivKursa}',OpisKursa='{OpisKursa}',Trajanje='{Trajanje}',UkupanBrojCasova={UkupanBrojCasova},idjezika={Jezik.Id}";
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Kurs kurs = new Kurs()
                {
                    Id = (int)reader["Id"],
                    NazivKursa = (string)reader["NazivKursa"],
                };
                entities.Add(kurs);
            }
            return entities;
        }

        public override string ToString()
        {
            return NazivKursa;
        }
    }
}
