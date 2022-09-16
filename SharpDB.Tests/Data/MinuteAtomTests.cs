using SharpDB.Data;
using static SharpDB.Data.BaseIntAtom;

namespace SharpDB.Tests.Data;

public class MinuteAtomTests
{
    private readonly MinuteAtom _null = new(Null);
    private readonly MinuteAtom _negativeInfinity = new(NegativeInfinity);
    private readonly MinuteAtom _positiveInfinity = new(PositiveInfinity);
    private readonly MinuteAtom _zero = new(0);
    private readonly MinuteAtom _one = new(1);
    private readonly MinuteAtom _negativeOne = new(-1);
    private readonly MinuteAtom _large = new(12345);

    [Test]
    public void TypeIsMinuteAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.MinuteAtom));
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
            239, // DataType.MinuteAtom
            0, 0, 0, 128, // int.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            1, 0, 0, 128, // int.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            255, 255, 255, 127, // int.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            0, 0, 0, 0, // 00:00
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            1, 0, 0, 0, // 00:01
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            255, 255, 255, 255, // -00:01
        }));
        Assert.That(_large.Serialize(), Is.EqualTo(new byte[]
        {
            239, // DataType.MinuteAtom
            57, 48, 0, 0, // 205:45
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nu"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wu"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wu"));
        Assert.That(_zero.ToString(), Is.EqualTo("00:00"));
        Assert.That(_one.ToString(), Is.EqualTo("00:01"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("-00:01"));
        Assert.That(_large.ToString(), Is.EqualTo("205:45"));
    }
}