using System;


namespace DesignPatterns.SOLID
{
    public class DbContext
    {
        public void Save(User user)
        {
            Console.WriteLine("Saved");
        }
    }
}
