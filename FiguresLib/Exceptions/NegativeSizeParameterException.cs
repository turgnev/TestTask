namespace FiguresLib.Exceptions
{
    public class NegativeSizeParameterException : Exception
    {
        public NegativeSizeParameterException()
        {
        }

        public NegativeSizeParameterException(string? message) : base(message)
        {
        }

        public NegativeSizeParameterException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
