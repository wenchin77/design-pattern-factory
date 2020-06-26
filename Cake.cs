namespace factory
{
    public class Cake : IBread
    {
        public string Name { get; set; }
        public string GetBreadName()
        {
            return this.Name;
        }
        public Cake(string name)
        {
            Name = name;
        }
    }
}