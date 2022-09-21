namespace SharpDB.Data;

public class IntAtom : BaseAtom<int>, IIntAtomOperators
{
    public const int Null = int.MinValue;
    public const int NegativeInfinity = int.MinValue + 1;
    public const int PositiveInfinity = int.MaxValue;

    public override DataType Type => DataType.IntAtom;

    public IntAtom(int value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[5];
        result[0] = (byte)Type;
        Buffer.BlockCopy(BitConverter.GetBytes(Value), 0, result, 1, 4);
        return result;
    }

    public override string ToString() => Value switch
    {
        Null => "0Ni",
        NegativeInfinity => "-0Wi",
        PositiveInfinity => "0Wi",
        _ => $"{Value}i",
    };

    public static IntAtom operator +(IntAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(IntAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator +(IntAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator +(IntAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(IntAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(IntAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(IntAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(IntAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(IntAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(IntAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(IntAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(IntAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(IntAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator +(IntAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(IntAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(IntAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(IntAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(IntAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(IntAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(IntAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(IntAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(IntAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(IntAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(IntAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(IntAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(IntAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(IntAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(IntAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(IntAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(IntAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(IntAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(IntAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(IntAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(IntAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(IntAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(IntAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(IntAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(IntAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(IntAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(IntAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(IntAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(IntAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(IntAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(IntAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(IntAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(IntAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(IntAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(IntAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(IntAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(IntAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(IntAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(IntAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(IntAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(IntAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(IntAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(IntAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(IntAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(IntAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(IntAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(IntAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(IntAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(IntAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(IntAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(IntAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
