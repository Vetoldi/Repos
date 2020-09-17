using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Rectangle
    {
        
             
        
        private double side1,side2,area,perimtr;

        public Rectangle()
        {
        }


        private Rectangle(double side1, double side2)
        {
            this.side1 = side1;

            this.side2 = side2;

        }

        public double AreaCalculator( double side1, double side2)
        {
            area = side1 * side2;
            return area;
            
        }

        public double PerimeterCalculator(double side1, double side2) 
        {
            perimtr = (side1 + side2) * 2;
            return perimtr;
           
        }
        public double Area { get { return area; } }
        public double Perimeter { get { return perimtr; } }

    }
}
