namespace SharpDB.Data;

public abstract class BaseLongAtom : BaseAtom<long>
{
    public const long Null = long.MinValue;
    public const long NegativeInfinity = long.MinValue + 1;
    public const long PositiveInfinity = long.MaxValue;

    protected BaseLongAtom(long value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[9];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 8);
        return result;
    }
}