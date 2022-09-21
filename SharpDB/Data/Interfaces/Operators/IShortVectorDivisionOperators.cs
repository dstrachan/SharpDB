using System.Numerics;

namespace SharpDB.Data;

public interface IShortVectorDivisionOperators : IDivisionOperators<ShortVector, ByteAtom, DoubleVector>,
    IDivisionOperators<ShortVector, ByteVector, DoubleVector>, IDivisionOperators<ShortVector, ShortAtom, DoubleVector>,
    IDivisionOperators<ShortVector, ShortVector, DoubleVector>, IDivisionOperators<ShortVector, IntAtom, DoubleVector>,
    IDivisionOperators<ShortVector, IntVector, DoubleVector>, IDivisionOperators<ShortVector, LongAtom, DoubleVector>,
    IDivisionOperators<ShortVector, LongVector, DoubleVector>, IDivisionOperators<ShortVector, FloatAtom, DoubleVector>,
    IDivisionOperators<ShortVector, FloatVector, DoubleVector>,
    IDivisionOperators<ShortVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<ShortVector, DoubleVector, DoubleVector>,
    IDivisionOperators<ShortVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<ShortVector, TimestampVector, DoubleVector>,
    IDivisionOperators<ShortVector, MonthAtom, DoubleVector>,
    IDivisionOperators<ShortVector, MonthVector, DoubleVector>, IDivisionOperators<ShortVector, DateAtom, DoubleVector>,
    IDivisionOperators<ShortVector, DateVector, DoubleVector>,
    IDivisionOperators<ShortVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<ShortVector, TimespanVector, DoubleVector>,
    IDivisionOperators<ShortVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<ShortVector, MinuteVector, DoubleVector>,
    IDivisionOperators<ShortVector, SecondAtom, DoubleVector>,
    IDivisionOperators<ShortVector, SecondVector, DoubleVector>
{
}
