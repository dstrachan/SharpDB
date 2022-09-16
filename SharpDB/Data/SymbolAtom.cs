using System.Text;

namespace SharpDB.Data;

public class SymbolAtom : BaseAtom<string>
{
    public const string Null = "";

    public override DataType Type => DataType.SymbolAtom;

    public SymbolAtom(string value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var symbolBytes = Encoding.UTF8.GetBytes($"{Value}{char.MinValue}");
        var result = new byte[1 + symbolBytes.Length];
        result[0] = (byte)Type;
        Buffer.BlockCopy(symbolBytes, 0, result, 1, symbolBytes.Length);
        return result;
    }

    public override string ToString() => $"`{Value}";
}