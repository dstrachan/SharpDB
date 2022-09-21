using SharpDB.Data;
using static SharpDB.Data.GuidAtom;

namespace SharpDB.Tests.Data.Types;

public class GuidVectorTests
{
    private readonly GuidVector _empty = new(Array.Empty<Guid>());
    private readonly GuidVector _single = new(new[] { Null });
    private readonly GuidVector _many = new(new[] { Null, Null });

    [Test]
    public void TypeIsGuidVector()
    {
        Assert.That(_empty.Type, Is.EqualTo(DataType.GuidVector));
    }

    [Test]
    public void ValueTypeIsGuidArray()
    {
        Assert.That(_empty.Value.GetType(), Is.EqualTo(typeof(Guid[])));
    }

    [Test]
    public void SerializeIsCorrect()
    {
        Assert.That(_empty.Serialize(), Is.EqualTo(new byte[]
        {
            2, // DataType.GuidVector
            0, // VectorAttribute.None
            0, 0, 0, 0, // 0
        }));
        Assert.That(_single.Serialize(), Is.EqualTo(new byte[]
        {
            2, // DataType.GuidVector
            0, // VectorAttribute.None
            1, 0, 0, 0, // 1
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 00000000-0000-0000-0000-000000000000
        }));
        Assert.That(_many.Serialize(), Is.EqualTo(new byte[]
        {
            2, // DataType.GuidVector
            0, // VectorAttribute.None
            2, 0, 0, 0, // 2
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 00000000-0000-0000-0000-000000000000
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, // 00000000-0000-0000-0000-000000000000
        }));
    }

    [Test]
    public void ToStringIsCorrect()
    {
        Assert.That(_empty.ToString(), Is.EqualTo("`guid$()"));
        Assert.That(_single.ToString(), Is.EqualTo(",00000000-0000-0000-0000-000000000000"));
        Assert.That(_many.ToString(), Is.EqualTo("00000000-0000-0000-0000-000000000000 00000000-0000-0000-0000-000000000000"));
    }
}