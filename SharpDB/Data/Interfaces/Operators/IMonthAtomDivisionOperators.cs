using System.Numerics;

namespace SharpDB.Data;

public interface IMonthAtomDivisionOperators : IDivisionOperators<MonthAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, ByteVector, DoubleVector>, IDivisionOperators<MonthAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, ShortVector, DoubleVector>, IDivisionOperators<MonthAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, IntVector, DoubleVector>, IDivisionOperators<MonthAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, LongVector, DoubleVector>, IDivisionOperators<MonthAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, FloatVector, DoubleVector>, IDivisionOperators<MonthAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, DoubleVector, DoubleVector>, IDivisionOperators<MonthAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, TimestampVector, DoubleVector>, IDivisionOperators<MonthAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, MonthVector, DoubleVector>, IDivisionOperators<MonthAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, DateVector, DoubleVector>, IDivisionOperators<MonthAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, TimespanVector, DoubleVector>, IDivisionOperators<MonthAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, MinuteVector, DoubleVector>, IDivisionOperators<MonthAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<MonthAtom, SecondVector, DoubleVector>
{
}
