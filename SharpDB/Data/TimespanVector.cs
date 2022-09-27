using System.Text;
using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class TimespanVector : LongVectorBase<TimespanVector>
{
    public override DataType Type => DataType.TimespanVector;

    public TimespanVector(long[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new TimespanVector(x, y))
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
}
