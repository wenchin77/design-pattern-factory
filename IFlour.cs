namespace factory
{
    public interface IFlour
    {
        string Name { get; set; }
        int Amount { get; set; }
        string GetIngredient();
    }
}