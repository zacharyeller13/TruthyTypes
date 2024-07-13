namespace TruthyTypes;

public readonly struct Byte : IComparable<Byte>, IEquatable<Byte>, IComparable
{
    private readonly byte _value;

    /// <summary>
    /// Initializes a new Byte.
    /// Is private because we will always implicitly convert a <c>byte</c> to a <c>Byte</c>
    /// i.e. <code>Byte newNum = 1</code> will do <code>Byte newNum = new(1)</code>
    /// </summary>
    /// <param name="value">A byte</param>
    private Byte(byte value)
    {
        _value = value;
    }

    public static implicit operator bool(Byte num) => Convert.ToBoolean(num._value);
    public static implicit operator byte(Byte num) => num._value;
    public static implicit operator Byte(byte num) => new(num);

    public bool Equals(Byte other) => _value == other._value;
    public override string ToString() => _value.ToString();

    public override bool Equals(object? obj)
    {
        return obj is Byte num && Equals(num);
    }

    public override int GetHashCode()
    {
        return _value;
    }

    public static bool operator ==(Byte left, Byte right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Byte left, Byte right)
    {
        return !left.Equals(right);
    }

    public int CompareTo(Byte other)
    {
        return _value.CompareTo(other._value);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Byte other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Byte)}");
    }

    public static bool operator <(Byte left, Byte right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Byte left, Byte right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Byte left, Byte right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Byte left, Byte right)
    {
        return left.CompareTo(right) >= 0;
    }
}