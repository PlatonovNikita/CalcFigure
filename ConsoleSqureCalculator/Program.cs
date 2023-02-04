using CalcFigure.Models;
using CalcFigure.Models.SqureCalculator;
using System;

namespace ConsoleSqureCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISquareCalculator squreCalculator = null;
            Console.WriteLine("Enter type of figure\n" +
                              "1. Circle\n" +
                              "2. Triangle");
            switch (Console.ReadLine())
            {
                case "1":
                {
                    squreCalculator = FigureBuildHelper.CircleFactory();
                    break;
                }
                case "2":
                {
                    squreCalculator = FigureBuildHelper.TriangleFactory();
                    break;
                }
            }

            Console.WriteLine($"Squre equals: {squreCalculator.GetSquare()}");
        }
    }
}
