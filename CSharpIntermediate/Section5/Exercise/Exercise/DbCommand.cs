using System;

namespace Exercise
{
    public class DbCommand
    {
        public DbCommand(DbConnection connection)
        {
            if (connection == null) throw new ArgumentNullException("connectionString");
            DbConnection = connection;
        }

        public DbConnection DbConnection { get; set; }

        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine("Execute the query");
            DbConnection.CloseConnection();
        }
    }
}