using System;

namespace Exercise
{
    public class DbConnection
    {
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public virtual void OpenConnection()
        {
            // Open connection...
        }

        public virtual void CloseConnection()
        {
            // Close connection...
        }
    }
}