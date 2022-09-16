using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.BaseLongAtom;

namespace SharpDB.Data;

public class TimespanVector : BaseLongVector
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
}