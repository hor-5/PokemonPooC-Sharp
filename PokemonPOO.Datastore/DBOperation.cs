using Dapper;
using System.Data.SqlClient;

namespace PokemonPOO.Datastore
{
    public class DBOperation
    {
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\source\repos\PokemonPOO\PokemonPOO.Datastore\Database\DBpokemonPOO.mdf;Integrated Security=True";

        public List<T> OperationQuery<T>(string sqlQuery)
        {
            List<T> LstResult;
            using (var connection = new SqlConnection(ConnectionString))
            {
                LstResult = connection.Query<T>(sqlQuery).ToList();
            }
            return LstResult;
        }

        public T OperationQueryById<T>(string sqlQuery)
        {
            T result;
            using (var connection = new SqlConnection(ConnectionString))
            {
                result = connection.Query<T>(sqlQuery).First();
            }
            return result;
        }

        public int OperationExecute(string SQLExecute, object paramList)
        {
            int affectedRows;
            using (var connection = new SqlConnection(ConnectionString))
            {
                affectedRows = connection.Execute(SQLExecute, paramList);
            }
            return affectedRows;
        }

        public int OperationExecuteWithIdentity(string SQLExecute, object paramList)
        {
            int identity;
            using (var connection = new SqlConnection(ConnectionString))
            {
                identity = connection.ExecuteScalar<int>(SQLExecute, paramList);
            }
            return identity;
        }
    }
}
