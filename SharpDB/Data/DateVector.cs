using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Data;

public class DateVector : IntVector, IDateVectorOperators
{
    public override DataType Type => DataType.DateVector;

    public DateVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`date$()";
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
                    return x.ToDateString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('d');
        }

        return stringBuilder.ToString();
    }

    public static DateVector operator +(DateVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(DateVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(DateVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(DateVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(DateVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(DateVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(DateVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(DateVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(DateVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(DateVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(DateVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
