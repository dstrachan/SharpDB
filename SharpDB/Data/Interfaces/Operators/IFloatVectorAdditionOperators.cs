using System.Numerics;

namespace SharpDB.Data;

public interface IFloatVectorAdditionOperators : IAdditionOperators<FloatVector, ByteAtom, FloatVector>,
    IAdditionOperators<FloatVector, ByteVector, FloatVector>, IAdditionOperators<FloatVector, ShortAtom, FloatVector>,
    IAdditionOperators<FloatVector, ShortVector, FloatVector>, IAdditionOperators<FloatVector, IntAtom, FloatVector>,
    IAdditionOperators<FloatVector, IntVector, FloatVector>, IAdditionOperators<FloatVector, LongAtom, FloatVector>,
    IAdditionOperators<FloatVector, LongVector, FloatVector>, IAdditionOperators<FloatVector, FloatAtom, FloatVector>,
    IAdditionOperators<FloatVector, FloatVector, FloatVector>,
    IAdditionOperators<FloatVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<FloatVector, DoubleVector, DoubleVector>,
    IAdditionOperators<FloatVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<FloatVector, TimestampVector, TimestampVector>,
    IAdditionOperators<FloatVector, MonthAtom, MonthVector>, IAdditionOperators<FloatVector, MonthVector, MonthVector>,
    IAdditionOperators<FloatVector, DateAtom, DateVector>, IAdditionOperators<FloatVector, DateVector, DateVector>,
    IAdditionOperators<FloatVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<FloatVector, TimespanVector, TimespanVector>,
    IAdditionOperators<FloatVector, MinuteAtom, MinuteVector>,
    IAdditionOperators<FloatVector, MinuteVector, MinuteVector>,
    IAdditionOperators<FloatVector, SecondAtom, SecondVector>,
    IAdditionOperators<FloatVector, SecondVector, SecondVector>
{
}
