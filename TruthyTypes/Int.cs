namespace TruthyTypes;

public static class IntExtensions
{
    public static bool ToBool(this int num)
    {
        return num != 0;
    }
}

/// <summary>
/// Class <c>Int</c> wraps the built-in <c>int</c> type to shoehorn in truthiness and falsiness
/// </summary>
public class Int
{
    private readonly int _value;

    /// <summary>
    /// Initializes a new Int.
    /// Is private because we will always implicitly convert an <c>int</c> to an <c>Int</c>
    /// <code>Int newNum = 1</code> will essentially do <code>Int newNum = new(1)</code> behind the scenes
    /// </summary>
    /// <param name="num">An integer</param>
    private Int(int num)
    {
        _value = num;
    }

    public static implicit operator bool(Int num) => num._value.ToBool();

    public static implicit operator int(Int num) => num._value;
    public static implicit operator Int(int num) => new(num);

    private bool Equals(Int? other) => _value == other?._value;
    public override string ToString() => _value.ToString();

    public override bool Equals(object? obj)
    {
        return Equals(obj as Int);
    }

    public override int GetHashCode()
    {
        return _value;
    }
}