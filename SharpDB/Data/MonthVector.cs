using System.Text;
using SharpDB.Data.Extensions;

namespace SharpDB.Data;

public class MonthVector : IntVectorBase<MonthVector>
{
    public override DataType Type => DataType.MonthVector;

    public MonthVector(int[] value, VectorAttribute attribute = VectorAttribute.None)
        : base(value, attribute, (x, y) => new MonthVector(x, y))
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`month$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => x.ToMonthString(),
        }));
        stringBuilder.Append('m');

        return stringBuilder.ToString();
    }
}
