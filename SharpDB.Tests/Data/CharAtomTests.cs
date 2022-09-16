using SharpDB.Data;
using static SharpDB.Data.CharAtom;

namespace SharpDB.Tests.Data;

public class CharAtomTests
{
    private readonly CharAtom _null = new(Null);
    private readonly CharAtom _nonNull = new('a');

    [Test]
    public void TypeIsCharAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.CharAtom));
    }

    [Test]
    public void ValueTypeIsChar()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(char)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            246, // DataType.CharAtom
            32, // " "
        }));
        Assert.That(_nonNull.Serialize(), Is.EqualTo(new byte[]
        {
            246, // DataType.CharAtom
            97, // " "
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("\" \""));
        Assert.That(_nonNull.ToString(), Is.EqualTo("\"a\""));
    }
}