using SharpDB.Data;
using static SharpDB.Data.LongVectorBase<SharpDB.Data.LongVector>;

namespace SharpDB.Tests.Data;

public class LongVectorTests
{
    private readonly LongVector _empty = new(Array.Empty<long>());
    private readonly LongVector _single = new(new[] { 0L });
    private readonly LongVector _many = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsLongVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.LongVector));
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
            7, // DataType.LongVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            7, // DataType.LongVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, 0, 0, 0, 0, // 0
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            7, // DataType.LongVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, 0, 0, 0, 0, // 0
            0, 0, 0, 0, 0, 0, 0, 128, // 0N
            1, 0, 0, 0, 0, 0, 0, 128, // -0W
            255, 255, 255, 255, 255, 255, 255, 127, // 0W
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`long$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0"));
        Assert.That(_many.ToString(), Is.EqualTo("0 0N -0W 0W"));
    }

    [Test]
    public void FactoryIsCalled()
    {
        Assert.That(_many[..].Value, Is.EqualTo(_many.Value));
    }
}
