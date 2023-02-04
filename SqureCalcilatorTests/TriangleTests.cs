using CalcFigure.Models.SqureCalculator.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SquareCalcilatorTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, -1, -1)]
        [InlineData(0, 0, -1)]
        [InlineData(0, -1, 0)]
        [InlineData(-1, 0, 0)]
        public void Triangle_with_negative_side_should_not_be(
            double firstSide, double secondSide, double thirdSide)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 1, 1)]
        [InlineData(12, 5, 6)]
        public void TriangleSide_should_be_less_than_otherSideSum(
            double firstSide, double secondSide, double thirdSide)
        {
            //Asssert
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
            Assert.Throws<ArgumentException>(() => new Triangle(secondSide, thirdSide, firstSide));
            Assert.Throws<ArgumentException>(() => new Triangle(thirdSide, firstSide, secondSide));
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(2, 4, 5, false)]
        [InlineData(1, 1, 1, false)]
        [InlineData(3, 1, 3, false)]
        public void Check_for_right_triangle(double firstSide,
            double secondSide, double thirdSide, bool expected)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var isRightTriangle = triangle.CheckForRightTriangle(out var _, out var _);

            //Assert
            Assert.Equal(isRightTriangle, expected);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 8, 12)]
        [InlineData(5, 5, 6, 12)]
        public void Check_work_with_positive_sides(double firstSide,
            double secondSide, double thirdSide, double expected)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var square = triangle.GetSquare();

            //Assert
            Assert.Equal(square, expected);
        }
    }
}
