namespace factory
{
    public class CakeFactory : Bakery
    {
        public override IFlour CreateFlour(int amount)
        {
            IFlour flour = new Flour();
            flour.Name = "cake flour";
            flour.Amount = amount;
            return flour;
        }
        public override IOil CreateOil(int amount)
        {
            IOil oil = new Oil();
            oil.Name = "butter";
            oil.Amount = amount;
            return oil;
        }
    }
}