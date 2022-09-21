using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampAtomSubtractionOperators : ISubtractionOperators<TimestampAtom, ByteAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, ByteVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, ShortAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, ShortVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, IntAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, IntVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, LongAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, LongVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, FloatAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, FloatVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<TimestampAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<TimestampAtom, TimestampAtom, TimespanAtom>,
    ISubtractionOperators<TimestampAtom, TimestampVector, TimespanVector>,
    ISubtractionOperators<TimestampAtom, TimespanAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, TimespanVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, MinuteAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, MinuteVector, TimestampVector>,
    ISubtractionOperators<TimestampAtom, SecondAtom, TimestampAtom>,
    ISubtractionOperators<TimestampAtom, SecondVector, TimestampVector>
{
}
