using System.Text;
using static SharpDB.Data.BaseLongAtom;

namespace SharpDB.Data;

public class LongVector : BaseLongVector
{
    public override DataType Type => DataType.LongVector;

    public LongVector(long[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
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
}