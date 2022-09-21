using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanVectorMultiplyOperators : IMultiplyOperators<TimespanVector, ByteAtom, TimespanVector>,
    IMultiplyOperators<TimespanVector, ByteVector, TimespanVector>,
    IMultiplyOperators<TimespanVector, ShortAtom, TimespanVector>,
    IMultiplyOperators<TimespanVector, ShortVector, TimespanVector>,
    IMultiplyOperators<TimespanVector, IntAtom, TimespanVector>,
    IMultiplyOperators<TimespanVector, IntVector, TimespanVector>,
    IMultiplyOperators<TimespanVector, LongAtom, TimespanVector>,
    IMultiplyOperators<TimespanVector, LongVector, TimespanVector>,
    IMultiplyOperators<TimespanVector, FloatAtom, TimespanVector>,
    IMultiplyOperators<TimespanVector, FloatVector, TimespanVector>,
    IMultiplyOperators<TimespanVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<TimespanVector, DoubleVector, DoubleVector>
{
}
