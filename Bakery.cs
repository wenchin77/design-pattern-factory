namespace factory
{
    public abstract class Bakery
    {
        public abstract IFlour CreateFlour(int amount);
        public abstract IOil CreateOil(int amount);
    }
}