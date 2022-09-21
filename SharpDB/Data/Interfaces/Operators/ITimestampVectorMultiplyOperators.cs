using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampVectorMultiplyOperators : IMultiplyOperators<TimestampVector, ByteAtom, TimestampVector>,
    IMultiplyOperators<TimestampVector, ByteVector, TimestampVector>,
    IMultiplyOperators<TimestampVector, ShortAtom, TimestampVector>,
    IMultiplyOperators<TimestampVector, ShortVector, TimestampVector>,
    IMultiplyOperators<TimestampVector, IntAtom, TimestampVector>,
    IMultiplyOperators<TimestampVector, IntVector, TimestampVector>,
    IMultiplyOperators<TimestampVector, LongAtom, TimestampVector>,
    IMultiplyOperators<TimestampVector, LongVector, TimestampVector>,
    IMultiplyOperators<TimestampVector, FloatAtom, TimestampVector>,
    IMultiplyOperators<TimestampVector, FloatVector, TimestampVector>,
    IMultiplyOperators<TimestampVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<TimestampVector, DoubleVector, DoubleVector>
{
}
