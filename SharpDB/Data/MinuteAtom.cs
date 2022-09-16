using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class MinuteAtom : BaseIntAtom
{
    public override DataType Type => DataType.MinuteAtom;

    public MinuteAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nu",
        NegativeInfinity => "-0Wu",
        PositiveInfinity => "0Wu",
        _ => Value.ToMinuteString(),
    };
}