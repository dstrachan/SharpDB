using System.Text;
using static SharpDB.Data.ShortAtom;

namespace SharpDB.Data;

public class ShortVector : BaseVector<short>, IShortVectorOperators
{
    public override DataType Type => DataType.ShortVector;

    public ShortVector(short[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 2];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length * 2);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`short$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('h');
        return stringBuilder.ToString();
    }

    public static IntVector operator +(ShortVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator +(ShortVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(ShortVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator +(ShortVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(ShortVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(ShortVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(ShortVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(ShortVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(ShortVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(ShortVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(ShortVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(ShortVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(ShortVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator +(ShortVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(ShortVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(ShortVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(ShortVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(ShortVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(ShortVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(ShortVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator -(ShortVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ShortVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator -(ShortVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ShortVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(ShortVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ShortVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(ShortVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ShortVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(ShortVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ShortVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(ShortVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ShortVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator -(ShortVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ShortVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(ShortVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ShortVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(ShortVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ShortVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(ShortVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static IntVector operator *(ShortVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ShortVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static LongVector operator *(ShortVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ShortVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(ShortVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ShortVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(ShortVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ShortVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(ShortVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ShortVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(ShortVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ShortVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DateVector operator *(ShortVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ShortVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(ShortVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ShortVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(ShortVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ShortVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(ShortVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, DateAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, DateVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(ShortVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
