namespace factory
{
    public interface IOil
    {
        string Name { get; set; }
        int Amount { get; set; }
        string GetIngredient();
    }
}