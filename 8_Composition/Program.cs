namespace LearningCompositon
{
    class Program
    {
        public static void Main(string[] args)
        {

            var dbLogger = new DbMigrator(new Logger());
            dbLogger.Migrate();

            var installerLogger = new Installer(new Logger());
            installerLogger.Install();

        }
    }
}