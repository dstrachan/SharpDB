namespace SharpDB.Data;

public class DoubleAtom : BaseAtom<double>
{
    public const double Null = double.NaN;
    public const double NegativeInfinity = double.NegativeInfinity;
    public const double PositiveInfinity = double.PositiveInfinity;

    public override DataType Type => DataType.DoubleAtom;

    public DoubleAtom(double value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[9];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 8);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0n",
        NegativeInfinity => "-0w",
        PositiveInfinity => "0w",
        _ => Math.Abs(Value - (int)Value) < double.Epsilon ? $"{Value}f" : $"{Value}",
    };
}