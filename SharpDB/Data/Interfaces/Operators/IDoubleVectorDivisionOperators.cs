using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleVectorDivisionOperators : IDivisionOperators<DoubleVector, ByteAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, ByteVector, DoubleVector>,
    IDivisionOperators<DoubleVector, ShortAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, ShortVector, DoubleVector>,
    IDivisionOperators<DoubleVector, IntAtom, DoubleVector>, IDivisionOperators<DoubleVector, IntVector, DoubleVector>,
    IDivisionOperators<DoubleVector, LongAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, LongVector, DoubleVector>,
    IDivisionOperators<DoubleVector, FloatAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, FloatVector, DoubleVector>,
    IDivisionOperators<DoubleVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, DoubleVector, DoubleVector>,
    IDivisionOperators<DoubleVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, TimestampVector, DoubleVector>,
    IDivisionOperators<DoubleVector, MonthAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, MonthVector, DoubleVector>,
    IDivisionOperators<DoubleVector, DateAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, DateVector, DoubleVector>,
    IDivisionOperators<DoubleVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, TimespanVector, DoubleVector>,
    IDivisionOperators<DoubleVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, MinuteVector, DoubleVector>,
    IDivisionOperators<DoubleVector, SecondAtom, DoubleVector>,
    IDivisionOperators<DoubleVector, SecondVector, DoubleVector>
{
}
