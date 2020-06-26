namespace factory
{
    public class ToastMaker : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }
    }
}