using System.Numerics;

namespace SharpDB.Data;

public interface IShortVectorMultiplyOperators : IMultiplyOperators<ShortVector, ByteAtom, IntVector>,
    IMultiplyOperators<ShortVector, ByteVector, IntVector>, IMultiplyOperators<ShortVector, ShortAtom, IntVector>,
    IMultiplyOperators<ShortVector, ShortVector, IntVector>, IMultiplyOperators<ShortVector, IntAtom, IntVector>,
    IMultiplyOperators<ShortVector, IntVector, IntVector>, IMultiplyOperators<ShortVector, LongAtom, LongVector>,
    IMultiplyOperators<ShortVector, LongVector, LongVector>, IMultiplyOperators<ShortVector, FloatAtom, FloatVector>,
    IMultiplyOperators<ShortVector, FloatVector, FloatVector>,
    IMultiplyOperators<ShortVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<ShortVector, DoubleVector, DoubleVector>,
    IMultiplyOperators<ShortVector, TimestampAtom, TimestampVector>,
    IMultiplyOperators<ShortVector, TimestampVector, TimestampVector>,
    IMultiplyOperators<ShortVector, MonthAtom, MonthVector>, IMultiplyOperators<ShortVector, MonthVector, MonthVector>,
    IMultiplyOperators<ShortVector, DateAtom, DateVector>, IMultiplyOperators<ShortVector, DateVector, DateVector>,
    IMultiplyOperators<ShortVector, TimespanAtom, TimespanVector>,
    IMultiplyOperators<ShortVector, TimespanVector, TimespanVector>,
    IMultiplyOperators<ShortVector, MinuteAtom, MinuteVector>,
    IMultiplyOperators<ShortVector, MinuteVector, MinuteVector>,
    IMultiplyOperators<ShortVector, SecondAtom, SecondVector>,
    IMultiplyOperators<ShortVector, SecondVector, SecondVector>
{
}
