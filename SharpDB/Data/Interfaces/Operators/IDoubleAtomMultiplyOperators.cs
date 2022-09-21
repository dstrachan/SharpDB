using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleAtomMultiplyOperators : IMultiplyOperators<DoubleAtom, ByteAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, ByteVector, DoubleVector>, IMultiplyOperators<DoubleAtom, ShortAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, ShortVector, DoubleVector>, IMultiplyOperators<DoubleAtom, IntAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, IntVector, DoubleVector>, IMultiplyOperators<DoubleAtom, LongAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, LongVector, DoubleVector>, IMultiplyOperators<DoubleAtom, FloatAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, FloatVector, DoubleVector>, IMultiplyOperators<DoubleAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, DoubleVector, DoubleVector>,
    IMultiplyOperators<DoubleAtom, TimestampAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, TimestampVector, DoubleVector>,
    IMultiplyOperators<DoubleAtom, MonthAtom, DoubleAtom>, IMultiplyOperators<DoubleAtom, MonthVector, DoubleVector>,
    IMultiplyOperators<DoubleAtom, TimespanAtom, DoubleAtom>,
    IMultiplyOperators<DoubleAtom, TimespanVector, DoubleVector>,
    IMultiplyOperators<DoubleAtom, MinuteAtom, DoubleAtom>, IMultiplyOperators<DoubleAtom, MinuteVector, DoubleVector>,
    IMultiplyOperators<DoubleAtom, SecondAtom, DoubleAtom>, IMultiplyOperators<DoubleAtom, SecondVector, DoubleVector>
{
}
