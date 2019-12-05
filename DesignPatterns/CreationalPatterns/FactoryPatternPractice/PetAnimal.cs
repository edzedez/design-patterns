namespace DesignPatterns.FactoryPatternPractice
{
    public class PetAnimal : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            var dog = new Dog();
            dog.Move();
            return new Dog();
        }
    }




}
