using System;

namespace DesignPatterns.FactoryPatternPractice
{
    public class Pig : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Pig Walks");
        }

    }
}
