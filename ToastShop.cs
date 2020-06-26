namespace factory
{
    public class ToastShop : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }
    }
}