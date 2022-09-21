using SharpDB.Data;
using static SharpDB.Data.DoubleAtom;

namespace SharpDB.Tests.Data.Types;

public class DoubleAtomTests
{
    private readonly DoubleAtom _null = new(Null);
    private readonly DoubleAtom _negativeInfinity = new(NegativeInfinity);
    private readonly DoubleAtom _positiveInfinity = new(PositiveInfinity);
    private readonly DoubleAtom _zero = new(0);
    private readonly DoubleAtom _nonZero = new(1.1);

    [Test]
    public void TypeIsDoubleAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.DoubleAtom));
    }

    [Test]
    public void ValueTypeIsDouble()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(double)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            247, // DataType.DoubleAtom
            0, 0, 0, 0, 0, 0, 248, 255, // double.NaN
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            247, // DataType.DoubleAtom
            0, 0, 0, 0, 0, 0, 240, 255, // double.NegativeInfinity
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            247, // DataType.DoubleAtom
            0, 0, 0, 0, 0, 0, 240, 127, // double.PositiveInfinity
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            247, // DataType.DoubleAtom
            0, 0, 0, 0, 0, 0, 0, 0, // 0
        }));
        Assert.That(_nonZero.Serialize(), Is.EqualTo(new byte[]
        {
            247, // DataType.DoubleAtom
            154, 153, 153, 153, 153, 153, 241, 63, // 1.1
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0n"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0w"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0w"));
        Assert.That(_zero.ToString(), Is.EqualTo("0f"));
        Assert.That(_nonZero.ToString(), Is.EqualTo("1.1"));
    }
}