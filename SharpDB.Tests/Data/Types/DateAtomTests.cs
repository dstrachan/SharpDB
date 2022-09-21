using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class DateAtomTests
{
    private readonly DateAtom _null = new(Null);
    private readonly DateAtom _negativeInfinity = new(NegativeInfinity);
    private readonly DateAtom _positiveInfinity = new(PositiveInfinity);
    private readonly DateAtom _zero = new(0);
    private readonly DateAtom _one = new(1);
    private readonly DateAtom _negativeOne = new(-1);
    private readonly DateAtom _large = new(52813);

    [Test]
    public void TypeIsDateAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.DateAtom));
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
            242, // DataType.DateAtom
            0, 0, 0, 128, // int.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            1, 0, 0, 128, // int.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            255, 255, 255, 127, // int.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            0, 0, 0, 0, // 2000.01.01
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            1, 0, 0, 0, // 2000.01.02
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            255, 255, 255, 255, // 1999.12.31
        }));
        Assert.That(_large.Serialize(), Is.EqualTo(new byte[]
        {
            242, // DataType.DateAtom
            77, 206, 0, 0, // 2144.08.06
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nd"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wd"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wd"));
        Assert.That(_zero.ToString(), Is.EqualTo("2000.01.01"));
        Assert.That(_one.ToString(), Is.EqualTo("2000.01.02"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("1999.12.31"));
        Assert.That(_large.ToString(), Is.EqualTo("2144.08.06"));
    }
}
