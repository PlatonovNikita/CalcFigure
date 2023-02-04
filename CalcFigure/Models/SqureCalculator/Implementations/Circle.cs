using System;

namespace CalcFigure.Models.SqureCalculator.Implementations
{
    public class Circle : ISquareCalculator
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"{nameof(radius)} can't be negative!");
            }

            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
