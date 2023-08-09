using FiguresLib.Exceptions;
using FiguresLib.Interfaces;

namespace FiguresLib.Figures
{
    public class Triangle : IFigure
    {
        private readonly List<double> _sortedSizes;

        internal Triangle(double a, double b, double c)
        {
            _sortedSizes = new List<double> { a, b, c };
            _sortedSizes.Sort();
        }

        public double GetArea()
        {
            Validate();

            var p = _sortedSizes.Sum() / 2;
            return Math.Sqrt(p * (p - _sortedSizes[0]) * (p - _sortedSizes[1]) * (p - _sortedSizes[2]));
        }

        public bool IsOrthogonal()
        {
            Validate();

            return _sortedSizes[2] * _sortedSizes[2] == _sortedSizes[1] * _sortedSizes[1] + _sortedSizes[0] * _sortedSizes[0];
        }

        private void Validate()
        {
            if (_sortedSizes.Any(x => x < 0))
                throw new NegativeSizeParameterException();

            if (_sortedSizes[2] > _sortedSizes[1] + _sortedSizes[0])
                throw new InvalidTriangleException();
        }
    }
}
