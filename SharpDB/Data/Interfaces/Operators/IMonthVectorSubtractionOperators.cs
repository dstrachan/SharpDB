using System.Numerics;

namespace SharpDB.Data;

public interface IMonthVectorSubtractionOperators : ISubtractionOperators<MonthVector, ByteAtom, MonthVector>,
    ISubtractionOperators<MonthVector, ByteVector, MonthVector>, ISubtractionOperators<MonthVector, ShortAtom, MonthVector>,
    ISubtractionOperators<MonthVector, ShortVector, MonthVector>, ISubtractionOperators<MonthVector, IntAtom, MonthVector>,
    ISubtractionOperators<MonthVector, IntVector, MonthVector>, ISubtractionOperators<MonthVector, LongAtom, MonthVector>,
    ISubtractionOperators<MonthVector, LongVector, MonthVector>, ISubtractionOperators<MonthVector, FloatAtom, MonthVector>,
    ISubtractionOperators<MonthVector, FloatVector, MonthVector>,
    ISubtractionOperators<MonthVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<MonthVector, DoubleVector, DoubleVector>, ISubtractionOperators<MonthVector, MonthAtom, IntVector>,
    ISubtractionOperators<MonthVector, MonthVector, IntVector>,
    ISubtractionOperators<MonthVector, TimespanAtom, TimestampVector>,
    ISubtractionOperators<MonthVector, TimespanVector, TimestampVector>,
    ISubtractionOperators<MonthVector, MinuteAtom, TimestampVector>,
    ISubtractionOperators<MonthVector, MinuteVector, TimestampVector>,
    ISubtractionOperators<MonthVector, SecondAtom, TimestampVector>,
    ISubtractionOperators<MonthVector, SecondVector, TimestampVector>
{
}
