namespace SharpDB.Data;

public class ByteAtom : BaseAtom<byte>, IByteAtomOperators
{
    public override DataType Type => DataType.ByteAtom;

    public ByteAtom(byte value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = Value;
        return result;
    }

    public override string ToString() => $"0x{Value:x2}";

    public static IntAtom operator +(ByteAtom left, ByteAtom right) => new(left.Value + right.Value);

    public static IntVector operator +(ByteAtom left, ByteVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new IntVector(result);
    }

    public static IntAtom operator +(ByteAtom left, ShortAtom right) => new(left.Value + right.Value);

    public static IntVector operator +(ByteAtom left, ShortVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new IntVector(result);
    }

    public static IntAtom operator +(ByteAtom left, IntAtom right) => new(left.Value + right.Value);

    public static IntVector operator +(ByteAtom left, IntVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new IntVector(result);
    }

    public static LongAtom operator +(ByteAtom left, LongAtom right) => new(left.Value + right.Value);

    public static LongVector operator +(ByteAtom left, LongVector right)
    {
        var result = new long[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new LongVector(result);
    }

    public static TimestampAtom operator +(ByteAtom left, TimestampAtom right) => new(left.Value + right.Value);

    public static TimestampVector operator +(ByteAtom left, TimestampVector right)
    {
        var result = new long[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new TimestampVector(result);
    }

    public static MonthAtom operator +(ByteAtom left, MonthAtom right) => new(left.Value + right.Value);

    public static MonthVector operator +(ByteAtom left, MonthVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new MonthVector(result);
    }

    public static DateAtom operator +(ByteAtom left, DateAtom right) => new(left.Value + right.Value);

    public static DateVector operator +(ByteAtom left, DateVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new DateVector(result);
    }

    public static TimespanAtom operator +(ByteAtom left, TimespanAtom right) => new(left.Value + right.Value);

    public static TimespanVector operator +(ByteAtom left, TimespanVector right)
    {
        var result = new long[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new TimespanVector(result);
    }

    public static MinuteAtom operator +(ByteAtom left, MinuteAtom right) => new(left.Value + right.Value);

    public static MinuteVector operator +(ByteAtom left, MinuteVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new MinuteVector(result);
    }

    public static FloatAtom operator +(ByteAtom left, FloatAtom right) => new(left.Value + right.Value);

    public static FloatVector operator +(ByteAtom left, FloatVector right)
    {
        var result = new float[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new FloatVector(result);
    }

    public static DoubleAtom operator +(ByteAtom left, DoubleAtom right) => new(left.Value + right.Value);

    public static DoubleVector operator +(ByteAtom left, DoubleVector right)
    {
        var result = new double[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new DoubleVector(result);
    }

    public static SecondAtom operator +(ByteAtom left, SecondAtom right) => new(left.Value + right.Value);

    public static SecondVector operator +(ByteAtom left, SecondVector right)
    {
        var result = new int[right.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value + right.Value[i];
        }

        return new SecondVector(result);
    }

    public static IntAtom operator -(ByteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(ByteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator -(ByteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator -(ByteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ByteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator -(ByteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ByteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator -(ByteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ByteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator -(ByteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ByteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator -(ByteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ByteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator -(ByteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ByteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator -(ByteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ByteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator -(ByteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ByteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator -(ByteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ByteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ByteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ByteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntAtom operator *(ByteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongAtom operator *(ByteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ByteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatAtom operator *(ByteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ByteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator *(ByteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ByteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampAtom operator *(ByteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ByteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthAtom operator *(ByteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ByteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateAtom operator *(ByteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ByteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanAtom operator *(ByteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ByteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteAtom operator *(ByteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ByteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondAtom operator *(ByteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ByteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleAtom operator /(ByteAtom left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteAtom left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
