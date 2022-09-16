namespace SharpDB.Data;

public abstract class BaseVector<T> : IVector<T> where T : notnull
{
    public abstract DataType Type { get; }

    public T[] Value { get; }

    public VectorAttribute Attribute { get; }

    protected BaseVector(T[] value, VectorAttribute attribute)
    {
        Value = value;
        Attribute = attribute;
    }

    public abstract byte[] Serialize();

    public abstract override string ToString();
}