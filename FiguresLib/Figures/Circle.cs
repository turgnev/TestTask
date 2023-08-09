using FiguresLib.Exceptions;
using FiguresLib.Interfaces;

namespace FiguresLib.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        internal Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            if (_radius < 0)
                throw new NegativeSizeParameterException();

            return Math.PI * _radius * _radius;
        }
    }
}
