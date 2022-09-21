using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class MonthAtomTests
{
    private readonly MonthAtom _null = new(Null);
    private readonly MonthAtom _negativeInfinity = new(NegativeInfinity);
    private readonly MonthAtom _positiveInfinity = new(PositiveInfinity);
    private readonly MonthAtom _zero = new(0);
    private readonly MonthAtom _one = new(1);
    private readonly MonthAtom _negativeOne = new(-1);
    private readonly MonthAtom _large = new(1234);

    [Test]
    public void TypeIsMonthAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.MonthAtom));
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
            243, // DataType.MonthAtom
            0, 0, 0, 128, // int.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            1, 0, 0, 128, // int.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            255, 255, 255, 127, // int.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            0, 0, 0, 0, // 2000.01m
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            1, 0, 0, 0, // 2000.02m
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            255, 255, 255, 255, // 1999.12m
        }));
        Assert.That(_large.Serialize(), Is.EqualTo(new byte[]
        {
            243, // DataType.MonthAtom
            210, 4, 0, 0, // 2102.11m
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nm"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wm"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wm"));
        Assert.That(_zero.ToString(), Is.EqualTo("2000.01m"));
        Assert.That(_one.ToString(), Is.EqualTo("2000.02m"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("1999.12m"));
        Assert.That(_large.ToString(), Is.EqualTo("2102.11m"));
    }
}
