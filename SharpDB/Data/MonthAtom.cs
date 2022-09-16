using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class MonthAtom : BaseIntAtom
{
    public override DataType Type => DataType.MonthAtom;

    public MonthAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nm",
        NegativeInfinity => "-0Wm",
        PositiveInfinity => "0Wm",
        _ => $"{Value.ToMonthString()}m",
    };
}