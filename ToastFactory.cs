namespace factory
{
    public class ToastFactory : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }
    }
}