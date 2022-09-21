using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class DateVectorTests
{
    private readonly DateVector _empty = new(Array.Empty<int>());
    private readonly DateVector _single = new(new[] { 0 });
    private readonly DateVector _manyNoNull = new(new[] { 0, 1, 2, 3 });
    private readonly DateVector _manyWithNull = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });
    private readonly DateVector _manyOnlyNull = new(new[] { Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsDateVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.DateVector));
    }

    [Test]
    public void ValueTypeIsIntArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(int[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            14, // DataType.DateVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            14, // DataType.DateVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, // 2000.01.01
        }));
        Assert.That(_manyNoNull.Serialize(), Is.EqualTo(new byte[]
        {
            14, // DataType.DateVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 2000.01.01
            1, 0, 0, 0, // 2000.01.02
            2, 0, 0, 0, // 2000.01.03
            3, 0, 0, 0, // 2000.01.04
        }));
        Assert.That(_manyWithNull.Serialize(), Is.EqualTo(new byte[]
        {
            14, // DataType.DateVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 2000.01.01
            0, 0, 0, 128, // 0Nd
            1, 0, 0, 128, // -0Wd
            255, 255, 255, 127, // 0Wd
        }));
        Assert.That(_manyOnlyNull.Serialize(), Is.EqualTo(new byte[]
        {
            14, // DataType.DateVector
            0, // VectorAttribute.None
            3, 0, 0, 0, // 3
            0, 0, 0, 128, // 0Nd
            1, 0, 0, 128, // -0Wd
            255, 255, 255, 127, // 0Wd
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`date$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",2000.01.01"));
        Assert.That(_manyNoNull.ToString(), Is.EqualTo("2000.01.01 2000.01.02 2000.01.03 2000.01.04"));
        Assert.That(_manyWithNull.ToString(), Is.EqualTo("2000.01.01 0N -0W 0W"));
        Assert.That(_manyOnlyNull.ToString(), Is.EqualTo("0N -0W 0Wd"));
    }
}
