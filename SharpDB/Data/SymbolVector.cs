using System.Text;

namespace SharpDB.Data;

public class SymbolVector : BaseVector<string>
{
    public override DataType Type => DataType.SymbolVector;

    public SymbolVector(string[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        var offset = 6;
        foreach (var symbol in Value)
        {
            var symbolBytes = Encoding.UTF8.GetBytes($"{symbol}{char.MinValue}");
            if (result.Length < offset + symbolBytes.Length)
            {
                Array.Resize(ref result, offset + symbolBytes.Length);
            }

            Buffer.BlockCopy(symbolBytes, 0, result, offset, symbolBytes.Length);
            offset += symbolBytes.Length;
        }

        return result;
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