using System;

namespace Exercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Timeout = new TimeSpan(1);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open oracle connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close oracle connection...");
        }
    }
}