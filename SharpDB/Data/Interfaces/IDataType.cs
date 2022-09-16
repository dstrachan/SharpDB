namespace SharpDB.Data;

public interface IDataType
{
    public DataType Type { get; }

    byte[] Serialize();
}
