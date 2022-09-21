using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Data;

public class SecondVector : IntVector, ISecondVectorOperators
{
    public override DataType Type => DataType.SecondVector;

    public SecondVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`second$()";
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
                    return x.ToSecondString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('v');
        }

        return stringBuilder.ToString();
    }

    public static SecondVector operator +(SecondVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(SecondVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(SecondVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(SecondVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(SecondVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(SecondVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(SecondVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(SecondVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(SecondVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(SecondVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(SecondVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(SecondVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(SecondVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(SecondVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(SecondVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(SecondVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(SecondVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
