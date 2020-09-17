using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.apartment = 13;
            address.country = "Bruklin";
            address.city = "United States";
            address.house = 15;
            address.index = 22341;
            address.street = "Bulkina";

            // may be like below
            // address.apartment = int.Parse(Console.ReadLine());

            Console.WriteLine("Country: " + address.country + " , " + "City: " + address.city + 
                              " , " + "index: " + address.index + " , " + "Street: " + address.street + " , " + 
                               "House number: " + address.house + " , " + "Appartment number: " + address.apartment);
           
        }
    }
}
