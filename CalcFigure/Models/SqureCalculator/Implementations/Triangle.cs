using System;

namespace CalcFigure.Models.SqureCalculator.Implementations
{
    public class Triangle : ISquareCalculator
    {
        private double _firstSide;

        private double _secondSide;

        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0)
            {
                throw new ArgumentException($"{nameof(firstSide)} can't be negative");
            }
            if (secondSide < 0)
            {
                throw new ArgumentException($"{nameof(secondSide)} can't be negative");
            }
            if (thirdSide < 0)
            {
                throw new ArgumentException($"{nameof(thirdSide)} can't be negative");
            }

            if (firstSide >= secondSide + thirdSide)
            {
                throw new ArgumentException($"{nameof(firstSide)} should be less than other sides sum");
            }
            if (secondSide >= firstSide + thirdSide)
            {
                throw new ArgumentException($"{nameof(secondSide)} should be less than other sides sum");
            }
            if (thirdSide >= firstSide + secondSide)
            {
                throw new ArgumentException($"{nameof(thirdSide)} should be less than other sides sum");
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public bool CheckForRightTriangle(out double firstCathet, out double secondCathet)
        {
            double hypotenuse = 0;
            firstCathet = 0;
            secondCathet = 0;

            if (_firstSide >= _thirdSide)
            {
                if (_firstSide >= _secondSide)
                {
                    hypotenuse = _firstSide;
                    firstCathet = _secondSide;
                    secondCathet = _thirdSide;
                }
                else
                {
                    hypotenuse = _secondSide;
                    firstCathet = _thirdSide;
                    secondCathet = _firstSide;
                }
            }
            else if (_thirdSide > _secondSide)
            {
                hypotenuse = _thirdSide;
                firstCathet = _firstSide;
                secondCathet = _secondSide;
            }

            if (Math.Pow(hypotenuse, 2)
                == Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2))
            {
                return true;
            }

            return false;
        }

        public double GetSquare()
        {
            if (CheckForRightTriangle(out double firstCathet, out double secondCathet))
            {
                return firstCathet * secondCathet / 2;
            }

            var halfPerimetr = (_firstSide + _secondSide + _thirdSide) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - _firstSide)
                             * (halfPerimetr - _secondSide)
                             * (halfPerimetr - _thirdSide));
        }
    }
}
