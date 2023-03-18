using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.CategoryId = 2;
            p1.ProductName = "Kahve Makinesi";
            p1.UnitPrice = 4500;
            p1.UnitsInStock = 2;

            Product p2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "İphone 14 Pro Max",
                UnitPrice = 50000,
                UnitsInStock = 5
            };

            //PascalCase   camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(p1);
            productManager.Add(p2);

            //eklenen ürünlerin listelenmesi
            Product[] products = new Product[] { p1, p2 };
            Console.WriteLine();

            Console.WriteLine("Eklenen Ürünlerin Listesi");
            Console.WriteLine();

            productManager.ListProduct(products);
            Console.WriteLine("Uygulama sonlandırıldı!");
            

        }
    }
}
