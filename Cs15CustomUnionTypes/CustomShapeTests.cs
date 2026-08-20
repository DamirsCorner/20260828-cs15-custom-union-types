namespace Cs15CustomUnionTypes;

public class CustomShapeTests
{
    private double CalculateArea(CustomShape shape)
    {
        return shape switch
        {
            Square square => Math.Pow(square.Length, 2),
            Circle circle => Math.PI * Math.Pow(circle.Radius, 2),
        };
    }

    [Test]
    public void CalculateSquareArea()
    {
        var square = new Square(2);
        var area = CalculateArea(square);
        Assert.That(area, Is.EqualTo(4));
    }

    [Test]
    public void CalculateCircleArea()
    {
        var circle = new Circle(1);
        var area = CalculateArea(circle);
        Assert.That(area, Is.EqualTo(Math.PI));
    }
}
