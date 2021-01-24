using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerNumber = "12345";
            individualCustomer.Name = "Turan";
            individualCustomer.Surname = "Bastacioglu";
            individualCustomer.TcNo = "324123123";

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNumber = "3241";
            corporateCustomer.CompanyName = "BASTACIOGLU MUHENDISLIK";
            corporateCustomer.VatNo = "1231231";

            Customer customer1 = new CorporateCustomer();
            Customer customer2 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);
            
        }
    }
}
