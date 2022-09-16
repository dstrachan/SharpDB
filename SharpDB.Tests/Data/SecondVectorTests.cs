using SharpDB.Data;
using static SharpDB.Data.BaseIntAtom;

namespace SharpDB.Tests.Data;

public class SecondVectorTests
{
    private readonly SecondVector _empty = new(Array.Empty<int>());
    private readonly SecondVector _single = new(new[] { 0 });
    private readonly SecondVector _manyNoNull = new(new[] { 0, 1, 2, 3 });
    private readonly SecondVector _manyWithNull = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });
    private readonly SecondVector _manyOnlyNull = new(new[] { Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsSecondVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.SecondVector));
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
            18, // DataType.SecondVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            18, // DataType.SecondVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, // 2000.01.01
        }));
        Assert.That(_manyNoNull.Serialize(), Is.EqualTo(new byte[]
        {
            18, // DataType.SecondVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 00:00
            1, 0, 0, 0, // 00:01
            2, 0, 0, 0, // 00:02
            3, 0, 0, 0, // 00:03
        }));
        Assert.That(_manyWithNull.Serialize(), Is.EqualTo(new byte[]
        {
            18, // DataType.SecondVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 00:00
            0, 0, 0, 128, // 0Nu
            1, 0, 0, 128, // -0Wu
            255, 255, 255, 127, // 0Wu
        }));
        Assert.That(_manyOnlyNull.Serialize(), Is.EqualTo(new byte[]
        {
            18, // DataType.SecondVector
            0, // VectorAttribute.None
            3, 0, 0, 0, // 3
            0, 0, 0, 128, // 0Nu
            1, 0, 0, 128, // -0Wu
            255, 255, 255, 127, // 0Wu
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`second$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",00:00:00"));
        Assert.That(_manyNoNull.ToString(), Is.EqualTo("00:00:00 00:00:01 00:00:02 00:00:03"));
        Assert.That(_manyWithNull.ToString(), Is.EqualTo("00:00:00 0N -0W 0W"));
        Assert.That(_manyOnlyNull.ToString(), Is.EqualTo("0N -0W 0Wv"));
    }
}