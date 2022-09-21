using SharpDB.Data;
using static SharpDB.Data.LongAtom;

namespace SharpDB.Tests.Data.Types;

public class TimespanAtomTests
{
    private readonly TimespanAtom _null = new(Null);
    private readonly TimespanAtom _negativeInfinity = new(NegativeInfinity);
    private readonly TimespanAtom _positiveInfinity = new(PositiveInfinity);
    private readonly TimespanAtom _zero = new(0);
    private readonly TimespanAtom _one = new(1);
    private readonly TimespanAtom _negativeOne = new(-1);

    [Test]
    public void TypeIsTimespanAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.TimespanAtom));
    }

    [Test]
    public void ValueTypeIsTimespan()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(long)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            0, 0, 0, 0, 0, 0, 0, 128, // long.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            1, 0, 0, 0, 0, 0, 0, 128, // long.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            255, 255, 255, 255, 255, 255, 255, 127, // long.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            0, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000000
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            1, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000001
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            240, // DataType.TimespanAtom
            255, 255, 255, 255, 255, 255, 255, 255, // -0D00:00:00.000000001
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Nn"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wn"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wn"));
        Assert.That(_zero.ToString(), Is.EqualTo("0D00:00:00.000000000"));
        Assert.That(_one.ToString(), Is.EqualTo("0D00:00:00.000000001"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("-0D00:00:00.000000001"));
    }
}
