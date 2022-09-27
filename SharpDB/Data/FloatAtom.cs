namespace SharpDB.Data;

public class FloatAtom : BaseAtom<float>, IFloatAtomOperators
{
    public const float Null = float.NaN;
    public const float NegativeInfinity = float.NegativeInfinity;
    public const float PositiveInfinity = float.PositiveInfinity;

    public override DataType Type => DataType.FloatAtom;

    public FloatAtom(float value) : base(value)
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
        Null => "0Ne",
        NegativeInfinity => "-0We",
        PositiveInfinity => "0We",
        _ => $"{Value}e",
    };

    public static FloatAtom operator +(FloatAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(FloatAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(FloatAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(FloatAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator +(FloatAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(FloatAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(FloatAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator +(FloatAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(FloatAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator +(FloatAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(FloatAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator +(FloatAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(FloatAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator +(FloatAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(FloatAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator +(FloatAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(FloatAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(FloatAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(FloatAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(FloatAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(FloatAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(FloatAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(FloatAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(FloatAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(FloatAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(FloatAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(FloatAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(FloatAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(FloatAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(FloatAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(FloatAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(FloatAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(FloatAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(FloatAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(FloatAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(FloatAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(FloatAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(FloatAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(FloatAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(FloatAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(FloatAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(FloatAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(FloatAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(FloatAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(FloatAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(FloatAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(FloatAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(FloatAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(FloatAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(FloatAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(FloatAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(FloatAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
