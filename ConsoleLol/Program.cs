using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLol
{
    class Address
    {
        private string country, city, street = null;
        public string Country
        {
            set
            {
                if (value != "проверка")
                    country = value;
                else
                    country = "проверка";
            }
            get
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                if (value != "проверка")
                    city = value;
                else
                    city = "проверка";
            }
            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                if (value != "проверка")
                    street = value;
                else
                    street = "проверка";
            }
            get
            {
                return street;
            }
        }
        public int Index { set; get; }
        public int House { set; get; }
        public int Appartment { set; get; }
        public void ReadAddress()
        {
            Console.WriteLine("Введите страну: ");
            country = Console.ReadLine();
            Console.WriteLine("Введите город: ");
            city = Console.ReadLine();
            Console.WriteLine("Введите улицу: ");
            street = Console.ReadLine();
            Console.WriteLine("Введите индекс: ");
            Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дома: ");
            House = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите квартиру: ");
            Appartment = Convert.ToInt32(Console.ReadLine());
        }
        public void WriteAddress()
        {
            Console.WriteLine($"Ты живешь по адресу {country}, город {city}, улица {street}, дом {House}, квартира {Appartment}. Индекс {Index}");
        }

        public Address(string country, string city, string street, int index, int house, int appartment)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            Index = index;
            House = house;
            Appartment = appartment;
        }

        public Address()
        {
        }
    }