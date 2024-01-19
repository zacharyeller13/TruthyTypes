using TruthyTypes;

namespace TestTruthyTypes;

public class UnitTest1
{
    [Fact]
    public void TestIntTruthiness()
    {
        Int truthyInt = 1;
        Int falsyInt = 0;
        
        Assert.True(truthyInt);
        Assert.False(falsyInt);
    }
}