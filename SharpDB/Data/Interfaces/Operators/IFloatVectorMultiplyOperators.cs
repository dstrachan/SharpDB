using System.Numerics;

namespace SharpDB.Data;

public interface IFloatVectorMultiplyOperators : IMultiplyOperators<FloatVector, ByteAtom, FloatVector>,
    IMultiplyOperators<FloatVector, ByteVector, FloatVector>, IMultiplyOperators<FloatVector, ShortAtom, FloatVector>,
    IMultiplyOperators<FloatVector, ShortVector, FloatVector>, IMultiplyOperators<FloatVector, IntAtom, FloatVector>,
    IMultiplyOperators<FloatVector, IntVector, FloatVector>, IMultiplyOperators<FloatVector, LongAtom, FloatVector>,
    IMultiplyOperators<FloatVector, LongVector, FloatVector>, IMultiplyOperators<FloatVector, FloatAtom, FloatVector>,
    IMultiplyOperators<FloatVector, FloatVector, FloatVector>,
    IMultiplyOperators<FloatVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<FloatVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<FloatVector, TimestampAtom, TimestampVector>,
    IMultiplyOperators<FloatVector, TimestampVector, TimestampVector>,
    IMultiplyOperators<FloatVector, MonthAtom, MonthVector>, IMultiplyOperators<FloatVector, MonthVector, MonthVector>,
    IMultiplyOperators<FloatVector, DateAtom, DateVector>, IMultiplyOperators<FloatVector, DateVector, DateVector>,
    IMultiplyOperators<FloatVector, TimespanAtom, TimespanVector>,
    IMultiplyOperators<FloatVector, TimespanVector, TimespanVector>,
    IMultiplyOperators<FloatVector, MinuteAtom, MinuteVector>,
    IMultiplyOperators<FloatVector, MinuteVector, MinuteVector>,
    IMultiplyOperators<FloatVector, SecondAtom, SecondVector>,
    IMultiplyOperators<FloatVector, SecondVector, SecondVector>
{
}
