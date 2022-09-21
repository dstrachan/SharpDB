using System.Numerics;

namespace SharpDB.Data;

public interface ILongAtomSubtractionOperators : ISubtractionOperators<LongAtom, ByteAtom, LongAtom>,
    ISubtractionOperators<LongAtom, ByteVector, LongVector>, ISubtractionOperators<LongAtom, ShortAtom, LongAtom>,
    ISubtractionOperators<LongAtom, ShortVector, LongVector>, ISubtractionOperators<LongAtom, IntAtom, LongAtom>,
    ISubtractionOperators<LongAtom, IntVector, LongVector>, ISubtractionOperators<LongAtom, LongAtom, LongAtom>,
    ISubtractionOperators<LongAtom, LongVector, LongVector>, ISubtractionOperators<LongAtom, FloatAtom, FloatAtom>,
    ISubtractionOperators<LongAtom, FloatVector, FloatVector>, ISubtractionOperators<LongAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<LongAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<LongAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<LongAtom, TimestampVector, TimestampVector>, ISubtractionOperators<LongAtom, MonthAtom, MonthAtom>,
    ISubtractionOperators<LongAtom, MonthVector, MonthVector>, ISubtractionOperators<LongAtom, DateAtom, DateAtom>,
    ISubtractionOperators<LongAtom, DateVector, DateVector>, ISubtractionOperators<LongAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<LongAtom, TimespanVector, TimespanVector>, ISubtractionOperators<LongAtom, MinuteAtom, MinuteAtom>,
    ISubtractionOperators<LongAtom, MinuteVector, MinuteVector>, ISubtractionOperators<LongAtom, SecondAtom, SecondAtom>,
    ISubtractionOperators<LongAtom, SecondVector, SecondVector>
{
}
