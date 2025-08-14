namespace LearningCompositon
{
    class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            Console.WriteLine("We are migrating the database.");
        }
    }
}