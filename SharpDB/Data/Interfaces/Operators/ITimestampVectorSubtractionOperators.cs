using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampVectorSubtractionOperators : ISubtractionOperators<TimestampVector, ByteAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, ByteVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, ShortAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, ShortVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, IntAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, IntVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, LongAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, LongVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, FloatAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, FloatVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<TimestampVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<TimestampVector, TimestampAtom, TimespanVector>,
    ISubtractionOperators<TimestampVector, TimestampVector, TimespanVector>,
    ISubtractionOperators<TimestampVector, TimespanAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, TimespanVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, MinuteAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, MinuteVector, TimestampVector>,
    ISubtractionOperators<TimestampVector, SecondAtom, TimestampVector>,
    ISubtractionOperators<TimestampVector, SecondVector, TimestampVector>
{
}
