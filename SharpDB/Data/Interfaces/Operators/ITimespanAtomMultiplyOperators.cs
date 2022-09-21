using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanAtomMultiplyOperators : IMultiplyOperators<TimespanAtom, ByteAtom, TimespanAtom>,
    IMultiplyOperators<TimespanAtom, ByteVector, TimespanVector>,
    IMultiplyOperators<TimespanAtom, ShortAtom, TimespanAtom>,
    IMultiplyOperators<TimespanAtom, ShortVector, TimespanVector>,
    IMultiplyOperators<TimespanAtom, IntAtom, TimespanAtom>,
    IMultiplyOperators<TimespanAtom, IntVector, TimespanVector>,
    IMultiplyOperators<TimespanAtom, LongAtom, TimespanAtom>,
    IMultiplyOperators<TimespanAtom, LongVector, TimespanVector>,
    IMultiplyOperators<TimespanAtom, FloatAtom, TimespanAtom>,
    IMultiplyOperators<TimespanAtom, FloatVector, TimespanVector>,
    IMultiplyOperators<TimespanAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<TimespanAtom, DoubleVector, DoubleVector>
{
}
