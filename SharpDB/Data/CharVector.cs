using System.Text;

namespace SharpDB.Data;

public class CharVector : VectorBase<CharVector, char>
{
    public override DataType Type => DataType.CharVector;

    public CharVector(char[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new CharVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        foreach (var value in Value)
        {
            stream.WriteByte((byte)value);
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "\"\"";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? ",\"" : "\"");
        foreach (var element in Value)
        {
            stringBuilder.Append(element);
        }

        stringBuilder.Append('"');
        return stringBuilder.ToString();
    }
}
