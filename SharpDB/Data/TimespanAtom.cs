using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class TimespanAtom : BaseLongAtom
{
    public override DataType Type => DataType.TimespanAtom;

    public TimespanAtom(long value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nn",
        NegativeInfinity => "-0Wn",
        PositiveInfinity => "0Wn",
        _ => Value.ToTimespanString(),
    };
}