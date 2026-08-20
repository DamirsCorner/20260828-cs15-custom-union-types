namespace Cs15CustomUnionTypes;

public record Square(double Length);

public record Circle(double Radius);

public union Shape(Square, Circle)
{
    public double Area =>
        this switch
        {
            Square square => Math.Pow(square.Length, 2),
            Circle circle => Math.PI * Math.Pow(circle.Radius, 2)
        };
}
