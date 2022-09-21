using System.Numerics;

namespace SharpDB.Data;

public interface IDateVectorSubtractionOperators : ISubtractionOperators<DateVector, ByteAtom, DateVector>,
    ISubtractionOperators<DateVector, ByteVector, DateVector>, ISubtractionOperators<DateVector, ShortAtom, DateVector>,
    ISubtractionOperators<DateVector, ShortVector, DateVector>, ISubtractionOperators<DateVector, IntAtom, DateVector>,
    ISubtractionOperators<DateVector, IntVector, DateVector>, ISubtractionOperators<DateVector, LongAtom, DateVector>,
    ISubtractionOperators<DateVector, LongVector, DateVector>, ISubtractionOperators<DateVector, FloatAtom, DateVector>,
    ISubtractionOperators<DateVector, FloatVector, DateVector>, ISubtractionOperators<DateVector, DateAtom, IntVector>,
    ISubtractionOperators<DateVector, DateVector, IntVector>,
    ISubtractionOperators<DateVector, TimespanAtom, TimestampVector>,
    ISubtractionOperators<DateVector, TimespanVector, TimestampVector>,
    ISubtractionOperators<DateVector, MinuteAtom, TimestampVector>,
    ISubtractionOperators<DateVector, MinuteVector, TimestampVector>,
    ISubtractionOperators<DateVector, SecondAtom, TimestampVector>,
    ISubtractionOperators<DateVector, SecondVector, TimestampVector>
{
}
