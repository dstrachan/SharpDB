using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Data;

public class MonthVector : IntVector, IMonthVectorOperators
{
    public override DataType Type => DataType.MonthVector;

    public MonthVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`month$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => x.ToMonthString(),
        }));
        stringBuilder.Append('m');

        return stringBuilder.ToString();
    }

    public static MonthVector operator +(MonthVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(MonthVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MonthVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(MonthVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(MonthVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(MonthVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(MonthVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(MonthVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MonthVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(MonthVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(MonthVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(MonthVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(MonthVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(MonthVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MonthVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(MonthVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(MonthVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
