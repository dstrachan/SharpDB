using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class DateAtom : IntAtom, IDateAtomOperators
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

    public static DateAtom operator +(DateAtom left, ByteAtom right) => new(left.Value + right.Value);

    public static DateVector operator +(DateAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(DateAtom left, ShortAtom right) => new(left.Value + right.Value);

    public static DateVector operator +(DateAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(DateAtom left, IntAtom right) => new(left.Value + right.Value);

    public static DateVector operator +(DateAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(DateAtom left, LongAtom right) => new((int)(left.Value + right.Value));

    public static DateVector operator +(DateAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(DateAtom left, DateAtom right) => new(left.Value + right.Value);

    public static IntVector operator +(DateAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(DateAtom left, TimespanAtom right) => new(left.Value + right.Value);

    public static TimestampVector operator +(DateAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(DateAtom left, MinuteAtom right) => new(left.Value + right.Value);

    public static TimestampVector operator +(DateAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(DateAtom left, SecondAtom right) => new(left.Value + right.Value);

    public static TimestampVector operator +(DateAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(DateAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(DateAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(DateAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(DateAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(DateAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(DateAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(DateAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(DateAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(DateAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(DateAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(DateAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(DateAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(DateAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DateAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
