using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter(26.36, 29.43, 0.41);

            Console.WriteLine("Choose variant:");
            Console.WriteLine("1: Convert to grivna");
            Console.WriteLine("2: Convert from grivna");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void ConvertTo(Converter currencyConverter)
        {
            Console.WriteLine("Choose variant:");
            Console.WriteLine("1: Convert from USD");
            Console.WriteLine("2: Convert from EUR");
            Console.WriteLine("3: Convert from RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(Converter currencyConverter)
        {
            Console.WriteLine("Choose variant:");
            Console.WriteLine("1: Convert to USD");
            Console.WriteLine("2: Convert to EUR");
            Console.WriteLine("3: Convert to RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }
        }
    }
}
    
