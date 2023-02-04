using CalcFigure.Models.SqureCalculator.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSqureCalculator
{
    public static class FigureBuildHelper
    {
        public static Circle CircleFactory()
        {
            while (true) 
            {
                Console.WriteLine("Enter radius: ");
                if (double.TryParse(Console.ReadLine(), out var radius))
                {
                    return new Circle(radius);
                }
                Console.WriteLine("This isn't a number!");
            }
        }

        public static Triangle TriangleFactory()
        {
            double firstSide = 0, secondSide = 0, thirdSide = 0;
            while (true)
            {
                Console.WriteLine("Enter length of first side of triangle: ");
                if (double.TryParse(Console.ReadLine(), out firstSide))
                {
                    break;
                }
                Console.WriteLine("This isn't a number!");
            }
            while (true)
            {
                Console.WriteLine("Enter length of second side of triangle: ");
                if (double.TryParse(Console.ReadLine(), out secondSide))
                {
                    break;
                }
                Console.WriteLine("This isn't a number!");
            }
            while (true)
            {
                Console.WriteLine("Enter length of third side of triangle: ");
                if (double.TryParse(Console.ReadLine(), out thirdSide))
                {
                    break;
                }
                Console.WriteLine("This isn't a number!");
            }

            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
