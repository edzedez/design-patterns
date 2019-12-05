namespace DoFactory.GangOfFour.Abstract.RealWorld
{

    abstract class ContinentFactory

    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
