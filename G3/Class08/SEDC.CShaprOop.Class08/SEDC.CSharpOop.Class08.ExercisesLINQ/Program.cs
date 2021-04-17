using SEDC.CSharpOop.Class08.ExercisesLINQ.Classes;
using SEDC.CSharpOop.Class08.ExercisesLINQ.Services;
using System;

namespace SEDC.CSharpOop.Class08.ExercisesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            // TODO: Test this methods
            Product product = productService.GetCheapestProductLINQ();
            int productPrice = 0;
            try
            {
                productPrice = productService.GetProductPrice("Headphones2");
            }
            catch (Exception)
            {
                Console.WriteLine("The product does not exist!");
            }
            Console.WriteLine(productPrice);
            Console.WriteLine($"{product.Name} with price {product.Price} in category {product.Category}");

            Console.ReadLine();
        }
    }
}
