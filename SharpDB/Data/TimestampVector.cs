using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.LongAtom;

namespace SharpDB.Data;

public class TimestampVector : LongVector, ITimestampVectorOperators
{
    public override DataType Type => DataType.TimestampVector;

    public TimestampVector(long[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`timestamp$()";
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
                    return x.ToTimestampString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('p');
        }

        return stringBuilder.ToString();
    }

    public static TimestampVector operator +(TimestampVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimestampVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(TimestampVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimestampVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(TimestampVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(TimestampVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimestampVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(TimestampVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimestampVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(TimestampVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(TimestampVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(TimestampVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimestampVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(TimestampVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(TimestampVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
