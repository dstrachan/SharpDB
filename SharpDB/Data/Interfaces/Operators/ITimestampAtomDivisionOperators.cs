using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampAtomDivisionOperators : IDivisionOperators<TimestampAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, ByteVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, ShortVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, IntAtom, DoubleAtom>, IDivisionOperators<TimestampAtom, IntVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, LongVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, FloatVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, DoubleVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, TimestampVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, MonthVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, DateVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, TimespanVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, MinuteVector, DoubleVector>,
    IDivisionOperators<TimestampAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<TimestampAtom, SecondVector, DoubleVector>
{
}
