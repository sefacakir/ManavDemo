using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Product product1 = new Product()
            {
                ProductId = 1,
                ProductName = "Elma",
                Quantity = 30,
                UnitPrice = 3.45
            }; 

            productManager.Add(product1);


        }
    }
}
