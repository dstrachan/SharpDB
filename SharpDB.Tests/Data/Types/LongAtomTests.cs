using SharpDB.Data;
using static SharpDB.Data.LongAtom;

namespace SharpDB.Tests.Data.Types;

public class LongAtomTests
{
    private readonly LongAtom _null = new(Null);
    private readonly LongAtom _negativeInfinity = new(NegativeInfinity);
    private readonly LongAtom _positiveInfinity = new(PositiveInfinity);
    private readonly LongAtom _zero = new(0);

    [Test]
    public void TypeIsLongAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.LongAtom));
    }

    [Test]
    public void ValueTypeIsLong()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(long)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            249, // DataType.LongAtom
            0, 0, 0, 0, 0, 0, 0, 128, // long.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            249, // DataType.LongAtom
            1, 0, 0, 0, 0, 0, 0, 128, // long.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            249, // DataType.LongAtom
            255, 255, 255, 255, 255, 255, 255, 127, // long.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            249, // DataType.LongAtom
            0, 0, 0, 0, 0, 0, 0, 0, // 0
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0N"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0W"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0W"));
        Assert.That(_zero.ToString(), Is.EqualTo("0"));
    }
}
