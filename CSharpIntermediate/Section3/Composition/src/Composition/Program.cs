using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var migrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            migrator.Migrate();
            installer.Install();
        }
    }
}
