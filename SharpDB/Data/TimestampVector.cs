using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.BaseLongAtom;

namespace SharpDB.Data;

public class TimestampVector : BaseLongVector
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
}