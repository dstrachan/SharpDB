using System.Numerics;

namespace SharpDB.Data;

public interface IShortAtomDivisionOperators : IDivisionOperators<ShortAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, ByteVector, DoubleVector>, IDivisionOperators<ShortAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, ShortVector, DoubleVector>, IDivisionOperators<ShortAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, IntVector, DoubleVector>, IDivisionOperators<ShortAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, LongVector, DoubleVector>, IDivisionOperators<ShortAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, FloatVector, DoubleVector>, IDivisionOperators<ShortAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, DoubleVector, DoubleVector>, IDivisionOperators<ShortAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, TimestampVector, DoubleVector>, IDivisionOperators<ShortAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, MonthVector, DoubleVector>, IDivisionOperators<ShortAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, DateVector, DoubleVector>, IDivisionOperators<ShortAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, TimespanVector, DoubleVector>, IDivisionOperators<ShortAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, MinuteVector, DoubleVector>, IDivisionOperators<ShortAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<ShortAtom, SecondVector, DoubleVector>
{
}
