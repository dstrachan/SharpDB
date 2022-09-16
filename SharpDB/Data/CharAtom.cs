namespace SharpDB.Data;

public class CharAtom : BaseAtom<char>
{
    public const char Null = ' ';

    public override DataType Type => DataType.CharAtom;

    public CharAtom(char value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = (byte)Value;
        return result;
    }

    public override string ToString() => $"\"{Value}\"";
}