using System.Numerics;

namespace SharpDB.Data;

public interface IFloatAtomMultiplyOperators : IMultiplyOperators<FloatAtom, ByteAtom, FloatAtom>,
    IMultiplyOperators<FloatAtom, ByteVector, FloatVector>, IMultiplyOperators<FloatAtom, ShortAtom, FloatAtom>,
    IMultiplyOperators<FloatAtom, ShortVector, FloatVector>, IMultiplyOperators<FloatAtom, IntAtom, FloatAtom>,
    IMultiplyOperators<FloatAtom, IntVector, FloatVector>, IMultiplyOperators<FloatAtom, LongAtom, FloatAtom>,
    IMultiplyOperators<FloatAtom, LongVector, FloatVector>, IMultiplyOperators<FloatAtom, FloatAtom, FloatAtom>,
    IMultiplyOperators<FloatAtom, FloatVector, FloatVector>, IMultiplyOperators<FloatAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<FloatAtom, DoubleVector, DoubleVector>,
    IMultiplyOperators<FloatAtom, TimestampAtom, TimestampAtom>,
    IMultiplyOperators<FloatAtom, TimestampVector, TimestampVector>,
    IMultiplyOperators<FloatAtom, MonthAtom, MonthAtom>, IMultiplyOperators<FloatAtom, MonthVector, MonthVector>,
    IMultiplyOperators<FloatAtom, TimespanAtom, TimespanAtom>,
    IMultiplyOperators<FloatAtom, TimespanVector, TimespanVector>,
    IMultiplyOperators<FloatAtom, MinuteAtom, MinuteAtom>, IMultiplyOperators<FloatAtom, MinuteVector, MinuteVector>,
    IMultiplyOperators<FloatAtom, SecondAtom, SecondAtom>, IMultiplyOperators<FloatAtom, SecondVector, SecondVector>
{
}
