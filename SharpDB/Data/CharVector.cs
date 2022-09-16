using System.Text;

namespace SharpDB.Data;

public class CharVector : BaseVector<char>
{
    public override DataType Type => DataType.CharVector;

    public CharVector(char[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        for (var i = 0; i < Value.Length; i++)
        {
            result[6 + i] = (byte)Value[i];
        }
        return result;
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