using PrimeService;

namespace PrimeService.Tests;

[TestClass]
public class PrimeService_IsPrimeShould
{
    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [TestMethod]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        var result = _primeService.IsPrime(1);
        Assert.IsFalse(result, "1 should not be prime");
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(1)]
    public void IsPrime_ValueLessThan2_ReturnFalse(int value)
    {
        var result = _primeService.IsPrime(value);
        Assert.IsFalse(result, $"{value} should not be prime");
    }
}