namespace factory
{
    internal class Toast : IBread
    {
        public string Name { get; set; }
        public string GetBreadName()
        {
            return this.Name;
        }
        public Toast(string name)
        {
            Name = name;
        }
    }
}