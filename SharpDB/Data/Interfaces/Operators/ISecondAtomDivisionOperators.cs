using System.Numerics;

namespace SharpDB.Data;

public interface ISecondAtomDivisionOperators : IDivisionOperators<SecondAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, ByteVector, DoubleVector>, IDivisionOperators<SecondAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, ShortVector, DoubleVector>, IDivisionOperators<SecondAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, IntVector, DoubleVector>, IDivisionOperators<SecondAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, LongVector, DoubleVector>, IDivisionOperators<SecondAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, FloatVector, DoubleVector>, IDivisionOperators<SecondAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, DoubleVector, DoubleVector>,
    IDivisionOperators<SecondAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, TimestampVector, DoubleVector>,
    IDivisionOperators<SecondAtom, MonthAtom, DoubleAtom>, IDivisionOperators<SecondAtom, MonthVector, DoubleVector>,
    IDivisionOperators<SecondAtom, DateAtom, DoubleAtom>, IDivisionOperators<SecondAtom, DateVector, DoubleVector>,
    IDivisionOperators<SecondAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<SecondAtom, TimespanVector, DoubleVector>,
    IDivisionOperators<SecondAtom, MinuteAtom, DoubleAtom>, IDivisionOperators<SecondAtom, MinuteVector, DoubleVector>,
    IDivisionOperators<SecondAtom, SecondAtom, DoubleAtom>, IDivisionOperators<SecondAtom, SecondVector, DoubleVector>
{
}
