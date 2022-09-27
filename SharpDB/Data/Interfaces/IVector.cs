namespace SharpDB.Data;

public interface IVector<out T>
{
    DataType Type { get; }

    T[] Value { get; }

    VectorAttribute Attribute { get; }

    void Serialize(Stream stream);
}
