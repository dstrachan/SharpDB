using System.Buffers.Binary;

namespace SharpDB.Data;

public abstract class LongVectorBase<TSelf> : VectorBase<TSelf, long>
    where TSelf : IVector<long>
{
    public const long Null = long.MinValue;
    public const long NegativeInfinity = long.MinValue + 1;
    public const long PositiveInfinity = long.MaxValue;

    protected LongVectorBase(long[] value, VectorAttribute attribute, Func<long[], VectorAttribute, TSelf> factory)
        : base(value, attribute, factory)
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        Span<byte> buffer = stackalloc byte[sizeof(long)];
        foreach (var value in Value)
        {
            BinaryPrimitives.WriteInt64LittleEndian(buffer, value);
            stream.Write(buffer);
        }
    }
}
