using System.Numerics;

namespace SharpDB.Data;

public interface IIntAtomDivisionOperators : IDivisionOperators<IntAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, ByteVector, DoubleVector>, IDivisionOperators<IntAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, ShortVector, DoubleVector>, IDivisionOperators<IntAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, IntVector, DoubleVector>, IDivisionOperators<IntAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, LongVector, DoubleVector>, IDivisionOperators<IntAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, FloatVector, DoubleVector>, IDivisionOperators<IntAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, DoubleVector, DoubleVector>, IDivisionOperators<IntAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, TimestampVector, DoubleVector>, IDivisionOperators<IntAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, MonthVector, DoubleVector>, IDivisionOperators<IntAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, DateVector, DoubleVector>, IDivisionOperators<IntAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, TimespanVector, DoubleVector>, IDivisionOperators<IntAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, MinuteVector, DoubleVector>, IDivisionOperators<IntAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<IntAtom, SecondVector, DoubleVector>
{
}
