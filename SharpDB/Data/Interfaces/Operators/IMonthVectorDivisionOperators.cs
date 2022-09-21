using System.Numerics;

namespace SharpDB.Data;

public interface IMonthVectorDivisionOperators : IDivisionOperators<MonthVector, ByteAtom, DoubleVector>,
    IDivisionOperators<MonthVector, ByteVector, DoubleVector>, IDivisionOperators<MonthVector, ShortAtom, DoubleVector>,
    IDivisionOperators<MonthVector, ShortVector, DoubleVector>, IDivisionOperators<MonthVector, IntAtom, DoubleVector>,
    IDivisionOperators<MonthVector, IntVector, DoubleVector>, IDivisionOperators<MonthVector, LongAtom, DoubleVector>,
    IDivisionOperators<MonthVector, LongVector, DoubleVector>, IDivisionOperators<MonthVector, FloatAtom, DoubleVector>,
    IDivisionOperators<MonthVector, FloatVector, DoubleVector>,
    IDivisionOperators<MonthVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<MonthVector, DoubleVector, DoubleVector>,
    IDivisionOperators<MonthVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<MonthVector, TimestampVector, DoubleVector>,
    IDivisionOperators<MonthVector, MonthAtom, DoubleVector>,
    IDivisionOperators<MonthVector, MonthVector, DoubleVector>, IDivisionOperators<MonthVector, DateAtom, DoubleVector>,
    IDivisionOperators<MonthVector, DateVector, DoubleVector>,
    IDivisionOperators<MonthVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<MonthVector, TimespanVector, DoubleVector>,
    IDivisionOperators<MonthVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<MonthVector, MinuteVector, DoubleVector>,
    IDivisionOperators<MonthVector, SecondAtom, DoubleVector>,
    IDivisionOperators<MonthVector, SecondVector, DoubleVector>
{
}
