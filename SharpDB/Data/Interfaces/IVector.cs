namespace SharpDB.Data;

public interface IVector<out T> : IDataType where T : notnull
{
    T[] Value { get; }

    VectorAttribute Attribute { get; }
}