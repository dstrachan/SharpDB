using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class SecondAtom : BaseIntAtom
{
    public override DataType Type => DataType.SecondAtom;

    public SecondAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nv",
        NegativeInfinity => "-0Wv",
        PositiveInfinity => "0Wv",
        _ => Value.ToSecondString(),
    };
}