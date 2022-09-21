using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class SecondAtomTests
{
    private readonly SecondAtom _null = new(Null);
    private readonly SecondAtom _negativeInfinity = new(NegativeInfinity);
    private readonly SecondAtom _positiveInfinity = new(PositiveInfinity);
    private readonly SecondAtom _zero = new(0);
    private readonly SecondAtom _one = new(1);
    private readonly SecondAtom _negativeOne = new(-1);
    private readonly SecondAtom _large = new(1234567);

    [Test]
    public void TypeIsSecondAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.SecondAtom));
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
            238, // DataType.SecondAtom
            0, 0, 0, 128, // int.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            1, 0, 0, 128, // int.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            255, 255, 255, 127, // int.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            0, 0, 0, 0, // 00:00:00
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            1, 0, 0, 0, // 00:00:01
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            255, 255, 255, 255, // -00:00:01
        }));
        Assert.That(_large.Serialize(), Is.EqualTo(new byte[]
        {
            238, // DataType.SecondAtom
            135, 214, 18, 0, // 342:56:07
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nv"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wv"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wv"));
        Assert.That(_zero.ToString(), Is.EqualTo("00:00:00"));
        Assert.That(_one.ToString(), Is.EqualTo("00:00:01"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("-00:00:01"));
        Assert.That(_large.ToString(), Is.EqualTo("342:56:07"));
    }
}
