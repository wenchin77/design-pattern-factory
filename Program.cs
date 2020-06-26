using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get some bread at CakeShop!");
            var bread = new CakeShop().CreateBread("Cheesecake");
            Console.WriteLine(bread.GetBreadName());
            var bread1 = new CakeShop().CreateBread("Strawberry cake");
            Console.WriteLine(bread1.GetBreadName());

            Console.WriteLine("Let's get some bread at ToastShop!");
            var bread2 = new ToastShop().CreateBread("Chocolate toast");
            Console.WriteLine(bread2.GetBreadName());
            var bread3 = new ToastShop().CreateBread("Peanut butter toast");
            Console.WriteLine(bread3.GetBreadName());
        }
    }
}
