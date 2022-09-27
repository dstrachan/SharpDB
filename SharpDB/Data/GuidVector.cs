using System.Buffers.Binary;
using System.Text;

namespace SharpDB.Data;

public class GuidVector : VectorBase<GuidVector, Guid>
{
    public static readonly Guid Null = Guid.Empty;
    
    public override DataType Type => DataType.GuidVector;

    public GuidVector(Guid[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new GuidVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        foreach (var guid in Value)
        {
            stream.Write(guid.ToByteArray());
        }
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
