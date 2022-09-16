using System.Text;
using static SharpDB.Data.ShortAtom;

namespace SharpDB.Data;

public class ShortVector : BaseVector<short>
{
    public override DataType Type => DataType.ShortVector;

    public ShortVector(short[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 2];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length * 2);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`short$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('h');
        return stringBuilder.ToString();
    }
}