using SharpDB.Data;

namespace SharpDB.Tests;

public static class TestExtensions
{
    public static byte[] Serialize<TSelf, TData>(this VectorBase<TSelf, TData> vector) where TSelf : IVector<TData>
    {
        using var stream = new MemoryStream();
        vector.Serialize(stream);
        return stream.ToArray();
    }
}
