namespace TruthyTypes;

public static class CharExtensions
{
    public static bool ToBool(this char chr)
    {
        return chr != '\0';
    }
}

/// <summary>
/// Class <c>Char</c> wraps the built-in <c>char</c> type to shoehorn in truthiness and falsiness
/// </summary>
public class Char
{
    private readonly char _value;

    /// <summary>
    /// Initializes a new Char.
    /// Is private because we will always implicitly convert a <c>char</c> to a <c>Char</c>
    /// <code>Char newChar = 'c'</code> will essentially do <code>Char newChar = new('c')</code> behind the scenes
    /// </summary>
    /// <param name="chr">An character literal</param>
    private Char(char chr)
    {
        _value = chr;
    }

    public static implicit operator bool(Char chr) => chr._value.ToBool();

    public static implicit operator char(Char chr) => chr._value;
    public static implicit operator Char(char chr) => new(chr);

    private bool Equals(Char? other) => _value == other?._value;
    public override string ToString() => _value.ToString();

    public override bool Equals(object? obj)
    {
        return Equals(obj as Char);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }
}