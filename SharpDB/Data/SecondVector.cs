using System.Text;
using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class SecondVector : IntVectorBase<SecondVector>
{
    public override DataType Type => DataType.SecondVector;

    public SecondVector(int[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new SecondVector(x, y))
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
}
