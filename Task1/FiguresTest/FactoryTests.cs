using FiguresLib;

namespace FiguresTest
{
    public class FactoryTests
    {
        [Fact]
        public void NoParametersTest()
        {
            Assert.Throws<NotSupportedException>(() => FiguresFactory.CreateFigure());
        }

        [Fact]
        public void InvalidNumberOfParametersTest()
        {
            Assert.Throws<NotSupportedException>(() => FiguresFactory.CreateFigure(1, 2));
        }
    }
}
