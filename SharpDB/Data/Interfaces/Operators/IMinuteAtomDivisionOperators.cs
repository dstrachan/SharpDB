using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteAtomDivisionOperators : IDivisionOperators<MinuteAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, ByteVector, DoubleVector>, IDivisionOperators<MinuteAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, ShortVector, DoubleVector>, IDivisionOperators<MinuteAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, IntVector, DoubleVector>, IDivisionOperators<MinuteAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, LongVector, DoubleVector>, IDivisionOperators<MinuteAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, FloatVector, DoubleVector>, IDivisionOperators<MinuteAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, DoubleVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, TimestampVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, MonthAtom, DoubleAtom>, IDivisionOperators<MinuteAtom, MonthVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, DateAtom, DoubleAtom>, IDivisionOperators<MinuteAtom, DateVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<MinuteAtom, TimespanVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, MinuteAtom, DoubleAtom>, IDivisionOperators<MinuteAtom, MinuteVector, DoubleVector>,
    IDivisionOperators<MinuteAtom, SecondAtom, DoubleAtom>, IDivisionOperators<MinuteAtom, SecondVector, DoubleVector>
{
}
