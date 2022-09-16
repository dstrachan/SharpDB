namespace SharpDB.Data;

public class GuidAtom : BaseAtom<Guid>
{
    public static readonly Guid Null = Guid.Empty;

    public override DataType Type => DataType.GuidAtom;

    public GuidAtom(Guid value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[17];
        result[0] = (byte)Type;
        Buffer.BlockCopy(Value.ToByteArray(), 0, result, 1, 16);
        return result;
    }

    public override string ToString()
    {
        return $"{Value}";
    }
}