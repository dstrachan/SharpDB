using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class MonthAtom : IntAtom, IMonthAtomOperators
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

    public static MonthAtom operator +(MonthAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(MonthAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(MonthAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(MonthAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(MonthAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(MonthAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MonthAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(MonthAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(MonthAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MonthAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MonthAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MonthAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(MonthAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(MonthAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(MonthAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(MonthAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(MonthAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(MonthAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MonthAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(MonthAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(MonthAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MonthAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MonthAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MonthAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(MonthAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(MonthAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(MonthAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(MonthAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(MonthAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(MonthAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MonthAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MonthAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
