using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class MinuteAtom : IntAtom, IMinuteAtomOperators
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

    public static MinuteAtom operator +(MinuteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(MinuteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(MinuteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(MinuteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(MinuteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(MinuteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MinuteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MinuteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MinuteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(MinuteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(MinuteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(MinuteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(MinuteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(MinuteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(MinuteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(MinuteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MinuteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MinuteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MinuteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(MinuteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(MinuteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(MinuteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(MinuteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(MinuteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(MinuteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(MinuteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(MinuteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(MinuteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(MinuteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(MinuteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(MinuteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MinuteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(MinuteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
