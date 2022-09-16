using SharpDB.Data;
using static SharpDB.Data.SymbolAtom;

namespace SharpDB.Tests.Data;

public class SymbolAtomTests
{
    private readonly SymbolAtom _null = new(Null);
    private readonly SymbolAtom _nonNull = new("abc");

    [Test]
    public void TypeIsSymbolAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.SymbolAtom));
    }

    [Test]
    public void ValueTypeIsString()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(string)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            245, // DataType.SymbolAtom
            0, // ""
        }));
        Assert.That(_nonNull.Serialize(), Is.EqualTo(new byte[]
        {
            245, // DataType.SymbolAtom
            97, 98, 99, 0, // `abc
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("`"));
        Assert.That(_nonNull.ToString(), Is.EqualTo("`abc"));
    }
}