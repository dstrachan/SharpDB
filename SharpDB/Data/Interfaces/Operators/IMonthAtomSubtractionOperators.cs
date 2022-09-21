using System.Numerics;

namespace SharpDB.Data;

public interface IMonthAtomSubtractionOperators : ISubtractionOperators<MonthAtom, ByteAtom, MonthAtom>,
    ISubtractionOperators<MonthAtom, ByteVector, MonthVector>, ISubtractionOperators<MonthAtom, ShortAtom, MonthAtom>,
    ISubtractionOperators<MonthAtom, ShortVector, MonthVector>, ISubtractionOperators<MonthAtom, IntAtom, MonthAtom>,
    ISubtractionOperators<MonthAtom, IntVector, MonthVector>, ISubtractionOperators<MonthAtom, LongAtom, MonthAtom>,
    ISubtractionOperators<MonthAtom, LongVector, MonthVector>, ISubtractionOperators<MonthAtom, FloatAtom, MonthAtom>,
    ISubtractionOperators<MonthAtom, FloatVector, MonthVector>, ISubtractionOperators<MonthAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<MonthAtom, DoubleVector, DoubleVector>, ISubtractionOperators<MonthAtom, MonthAtom, IntAtom>,
    ISubtractionOperators<MonthAtom, MonthVector, IntVector>, ISubtractionOperators<MonthAtom, TimespanAtom, TimestampAtom>,
    ISubtractionOperators<MonthAtom, TimespanVector, TimestampVector>,
    ISubtractionOperators<MonthAtom, MinuteAtom, TimestampAtom>,
    ISubtractionOperators<MonthAtom, MinuteVector, TimestampVector>,
    ISubtractionOperators<MonthAtom, SecondAtom, TimestampAtom>,
    ISubtractionOperators<MonthAtom, SecondVector, TimestampVector>
{
}
