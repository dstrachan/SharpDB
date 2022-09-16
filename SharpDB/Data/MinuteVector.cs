using System.Text;
using SharpDB.Data.Extensions;
using static SharpDB.Data.BaseIntAtom;

namespace SharpDB.Data;

public class MinuteVector : BaseIntVector
{
    public override DataType Type => DataType.MinuteVector;

    public MinuteVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`minute$()";
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
                    return x.ToMinuteString();
            }
        }));
        if (requiresSuffix)
        {
            stringBuilder.Append('u');
        }

        return stringBuilder.ToString();
    }
}