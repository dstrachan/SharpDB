using System.Numerics;

namespace SharpDB.Data;

public interface ISecondVectorDivisionOperators : IDivisionOperators<SecondVector, ByteAtom, DoubleVector>,
    IDivisionOperators<SecondVector, ByteVector, DoubleVector>,
    IDivisionOperators<SecondVector, ShortAtom, DoubleVector>,
    IDivisionOperators<SecondVector, ShortVector, DoubleVector>,
    IDivisionOperators<SecondVector, IntAtom, DoubleVector>, IDivisionOperators<SecondVector, IntVector, DoubleVector>,
    IDivisionOperators<SecondVector, LongAtom, DoubleVector>,
    IDivisionOperators<SecondVector, LongVector, DoubleVector>,
    IDivisionOperators<SecondVector, FloatAtom, DoubleVector>,
    IDivisionOperators<SecondVector, FloatVector, DoubleVector>,
    IDivisionOperators<SecondVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<SecondVector, DoubleVector, DoubleVector>,
    IDivisionOperators<SecondVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<SecondVector, TimestampVector, DoubleVector>,
    IDivisionOperators<SecondVector, MonthAtom, DoubleVector>,
    IDivisionOperators<SecondVector, MonthVector, DoubleVector>,
    IDivisionOperators<SecondVector, DateAtom, DoubleVector>,
    IDivisionOperators<SecondVector, DateVector, DoubleVector>,
    IDivisionOperators<SecondVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<SecondVector, TimespanVector, DoubleVector>,
    IDivisionOperators<SecondVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<SecondVector, MinuteVector, DoubleVector>,
    IDivisionOperators<SecondVector, SecondAtom, DoubleVector>,
    IDivisionOperators<SecondVector, SecondVector, DoubleVector>
{
}
