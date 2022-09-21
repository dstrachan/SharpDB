using SharpDB.Data;

namespace SharpDB.Tests.Data.Types;

public class BooleanAtomTests
{
    private readonly BooleanAtom _true = new(true);
    private readonly BooleanAtom _false = new(false);

    [Test]
    public void TypeIsBooleanAtom()
    {
        Assert.That(_true.Type, Is.EqualTo(DataType.BooleanAtom));
    }

    [Test]
    public void ValueTypeIsBool()
    {
        Assert.That(_true.Value.GetType(), Is.EqualTo(typeof(bool)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_true.Serialize(), Is.EqualTo(new byte[]
        {
            255, // DataType.BooleanAtom
            1, // 1b
        }));
        Assert.That(_false.Serialize(), Is.EqualTo(new byte[]
        {
            255, // DataType.BooleanAtom
            0, // 0b
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_true.ToString(), Is.EqualTo("1b"));
        Assert.That(_false.ToString(), Is.EqualTo("0b"));
    }
}
