namespace SharpDB.Data;

public class ByteAtom : BaseAtom<byte>
{
    public override DataType Type => DataType.ByteAtom;

    public ByteAtom(byte value) : base(value)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[2];
        result[0] = (byte)Type;
        result[1] = Value;
        return result;
    }

    public override string ToString() => $"0x{Value:x2}";
}