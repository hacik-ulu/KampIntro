using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi:" + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi:" + product.ProductName);

        }

        public void ListProduct(Product[] products)
        {
            foreach (Product product in products) 
            {
                Console.WriteLine("Ürün Id:"+product.Id);
                Console.WriteLine("Kategori Id:"+product.CategoryId);
                Console.WriteLine("Ürün Birim Fiyatı:"+product.UnitPrice);
                Console.WriteLine("Ürün Adı:"+product.ProductName);
                Console.WriteLine("Ürün Stok Adedi:"+product.UnitsInStock);
                Console.WriteLine();
            }
        }
    }
}
