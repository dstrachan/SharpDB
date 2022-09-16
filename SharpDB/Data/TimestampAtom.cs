using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class TimestampAtom : BaseLongAtom
{
    public override DataType Type => DataType.TimestampAtom;

    public TimestampAtom(long value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Np",
        NegativeInfinity => "-0Wp",
        PositiveInfinity => "0Wp",
        _ => Value.ToTimestampString(),
    };
}