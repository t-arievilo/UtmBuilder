namespace UtmBuilder.Core.ValueObjects;

public class InvalidUrlException : Exception
{
    public InvalidUrlException(string message = "Invalid url") : base(message)
    {
        
    }
}