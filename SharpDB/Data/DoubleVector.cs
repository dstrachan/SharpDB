using System.Text;
using static SharpDB.Data.DoubleAtom;

namespace SharpDB.Data;

public class DoubleVector : BaseVector<double>, IDoubleVectorOperators
{
    public override DataType Type => DataType.DoubleVector;

    public DoubleVector(double[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 8];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length * 8);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`double$()";
        }

        var requiresSuffix = true;
        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x =>
        {
            switch (x)
            {
                case Null:
                    requiresSuffix = false;
                    return "0n";
                case NegativeInfinity:
                    requiresSuffix = false;
                    return "-0w";
                case PositiveInfinity:
                    requiresSuffix = false;
                    return "0w";
                default:
                    requiresSuffix &= Math.Abs(x - (int)x) < double.Epsilon;
                    return $"{x}";
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('f');
        }

        return stringBuilder.ToString();
    }

    public static DoubleVector operator +(DoubleVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(DoubleVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(DoubleVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(DoubleVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DoubleVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
