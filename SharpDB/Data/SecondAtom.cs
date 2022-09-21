using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class SecondAtom : IntAtom, ISecondAtomOperators
{
    public override DataType Type => DataType.SecondAtom;

    public SecondAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Nv",
        NegativeInfinity => "-0Wv",
        PositiveInfinity => "0Wv",
        _ => Value.ToSecondString(),
    };

    public static SecondAtom operator +(SecondAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(SecondAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(SecondAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(SecondAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(SecondAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(SecondAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(SecondAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(SecondAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(SecondAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(SecondAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(SecondAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(SecondAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(SecondAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(SecondAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(SecondAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(SecondAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(SecondAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(SecondAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(SecondAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(SecondAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(SecondAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(SecondAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(SecondAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(SecondAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(SecondAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
