namespace SimpleAPI.Test;
using Xunit;

public class UnitTest1
{
    ValuesController controller = new();

    [Fact]
    public void GetReturnsMyName() 
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Eric Sällström", returnValue.Value);        
    }

    [Fact]
    public void Test1()
    {

    }
}