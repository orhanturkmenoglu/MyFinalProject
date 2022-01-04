using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();

            //ProductManager productManager = new ProductManager(inMemoryProductDal);
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}


            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
