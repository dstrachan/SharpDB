namespace SharpDB.Data;

public abstract class BaseIntVector : BaseVector<int>
{
    protected BaseIntVector(int[] value, VectorAttribute attribute) : base(value, attribute)
    {
    }

    public override byte[] Serialize()
    {
        var result = new byte[6 + Value.Length * 4];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length * 4);
        return result;
    }
}