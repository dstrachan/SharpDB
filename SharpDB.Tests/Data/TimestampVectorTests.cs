using SharpDB.Data;
using static SharpDB.Data.BaseLongAtom;

namespace SharpDB.Tests.Data;

public class TimestampVectorTests
{
    private readonly TimestampVector _empty = new(Array.Empty<long>());
    private readonly TimestampVector _single = new(new long[] { 0 });
    private readonly TimestampVector _manyNoNull = new(new long[] { 0, 1, 2, 3 });
    private readonly TimestampVector _manyWithNull = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });
    private readonly TimestampVector _manyOnlyNull = new(new[] { Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsTimestampVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.TimestampVector));
    }

    [Test]
    public void ValueTypeIsLongArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(long[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            12, // DataType.TimestampVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            12, // DataType.TimestampVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000000
        }));
        Assert.That(_manyNoNull.Serialize(), Is.EqualTo(new byte[]
        {
            12, // DataType.TimestampVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000000
            1, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000001
            2, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000002
            3, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000003
        }));
        Assert.That(_manyWithNull.Serialize(), Is.EqualTo(new byte[]
        {
            12, // DataType.TimestampVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, 0, 0, 0, 0, // 0D00:00:00.000000000
            0, 0, 0, 0, 0, 0, 0, 128, // 0Np
            1, 0, 0, 0, 0, 0, 0, 128, // -0Wp
            255, 255, 255, 255, 255, 255, 255, 127, // 0Wp
        }));
        Assert.That(_manyOnlyNull.Serialize(), Is.EqualTo(new byte[]
        {
            12, // DataType.TimestampVector
            0, // VectorAttribute.None
            3, 0, 0, 0, // 3
            0, 0, 0, 0, 0, 0, 0, 128, // 0Np
            1, 0, 0, 0, 0, 0, 0, 128, // -0Wp
            255, 255, 255, 255, 255, 255, 255, 127, // 0Wp
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`timestamp$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",2000.01.01D00:00:00.000000000"));
        Assert.That(_manyNoNull.ToString(), Is.EqualTo("2000.01.01D00:00:00.000000000 2000.01.01D00:00:00.000000001 2000.01.01D00:00:00.000000002 2000.01.01D00:00:00.000000003"));
        Assert.That(_manyWithNull.ToString(), Is.EqualTo("2000.01.01D00:00:00.000000000 0N -0W 0W"));
        Assert.That(_manyOnlyNull.ToString(), Is.EqualTo("0N -0W 0Wp"));
    }
}