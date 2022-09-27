using System.Text;

namespace SharpDB.Data;

public class ByteVector : VectorBase<ByteVector, byte>
{
    public override DataType Type => DataType.ByteVector;

    public ByteVector(byte[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new ByteVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));
        stream.Write(Value);
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`byte$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? ",0x" : "0x");
        foreach (var element in Value)
        {
            stringBuilder.Append($"{element:x2}");
        }

        return stringBuilder.ToString();
    }
}
