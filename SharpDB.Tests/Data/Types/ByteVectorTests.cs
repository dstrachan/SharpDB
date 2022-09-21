using SharpDB.Data;

namespace SharpDB.Tests.Data.Types;

public class ByteVectorTests
{
    private readonly ByteVector _empty = new(Array.Empty<byte>());
    private readonly ByteVector _single = new(new byte[] { 0 });
    private readonly ByteVector _many = new(new byte[] { 0, 255, 255, 0 });

    [Test]
    public void TypeIsByteVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.ByteVector));
    }

    [Test]
    public void ValueTypeIsByteArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(byte[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            4, // DataType.ByteVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            4, // DataType.ByteVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, // 0x00
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            4, // DataType.ByteVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            0, 255, 255, 0, // 0x00ffff00
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`byte$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",0x00"));
        Assert.That(_many.ToString(), Is.EqualTo("0x00ffff00"));
    }
}