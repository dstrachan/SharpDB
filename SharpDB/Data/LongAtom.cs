namespace SharpDB.Data;

public class LongAtom : BaseAtom<long>, ILongAtomOperators
{
    public const long Null = long.MinValue;
    public const long NegativeInfinity = long.MinValue + 1;
    public const long PositiveInfinity = long.MaxValue;

    public override DataType Type => DataType.LongAtom;

    public LongAtom(long value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[9];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 8);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0N",
        NegativeInfinity => "-0W",
        PositiveInfinity => "0W",
        _ => $"{Value}",
    };

    public static LongAtom operator +(LongAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator +(LongAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator +(LongAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator +(LongAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(LongAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(LongAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(LongAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(LongAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(LongAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(LongAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(LongAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(LongAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(LongAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(LongAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(LongAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(LongAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(LongAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(LongAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(LongAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(LongAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(LongAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(LongAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(LongAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(LongAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(LongAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(LongAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(LongAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(LongAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(LongAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(LongAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(LongAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(LongAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(LongAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(LongAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(LongAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(LongAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(LongAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(LongAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(LongAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(LongAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(LongAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(LongAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(LongAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(LongAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(LongAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(LongAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(LongAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(LongAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(LongAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(LongAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(LongAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(LongAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(LongAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(LongAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(LongAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(LongAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(LongAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(LongAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(LongAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(LongAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(LongAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
