using System.Numerics;

namespace SharpDB.Data;

public interface IDateAtomSubtractionOperators : ISubtractionOperators<DateAtom, ByteAtom, DateAtom>,
    ISubtractionOperators<DateAtom, ByteVector, DateVector>, ISubtractionOperators<DateAtom, ShortAtom, DateAtom>,
    ISubtractionOperators<DateAtom, ShortVector, DateVector>, ISubtractionOperators<DateAtom, IntAtom, DateAtom>,
    ISubtractionOperators<DateAtom, IntVector, DateVector>, ISubtractionOperators<DateAtom, LongAtom, DateAtom>,
    ISubtractionOperators<DateAtom, LongVector, DateVector>, ISubtractionOperators<DateAtom, DateAtom, IntAtom>,
    ISubtractionOperators<DateAtom, DateVector, IntVector>,
    ISubtractionOperators<DateAtom, TimespanAtom, TimestampAtom>,
    ISubtractionOperators<DateAtom, TimespanVector, TimestampVector>,
    ISubtractionOperators<DateAtom, MinuteAtom, TimestampAtom>,
    ISubtractionOperators<DateAtom, MinuteVector, TimestampVector>,
    ISubtractionOperators<DateAtom, SecondAtom, TimestampAtom>,
    ISubtractionOperators<DateAtom, SecondVector, TimestampVector>
{
}
