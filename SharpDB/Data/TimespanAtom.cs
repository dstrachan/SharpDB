using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class TimespanAtom : TimestampAtom, ITimespanAtomOperators
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

    public static TimespanAtom operator +(TimespanAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(TimespanAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimespanAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimespanAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimespanAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimespanAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimespanAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(TimespanAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimespanAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimespanAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimespanAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimespanAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimespanAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(TimespanAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(TimespanAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(TimespanAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(TimespanAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(TimespanAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(TimespanAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimespanAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimespanAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
