using System.Text;

namespace SharpDB.Data;

public class SymbolVector : VectorBase<SymbolVector, string>
{
    public override DataType Type => DataType.SymbolVector;

    public SymbolVector(string[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new SymbolVector(x, y))
    {
    }

    public override void Serialize(Stream stream)
    {
        stream.WriteByte((byte)Type);
        stream.WriteByte((byte)VectorAttribute.None);
        stream.Write(BitConverter.GetBytes(Value.Length));

        foreach (var value in Value)
        {
            stream.Write(Encoding.UTF8.GetBytes($"{value}{char.MinValue}"));
        }
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`symbol$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? ",`" : "`");
        stringBuilder.AppendJoin('`', Value);
        return stringBuilder.ToString();
    }
}
