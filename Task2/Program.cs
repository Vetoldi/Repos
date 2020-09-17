using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.Write("Введите длину прямоугольника -> ");
            
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника -> ");
            
            double side2 = double.Parse(Console.ReadLine());

            rectangle.AreaCalculator(side1, side2);
            rectangle.PerimeterCalculator(side1, side2);
            Console.WriteLine("Площадь = {0}", rectangle.Area);
            Console.WriteLine("Периметр = {0}", rectangle.Perimeter);


        }
    }
}
