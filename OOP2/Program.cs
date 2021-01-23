using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soyutlama Mantığı...

            //Baresss...
            ReelCustomer customer1 = new ReelCustomer();
            customer1.ID = 1;
            customer1.CustumerNo = "12345";
            customer1.Name = "Barış";
            customer1.LastName = "Karakaya";
            customer1.TcNo = "1425678945";

            //Kodlama.io...

            CompanyCustomer customer2 = new CompanyCustomer();
            customer2.ID = 2;
            customer2.CustumerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "423568751";


            //SOLID...
            //Gerçek Müşteri - Tüzel Müşteri...

            Customer customer3 = new ReelCustomer();
            Customer customer4 = new CompanyCustomer();
            //Customer Sınıfı her iki sınıfında referansını tutabiliyor...
            //Base sınıf bir referans tutucudu...
        }
    }
}
