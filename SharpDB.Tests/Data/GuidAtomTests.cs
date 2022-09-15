using SharpDB.Data;

namespace SharpDB.Tests.Data;

public class GuidAtomTests
{
    private readonly GuidAtom _null = new(GuidAtom.Null);
    private readonly GuidAtom _value = new(new Guid("6ba71174-9998-4c6d-9785-c75226eb557f"));

    [Test]
    public void TypeIsGuidAtom()
    {
        Assert.That(_null.Type, Is.EqualTo(DataType.GuidAtom));
    }

    [Test]
    public void ValueTypeIsGuid()
    {
        Assert.That(_null.Value.GetType(), Is.EqualTo(typeof(Guid)));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_null.Serialize(), Is.EqualTo(new byte[]
        {
            254, // DataType.GuidAtom
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 00000000-0000-0000-0000-000000000000
        }));
        Assert.That(_value.Serialize(), Is.EqualTo(new byte[]
        {
            254, // DataType.GuidAtom
            116, 17, 167, 107, 152, 153, 109, 76, 151, 133, 199, 82, 38, 235, 85,
            127, // 6ba71174-9998-4c6d-9785-c75226eb557f
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_null.ToString(), Is.EqualTo("00000000-0000-0000-0000-000000000000"));
        Assert.That(_value.ToString(), Is.EqualTo("6ba71174-9998-4c6d-9785-c75226eb557f"));
    }
}