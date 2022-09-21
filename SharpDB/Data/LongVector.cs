using System.Text;
using static SharpDB.Data.LongAtom;

namespace SharpDB.Data;

public class LongVector : BaseVector<long>, ILongVectorOperators
{
    public override DataType Type => DataType.LongVector;

    public LongVector(long[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
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
            return "`long$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        return stringBuilder.ToString();
    }

    public static LongVector operator +(LongVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(LongVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(LongVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(LongVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(LongVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(LongVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(LongVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(LongVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(LongVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(LongVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(LongVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(LongVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(LongVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(LongVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(LongVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(LongVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(LongVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(LongVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(LongVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(LongVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(LongVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(LongVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(LongVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(LongVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(LongVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(LongVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(LongVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(LongVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(LongVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(LongVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(LongVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(LongVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(LongVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(LongVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(LongVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(LongVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(LongVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(LongVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(LongVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(LongVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(LongVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(LongVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(LongVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(LongVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(LongVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(LongVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(LongVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(LongVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(LongVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(LongVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(LongVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(LongVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(LongVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
