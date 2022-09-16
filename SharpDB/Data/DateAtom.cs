using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class DateAtom : BaseIntAtom
{
    public override DataType Type => DataType.DateAtom;

    public DateAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nd",
        NegativeInfinity => "-0Wd",
        PositiveInfinity => "0Wd",
        _ => Value.ToDateString(),
    };
}