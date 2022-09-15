namespace SharpDB.Data;

public interface IAtom<out T> : IDataType where T : notnull
{
    T Value { get; }
}
