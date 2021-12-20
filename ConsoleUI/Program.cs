using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //var result = productManager.GetAllByCategoryId(2);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            var result2 = productManager.GetByUnitPrice(50, 100);

            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
