using FiguresLib;
using FiguresLib.Exceptions;

namespace FiguresTest
{
    public class CircleTests
    {
        private double Tolerance = 1e-4;

        [Fact]
        public void CircleTest()
        {
            var radius = 1;
            var expectedArea = Math.PI;

            var circle = FiguresFactory.CreateFigure(radius);
            var res = circle.GetArea();

            Assert.Equal(expectedArea, res, Tolerance);
        }

        [Fact]
        public void CircleDegeneratedTest()
        {
            var radius = 0;
            var expectedArea = 0;

            var circle = FiguresFactory.CreateFigure(radius);
            var res = circle.GetArea();

            Assert.Equal(expectedArea, res, Tolerance);
        }

        [Fact]
        public void CircleNegativeTest()
        {
            var radius = -1;

            var circle = FiguresFactory.CreateFigure(radius);
            Assert.Throws<NegativeSizeParameterException>(()=> circle.GetArea());
        }
    }
}