using System.Text;

namespace SharpDB.Data;

public class ByteVector : BaseVector<byte>, IByteVectorOperators
{
    public override DataType Type => DataType.ByteVector;

    public ByteVector(byte[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`byte$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? ",0x" : "0x");
        foreach (var element in Value)
        {
            stringBuilder.Append($"{element:x2}");
        }

        return stringBuilder.ToString();
    }

    public static IntVector operator +(ByteVector left, ByteAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new IntVector(result);
    }

    public static IntVector operator +(ByteVector left, ByteVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new IntVector(result);
    }

    public static IntVector operator +(ByteVector left, ShortAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new IntVector(result);
    }

    public static IntVector operator +(ByteVector left, ShortVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new IntVector(result);
    }

    public static IntVector operator +(ByteVector left, IntAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new IntVector(result);
    }

    public static IntVector operator +(ByteVector left, IntVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new IntVector(result);
    }

    public static LongVector operator +(ByteVector left, LongAtom right)
    {
        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new LongVector(result);
    }

    public static LongVector operator +(ByteVector left, LongVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new LongVector(result);
    }

    public static TimestampVector operator +(ByteVector left, TimestampAtom right)
    {
        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new TimestampVector(result);
    }

    public static TimestampVector operator +(ByteVector left, TimestampVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new TimestampVector(result);
    }

    public static MonthVector operator +(ByteVector left, MonthAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new MonthVector(result);
    }

    public static MonthVector operator +(ByteVector left, MonthVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new MonthVector(result);
    }

    public static DateVector operator +(ByteVector left, DateAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new DateVector(result);
    }

    public static DateVector operator +(ByteVector left, DateVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new DateVector(result);
    }

    public static TimespanVector operator +(ByteVector left, TimespanAtom right)
    {
        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new TimespanVector(result);
    }

    public static TimespanVector operator +(ByteVector left, TimespanVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new long[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new TimespanVector(result);
    }

    public static MinuteVector operator +(ByteVector left, MinuteAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new MinuteVector(result);
    }

    public static MinuteVector operator +(ByteVector left, MinuteVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new MinuteVector(result);
    }

    public static FloatVector operator +(ByteVector left, FloatAtom right)
    {
        var result = new float[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new FloatVector(result);
    }

    public static FloatVector operator +(ByteVector left, FloatVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new float[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new FloatVector(result);
    }

    public static DoubleVector operator +(ByteVector left, DoubleAtom right)
    {
        var result = new double[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new DoubleVector(result);
    }

    public static DoubleVector operator +(ByteVector left, DoubleVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new double[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new DoubleVector(result);
    }

    public static SecondVector operator +(ByteVector left, SecondAtom right)
    {
        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value;
        }

        return new SecondVector(result);
    }

    public static SecondVector operator +(ByteVector left, SecondVector right)
    {
        if (left.Value.Length != right.Value.Length) throw new ArgumentException("length");

        var result = new int[left.Value.Length];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = left.Value[i] + right.Value[i];
        }

        return new SecondVector(result);
    }

    public static IntVector operator -(ByteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ByteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ByteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ByteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ByteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ByteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ByteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ByteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ByteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ByteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ByteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ByteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ByteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ByteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ByteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ByteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ByteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ByteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ByteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ByteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ByteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ByteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ByteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ByteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ByteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ByteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ByteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ByteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ByteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ByteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ByteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ByteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ByteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ByteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ByteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ByteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ByteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ByteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ByteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ByteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
