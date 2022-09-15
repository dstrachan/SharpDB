namespace SharpDB.Data;

public class GuidAtom : IAtom<Guid>
{
    public static readonly Guid Null = Guid.Empty;
    
    public DataType Type => DataType.GuidAtom;

    public Guid Value { get; }

    public GuidAtom(Guid value)
    {
        Value = value;
    }

    public byte[] Serialize()
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