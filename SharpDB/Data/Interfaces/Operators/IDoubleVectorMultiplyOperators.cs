using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleVectorMultiplyOperators : IMultiplyOperators<DoubleVector, ByteAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, ByteVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, ShortAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, ShortVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, IntAtom, DoubleVector>, IMultiplyOperators<DoubleVector, IntVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, LongAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, LongVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, FloatAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, FloatVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, TimestampAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, TimestampVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, MonthAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, MonthVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, TimespanAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, TimespanVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, MinuteAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, MinuteVector, DoubleVector>,
    IMultiplyOperators<DoubleVector, SecondAtom, DoubleVector>,
    IMultiplyOperators<DoubleVector, SecondVector, DoubleVector>
{
}
