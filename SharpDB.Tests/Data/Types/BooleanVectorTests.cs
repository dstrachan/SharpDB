using SharpDB.Data;

namespace SharpDB.Tests.Data.Types;

public class BooleanVectorTests
{
    private readonly BooleanVector _empty = new(Array.Empty<bool>());
    private readonly BooleanVector _single = new(new[] { false });
    private readonly BooleanVector _many = new(new[] { false, true, true, false });

    [Test]
    public void TypeIsBooleanVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.BooleanVector));
    }

    [Test]
    public void ValueTypeIsBoolArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(bool[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            1, // DataType.BooleanVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            1, // DataType.BooleanVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, // 0b
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            1, // DataType.BooleanVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 1, 1, 0, // 0110b
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`boolean$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0b"));
        Assert.That(_many.ToString(), Is.EqualTo("0110b"));
    }
}
