using System.Buffers.Binary;
using System.Text;

namespace SharpDB.Data;

public class FloatVector : VectorBase<FloatVector, float>
{
    public const float Null = float.NaN;
    public const float NegativeInfinity = float.NegativeInfinity;
    public const float PositiveInfinity = float.PositiveInfinity;

    public override DataType Type => DataType.FloatVector;

    public FloatVector(float[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new FloatVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        Span<byte> buffer = stackalloc byte[sizeof(float)];
        foreach (var value in Value)
        {
            BinaryPrimitives.WriteSingleLittleEndian(buffer, value);
            stream.Write(buffer);
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`float$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('e');
        return stringBuilder.ToString();
    }
}
