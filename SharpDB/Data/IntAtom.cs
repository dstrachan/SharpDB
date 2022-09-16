namespace SharpDB.Data;

public class IntAtom : BaseIntAtom
{
    public override DataType Type => DataType.IntAtom;

    public IntAtom(int value) : base(value)
    {
    }

    public override string ToString() => Value switch
    {
        Null => "0Ni",
        NegativeInfinity => "-0Wi",
        PositiveInfinity => "0Wi",
        _ => $"{Value}i",
    };
}