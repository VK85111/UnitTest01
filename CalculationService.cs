using System;
using Calculation;
using FiguresList;
using Xunit;

namespace UnitTest01
{
    public class CalculationService
    {
        private readonly Calculator _calc = new Calculator();

        [Fact]
        public void CircleZeroTest()
        {
            var result = _calc.Calc(new Circle(0));
            Assert.Equal(0, result);
        }

        [Fact]
        public void CircleNullTest()
        {
            Assert.Throws<Exception>(() => _calc.Calc(null));
        }

        [Fact]
        public void CircleTest()
        {
            Circle circl = new Circle(5);
            
            Assert.Equal(79, Math.Round(_calc.CircleCalc(circl as Circle)), 2);
        }

        [Fact]
        public void TriangleTest()
        {
            Triangle triangl = new Triangle(5, 8, 9);
            Assert.Equal(19.9, Math.Round(_calc.TriangleCalc(triangl as Triangle), 2));
        }

        [Fact]
        public void TriangleChecking()
        {
            Triangle triangl = new Triangle(5, 8, 9);
            Assert.False(_calc.TriangleCheck(triangl as Triangle));
        }

    }
}
