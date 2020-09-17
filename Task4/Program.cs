using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
