namespace DesignPatterns.AbstractFactoryPatternPractice
{
    //concrete factory
    public class ToyotaFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new Toyota86();
        }

        public override SUV CreateSUV()
        {
            return new RAV4();
        }
    }
}
