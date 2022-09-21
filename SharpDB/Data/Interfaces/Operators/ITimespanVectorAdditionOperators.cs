using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanVectorAdditionOperators : IAdditionOperators<TimespanVector, ByteAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, ByteVector, TimespanVector>,
    IAdditionOperators<TimespanVector, ShortAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, ShortVector, TimespanVector>,
    IAdditionOperators<TimespanVector, IntAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, IntVector, TimespanVector>,
    IAdditionOperators<TimespanVector, LongAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, LongVector, TimespanVector>,
    IAdditionOperators<TimespanVector, FloatAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, FloatVector, TimespanVector>,
    IAdditionOperators<TimespanVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<TimespanVector, DoubleVector, DoubleVector>,
    IAdditionOperators<TimespanVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<TimespanVector, TimestampVector, TimestampVector>,
    IAdditionOperators<TimespanVector, MonthAtom, TimestampVector>,
    IAdditionOperators<TimespanVector, MonthVector, TimestampVector>,
    IAdditionOperators<TimespanVector, DateAtom, TimestampVector>,
    IAdditionOperators<TimespanVector, DateVector, TimestampVector>,
    IAdditionOperators<TimespanVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, TimespanVector, TimespanVector>,
    IAdditionOperators<TimespanVector, MinuteAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, MinuteVector, TimespanVector>,
    IAdditionOperators<TimespanVector, SecondAtom, TimespanVector>,
    IAdditionOperators<TimespanVector, SecondVector, TimespanVector>
{
}
