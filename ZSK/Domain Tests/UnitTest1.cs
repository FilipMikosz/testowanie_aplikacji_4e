namespace Domain.NewDirectory;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 10;
        int b = 20;
        int expectedResult = 10;

        var result = GreatestCommonDivisor.GCDiterative(a, b);
        Assert.Equal(expectedResult, result);
    }
} 
