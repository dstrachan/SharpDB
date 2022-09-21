using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanVectorDivisionOperators : IDivisionOperators<TimespanVector, ByteAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, ByteVector, DoubleVector>,
    IDivisionOperators<TimespanVector, ShortAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, ShortVector, DoubleVector>,
    IDivisionOperators<TimespanVector, IntAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, IntVector, DoubleVector>,
    IDivisionOperators<TimespanVector, LongAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, LongVector, DoubleVector>,
    IDivisionOperators<TimespanVector, FloatAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, FloatVector, DoubleVector>,
    IDivisionOperators<TimespanVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, DoubleVector, DoubleVector>,
    IDivisionOperators<TimespanVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, TimestampVector, DoubleVector>,
    IDivisionOperators<TimespanVector, MonthAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, MonthVector, DoubleVector>,
    IDivisionOperators<TimespanVector, DateAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, DateVector, DoubleVector>,
    IDivisionOperators<TimespanVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, TimespanVector, DoubleVector>,
    IDivisionOperators<TimespanVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, MinuteVector, DoubleVector>,
    IDivisionOperators<TimespanVector, SecondAtom, DoubleVector>,
    IDivisionOperators<TimespanVector, SecondVector, DoubleVector>
{
}
