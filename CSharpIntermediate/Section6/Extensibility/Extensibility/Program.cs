using System;

namespace Extensibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("D:\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}