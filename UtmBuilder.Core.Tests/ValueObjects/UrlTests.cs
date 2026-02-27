using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
    {
        new Url("banana");
    }
    [TestMethod]
    public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
    {
        new Url("https://google.com");
        Assert.IsTrue(true);
    }
}