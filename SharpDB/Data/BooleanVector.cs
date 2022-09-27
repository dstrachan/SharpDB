using System.Text;

namespace SharpDB.Data;

public class BooleanVector : VectorBase<BooleanVector, bool>
{
    public override DataType Type => DataType.BooleanVector;

    public BooleanVector(bool[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new BooleanVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        foreach (var value in Value)
        {
            stream.WriteByte((byte)(value ? 1 : 0));
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`boolean$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        foreach (var element in Value)
        {
            stringBuilder.Append(element ? 1 : 0);
        }

        stringBuilder.Append('b');
        return stringBuilder.ToString();
    }
}
