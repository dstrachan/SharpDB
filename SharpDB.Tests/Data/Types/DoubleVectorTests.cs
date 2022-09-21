using SharpDB.Data;
using static SharpDB.Data.DoubleAtom;

namespace SharpDB.Tests.Data.Types;

public class DoubleVectorTests
{
    private readonly DoubleVector _empty = new(Array.Empty<double>());
    private readonly DoubleVector _single = new(new double[] { 0 });
    private readonly DoubleVector _many = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsDoubleVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.DoubleVector));
    }

    [Test]
    public void ValueTypeIsDoubleArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(double[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            9, // DataType.DoubleVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            9, // DataType.DoubleVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, 0, 0, 0, 0, // 0
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            9, // DataType.DoubleVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, 0, 0, 0, 0, // 0
            0, 0, 0, 0, 0, 0, 248, 255, // 0N
            0, 0, 0, 0, 0, 0, 240, 255, // -0W
            0, 0, 0, 0, 0, 0, 240, 127, // 0W
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`double$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0f"));
        Assert.That(_many.ToString(), Is.EqualTo("0 0n -0w 0w"));
    }
}