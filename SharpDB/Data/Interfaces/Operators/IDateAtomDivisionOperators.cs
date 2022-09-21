using System.Numerics;

namespace SharpDB.Data;

public interface IDateAtomDivisionOperators : IDivisionOperators<DateAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, ByteVector, DoubleVector>, IDivisionOperators<DateAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, ShortVector, DoubleVector>, IDivisionOperators<DateAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, IntVector, DoubleVector>, IDivisionOperators<DateAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, LongVector, DoubleVector>, IDivisionOperators<DateAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, FloatVector, DoubleVector>, IDivisionOperators<DateAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, DoubleVector, DoubleVector>, IDivisionOperators<DateAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, TimestampVector, DoubleVector>, IDivisionOperators<DateAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, MonthVector, DoubleVector>, IDivisionOperators<DateAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, DateVector, DoubleVector>, IDivisionOperators<DateAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, TimespanVector, DoubleVector>, IDivisionOperators<DateAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, MinuteVector, DoubleVector>, IDivisionOperators<DateAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<DateAtom, SecondVector, DoubleVector>
{
}
