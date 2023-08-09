using FiguresLib.Figures;
using FiguresLib.Interfaces;

namespace FiguresLib
{
    public static class FiguresFactory
    {
        public static IFigure CreateFigure(params double[] sizes)
        {
            switch (sizes.Length)
            {
                case 1:
                    return new Circle(sizes[0]);
                case 3:
                    return new Triangle(sizes[0], sizes[1], sizes[2]);
                default:
                    throw new NotSupportedException("Sizes array length");
            }
        }
    }
}
