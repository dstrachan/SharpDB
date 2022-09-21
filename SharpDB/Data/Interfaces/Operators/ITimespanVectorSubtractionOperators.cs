using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanVectorSubtractionOperators : ISubtractionOperators<TimespanVector, ByteAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, ByteVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, ShortAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, ShortVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, IntAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, IntVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, LongAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, LongVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, FloatAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, FloatVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<TimespanVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<TimespanVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<TimespanVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<TimespanVector, MonthAtom, TimestampVector>,
    ISubtractionOperators<TimespanVector, MonthVector, TimestampVector>,
    ISubtractionOperators<TimespanVector, DateAtom, TimestampVector>,
    ISubtractionOperators<TimespanVector, DateVector, TimestampVector>,
    ISubtractionOperators<TimespanVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, MinuteAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, MinuteVector, TimespanVector>,
    ISubtractionOperators<TimespanVector, SecondAtom, TimespanVector>,
    ISubtractionOperators<TimespanVector, SecondVector, TimespanVector>
{
}
