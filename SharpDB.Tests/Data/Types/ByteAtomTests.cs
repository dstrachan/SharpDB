using SharpDB.Data;

namespace SharpDB.Tests.Data.Types;

public class ByteAtomTests
{
    private readonly ByteAtom _zero = new(0);
    private readonly ByteAtom _ff = new(255);

    [Test]
    public void TypeIsByteAtom()
    {
        Assert.That(_zero.Type, Is.EqualTo(DataType.ByteAtom));
    }

    [Test]
    public void ValueTypeIsByte()
    {
        Assert.That(_zero.Value.GetType(), Is.EqualTo(typeof(byte)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_zero.Serialize(), Is.EqualTo(new byte[]
        {
            252, // DataType.ByteAtom
            0, // 0x00
        }));
        Assert.That(_ff.Serialize(), Is.EqualTo(new byte[]
        {
            252, // DataType.ByteAtom
            255, // 0xff
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_zero.ToString(), Is.EqualTo("0x00"));
        Assert.That(_ff.ToString(), Is.EqualTo("0xff"));
    }
}