using System.Text;
using static SharpDB.Data.FloatAtom;

namespace SharpDB.Data;

public class FloatVector : BaseVector<float>, IFloatVectorOperators
{
    public override DataType Type => DataType.FloatVector;

    public FloatVector(float[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
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
            return "`float$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('e');
        return stringBuilder.ToString();
    }

    public static FloatVector operator +(FloatVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator +(FloatVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(FloatVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator +(FloatVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(FloatVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator +(FloatVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(FloatVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator +(FloatVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(FloatVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator +(FloatVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(FloatVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator +(FloatVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(FloatVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator +(FloatVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator -(FloatVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(FloatVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator -(FloatVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(FloatVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator -(FloatVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(FloatVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator -(FloatVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(FloatVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator -(FloatVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(FloatVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator -(FloatVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(FloatVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator -(FloatVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static FloatVector operator *(FloatVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(FloatVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator *(FloatVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(FloatVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimestampVector operator *(FloatVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(FloatVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static MonthVector operator *(FloatVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(FloatVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static TimespanVector operator *(FloatVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(FloatVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static MinuteVector operator *(FloatVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(FloatVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static SecondVector operator *(FloatVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, ByteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, ByteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, ShortAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, ShortVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, IntAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, IntVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, LongAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, LongVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, FloatAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, FloatVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, DoubleAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, DoubleVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, TimestampAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, TimestampVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, MonthAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, MonthVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, TimespanAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, TimespanVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, MinuteAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, MinuteVector right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, SecondAtom right)
    {
        throw new NotImplementedException();
    }

    public static DoubleVector operator /(FloatVector left, SecondVector right)
    {
        throw new NotImplementedException();
    }
}
