using System.Text;

namespace SharpDB.Data;

public class BooleanVector : BaseVector<bool>
{
    public override DataType Type => DataType.BooleanVector;

    public BooleanVector(bool[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length);
        return result;
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
