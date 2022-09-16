namespace SharpDB.Data;

public class ShortAtom : BaseAtom<short>
{
    public const short Null = short.MinValue;
    public const short NegativeInfinity = short.MinValue + 1;
    public const short PositiveInfinity = short.MaxValue;

    public override DataType Type => DataType.ShortAtom;

    public ShortAtom(short value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[3];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 2);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0Nh",
        NegativeInfinity => "-0Wh",
        PositiveInfinity => "0Wh",
        _ => $"{Value}h",
    };
}