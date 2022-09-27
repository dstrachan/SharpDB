namespace SharpDB.Data;

public abstract class VectorBase<TSelf, TData> : IVector<TData>
    where TSelf : IVector<TData>
{
    public abstract DataType Type { get; }
    
    public TData[] Value { get; }

    public VectorAttribute Attribute { get; }

    private Func<TData[], VectorAttribute, TSelf> Factory { get; }

    protected VectorBase(TData[] value, VectorAttribute attribute, Func<TData[], VectorAttribute, TSelf> factory)
    {
        Value = value;
        Attribute = attribute;
        Factory = factory;
    }

    public abstract void Serialize(Stream stream);

    public TData this[int index]
    {
        get => Value[index];
        set => Value[index] = value;
    }

    public TData this[Index index]
    {
        get => Value[index];
        set => Value[index] = value;
    }

    public TSelf this[Range range] => Factory(Value[range], VectorAttribute.None);

    public TSelf this[params int[] indices]
    {
        get
        {
            var result = new TData[indices.Length];

            for (var i = 0; i < indices.Length; i++)
            {
                var index = indices[i];
                result[i] = Value[index];
            }

            return Factory(result, VectorAttribute.None);
        }
        set
        {
            if ((value.Value.Length > 1 && value.Value.Length != indices.Length) || indices.Any(x => x >= Value.Length))
            {
                throw new ArgumentException("length");
            }

            if (value.Value.Length == 1)
            {
                foreach (var index in indices)
                {
                    Value[index] = value.Value[0];
                }
            }
            else
            {
                for (var i = 0; i < indices.Length; i++)
                {
                    var index = indices[i];
                    Value[index] = value.Value[i];
                }
            }
        }
    }

    public static implicit operator TData[](VectorBase<TSelf, TData> vector) => vector.Value;
}
