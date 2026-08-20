using System.Runtime.CompilerServices;

namespace Cs15CustomUnionTypes;

[Union]
public readonly struct IntOrDouble : IUnion
{
    private enum ValueType : byte
    {
        None,
        Int,
        Double,
    }

    private readonly int _intValue;
    private readonly double _doubleValue;
    private readonly ValueType _type = ValueType.None;

    public object? Value =>
        _type switch
        {
            ValueType.Int => _intValue,
            ValueType.Double => _doubleValue,
            _ => null,
        };

    public IntOrDouble(int value)
    {
        _type = ValueType.Int;
        _intValue = value;
    }

    public IntOrDouble(double value)
    {
        _type = ValueType.Double;
        _doubleValue = value;
    }

    public bool TryGetValue(out int value)
    {
        value = _intValue;
        return _type == ValueType.Int;
    }

    public bool TryGetValue(out double value)
    {
        value = _doubleValue;
        return _type == ValueType.Double;
    }
}
