namespace DesignPatterns.AbstractFactoryPatternPractice
{
    public class Client
    {
        private readonly SportsCar sportsCar;
        private readonly SUV suv;

        public Client(CarFactory carFactory)
        {
            sportsCar = carFactory.CreateSportsCar();
            suv = carFactory.CreateSUV();
        }

        public void Run()
        {

        }

    }
}
