namespace FiguresLib.Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
        {
        }

        public InvalidTriangleException(string? message) : base(message)
        {
        }

        public InvalidTriangleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
