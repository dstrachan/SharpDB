using System.Numerics;

namespace SharpDB.Data;

public interface IIntAtomSubtractionOperators : ISubtractionOperators<IntAtom, ByteAtom, IntAtom>,
    ISubtractionOperators<IntAtom, ByteVector, IntVector>, ISubtractionOperators<IntAtom, ShortAtom, IntAtom>,
    ISubtractionOperators<IntAtom, ShortVector, IntVector>, ISubtractionOperators<IntAtom, IntAtom, IntAtom>,
    ISubtractionOperators<IntAtom, IntVector, IntVector>, ISubtractionOperators<IntAtom, LongAtom, LongAtom>,
    ISubtractionOperators<IntAtom, LongVector, LongVector>, ISubtractionOperators<IntAtom, FloatAtom, FloatAtom>,
    ISubtractionOperators<IntAtom, FloatVector, FloatVector>, ISubtractionOperators<IntAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<IntAtom, DoubleVector, DoubleVector>, ISubtractionOperators<IntAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<IntAtom, TimestampVector, TimestampVector>, ISubtractionOperators<IntAtom, MonthAtom, MonthAtom>,
    ISubtractionOperators<IntAtom, MonthVector, MonthVector>, ISubtractionOperators<IntAtom, DateAtom, DateAtom>,
    ISubtractionOperators<IntAtom, DateVector, DateVector>, ISubtractionOperators<IntAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<IntAtom, TimespanVector, TimespanVector>, ISubtractionOperators<IntAtom, MinuteAtom, MinuteAtom>,
    ISubtractionOperators<IntAtom, MinuteVector, MinuteVector>, ISubtractionOperators<IntAtom, SecondAtom, SecondAtom>,
    ISubtractionOperators<IntAtom, SecondVector, SecondVector>
{
}
