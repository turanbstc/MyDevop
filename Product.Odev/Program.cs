using System;

namespace Product.Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product items = new Product();
            items.ProductName = "Sweatshirt";
            items.Brand = "Lacoste";
            items.Price = 570;
            items.DiscountRate = 10;
            items.PriceAfterDiscount = items.Price - ((items.Price * items.DiscountRate) / 100);

            Product items1 = new Product();
            items1.ProductName = "Jackets";
            items1.Brand = "Tommy Hilfiger";
            items1.Price = 1570;
            items1.DiscountRate = 20;
            items1.PriceAfterDiscount = items1.Price - ((items1.Price * items1.DiscountRate) / 100);

            Product items2 = new Product();
            items2.ProductName = "Jeans";
            items2.Brand = "Levis";
            items2.Price = 380;
            items2.DiscountRate = 12;
            items2.PriceAfterDiscount = items2.Price - ((items2.Price * items2.DiscountRate) / 100);

            Product[] products = new Product[] { items, items1, items2 };

            foreach (Product item in products)
            {
                Console.WriteLine(item.ProductName + "\n" + item.Brand + "\n" + "Price: " + item.Price + " TL" + "\n" + " Discount Rate: %" 
                    + item.DiscountRate + "\n" + " Price After Discount: " + item.PriceAfterDiscount+ " TL" + "\n");
            }
            Console.WriteLine("\n End Of Foreach Loop \n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + "\n" + products[i].Brand + "\n" + "Price: " +  products[i].Price + " TL" + "\n" + " Discount Rate: %" 
                    + products[i].DiscountRate + "\n" + " Price After Discount: " + products[i].PriceAfterDiscount + " TL" + "\n");
            }
            Console.WriteLine("\n End of For Loop \n");

            int counter = 0;
            while (counter < products.Length)
            {
                Console.WriteLine(products[counter].ProductName + "\n" + products[counter].Brand + "\n" + "Price: " + products[counter].Price + " TL" + "\n" + " Discount Rate: %"
                    + products[counter].DiscountRate + "\n" + " Price After Discount: " + products[counter].PriceAfterDiscount + " TL" + "\n");
                counter++;
            }
            Console.WriteLine("\n End of While Loop \n");
        }
    }

    class Product
    {
        public string ProductName { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }

        public int DiscountRate { get; set; }

        public int PriceAfterDiscount { get; set; }
    }

}
