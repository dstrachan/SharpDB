using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Data;

public class MinuteVector : IntVector, IMinuteVectorOperators
{
    public override DataType Type => DataType.MinuteVector;

    public MinuteVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`minute$()";
        }

        var requiresSuffix = true;
        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x =>
        {
            switch (x)
            {
                case Null:
                    return "0N";
                case NegativeInfinity:
                    return "-0W";
                case PositiveInfinity:
                    return "0W";
                default:
                    requiresSuffix = false;
                    return x.ToMinuteString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('u');
        }

        return stringBuilder.ToString();
    }

    public static MinuteVector operator +(MinuteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MinuteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MinuteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MinuteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(MinuteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(MinuteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(MinuteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(MinuteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(MinuteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MinuteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MinuteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MinuteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(MinuteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(MinuteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(MinuteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(MinuteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(MinuteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(MinuteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MinuteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MinuteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MinuteVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
