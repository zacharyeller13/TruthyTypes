using Byte = TruthyTypes.Byte;

namespace TestTruthyTypes;

public class TestByte
{
    [Fact]
    public void TestTruthiness()
    {
        Byte truthyByte = 1;
        Byte falsyByte = 0;

        Assert.True(truthyByte);
        Assert.False(falsyByte);
    }

    [Fact]
    public void TestEquality()
    {
        const byte normalByte = 1;
        Byte truthyByte = 1;
        
        Assert.True(normalByte == truthyByte);
        Assert.True(1 == truthyByte);
    }

    [Fact]
    public void TestCompare()
    {
        const byte normalByte = 1;
        Byte truthyByte = 2;
        
        Assert.True(normalByte < truthyByte);
    }
}