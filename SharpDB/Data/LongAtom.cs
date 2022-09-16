namespace SharpDB.Data;

public class LongAtom : BaseLongAtom
{
    public override DataType Type => DataType.LongAtom;

    public LongAtom(long value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0N",
        NegativeInfinity => "-0W",
        PositiveInfinity => "0W",
        _ => $"{Value}",
    };
}