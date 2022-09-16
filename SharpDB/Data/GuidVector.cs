using System.Text;

namespace SharpDB.Data;

public class GuidVector : BaseVector<Guid>
{
    public override DataType Type => DataType.GuidVector;

    public GuidVector(Guid[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 16];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        for (var i = 0; i < Value.Length; i++)
        {
            Buffer.BlockCopy(Value[i].ToByteArray(), 0, result, 6 + i * 16, 16);
        }

        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`guid$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value);
        return stringBuilder.ToString();
    }
}