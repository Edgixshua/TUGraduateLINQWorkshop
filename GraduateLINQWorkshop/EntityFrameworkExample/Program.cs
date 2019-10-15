using System;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var database = new northwndEntities())
            {
                var products = database.Products.Where(product => product.UnitPrice > 50);

                foreach (var product in products)
                {
                    Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
                }
            }

            Console.ReadLine();
        }
    }
}