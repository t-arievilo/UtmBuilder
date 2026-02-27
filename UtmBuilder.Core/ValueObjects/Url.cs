namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObjects
{
    public Url(string address)
    {
        Address = address;
    }
    
    
    public string Address { get; }
}