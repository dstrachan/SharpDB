namespace SharpDB.Data;

public abstract class BaseIntAtom : BaseAtom<int>
{
    public const int Null = int.MinValue;
    public const int NegativeInfinity = int.MinValue + 1;
    public const int PositiveInfinity = int.MaxValue;

    protected BaseIntAtom(int value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[5];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 4);
        return result;
    }
}