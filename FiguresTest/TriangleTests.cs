using FiguresLib.Exceptions;
using FiguresLib;

namespace FiguresTest
{
    public class TriangleTests
    {
        private double Tolerance = 1e-4;

        [Fact]
        public void TriangleTest()
        {
            var a = 1;
            var b = 1;
            var c = 1.5;
            var expectedArea = 0.49607;

            var triangle = FiguresFactory.CreateFigure(a, b, c);
            var res = triangle.GetArea();

            Assert.Equal(expectedArea, res, Tolerance);
        }

        [Fact]
        public void TriangleDegeneratedTest()
        {
            var a = 1;
            var b = 1;
            var c = 2;
            var expectedArea = 0;

            var triangle = FiguresFactory.CreateFigure(a, b, c);
            var res = triangle.GetArea();

            Assert.Equal(expectedArea, res, Tolerance);
        }


        [Fact]
        public void TriangleNegativeTest()
        {
            var a = -1;
            var b = 1;
            var c = 1;

            var triangle = FiguresFactory.CreateFigure(a, b, c);
            Assert.Throws<NegativeSizeParameterException>(() => triangle.GetArea());
        }

        [Fact]
        public void TriangleInvalidTest()
        {
            var a = 1;
            var b = 1;
            var c = 3;

            var triangle = FiguresFactory.CreateFigure(a, b, c);
            Assert.Throws<InvalidTriangleException>(() => triangle.GetArea());
        }
    }
}
