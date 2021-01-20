using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Product türünden bir product parametresi...
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //void; metotun sonucunda bir değer döndürülmüyorsa kullanılır...
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        
    }
}
