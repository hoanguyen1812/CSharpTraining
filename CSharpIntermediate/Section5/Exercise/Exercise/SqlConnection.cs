using System;

namespace Exercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Timeout = new TimeSpan(1);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open sql connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close sql connection...");
        }
    }
}