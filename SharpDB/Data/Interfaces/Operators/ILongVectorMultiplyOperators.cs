using System.Numerics;

namespace SharpDB.Data;

public interface ILongVectorMultiplyOperators : IMultiplyOperators<LongVector, ByteAtom, LongVector>,
    IMultiplyOperators<LongVector, ByteVector, LongVector>, IMultiplyOperators<LongVector, ShortAtom, LongVector>,
    IMultiplyOperators<LongVector, ShortVector, LongVector>, IMultiplyOperators<LongVector, IntAtom, LongVector>,
    IMultiplyOperators<LongVector, IntVector, LongVector>, IMultiplyOperators<LongVector, LongAtom, LongVector>,
    IMultiplyOperators<LongVector, LongVector, LongVector>, IMultiplyOperators<LongVector, FloatAtom, FloatVector>,
    IMultiplyOperators<LongVector, FloatVector, FloatVector>, IMultiplyOperators<LongVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<LongVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<LongVector, TimestampAtom, TimestampVector>,
    IMultiplyOperators<LongVector, TimestampVector, TimestampVector>,
    IMultiplyOperators<LongVector, MonthAtom, MonthVector>, IMultiplyOperators<LongVector, MonthVector, MonthVector>,
    IMultiplyOperators<LongVector, DateAtom, DateVector>, IMultiplyOperators<LongVector, DateVector, DateVector>,
    IMultiplyOperators<LongVector, TimespanAtom, TimespanVector>,
    IMultiplyOperators<LongVector, TimespanVector, TimespanVector>,
    IMultiplyOperators<LongVector, MinuteAtom, MinuteVector>,
    IMultiplyOperators<LongVector, MinuteVector, MinuteVector>,
    IMultiplyOperators<LongVector, SecondAtom, SecondVector>, IMultiplyOperators<LongVector, SecondVector, SecondVector>
{
}
