using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampAtomMultiplyOperators : IMultiplyOperators<TimestampAtom, ByteAtom, TimestampAtom>,
    IMultiplyOperators<TimestampAtom, ByteVector, TimestampVector>,
    IMultiplyOperators<TimestampAtom, ShortAtom, TimestampAtom>,
    IMultiplyOperators<TimestampAtom, ShortVector, TimestampVector>,
    IMultiplyOperators<TimestampAtom, IntAtom, TimestampAtom>,
    IMultiplyOperators<TimestampAtom, IntVector, TimestampVector>,
    IMultiplyOperators<TimestampAtom, LongAtom, TimestampAtom>,
    IMultiplyOperators<TimestampAtom, LongVector, TimestampVector>,
    IMultiplyOperators<TimestampAtom, FloatAtom, TimestampAtom>,
    IMultiplyOperators<TimestampAtom, FloatVector, TimestampVector>,
    IMultiplyOperators<TimestampAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<TimestampAtom, DoubleVector, DoubleVector>
{
}
