using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elmasi";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 60;
            product2.Explanation = "Mersin Karpuzu";

            Product[] products = new Product[] {product1, product2};

            foreach  (Product items in products)
            {
                Console.WriteLine(items.ProductName + "\n" + "Price : " + items.Price + "\n" + items.Explanation +"\n");
            }

            Console.WriteLine("--------------Methods-----------------\n");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            Console.WriteLine("--------------Methods-----------------\n");

            sepetManager.Add2("Armut", "Acayip bir Armut", 15, 5);
            sepetManager.Add2("Elma", "Acayip bir Elma", 10, 7);
            sepetManager.Add2("Mandalina", "Acayip bir Mandalina", 5, 3);
        }
    }
}
