using System.Numerics;

namespace SharpDB.Data;

public interface IIntVectorSubtractionOperators : ISubtractionOperators<IntVector, ByteAtom, IntVector>,
    ISubtractionOperators<IntVector, ByteVector, IntVector>, ISubtractionOperators<IntVector, ShortAtom, IntVector>,
    ISubtractionOperators<IntVector, ShortVector, IntVector>, ISubtractionOperators<IntVector, IntAtom, IntVector>,
    ISubtractionOperators<IntVector, IntVector, IntVector>, ISubtractionOperators<IntVector, LongAtom, LongVector>,
    ISubtractionOperators<IntVector, LongVector, LongVector>, ISubtractionOperators<IntVector, FloatAtom, FloatVector>,
    ISubtractionOperators<IntVector, FloatVector, FloatVector>, ISubtractionOperators<IntVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<IntVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<IntVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<IntVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<IntVector, MonthAtom, MonthVector>, ISubtractionOperators<IntVector, MonthVector, MonthVector>,
    ISubtractionOperators<IntVector, DateAtom, DateVector>, ISubtractionOperators<IntVector, DateVector, DateVector>,
    ISubtractionOperators<IntVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<IntVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<IntVector, MinuteAtom, MinuteVector>, ISubtractionOperators<IntVector, MinuteVector, MinuteVector>,
    ISubtractionOperators<IntVector, SecondAtom, SecondVector>, ISubtractionOperators<IntVector, SecondVector, SecondVector>
{
}
