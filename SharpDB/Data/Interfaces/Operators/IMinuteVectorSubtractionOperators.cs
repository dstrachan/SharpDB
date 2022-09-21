using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteVectorSubtractionOperators : ISubtractionOperators<MinuteVector, ByteAtom, MinuteVector>,
    ISubtractionOperators<MinuteVector, ByteVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, ShortAtom, MinuteVector>,
    ISubtractionOperators<MinuteVector, ShortVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, IntAtom, MinuteVector>, ISubtractionOperators<MinuteVector, IntVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, LongAtom, MinuteVector>,
    ISubtractionOperators<MinuteVector, LongVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, FloatAtom, MinuteVector>,
    ISubtractionOperators<MinuteVector, FloatVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<MinuteVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<MinuteVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<MinuteVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<MinuteVector, MonthAtom, TimestampVector>,
    ISubtractionOperators<MinuteVector, MonthVector, TimestampVector>,
    ISubtractionOperators<MinuteVector, DateAtom, TimestampVector>,
    ISubtractionOperators<MinuteVector, DateVector, TimestampVector>,
    ISubtractionOperators<MinuteVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<MinuteVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<MinuteVector, MinuteAtom, MinuteVector>,
    ISubtractionOperators<MinuteVector, MinuteVector, MinuteVector>,
    ISubtractionOperators<MinuteVector, SecondAtom, SecondVector>,
    ISubtractionOperators<MinuteVector, SecondVector, SecondVector>
{
}
