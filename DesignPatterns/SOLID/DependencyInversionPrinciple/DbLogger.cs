namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class DbLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.  
        }
    }
}
