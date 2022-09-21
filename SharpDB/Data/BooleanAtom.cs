namespace SharpDB.Data;

public class BooleanAtom : BaseAtom<bool>
{
    public override DataType Type => DataType.BooleanAtom;

    public BooleanAtom(bool value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = (byte)(Value ? 1 : 0);
        return result;
    }

    public override string ToString() => $"{(Value ? 1 : 0)}b";
}
