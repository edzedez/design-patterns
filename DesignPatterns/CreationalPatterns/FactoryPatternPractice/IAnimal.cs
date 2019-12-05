using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPatternPractice
{
    public interface IAnimal
    {
         void Move();
    }

    public class MainApp
    {
        static void Main()
        {
            var animalCreator = new List<AnimalCreator>();

            //animalCreator[0] = new FarmAnimal();
            //animalCreator[1] = new PetAnimal();

            animalCreator.Add(new FarmAnimal());
            animalCreator.Add(new PetAnimal());

            foreach (var creator in animalCreator)
            {
                Console.WriteLine(" " + animalCreator.GetType().Name);

            }
            Console.ReadKey();
        }
    }


}
