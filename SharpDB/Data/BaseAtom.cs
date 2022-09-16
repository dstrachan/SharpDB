namespace SharpDB.Data;

public abstract class BaseAtom<T> : IAtom<T> where T : notnull
{
    public abstract DataType Type { get; }

    public T Value { get; }

    protected BaseAtom(T value)
    {
        Value = value;
    }

    public abstract byte[] Serialize();

    public abstract override string ToString();
}