namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    /// <summary>

    /// The 'ConcreteFactory1' class

    /// </summary>

    internal class AfricaFactory : ContinentFactory

    {
        public AfricaFactory()
        {
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
