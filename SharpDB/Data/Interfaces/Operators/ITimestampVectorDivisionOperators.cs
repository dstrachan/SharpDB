using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampVectorDivisionOperators : IDivisionOperators<TimestampVector, ByteAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, ByteVector, DoubleVector>,
    IDivisionOperators<TimestampVector, ShortAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, ShortVector, DoubleVector>,
    IDivisionOperators<TimestampVector, IntAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, IntVector, DoubleVector>,
    IDivisionOperators<TimestampVector, LongAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, LongVector, DoubleVector>,
    IDivisionOperators<TimestampVector, FloatAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, FloatVector, DoubleVector>,
    IDivisionOperators<TimestampVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, DoubleVector, DoubleVector>,
    IDivisionOperators<TimestampVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, TimestampVector, DoubleVector>,
    IDivisionOperators<TimestampVector, MonthAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, MonthVector, DoubleVector>,
    IDivisionOperators<TimestampVector, DateAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, DateVector, DoubleVector>,
    IDivisionOperators<TimestampVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, TimespanVector, DoubleVector>,
    IDivisionOperators<TimestampVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, MinuteVector, DoubleVector>,
    IDivisionOperators<TimestampVector, SecondAtom, DoubleVector>,
    IDivisionOperators<TimestampVector, SecondVector, DoubleVector>
{
}
