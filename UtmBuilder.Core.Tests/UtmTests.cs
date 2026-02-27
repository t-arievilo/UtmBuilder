using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;
[TestClass]
public class UtmTests
{
    private const string Result = "https://google.com/?utm_source=src" +
                                  "&utm_medium=med" +
                                  "&utm_campaign=name" +
                                  "&utm_id=id" +
                                  "&utm_term=term" +
                                  "&utm_content=ctn";
    private readonly  Url _url = new ("https://google.com/");
    private readonly Campaign _campaign = new ("src", "med", "name", "id", "term", "ctn");
    
    
    [TestMethod]
    public void Deve_retornar_uma_string_a_partir_de_um_utm()
    {
        var utm = new Utm(_url, _campaign);
        var result = Result;
        Assert.AreEqual(Result, utm.ToString());
        Assert.AreEqual(Result, (string)utm);
    }

    [TestMethod]
    public void Deve_retornar_um_utm_a_partir_de_uma_string()
    {
        Utm utm = Result;
        
        Assert.AreEqual("https://google.com/", utm.Url.Address);
        Assert.AreEqual("src", utm.Campaign.Source);
        Assert.AreEqual("med", utm.Campaign.Medium);
        Assert.AreEqual("name", utm.Campaign.Name);
        Assert.AreEqual("id", utm.Campaign.Id);
        Assert.AreEqual("term", utm.Campaign.Term);
        Assert.AreEqual("ctn", utm.Campaign.Content);

    }
}