using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();   
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
           


        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.GetParametres()})";
            obj.ParametersForCommand(cmd);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public int AddAndReturnId(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {entity.TableName} OUTPUT INSERTED.{entity.PrimaryKey} VALUES({entity.GetParametres()})";
            entity.ParametersForCommand(cmd);
            var id = cmd.ExecuteScalar();
            cmd.Dispose();
            return (int)id;
        }

        

        public List<IEntity> GetAll(IEntity entity,string search="")
        {
            SqlCommand command = connection.CreateCommand();
            
            command.CommandText = $"select * from {entity.TableName}{entity.Join()} WHERE {entity.GetQueryForSearch(search)}";
            
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            reader.Close();
            command.Dispose();
            return list;
        }
       
       
        public IEntity GetById(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}{entity.Join()} where {entity.GetByID()}";
            SqlDataReader reader = command.ExecuteReader();
            entity = entity.GetReaderResult(reader);
            reader.Close();
            command.Dispose();
            return entity;
        }

        public void Azuriraj(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {entity.TableName} SET {entity.QueryForUpdate()} WHERE {entity.ByIDAzuriraj()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Izbrisi(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.GetByIDForDelete()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        



    }
}
