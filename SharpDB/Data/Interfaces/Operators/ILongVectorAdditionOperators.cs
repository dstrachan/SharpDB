using System.Numerics;

namespace SharpDB.Data;

public interface ILongVectorAdditionOperators : IAdditionOperators<LongVector, ByteAtom, LongVector>,
    IAdditionOperators<LongVector, ByteVector, LongVector>, IAdditionOperators<LongVector, ShortAtom, LongVector>,
    IAdditionOperators<LongVector, ShortVector, LongVector>, IAdditionOperators<LongVector, IntAtom, LongVector>,
    IAdditionOperators<LongVector, IntVector, LongVector>, IAdditionOperators<LongVector, LongAtom, LongVector>,
    IAdditionOperators<LongVector, LongVector, LongVector>, IAdditionOperators<LongVector, FloatAtom, FloatVector>,
    IAdditionOperators<LongVector, FloatVector, FloatVector>, IAdditionOperators<LongVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<LongVector, DoubleVector, DoubleVector>,
    IAdditionOperators<LongVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<LongVector, TimestampVector, TimestampVector>,
    IAdditionOperators<LongVector, MonthAtom, MonthVector>, IAdditionOperators<LongVector, MonthVector, MonthVector>,
    IAdditionOperators<LongVector, DateAtom, DateVector>, IAdditionOperators<LongVector, DateVector, DateVector>,
    IAdditionOperators<LongVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<LongVector, TimespanVector, TimespanVector>,
    IAdditionOperators<LongVector, MinuteAtom, MinuteVector>,
    IAdditionOperators<LongVector, MinuteVector, MinuteVector>,
    IAdditionOperators<LongVector, SecondAtom, SecondVector>, IAdditionOperators<LongVector, SecondVector, SecondVector>
{
}
