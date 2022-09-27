using System.Buffers.Binary;
using System.Text;

namespace SharpDB.Data;

public class DoubleVector : VectorBase<DoubleVector, double>
{
    public const double Null = double.NaN;
    public const double NegativeInfinity = double.NegativeInfinity;
    public const double PositiveInfinity = double.PositiveInfinity;

    public override DataType Type => DataType.DoubleVector;

    public DoubleVector(double[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new DoubleVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        Span<byte> buffer = stackalloc byte[sizeof(double)];
        foreach (var value in Value)
        {
            BinaryPrimitives.WriteDoubleLittleEndian(buffer, value);
            stream.Write(buffer);
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`double$()";
        }

        var requiresSuffix = true;
        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x =>
        {
            switch (x)
            {
                case Null:
                    requiresSuffix = false;
                    return "0n";
                case NegativeInfinity:
                    requiresSuffix = false;
                    return "-0w";
                case PositiveInfinity:
                    requiresSuffix = false;
                    return "0w";
                default:
                    requiresSuffix &= Math.Abs(x - (int)x) < double.Epsilon;
                    return $"{x}";
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('f');
        }

        return stringBuilder.ToString();
    }
}
