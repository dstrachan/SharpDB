﻿using System.Text;

namespace SharpDB.Data;

public class ByteVector : IVector<byte>
{
    public DataType Type => DataType.ByteVector;

    public byte[] Value { get; }

    public VectorAttribute Attribute { get; }

    public ByteVector(byte[] value, VectorAttribute attribute = VectorAttribute.None)
    {
        Value = value;
        Attribute = attribute;
    }

    public byte[] Serialize()
    {
        var result = new byte[6 + Value.Length];
        result[0] = (byte)Type;
        result[1] = (byte)Attribute;
        Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, result, 2, 4);
        Buffer.BlockCopy(Value, 0, result, 6, Value.Length);
        return result;
    }

    public override string ToString()
    {
        if (Value.Length == 0)
        {
            return "`byte$()";
        }

        var stringBuilder = new StringBuilder(Value.Length == 1 ? ",0x" : "0x");
        foreach (var element in Value)
        {
            stringBuilder.Append($"{element:x2}");
        }

        return stringBuilder.ToString();
    }
}