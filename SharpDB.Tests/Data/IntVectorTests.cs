using SharpDB.Data;
using static SharpDB.Data.BaseIntAtom;

namespace SharpDB.Tests.Data;

public class IntVectorTests
{
    private readonly IntVector _empty = new(Array.Empty<int>());
    private readonly IntVector _single = new(new[] { 0 });
    private readonly IntVector _many = new(new[] { 0, Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsIntVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.IntVector));
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
            6, // DataType.IntVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            6, // DataType.IntVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, // 0i
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            6, // DataType.IntVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, 0, 0, // 0i
            0, 0, 0, 128, // 0Ni
            1, 0, 0, 128, // -0Wi
            255, 255, 255, 127, // 0Wi
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`int$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0i"));
        Assert.That(_many.ToString(), Is.EqualTo("0 0N -0W 0Wi"));
    }
}