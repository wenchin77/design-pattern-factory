namespace factory
{
    public class Toast : IBread
    {
        public string Name { get; set; }
        public Toast(string name)
        {
            Name = name;
        }
        public string GetBreadName()
        {
            return $"Toast: {this.Name}";
        }
    }
}