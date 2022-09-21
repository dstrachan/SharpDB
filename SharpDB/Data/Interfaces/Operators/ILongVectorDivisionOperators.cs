using System.Numerics;

namespace SharpDB.Data;

public interface ILongVectorDivisionOperators : IDivisionOperators<LongVector, ByteAtom, DoubleVector>,
    IDivisionOperators<LongVector, ByteVector, DoubleVector>, IDivisionOperators<LongVector, ShortAtom, DoubleVector>,
    IDivisionOperators<LongVector, ShortVector, DoubleVector>, IDivisionOperators<LongVector, IntAtom, DoubleVector>,
    IDivisionOperators<LongVector, IntVector, DoubleVector>, IDivisionOperators<LongVector, LongAtom, DoubleVector>,
    IDivisionOperators<LongVector, LongVector, DoubleVector>, IDivisionOperators<LongVector, FloatAtom, DoubleVector>,
    IDivisionOperators<LongVector, FloatVector, DoubleVector>, IDivisionOperators<LongVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<LongVector, DoubleVector, DoubleVector>,
    IDivisionOperators<LongVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<LongVector, TimestampVector, DoubleVector>,
    IDivisionOperators<LongVector, MonthAtom, DoubleVector>, IDivisionOperators<LongVector, MonthVector, DoubleVector>,
    IDivisionOperators<LongVector, DateAtom, DoubleVector>, IDivisionOperators<LongVector, DateVector, DoubleVector>,
    IDivisionOperators<LongVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<LongVector, TimespanVector, DoubleVector>,
    IDivisionOperators<LongVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<LongVector, MinuteVector, DoubleVector>,
    IDivisionOperators<LongVector, SecondAtom, DoubleVector>, IDivisionOperators<LongVector, SecondVector, DoubleVector>
{
}
