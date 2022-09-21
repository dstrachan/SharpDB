using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteVectorDivisionOperators : IDivisionOperators<MinuteVector, ByteAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, ByteVector, DoubleVector>,
    IDivisionOperators<MinuteVector, ShortAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, ShortVector, DoubleVector>,
    IDivisionOperators<MinuteVector, IntAtom, DoubleVector>, IDivisionOperators<MinuteVector, IntVector, DoubleVector>,
    IDivisionOperators<MinuteVector, LongAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, LongVector, DoubleVector>,
    IDivisionOperators<MinuteVector, FloatAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, FloatVector, DoubleVector>,
    IDivisionOperators<MinuteVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, DoubleVector, DoubleVector>,
    IDivisionOperators<MinuteVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, TimestampVector, DoubleVector>,
    IDivisionOperators<MinuteVector, MonthAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, MonthVector, DoubleVector>,
    IDivisionOperators<MinuteVector, DateAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, DateVector, DoubleVector>,
    IDivisionOperators<MinuteVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, TimespanVector, DoubleVector>,
    IDivisionOperators<MinuteVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, MinuteVector, DoubleVector>,
    IDivisionOperators<MinuteVector, SecondAtom, DoubleVector>,
    IDivisionOperators<MinuteVector, SecondVector, DoubleVector>
{
}
