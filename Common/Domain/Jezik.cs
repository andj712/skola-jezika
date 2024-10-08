using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Jezik : IEntity
    {
        public int Id { get; set; }
        public string NazivJezika { get; set; }
        public string TableName => "Jezik";

        public string Values => NazivJezika;

        public object PrimaryKey => "Id";

        public object ByIDAzuriraj()
        {
            throw new NotImplementedException();
        }

        public string GetAttributesForSearch()
        {
            throw new NotImplementedException();
        }

        public string GetByID()
        {
            throw new NotImplementedException();
        }

        public object GetByIDForDelete()
        {
            throw new NotImplementedException();
        }

        public string GetParametres()
        {
            throw new NotImplementedException();
        }

        public string GetQueryForSearch(string search)
        {
           
            return "LOWER(NazivJezika) LIKE CONCAT('%',LOWER(''),'%')"; 
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Jezik jezik = new Jezik()
                {

                    Id = (int)reader["id"],
                NazivJezika = (string)reader["nazivJezika"]



            };

            entities.Add(jezik);
        }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string Join()
        {
           return "";
        }

        public void ParametersForCommand(SqlCommand cmd)
        {
            throw new NotImplementedException();
        }

        public string QueryForUpdate()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return NazivJezika;
        }
    }
}
