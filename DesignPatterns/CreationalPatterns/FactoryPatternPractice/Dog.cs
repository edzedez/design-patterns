using System;

namespace DesignPatterns.FactoryPatternPractice
{
    public class Dog : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Dog is walking");
        }
    }
}
