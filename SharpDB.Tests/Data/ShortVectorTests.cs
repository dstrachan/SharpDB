using SharpDB.Data;
using static SharpDB.Data.ShortAtom;

namespace SharpDB.Tests.Data;

public class ShortVectorTests
{
    private readonly ShortVector _empty = new(Array.Empty<short>());
    private readonly ShortVector _single = new(new short[] { 0 });
    private readonly ShortVector _many = new(new short[] { 0, Null, NegativeInfinity, PositiveInfinity });

    [Test]
    public void TypeIsShortVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.ShortVector));
    }

    [Test]
    public void ValueTypeIsShortArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(short[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            5, // DataType.ShortVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            5, // DataType.ShortVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, // 0h
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            5, // DataType.ShortVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 0, // 0h 
            0, 128, // 0Nh
            1, 128, // -0Wh
            255, 127, // 0Wh
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`short$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0h"));
        Assert.That(_many.ToString(), Is.EqualTo("0 0N -0W 0Wh"));
    }
}