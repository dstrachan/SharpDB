using SharpDB.Data;
using static SharpDB.Data.FloatAtom;

namespace SharpDB.Tests.Data;

public class FloatAtomTests
{
    private readonly FloatAtom _null = new(Null);
    private readonly FloatAtom _negativeInfinity = new(NegativeInfinity);
    private readonly FloatAtom _positiveInfinity = new(PositiveInfinity);
    private readonly FloatAtom _zero = new(0);

    [Test]
    public void TypeIsFloatAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.FloatAtom));
    }

    [Test]
    public void ValueTypeIsFloat()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(float)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            248, // DataType.FloatAtom
            0, 0, 192, 255, // float.NaN
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            248, // DataType.FloatAtom
            0, 0, 128, 255, // float.NegativeInfinity
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            248, // DataType.FloatAtom
            0, 0, 128, 127, // float.PositiveInfinity
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            248, // DataType.FloatAtom
            0, 0, 0, 0, // 0
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Ne"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0We"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0We"));
        Assert.That(_zero.ToString(), Is.EqualTo("0e"));
    }
}