namespace exception
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException() 
        { 
        }

        public NotAvailableException(string? message) : base(message)
        {
        }
    }
}
