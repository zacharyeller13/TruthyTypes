using TruthyTypes;
using Int32 = TruthyTypes.Int32;

namespace TestTruthyTypes;

public class TestInt32
{
    [Fact]
    public void TestIntTruthiness()
    {
        Int32 truthyInt = 1;
        Int32 falsyInt = 0;
        
        Assert.True(truthyInt);
        Assert.False(falsyInt);
    }

    [Fact]
    public void TestIntEquality()
    {
        int normalInt = 1;
        Int32 truthyInt = 1;
        
        Assert.True(normalInt == truthyInt);
    }
}