using CalcFigure.Models.SqureCalculator.Implementations;
using System;
using Xunit;

namespace SqureCalcilatorTests
{
    public class CircleTest
    {
        [Fact]
        public void Squre_equal_zero_when_radius_zero()
        {
            //Arrange
            var circleWithZeroRadius = new Circle(0);
            var circleWithPositiveRadius = new Circle(1);

            //Act
            var square = circleWithZeroRadius.GetSquare();

            //Assert
            Assert.Equal(square, 0);

            //Act
            square = circleWithPositiveRadius.GetSquare();

            //Assert
            Assert.NotEqual(square, 0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-1234)]
        [InlineData(-0.1234)]
        public void Circle_with_negative_radius_cant_be(double radius)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(100, Math.PI * 10000)]
        public void Check_work_with_positive_radius(double radius, double expectedResult)
        {
            //Arrange
            var circleWithPositiveRadius = new Circle(radius);

            //Act
            var square = circleWithPositiveRadius.GetSquare();

            //Assert
            Assert.Equal(square, expectedResult);
        }
    }
}
