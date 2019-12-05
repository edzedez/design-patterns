namespace DesignPatterns.FactoryPatternPractice
{
    public class FarmAnimal : AnimalCreator
    {
        public override IAnimal CreateAnimal()
        {
            var pig = new Pig();
            pig.Move();
            return new Pig();
        }
    }




}
