using System.Numerics;

namespace SharpDB.Data;

public interface IShortAtomMultiplyOperators : IMultiplyOperators<ShortAtom, ByteAtom, IntAtom>,
    IMultiplyOperators<ShortAtom, ByteVector, IntVector>, IMultiplyOperators<ShortAtom, ShortAtom, IntAtom>,
    IMultiplyOperators<ShortAtom, ShortVector, IntVector>, IMultiplyOperators<ShortAtom, IntAtom, IntAtom>,
    IMultiplyOperators<ShortAtom, IntVector, IntVector>, IMultiplyOperators<ShortAtom, LongAtom, LongAtom>,
    IMultiplyOperators<ShortAtom, LongVector, LongVector>, IMultiplyOperators<ShortAtom, FloatAtom, FloatAtom>,
    IMultiplyOperators<ShortAtom, FloatVector, FloatVector>, IMultiplyOperators<ShortAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<ShortAtom, DoubleVector, DoubleVector>,
    IMultiplyOperators<ShortAtom, TimestampAtom, TimestampAtom>,
    IMultiplyOperators<ShortAtom, TimestampVector, TimestampVector>,
    IMultiplyOperators<ShortAtom, MonthAtom, MonthAtom>, IMultiplyOperators<ShortAtom, MonthVector, MonthVector>,
    IMultiplyOperators<ShortAtom, DateAtom, DateAtom>, IMultiplyOperators<ShortAtom, DateVector, DateVector>,
    IMultiplyOperators<ShortAtom, TimespanAtom, TimespanAtom>,
    IMultiplyOperators<ShortAtom, TimespanVector, TimespanVector>,
    IMultiplyOperators<ShortAtom, MinuteAtom, MinuteAtom>, IMultiplyOperators<ShortAtom, MinuteVector, MinuteVector>,
    IMultiplyOperators<ShortAtom, SecondAtom, SecondAtom>, IMultiplyOperators<ShortAtom, SecondVector, SecondVector>
{
}
