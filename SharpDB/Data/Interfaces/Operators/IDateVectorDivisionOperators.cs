using System.Numerics;

namespace SharpDB.Data;

public interface IDateVectorDivisionOperators : IDivisionOperators<DateVector, ByteAtom, DoubleVector>,
    IDivisionOperators<DateVector, ByteVector, DoubleVector>, IDivisionOperators<DateVector, ShortAtom, DoubleVector>,
    IDivisionOperators<DateVector, ShortVector, DoubleVector>, IDivisionOperators<DateVector, IntAtom, DoubleVector>,
    IDivisionOperators<DateVector, IntVector, DoubleVector>, IDivisionOperators<DateVector, LongAtom, DoubleVector>,
    IDivisionOperators<DateVector, LongVector, DoubleVector>, IDivisionOperators<DateVector, FloatAtom, DoubleVector>,
    IDivisionOperators<DateVector, FloatVector, DoubleVector>, IDivisionOperators<DateVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<DateVector, DoubleVector, DoubleVector>,
    IDivisionOperators<DateVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<DateVector, TimestampVector, DoubleVector>,
    IDivisionOperators<DateVector, MonthAtom, DoubleVector>, IDivisionOperators<DateVector, MonthVector, DoubleVector>,
    IDivisionOperators<DateVector, DateAtom, DoubleVector>, IDivisionOperators<DateVector, DateVector, DoubleVector>,
    IDivisionOperators<DateVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<DateVector, TimespanVector, DoubleVector>,
    IDivisionOperators<DateVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<DateVector, MinuteVector, DoubleVector>,
    IDivisionOperators<DateVector, SecondAtom, DoubleVector>, IDivisionOperators<DateVector, SecondVector, DoubleVector>
{
}
