namespace TruthyTypes;

/// <summary>
/// Struct <c>Int32</c> re-implements parts of the built-in <c>int</c> type to shoehorn in truthiness and falsiness
/// </summary>
public readonly struct Int32
{
    private readonly int _value;

    /// <summary>
    /// Initializes a new Int32.
    /// Is private because we will always implicitly convert an <c>int</c> to an <c>Int</c>
    /// <code>Int32 newNum = 1</code> will essentially do <code>Int32 newNum = new(1)</code> behind the scenes
    /// </summary>
    /// <param name="num">An integer</param>
    private Int32(int num)
    {
        _value = num;
    }

    public static implicit operator bool(Int32 num) => Convert.ToBoolean(num._value);

    public static implicit operator int(Int32 num) => num._value;
    public static implicit operator Int32(int num) => new(num);

    private bool Equals(Int32 other) => _value == other._value;
    public override string ToString() => _value.ToString();

    public override bool Equals(object? obj)
    {
        return obj is Int32 int32 && Equals(int32);
    }

    public override int GetHashCode()
    {
        return _value;
    }

    public static bool operator ==(Int32 left, Int32 right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Int32 left, Int32 right)
    {
        return !left.Equals(right);
    }
}