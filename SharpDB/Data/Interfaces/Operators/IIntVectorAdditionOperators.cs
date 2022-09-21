using System.Numerics;

namespace SharpDB.Data;

public interface IIntVectorAdditionOperators : IAdditionOperators<IntVector, ByteAtom, IntVector>,
    IAdditionOperators<IntVector, ByteVector, IntVector>, IAdditionOperators<IntVector, ShortAtom, IntVector>,
    IAdditionOperators<IntVector, ShortVector, IntVector>, IAdditionOperators<IntVector, IntAtom, IntVector>,
    IAdditionOperators<IntVector, IntVector, IntVector>, IAdditionOperators<IntVector, LongAtom, LongVector>,
    IAdditionOperators<IntVector, LongVector, LongVector>, IAdditionOperators<IntVector, FloatAtom, FloatVector>,
    IAdditionOperators<IntVector, FloatVector, FloatVector>, IAdditionOperators<IntVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<IntVector, DoubleVector, DoubleVector>,
    IAdditionOperators<IntVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<IntVector, TimestampVector, TimestampVector>,
    IAdditionOperators<IntVector, MonthAtom, MonthVector>, IAdditionOperators<IntVector, MonthVector, MonthVector>,
    IAdditionOperators<IntVector, DateAtom, DateVector>, IAdditionOperators<IntVector, DateVector, DateVector>,
    IAdditionOperators<IntVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<IntVector, TimespanVector, TimespanVector>,
    IAdditionOperators<IntVector, MinuteAtom, MinuteVector>, IAdditionOperators<IntVector, MinuteVector, MinuteVector>,
    IAdditionOperators<IntVector, SecondAtom, SecondVector>, IAdditionOperators<IntVector, SecondVector, SecondVector>
{
}
