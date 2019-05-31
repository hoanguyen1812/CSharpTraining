using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration stared at " + DateTime.Now);

            // Console.WriteLine("Migration stared at {0}", DateTime.Today);

            _logger.LogInfo("Migration end at " + DateTime.Now );

            // Console.WriteLine("Migration stared at {0}", DateTime.Today);
        }
    }
}