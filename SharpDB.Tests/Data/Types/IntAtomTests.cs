using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class IntAtomTests
{
    private readonly IntAtom _null = new(Null);
    private readonly IntAtom _negativeInfinity = new(NegativeInfinity);
    private readonly IntAtom _positiveInfinity = new(PositiveInfinity);
    private readonly IntAtom _zero = new(0);
    private readonly IntAtom _one = new(1);

    [Test]
    public void TypeIsIntAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.IntAtom));
    }

    [Test]
    public void ValueTypeIsInt()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(int)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            250, // DataType.IntAtom
            0, 0, 0, 128, // int.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            250, // DataType.IntAtom
            1, 0, 0, 128, // int.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            250, // DataType.IntAtom
            255, 255, 255, 127, // int.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            250, // DataType.IntAtom
            0, 0, 0, 0, // 0
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Ni"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wi"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wi"));
        Assert.That(_zero.ToString(), Is.EqualTo("0i"));
    }
}
