using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObjects
{
        public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }
    
    
    public string Address { get; }
}