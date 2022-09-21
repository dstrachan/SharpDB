using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.LongAtom;

namespace SharpDB.Data;

public class TimespanVector : TimestampVector, ITimespanVectorOperators
{
    public override DataType Type => DataType.TimespanVector;

    public TimespanVector(long[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`timespan$()";
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
                    return x.ToTimespanString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('n');
        }

        return stringBuilder.ToString();
    }

    public static TimespanVector operator +(TimespanVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimespanVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimespanVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimespanVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimespanVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimespanVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimespanVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimespanVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimespanVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(TimespanVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimespanVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimespanVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimespanVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
