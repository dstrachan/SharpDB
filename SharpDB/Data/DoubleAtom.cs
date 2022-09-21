namespace SharpDB.Data;

public class DoubleAtom : BaseAtom<double>, IDoubleAtomOperators
{
    public const double Null = double.NaN;
    public const double NegativeInfinity = double.NegativeInfinity;
    public const double PositiveInfinity = double.PositiveInfinity;

    public override DataType Type => DataType.DoubleAtom;

    public DoubleAtom(double value) : base(value)
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
        Null => "0n",
        NegativeInfinity => "-0w",
        PositiveInfinity => "0w",
        _ => Math.Abs(Value - (int)Value) < double.Epsilon ? $"{Value}f" : $"{Value}",
    };

    public static DoubleAtom operator +(DoubleAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator +(DoubleAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(DoubleAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(DoubleAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(DoubleAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
