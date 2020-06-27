namespace factory
{
    public class Flour : IFlour
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public string GetIngredient()
        {
            return $"Flour name: {this.Name}\nFlour amount: {this.Amount}";
        }
    }
}
