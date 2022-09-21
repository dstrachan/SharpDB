using System.Numerics;

namespace SharpDB.Data;

public interface ILongAtomMultiplyOperators : IMultiplyOperators<LongAtom, ByteAtom, LongAtom>,
    IMultiplyOperators<LongAtom, ByteVector, LongVector>, IMultiplyOperators<LongAtom, ShortAtom, LongAtom>,
    IMultiplyOperators<LongAtom, ShortVector, LongVector>, IMultiplyOperators<LongAtom, IntAtom, LongAtom>,
    IMultiplyOperators<LongAtom, IntVector, LongVector>, IMultiplyOperators<LongAtom, LongAtom, LongAtom>,
    IMultiplyOperators<LongAtom, LongVector, LongVector>, IMultiplyOperators<LongAtom, FloatAtom, FloatAtom>,
    IMultiplyOperators<LongAtom, FloatVector, FloatVector>, IMultiplyOperators<LongAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<LongAtom, DoubleVector, DoubleVector>,
    IMultiplyOperators<LongAtom, TimestampAtom, TimestampAtom>,
    IMultiplyOperators<LongAtom, TimestampVector, TimestampVector>, IMultiplyOperators<LongAtom, MonthAtom, MonthAtom>,
    IMultiplyOperators<LongAtom, MonthVector, MonthVector>, IMultiplyOperators<LongAtom, DateAtom, DateAtom>,
    IMultiplyOperators<LongAtom, DateVector, DateVector>, IMultiplyOperators<LongAtom, TimespanAtom, TimespanAtom>,
    IMultiplyOperators<LongAtom, TimespanVector, TimespanVector>, IMultiplyOperators<LongAtom, MinuteAtom, MinuteAtom>,
    IMultiplyOperators<LongAtom, MinuteVector, MinuteVector>, IMultiplyOperators<LongAtom, SecondAtom, SecondAtom>,
    IMultiplyOperators<LongAtom, SecondVector, SecondVector>
{
}
