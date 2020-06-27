namespace factory
{
    public class CakeFactory : Bakery
    {
        public override IBread CreateBread(string name)
        {
            Cake cake = new Cake(name);
            if (name == "Cheesecake")
            {
                cake.Shape = "square";
            }
            else
            {
                cake.Shape = "round";
            }
            return cake;
        }
    }
}