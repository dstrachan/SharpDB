using System.Numerics;

namespace SharpDB.Data;

public interface IIntVectorDivisionOperators : IDivisionOperators<IntVector, ByteAtom, DoubleVector>,
    IDivisionOperators<IntVector, ByteVector, DoubleVector>, IDivisionOperators<IntVector, ShortAtom, DoubleVector>,
    IDivisionOperators<IntVector, ShortVector, DoubleVector>, IDivisionOperators<IntVector, IntAtom, DoubleVector>,
    IDivisionOperators<IntVector, IntVector, DoubleVector>, IDivisionOperators<IntVector, LongAtom, DoubleVector>,
    IDivisionOperators<IntVector, LongVector, DoubleVector>, IDivisionOperators<IntVector, FloatAtom, DoubleVector>,
    IDivisionOperators<IntVector, FloatVector, DoubleVector>, IDivisionOperators<IntVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<IntVector, DoubleVector, DoubleVector>,
    IDivisionOperators<IntVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<IntVector, TimestampVector, DoubleVector>,
    IDivisionOperators<IntVector, MonthAtom, DoubleVector>, IDivisionOperators<IntVector, MonthVector, DoubleVector>,
    IDivisionOperators<IntVector, DateAtom, DoubleVector>, IDivisionOperators<IntVector, DateVector, DoubleVector>,
    IDivisionOperators<IntVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<IntVector, TimespanVector, DoubleVector>,
    IDivisionOperators<IntVector, MinuteAtom, DoubleVector>, IDivisionOperators<IntVector, MinuteVector, DoubleVector>,
    IDivisionOperators<IntVector, SecondAtom, DoubleVector>, IDivisionOperators<IntVector, SecondVector, DoubleVector>
{
}
