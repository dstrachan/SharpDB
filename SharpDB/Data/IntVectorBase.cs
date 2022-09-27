using System.Buffers.Binary;

namespace SharpDB.Data;

public abstract class IntVectorBase<TSelf> : VectorBase<TSelf, int>
    where TSelf : IVector<int>
{
    public const int Null = int.MinValue;
    public const int NegativeInfinity = int.MinValue + 1;
    public const int PositiveInfinity = int.MaxValue;

    protected IntVectorBase(int[] value, VectorAttribute attribute, Func<int[], VectorAttribute, TSelf> factory)
        : base(value, attribute, factory)
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        Span<byte> buffer = stackalloc byte[sizeof(int)];
        foreach (var value in Value)
        {
            BinaryPrimitives.WriteInt32LittleEndian(buffer, value);
            stream.Write(buffer);
        }
    }
}
