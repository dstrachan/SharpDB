using System.Text;
using static SharpDB.Data.IntAtom;

namespace SharpDB.Data;

public class IntVector : BaseVector<int>, IIntVectorOperators
{
    public override DataType Type => DataType.IntVector;

    public IntVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 4];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length * 4);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`int$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('i');
        return stringBuilder.ToString();
    }

    public static IntVector operator +(IntVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(IntVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(IntVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(IntVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(IntVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(IntVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(IntVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(IntVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(IntVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(IntVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(IntVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(IntVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(IntVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(IntVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(IntVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(IntVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(IntVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(IntVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(IntVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(IntVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(IntVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(IntVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(IntVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(IntVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(IntVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(IntVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(IntVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(IntVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(IntVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(IntVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(IntVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(IntVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(IntVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(IntVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(IntVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(IntVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(IntVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(IntVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(IntVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(IntVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(IntVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(IntVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(IntVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(IntVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(IntVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(IntVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(IntVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(IntVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(IntVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(IntVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(IntVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(IntVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(IntVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(IntVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(IntVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(IntVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(IntVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(IntVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(IntVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
