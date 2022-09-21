using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleAtomDivisionOperators : IDivisionOperators<DoubleAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, ByteVector, DoubleVector>, IDivisionOperators<DoubleAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, ShortVector, DoubleVector>, IDivisionOperators<DoubleAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, IntVector, DoubleVector>, IDivisionOperators<DoubleAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, LongVector, DoubleVector>, IDivisionOperators<DoubleAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, FloatVector, DoubleVector>, IDivisionOperators<DoubleAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, DoubleVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, TimestampVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, MonthAtom, DoubleAtom>, IDivisionOperators<DoubleAtom, MonthVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, DateAtom, DoubleAtom>, IDivisionOperators<DoubleAtom, DateVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<DoubleAtom, TimespanVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, MinuteAtom, DoubleAtom>, IDivisionOperators<DoubleAtom, MinuteVector, DoubleVector>,
    IDivisionOperators<DoubleAtom, SecondAtom, DoubleAtom>, IDivisionOperators<DoubleAtom, SecondVector, DoubleVector>
{
}
