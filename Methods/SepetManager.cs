using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // Convention - Yazma methodu. İlk har büyük gibi
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Added to Card!");
        }

        public void Add2(string productName, string explanation, Double price, int stock)
        {
            Console.WriteLine(productName + " Added to Card!");
        }
    }
}
