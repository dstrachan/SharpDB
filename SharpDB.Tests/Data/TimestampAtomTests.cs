using SharpDB.Data;
using static SharpDB.Data.BaseLongAtom;

namespace SharpDB.Tests.Data;

public class TimestampAtomTests
{
    private readonly TimestampAtom _null = new(Null);
    private readonly TimestampAtom _negativeInfinity = new(NegativeInfinity);
    private readonly TimestampAtom _positiveInfinity = new(PositiveInfinity);
    private readonly TimestampAtom _zero = new(0);
    private readonly TimestampAtom _one = new(1);
    private readonly TimestampAtom _negativeOne = new(-1);
    private readonly TimestampAtom _large = new(112233445566778899);
    private readonly TimestampAtom _negativeLarge = new(-112233445566778899);

    [Test]
    public void TypeIsTimestampAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.TimestampAtom));
    }

    [Test]
    public void ValueTypeIsTimestamp()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(long)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            0, 0, 0, 0, 0, 0, 0, 128, // long.MinValue
        }));
        Assert.That(_negativeInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            1, 0, 0, 0, 0, 0, 0, 128, // long.MinValue + 1
        }));
        Assert.That(_positiveInfinity.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            255, 255, 255, 255, 255, 255, 255, 127, // long.MaxValue
        }));
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            0, 0, 0, 0, 0, 0, 0, 0, // 2000.01.01D00:00:00.000000000
        }));
        Assert.That(_one.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            1, 0, 0, 0, 0, 0, 0, 0, // 2000.01.01D00:00:00.000000001
        }));
        Assert.That(_negativeOne.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            255, 255, 255, 255, 255, 255, 255, 255, // 1999.12.31D23:59:59.999999999
        }));
        Assert.That(_large.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            19, 14, 237, 94, 185, 187, 142, 1, // 2003.07.22D23:57:25.566778899
        }));
        Assert.That(_negativeLarge.Serialize(), Is.EqualTo(new byte[]
        {
            244, // DataType.TimestampAtom
            237, 241, 18, 161, 70, 68, 113, 254, // 1996.06.11D00:02:34.433221101
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("0Np"));
        Assert.That(_negativeInfinity.ToString(), Is.EqualTo("-0Wp"));
        Assert.That(_positiveInfinity.ToString(), Is.EqualTo("0Wp"));
        Assert.That(_zero.ToString(), Is.EqualTo("2000.01.01D00:00:00.000000000"));
        Assert.That(_one.ToString(), Is.EqualTo("2000.01.01D00:00:00.000000001"));
        Assert.That(_negativeOne.ToString(), Is.EqualTo("1999.12.31D23:59:59.999999999"));
        Assert.That(_large.ToString(), Is.EqualTo("2003.07.22D23:57:25.566778899"));
        Assert.That(_negativeLarge.ToString(), Is.EqualTo("1996.06.11D00:02:34.433221101"));
    }
}