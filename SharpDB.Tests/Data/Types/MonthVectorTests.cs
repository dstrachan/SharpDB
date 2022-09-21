using SharpDB.Data;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Tests.Data.Types;

public class MonthVectorTests
{
    private readonly MonthVector _empty = new(Array.Empty<int>());
    private readonly MonthVector _single = new(new[] { 0 });
    private readonly MonthVector _manyNoNull = new(new[] { 0, 1, 2, 3 });
    private readonly MonthVector _manyWithNull = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });
    private readonly MonthVector _manyOnlyNull = new(new[] { Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsMonthVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.MonthVector));
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
            13, // DataType.MonthVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            13, // DataType.MonthVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, // 2000.01m
        }));
        Assert.That(_manyNoNull.Serialize(), Is.EqualTo(new byte[]
        {
            13, // DataType.MonthVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 2000.01m
            1, 0, 0, 0, // 2000.02m
            2, 0, 0, 0, // 2000.03m
            3, 0, 0, 0, // 2000.04m
        }));
        Assert.That(_manyWithNull.Serialize(), Is.EqualTo(new byte[]
        {
            13, // DataType.MonthVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 2000.01m
            0, 0, 0, 128, // 0Nm
            1, 0, 0, 128, // -0Wm
            255, 255, 255, 127, // 0Wm
        }));
        Assert.That(_manyOnlyNull.Serialize(), Is.EqualTo(new byte[]
        {
            13, // DataType.MonthVector
            0, // VectorAttribute.None
            3, 0, 0, 0, // 3
            0, 0, 0, 128, // 0Nm
            1, 0, 0, 128, // -0Wm
            255, 255, 255, 127, // 0Wm
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`month$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",2000.01m"));
        Assert.That(_manyNoNull.ToString(), Is.EqualTo("2000.01 2000.02 2000.03 2000.04m"));
        Assert.That(_manyWithNull.ToString(), Is.EqualTo("2000.01 0N -0W 0Wm"));
        Assert.That(_manyOnlyNull.ToString(), Is.EqualTo("0N -0W 0Wm"));
    }
}
