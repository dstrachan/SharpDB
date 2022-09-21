using SharpDB.Data;
using static SharpDB.Data.ShortAtom;

namespace SharpDB.Tests.Data.Types;

public class ShortAtomTests
{
    private readonly ShortAtom _null = new(Null);
    private readonly ShortAtom _negativeInfinity = new(NegativeInfinity);
    private readonly ShortAtom _positiveInfinity = new(PositiveInfinity);
    private readonly ShortAtom _zero = new(0);

    [Test]
    public void TypeIsShortAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.ShortAtom));
    }

    [Test]
    public void ValueTypeIsShort()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(short)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            251, // DataType.ShortAtom
            0, 128, // short.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            251, // DataType.ShortAtom
            1, 128, // short.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            251, // DataType.ShortAtom
            255, 127, // short.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            251, // DataType.ShortAtom
            0, 0, // 0
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nh"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wh"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wh"));
        Assert.That(_zero.ToString(), Is.EqualTo("0h"));
    }
}