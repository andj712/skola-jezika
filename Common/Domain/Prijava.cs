using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Prijava:IEntity
    {
        public Korisnik User { get; set; } 
        
        public DateTime DatumPrijave { get; set; }

        public Grupa Grupa { get;  set; }

        public string TableName => "Prijava";

        public string Values => $"Prijava+{DatumPrijave}";

        public object PrimaryKey => "";

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
            return "@IdKorisnika,@IdGrupe,@DatumPrijave";
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
            throw new NotImplementedException();
        }

        public string Join()
        {
            throw new NotImplementedException();
        }

        public void ParametersForCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@IdKorisnika", User.Id);
           
            cmd.Parameters.AddWithValue("@DatumPrijave", DatumPrijave);
           cmd.Parameters.AddWithValue("@IdGrupe", Grupa.Id);
           

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
