namespace TruthyTypes;

public static class CharExtensions
{
    public static bool ToBool(this char chr)
    {
        return chr != '\0';
    }
}

/// <summary>
/// Struct <c>Char</c> re-implements parts of the built-in <c>char</c> type to shoehorn in truthiness and falsiness
/// </summary>
public readonly struct Char
{
    private readonly char _value;

    /// <summary>
    /// Initializes a new Char.
    /// Is private because we will always implicitly convert a <c>char</c> to a <c>Char</c>
    /// <code>Char newChar = 'c'</code> will essentially do <code>Char newChar = new('c')</code> behind the scenes
    /// </summary>
    /// <param name="chr">A character literal</param>
    private Char(char chr)
    {
        _value = chr;
    }

    public static implicit operator bool(Char chr) => chr._value.ToBool();

    public static implicit operator char(Char chr) => chr._value;
    public static implicit operator Char(char chr) => new(chr);

    private bool Equals(Char other) => _value == other._value;
    public override string ToString() => _value.ToString();

    public override bool Equals(object? obj)
    {
        return obj is Char chr && Equals(chr);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }
    
    public static bool operator ==(Char left, Char right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Char left, Char right)
    {
        return !left.Equals(right);
    }
}