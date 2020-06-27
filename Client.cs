using System;

namespace factory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Let's make some bread!");
            
            var cakeMaker = new CakeFactory();
            Console.WriteLine("Cheesecake");
            CreateBread(cakeMaker, 300, 100);
            Console.WriteLine("Strawberry cake");
            CreateBread(cakeMaker, 400, 150);

            var toastMaker = new ToastFactory();
            Console.WriteLine("Chocolate toast");
            CreateBread(toastMaker, 200, 50);
            Console.WriteLine("Peanut butter toast");
            CreateBread(toastMaker, 200, 80);
        }
        void CreateBread(Bakery factory, int flourAmount, int oilAmount)
        {
            var flour = factory.CreateFlour(flourAmount);
            var oil = factory.CreateOil(oilAmount);
            Console.WriteLine("---");
            Console.WriteLine(flour.GetIngredient());
            Console.WriteLine(oil.GetIngredient());
            Console.WriteLine("---");
        }
    }
}