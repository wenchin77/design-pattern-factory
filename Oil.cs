namespace factory
{
    public class Oil : IOil
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public string GetIngredient()
        {
            return $"Oil name: {this.Name}\nOil amount: {this.Amount}";
        }
    }
}
