namespace factory
{
    public class ToastFactory : Bakery
    {
        public override IFlour CreateFlour(int amount)
        {
            IFlour flour = new Flour();
            flour.Name = "bread flour";
            flour.Amount = amount;
            return flour;
        }
        public override IOil CreateOil(int amount)
        {
            IOil oil = new Oil();
            oil.Name = "olive oil";
            oil.Amount = amount;
            return oil;
        }
    }
}