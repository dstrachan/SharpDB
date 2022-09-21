namespace SharpDB.Data;

public class ShortAtom : BaseAtom<short>, IShortAtomOperators
{
    public const short Null = short.MinValue;
    public const short NegativeInfinity = short.MinValue + 1;
    public const short PositiveInfinity = short.MaxValue;

    public override DataType Type => DataType.ShortAtom;

    public ShortAtom(short value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[3];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 2);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0Nh",
        NegativeInfinity => "-0Wh",
        PositiveInfinity => "0Wh",
        _ => $"{Value}h",
    };

    public static IntAtom operator +(ShortAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(ShortAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(ShortAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator +(ShortAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(ShortAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(ShortAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(ShortAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(ShortAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(ShortAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(ShortAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(ShortAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(ShortAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(ShortAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(ShortAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(ShortAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(ShortAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(ShortAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(ShortAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(ShortAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(ShortAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(ShortAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(ShortAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(ShortAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(ShortAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(ShortAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ShortAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(ShortAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ShortAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(ShortAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ShortAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(ShortAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ShortAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(ShortAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ShortAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(ShortAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ShortAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(ShortAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ShortAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(ShortAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ShortAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(ShortAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ShortAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ShortAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ShortAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ShortAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(ShortAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ShortAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(ShortAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ShortAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(ShortAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ShortAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(ShortAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ShortAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(ShortAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ShortAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(ShortAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ShortAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(ShortAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ShortAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(ShortAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ShortAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(ShortAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ShortAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ShortAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
