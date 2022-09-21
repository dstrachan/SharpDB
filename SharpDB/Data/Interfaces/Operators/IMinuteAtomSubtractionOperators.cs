using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteAtomSubtractionOperators : ISubtractionOperators<MinuteAtom, ByteAtom, MinuteAtom>,
    ISubtractionOperators<MinuteAtom, ByteVector, MinuteVector>, ISubtractionOperators<MinuteAtom, ShortAtom, MinuteAtom>,
    ISubtractionOperators<MinuteAtom, ShortVector, MinuteVector>, ISubtractionOperators<MinuteAtom, IntAtom, MinuteAtom>,
    ISubtractionOperators<MinuteAtom, IntVector, MinuteVector>, ISubtractionOperators<MinuteAtom, LongAtom, MinuteAtom>,
    ISubtractionOperators<MinuteAtom, LongVector, MinuteVector>, ISubtractionOperators<MinuteAtom, FloatAtom, MinuteAtom>,
    ISubtractionOperators<MinuteAtom, FloatVector, MinuteVector>, ISubtractionOperators<MinuteAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<MinuteAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<MinuteAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<MinuteAtom, TimestampVector, TimestampVector>,
    ISubtractionOperators<MinuteAtom, MonthAtom, TimestampAtom>,
    ISubtractionOperators<MinuteAtom, MonthVector, TimestampVector>,
    ISubtractionOperators<MinuteAtom, DateAtom, TimestampAtom>,
    ISubtractionOperators<MinuteAtom, DateVector, TimestampVector>,
    ISubtractionOperators<MinuteAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<MinuteAtom, TimespanVector, TimespanVector>,
    ISubtractionOperators<MinuteAtom, MinuteAtom, MinuteAtom>, ISubtractionOperators<MinuteAtom, MinuteVector, MinuteVector>,
    ISubtractionOperators<MinuteAtom, SecondAtom, SecondAtom>, ISubtractionOperators<MinuteAtom, SecondVector, SecondVector>
{
}
