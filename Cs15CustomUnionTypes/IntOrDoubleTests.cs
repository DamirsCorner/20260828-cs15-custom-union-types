namespace Cs15CustomUnionTypes;

public class IntOrDoubleTests
{
    [Test]
    public void StoresIntValue()
    {
        IntOrDouble union = 5;
        Assert.That(union.Value, Is.EqualTo(5));
    }

    [Test]
    public void MatchesIntValue()
    {
        IntOrDouble union = 5;
        if (union is int value)
        {
            Assert.That(value, Is.EqualTo(5));
        }
        else
        {
            Assert.Fail();
        }
    }

    [Test]
    public void StoresDoubleValue()
    {
        IntOrDouble union = Math.PI;
        Assert.That(union.Value, Is.EqualTo(Math.PI));
    }

    [Test]
    public void MatchesDoubleValue()
    {
        IntOrDouble union = Math.PI;
        if (union is double value)
        {
            Assert.That(value, Is.EqualTo(Math.PI));
        }
        else
        {
            Assert.Fail();
        }
    }
}
