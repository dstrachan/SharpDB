using System.Numerics;

namespace SharpDB.Data;

public interface IIntVectorMultiplyOperators : IMultiplyOperators<IntVector, ByteAtom, IntVector>,
    IMultiplyOperators<IntVector, ByteVector, IntVector>, IMultiplyOperators<IntVector, ShortAtom, IntVector>,
    IMultiplyOperators<IntVector, ShortVector, IntVector>, IMultiplyOperators<IntVector, IntAtom, IntVector>,
    IMultiplyOperators<IntVector, IntVector, IntVector>, IMultiplyOperators<IntVector, LongAtom, LongVector>,
    IMultiplyOperators<IntVector, LongVector, LongVector>, IMultiplyOperators<IntVector, FloatAtom, FloatVector>,
    IMultiplyOperators<IntVector, FloatVector, FloatVector>, IMultiplyOperators<IntVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<IntVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<IntVector, TimestampAtom, TimestampVector>,
    IMultiplyOperators<IntVector, TimestampVector, TimestampVector>,
    IMultiplyOperators<IntVector, MonthAtom, MonthVector>, IMultiplyOperators<IntVector, MonthVector, MonthVector>,
    IMultiplyOperators<IntVector, DateAtom, DateVector>, IMultiplyOperators<IntVector, DateVector, DateVector>,
    IMultiplyOperators<IntVector, TimespanAtom, TimespanVector>,
    IMultiplyOperators<IntVector, TimespanVector, TimespanVector>,
    IMultiplyOperators<IntVector, MinuteAtom, MinuteVector>, IMultiplyOperators<IntVector, MinuteVector, MinuteVector>,
    IMultiplyOperators<IntVector, SecondAtom, SecondVector>, IMultiplyOperators<IntVector, SecondVector, SecondVector>
{
}
