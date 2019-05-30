using System;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string oracleConnectionString = "abcxyz";
            var oracleConnection = new OracleConnection(oracleConnectionString);
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            const string sqlConnectionString = "123456";
            var sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();
            Console.Clear();

            var dbCommand = new DbCommand(oracleConnection);
            dbCommand.Execute();
        }
    }
}