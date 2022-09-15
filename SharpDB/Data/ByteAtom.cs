namespace SharpDB.Data;

public class ByteAtom : IAtom<byte>
{
    public DataType Type => DataType.ByteAtom;

    public byte Value { get; }

    public ByteAtom(byte value)
    {
        Value = value;
    }

    public byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = Value;
        return result;
    }

    public override string ToString() => $"0x{Value:x2}";
}