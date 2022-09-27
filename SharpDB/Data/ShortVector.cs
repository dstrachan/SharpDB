using System.Buffers.Binary;
using System.Text;

namespace SharpDB.Data;

public class ShortVector : VectorBase<ShortVector, short>
{
    public const short Null = short.MinValue;
    public const short NegativeInfinity = short.MinValue + 1;
    public const short PositiveInfinity = short.MaxValue;

    public override DataType Type => DataType.ShortVector;

    public ShortVector(short[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new ShortVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        Span<byte> buffer = stackalloc byte[sizeof(short)];
        foreach (var value in Value)
        {
            BinaryPrimitives.WriteInt16LittleEndian(buffer, value);
            stream.Write(buffer);
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`short$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('h');
        return stringBuilder.ToString();
    }
}
