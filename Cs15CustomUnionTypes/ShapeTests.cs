using System.Runtime.CompilerServices;

namespace Cs15CustomUnionTypes;

public class ShapeTests
{
    [Test]
    public void ShapeImplementsIUnionInterface()
    {
        Shape shape = new Square(2);
        Assert.That(shape, Is.InstanceOf<IUnion>());
    }

    [Test]
    public void ValuePropertyContainsAssignedCaseTypeInstance()
    {
        var square = new Square(2);
        Shape shape = square;
        Assert.That(shape.Value, Is.SameAs(square));
    }

    [Test]
    public void AreaPropertyCalculatesArea()
    {
        Shape shape = new Square(2);
        Assert.That(shape.Area, Is.EqualTo(4));
    }
}
