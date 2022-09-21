using System.Numerics;

namespace SharpDB.Data;

public interface IIntAtomMultiplyOperators : IMultiplyOperators<IntAtom, ByteAtom, IntAtom>,
    IMultiplyOperators<IntAtom, ByteVector, IntVector>, IMultiplyOperators<IntAtom, ShortAtom, IntAtom>,
    IMultiplyOperators<IntAtom, ShortVector, IntVector>, IMultiplyOperators<IntAtom, IntAtom, IntAtom>,
    IMultiplyOperators<IntAtom, IntVector, IntVector>, IMultiplyOperators<IntAtom, LongAtom, LongAtom>,
    IMultiplyOperators<IntAtom, LongVector, LongVector>, IMultiplyOperators<IntAtom, FloatAtom, FloatAtom>,
    IMultiplyOperators<IntAtom, FloatVector, FloatVector>, IMultiplyOperators<IntAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<IntAtom, DoubleVector, DoubleVector>, IMultiplyOperators<IntAtom, TimestampAtom, TimestampAtom>,
    IMultiplyOperators<IntAtom, TimestampVector, TimestampVector>, IMultiplyOperators<IntAtom, MonthAtom, MonthAtom>,
    IMultiplyOperators<IntAtom, MonthVector, MonthVector>, IMultiplyOperators<IntAtom, DateAtom, DateAtom>,
    IMultiplyOperators<IntAtom, DateVector, DateVector>, IMultiplyOperators<IntAtom, TimespanAtom, TimespanAtom>,
    IMultiplyOperators<IntAtom, TimespanVector, TimespanVector>, IMultiplyOperators<IntAtom, MinuteAtom, MinuteAtom>,
    IMultiplyOperators<IntAtom, MinuteVector, MinuteVector>, IMultiplyOperators<IntAtom, SecondAtom, SecondAtom>,
    IMultiplyOperators<IntAtom, SecondVector, SecondVector>
{
}
