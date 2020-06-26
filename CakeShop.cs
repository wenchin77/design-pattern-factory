namespace factory
{
    public class CakeShop : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Cake(name);
        }
    }
}