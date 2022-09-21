using System.Numerics;

namespace SharpDB.Data;

public interface IIntAtomAdditionOperators : IAdditionOperators<IntAtom, ByteAtom, IntAtom>,
    IAdditionOperators<IntAtom, ByteVector, IntVector>, IAdditionOperators<IntAtom, ShortAtom, IntAtom>,
    IAdditionOperators<IntAtom, ShortVector, IntVector>, IAdditionOperators<IntAtom, IntAtom, IntAtom>,
    IAdditionOperators<IntAtom, IntVector, IntVector>, IAdditionOperators<IntAtom, LongAtom, LongAtom>,
    IAdditionOperators<IntAtom, LongVector, LongVector>, IAdditionOperators<IntAtom, FloatAtom, FloatAtom>,
    IAdditionOperators<IntAtom, FloatVector, FloatVector>, IAdditionOperators<IntAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<IntAtom, DoubleVector, DoubleVector>, IAdditionOperators<IntAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<IntAtom, TimestampVector, TimestampVector>, IAdditionOperators<IntAtom, MonthAtom, MonthAtom>,
    IAdditionOperators<IntAtom, MonthVector, MonthVector>, IAdditionOperators<IntAtom, DateAtom, DateAtom>,
    IAdditionOperators<IntAtom, DateVector, DateVector>, IAdditionOperators<IntAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<IntAtom, TimespanVector, TimespanVector>, IAdditionOperators<IntAtom, MinuteAtom, MinuteAtom>,
    IAdditionOperators<IntAtom, MinuteVector, MinuteVector>, IAdditionOperators<IntAtom, SecondAtom, SecondAtom>,
    IAdditionOperators<IntAtom, SecondVector, SecondVector>
{
}
