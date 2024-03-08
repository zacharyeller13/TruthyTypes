using Char = TruthyTypes.Char;

namespace TestTruthyTypes;

public class TestChar
{
    [Fact]
    public void TestCharTruthiness()
    {
        Char truthyChar = 'A';
        Char falsyChar = '\0';
        Char falsyChar2 = char.MinValue;
        
        Assert.True(truthyChar);
        Assert.False(falsyChar);
        Assert.False(falsyChar2);
    }

    [Fact]
    public void TestCharEquality()
    {
        char left = 'A';
        Char right = 'A';

        Assert.True(left == right);
        Assert.True(right == left);
    }
}