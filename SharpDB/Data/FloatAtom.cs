namespace SharpDB.Data;

public class FloatAtom : BaseAtom<float>
{
    public const float Null = float.NaN;
    public const float NegativeInfinity = float.NegativeInfinity;
    public const float PositiveInfinity = float.PositiveInfinity;

    public override DataType Type => DataType.FloatAtom;

    public FloatAtom(float value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[5];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 4);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0Ne",
        NegativeInfinity => "-0We",
        PositiveInfinity => "0We",
        _ => $"{Value}e",
    };
}