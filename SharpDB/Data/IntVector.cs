using System.Text;
using static SharpDB.Data.BaseIntAtom;

namespace SharpDB.Data;

public class IntVector : BaseIntVector
{
    public override DataType Type => DataType.IntVector;

    public IntVector(int[] value, VectorAttribute attribute = VectorAttribute.None) : base(value, attribute)
    {
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`int$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? "," : "");
        stringBuilder.AppendJoin(' ', Value.Select(x => x switch
        {
            Null => "0N",
            NegativeInfinity => "-0W",
            PositiveInfinity => "0W",
            _ => $"{x}",
        }));
        stringBuilder.Append('i');
        return stringBuilder.ToString();
    }
}