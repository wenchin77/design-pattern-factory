using System;
using System.Collections.Generic;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make some bread!");
            List<IBread> breadList = new List<IBread>();
            var cakeMaker = new CakeMaker();
            var toastMaker = new ToastMaker();
            var bread = toastMaker.CreateBread("Peanut butter toast");
            var bread1 = toastMaker.CreateBread("Chocolate toast");
            var bread2 = cakeMaker.CreateBread("Cheesecake");
            var bread3 = cakeMaker.CreateBread("Strawberry cake");
            breadList.AddRange(new IBread[] { bread, bread1, bread2, bread3 });

            foreach (var item in breadList)
            {
                switch (item)
                {
                    case Toast x:
                        Console.WriteLine(x.GetBreadName());
                        break;
                    case Cake x:
                        Console.WriteLine(x.GetBreadName());
                        Console.WriteLine(x.GetShape());
                        break;
                    default:
                        throw new ArgumentException("Wrong bread type");
                }
            }
        }
    }
}
