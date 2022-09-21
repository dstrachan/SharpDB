using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanAtomSubtractionOperators : ISubtractionOperators<TimespanAtom, ByteAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, ByteVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, ShortAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, ShortVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, IntAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, IntVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, LongAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, LongVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, FloatAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, FloatVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<TimespanAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<TimespanAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<TimespanAtom, TimestampVector, TimestampVector>,
    ISubtractionOperators<TimespanAtom, MonthAtom, TimestampAtom>,
    ISubtractionOperators<TimespanAtom, MonthVector, TimestampVector>,
    ISubtractionOperators<TimespanAtom, DateAtom, TimestampAtom>,
    ISubtractionOperators<TimespanAtom, DateVector, TimestampVector>,
    ISubtractionOperators<TimespanAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, TimespanVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, MinuteAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, MinuteVector, TimespanVector>,
    ISubtractionOperators<TimespanAtom, SecondAtom, TimespanAtom>,
    ISubtractionOperators<TimespanAtom, SecondVector, TimespanVector>
{
}
