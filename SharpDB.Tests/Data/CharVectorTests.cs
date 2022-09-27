using SharpDB.Data;

namespace SharpDB.Tests.Data;

public class CharVectorTests
{
    private readonly CharVector _empty = new(Array.Empty<char>());
    private readonly CharVector _single = new(new[] { 'a' });
    private readonly CharVector _many = new(new[] { 'a', 'b', 'c', 'd' });

    [Test]
    public void TypeIsCharVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.CharVector));
    }

    [Test]
    public void ValueTypeIsCharArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(char[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            10, // DataType.CharVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            10, // DataType.CharVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            97, // "a"
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            10, // DataType.CharVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            97, 98, 99, 100, // "abcd"
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("\"\""));
        Assert.That(_single.ToString(), Is.EqualTo(",\"a\""));
        Assert.That(_many.ToString(), Is.EqualTo("\"abcd\""));
    }

    [Test]
    public void FactoryIsCalled()
    {
        Assert.That(_many[..].Value, Is.EqualTo(_many.Value));
    }
}
