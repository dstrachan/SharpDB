using System.Numerics;

namespace SharpDB.Data;

public interface ILongAtomAdditionOperators : IAdditionOperators<LongAtom, ByteAtom, LongAtom>,
    IAdditionOperators<LongAtom, ByteVector, LongVector>, IAdditionOperators<LongAtom, ShortAtom, LongAtom>,
    IAdditionOperators<LongAtom, ShortVector, LongVector>, IAdditionOperators<LongAtom, IntAtom, LongAtom>,
    IAdditionOperators<LongAtom, IntVector, LongVector>, IAdditionOperators<LongAtom, LongAtom, LongAtom>,
    IAdditionOperators<LongAtom, LongVector, LongVector>, IAdditionOperators<LongAtom, FloatAtom, FloatAtom>,
    IAdditionOperators<LongAtom, FloatVector, FloatVector>, IAdditionOperators<LongAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<LongAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<LongAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<LongAtom, TimestampVector, TimestampVector>, IAdditionOperators<LongAtom, MonthAtom, MonthAtom>,
    IAdditionOperators<LongAtom, MonthVector, MonthVector>, IAdditionOperators<LongAtom, DateAtom, DateAtom>,
    IAdditionOperators<LongAtom, DateVector, DateVector>, IAdditionOperators<LongAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<LongAtom, TimespanVector, TimespanVector>, IAdditionOperators<LongAtom, MinuteAtom, MinuteAtom>,
    IAdditionOperators<LongAtom, MinuteVector, MinuteVector>, IAdditionOperators<LongAtom, SecondAtom, SecondAtom>,
    IAdditionOperators<LongAtom, SecondVector, SecondVector>
{
}
