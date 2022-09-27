using System.Text;
using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class DateVector : IntVectorBase<DateVector>
{
    public override DataType Type => DataType.DateVector;

    public DateVector(int[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new DateVector(x, y))
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
}
