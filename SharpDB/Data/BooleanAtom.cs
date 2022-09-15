namespace SharpDB.Data;

public class BooleanAtom : IAtom<bool>
{
    public DataType Type => DataType.BooleanAtom;

    public bool Value { get; }

    public BooleanAtom(bool value)
    {
        Value = value;
    }

    public byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = (byte)(Value ? 1 : 0);
        return result;
    }

    public override string ToString() => $"{(Value ? 1 : 0)}b";
}