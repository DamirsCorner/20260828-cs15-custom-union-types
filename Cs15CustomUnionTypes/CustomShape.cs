using System.Runtime.CompilerServices;

namespace Cs15CustomUnionTypes;

[Union]
public class CustomShape : IUnion
{
    public object? Value { get; }

    public CustomShape(Square square)
    {
        Value = square;
    }

    public CustomShape(Circle circle)
    {
        Value = circle;
    }

    public static implicit operator CustomShape(Square square) => new(square);

    public static implicit operator CustomShape(Circle circle) => new(circle);
}
