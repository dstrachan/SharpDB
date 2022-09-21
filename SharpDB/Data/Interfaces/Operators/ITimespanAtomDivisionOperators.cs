using System.Numerics;

namespace SharpDB.Data;

public interface ITimespanAtomDivisionOperators : IDivisionOperators<TimespanAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, ByteVector, DoubleVector>, IDivisionOperators<TimespanAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, ShortVector, DoubleVector>, IDivisionOperators<TimespanAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, IntVector, DoubleVector>, IDivisionOperators<TimespanAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, LongVector, DoubleVector>, IDivisionOperators<TimespanAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, FloatVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, DoubleVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, TimestampVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, MonthVector, DoubleVector>, IDivisionOperators<TimespanAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, DateVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, TimespanVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, MinuteVector, DoubleVector>,
    IDivisionOperators<TimespanAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<TimespanAtom, SecondVector, DoubleVector>
{
}
