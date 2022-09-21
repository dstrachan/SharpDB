using System.Numerics;

namespace SharpDB.Data;

public interface IShortVectorSubtractionOperators : ISubtractionOperators<ShortVector, ByteAtom, IntVector>,
    ISubtractionOperators<ShortVector, ByteVector, IntVector>, ISubtractionOperators<ShortVector, ShortAtom, IntVector>,
    ISubtractionOperators<ShortVector, ShortVector, IntVector>, ISubtractionOperators<ShortVector, IntAtom, IntVector>,
    ISubtractionOperators<ShortVector, IntVector, IntVector>, ISubtractionOperators<ShortVector, LongAtom, LongVector>,
    ISubtractionOperators<ShortVector, LongVector, LongVector>, ISubtractionOperators<ShortVector, FloatAtom, FloatVector>,
    ISubtractionOperators<ShortVector, FloatVector, FloatVector>,
    ISubtractionOperators<ShortVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<ShortVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<ShortVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<ShortVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<ShortVector, MonthAtom, MonthVector>, ISubtractionOperators<ShortVector, MonthVector, MonthVector>,
    ISubtractionOperators<ShortVector, DateAtom, DateVector>, ISubtractionOperators<ShortVector, DateVector, DateVector>,
    ISubtractionOperators<ShortVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<ShortVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<ShortVector, MinuteAtom, MinuteVector>,
    ISubtractionOperators<ShortVector, MinuteVector, MinuteVector>,
    ISubtractionOperators<ShortVector, SecondAtom, SecondVector>,
    ISubtractionOperators<ShortVector, SecondVector, SecondVector>
{
}
