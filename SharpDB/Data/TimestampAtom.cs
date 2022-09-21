using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class TimestampAtom : LongAtom, ITimestampAtomOperators
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

    public static TimestampAtom operator +(TimestampAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(TimestampAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimestampAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(TimestampAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimestampAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(TimestampAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(TimestampAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimestampAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(TimestampAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimestampAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(TimestampAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(TimestampAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(TimestampAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(TimestampAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(TimestampAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(TimestampAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(TimestampAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimestampAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(TimestampAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
