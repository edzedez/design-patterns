namespace DesignPatterns.SOLID.LiskovSubtstitutionPrinciple
{
    public class ReadOnlySqlFile : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            return string.Empty;
        }
    }
}
