using System.Numerics;

namespace SharpDB.Data;

public interface ILongVectorSubtractionOperators : ISubtractionOperators<LongVector, ByteAtom, LongVector>,
    ISubtractionOperators<LongVector, ByteVector, LongVector>, ISubtractionOperators<LongVector, ShortAtom, LongVector>,
    ISubtractionOperators<LongVector, ShortVector, LongVector>, ISubtractionOperators<LongVector, IntAtom, LongVector>,
    ISubtractionOperators<LongVector, IntVector, LongVector>, ISubtractionOperators<LongVector, LongAtom, LongVector>,
    ISubtractionOperators<LongVector, LongVector, LongVector>, ISubtractionOperators<LongVector, FloatAtom, FloatVector>,
    ISubtractionOperators<LongVector, FloatVector, FloatVector>, ISubtractionOperators<LongVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<LongVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<LongVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<LongVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<LongVector, MonthAtom, MonthVector>, ISubtractionOperators<LongVector, MonthVector, MonthVector>,
    ISubtractionOperators<LongVector, DateAtom, DateVector>, ISubtractionOperators<LongVector, DateVector, DateVector>,
    ISubtractionOperators<LongVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<LongVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<LongVector, MinuteAtom, MinuteVector>,
    ISubtractionOperators<LongVector, MinuteVector, MinuteVector>,
    ISubtractionOperators<LongVector, SecondAtom, SecondVector>, ISubtractionOperators<LongVector, SecondVector, SecondVector>
{
}
