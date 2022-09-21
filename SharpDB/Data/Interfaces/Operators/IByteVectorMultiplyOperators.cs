using System.Numerics;

namespace SharpDB.Data;

public interface IByteVectorMultiplyOperators : IMultiplyOperators<ByteVector, ByteAtom, IntVector>,
    IMultiplyOperators<ByteVector, ByteVector, IntVector>, IMultiplyOperators<ByteVector, ShortAtom, IntVector>,
    IMultiplyOperators<ByteVector, ShortVector, IntVector>, IMultiplyOperators<ByteVector, IntAtom, IntVector>,
    IMultiplyOperators<ByteVector, IntVector, IntVector>, IMultiplyOperators<ByteVector, LongAtom, LongVector>,
    IMultiplyOperators<ByteVector, LongVector, LongVector>, IMultiplyOperators<ByteVector, FloatAtom, FloatVector>,
    IMultiplyOperators<ByteVector, FloatVector, FloatVector>, IMultiplyOperators<ByteVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<ByteVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<ByteVector, TimestampAtom, TimestampVector>,
    IMultiplyOperators<ByteVector, TimestampVector, TimestampVector>,
    IMultiplyOperators<ByteVector, MonthAtom, MonthVector>, IMultiplyOperators<ByteVector, MonthVector, MonthVector>,
    IMultiplyOperators<ByteVector, DateAtom, DateVector>, IMultiplyOperators<ByteVector, DateVector, DateVector>,
    IMultiplyOperators<ByteVector, TimespanAtom, TimespanVector>,
    IMultiplyOperators<ByteVector, TimespanVector, TimespanVector>,
    IMultiplyOperators<ByteVector, MinuteAtom, MinuteVector>,
    IMultiplyOperators<ByteVector, MinuteVector, MinuteVector>,
    IMultiplyOperators<ByteVector, SecondAtom, SecondVector>, IMultiplyOperators<ByteVector, SecondVector, SecondVector>
{
}
