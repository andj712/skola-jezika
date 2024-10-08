using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        object PrimaryKey { get; }

        string GetByID();

        IEntity GetReaderResult(SqlDataReader reader);

        List<IEntity> GetReaderList(SqlDataReader reader);
        string GetParametres();
        void ParametersForCommand(SqlCommand cmd);
        string GetAttributesForSearch();
        string Join();
        string GetQueryForSearch(string search);
        List<IEntity> ReadAllSearch(SqlDataReader reader);
        string QueryForUpdate();
        object ByIDAzuriraj();
        object GetByIDForDelete();
    }
}
