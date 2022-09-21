using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanAtomAdditionOperators : IAdditionOperators<TimespanAtom, ByteAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, ByteVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, ShortAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, ShortVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, IntAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, IntVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, LongAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, LongVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, FloatAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, FloatVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<TimespanAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<TimespanAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<TimespanAtom, TimestampVector, TimestampVector>,
    IAdditionOperators<TimespanAtom, MonthAtom, TimestampAtom>,
    IAdditionOperators<TimespanAtom, MonthVector, TimestampVector>,
    IAdditionOperators<TimespanAtom, DateAtom, TimestampAtom>,
    IAdditionOperators<TimespanAtom, DateVector, TimestampVector>,
    IAdditionOperators<TimespanAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, TimespanVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, MinuteAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, MinuteVector, TimespanVector>,
    IAdditionOperators<TimespanAtom, SecondAtom, TimespanAtom>,
    IAdditionOperators<TimespanAtom, SecondVector, TimespanVector>
{
}
