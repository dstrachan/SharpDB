using SharpDB.Data;
using static SharpDB.Data.FloatVector;

namespace SharpDB.Tests.Data;

public class FloatVectorTests
{
    private readonly FloatVector _empty = new(Array.Empty<float>());
    private readonly FloatVector _single = new(new float[] { 0 });
    private readonly FloatVector _many = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsFloatVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.FloatVector));
    }

    [Test]
    public void ValueTypeIsFloatArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(float[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            8, // DataType.FloatVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            8, // DataType.FloatVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, // 0e
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            8, // DataType.FloatVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 0e
            0, 0, 192, 255, // 0Ne
            0, 0, 128, 255, // -0We
            0, 0, 128, 127, // 0We
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`float$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0e"));
        Assert.That(_many.ToString(), Is.EqualTo("0 0N -0W 0We"));
    }

    [Test]
    public void FactoryIsCalled()
    {
        Assert.That(_many[..].Value, Is.EqualTo(_many.Value));
    }
}
