namespace LearningCompositon
{
    /// <summary>
    /// 1. Composition: Uses objects as fields to build more complex functionality.
    /// 2. Creates more loosly coupled code 
    /// 
    /// </summary>
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