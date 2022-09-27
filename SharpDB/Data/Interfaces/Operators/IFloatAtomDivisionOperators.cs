using System.Numerics;

namespace SharpDB.Data;

public interface IFloatAtomDivisionOperators : IDivisionOperators<FloatAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, ByteVector, DoubleVector>, IDivisionOperators<FloatAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, ShortVector, DoubleVector>, IDivisionOperators<FloatAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, IntVector, DoubleVector>, IDivisionOperators<FloatAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, LongVector, DoubleVector>, IDivisionOperators<FloatAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, FloatVector, DoubleVector>, IDivisionOperators<FloatAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, DoubleVector, DoubleVector>, IDivisionOperators<FloatAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, TimestampVector, DoubleVector>, IDivisionOperators<FloatAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, MonthVector, DoubleVector>, IDivisionOperators<FloatAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, TimespanVector, DoubleVector>, IDivisionOperators<FloatAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, MinuteVector, DoubleVector>, IDivisionOperators<FloatAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<FloatAtom, SecondVector, DoubleVector>
{
}
