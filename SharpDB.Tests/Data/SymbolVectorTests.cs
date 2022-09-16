using SharpDB.Data;

namespace SharpDB.Tests.Data;

public class SymbolVectorTests
{
    private readonly SymbolVector _empty = new(Array.Empty<string>());
    private readonly SymbolVector _single = new(new[] { "abc" });
    private readonly SymbolVector _many = new(new[] { "a", "ab", "abc", "abcd" });

    [Test]
    public void TypeIsSymbolVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.SymbolVector));
    }

    [Test]
    public void ValueTypeIsStringArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(string[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            11, // DataType.SymbolVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            11, // DataType.SymbolVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            97, 98, 99, 0, // `abc
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            11, // DataType.SymbolVector
            0, // VectorAttribute.None
            4, 0, 0, 0, // 4
            97, 0, // `a
            97, 98, 0, // `ab
            97, 98, 99, 0, // `abc
            97, 98, 99, 100, 0, // `abcd
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`symbol$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",`abc"));
        Assert.That(_many.ToString(), Is.EqualTo("`a`ab`abc`abcd"));
    }
}