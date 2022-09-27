using System.Numerics;

namespace SharpDB.Data;

public interface IFloatVectorDivisionOperators : IDivisionOperators<FloatVector, ByteAtom, DoubleVector>,
    IDivisionOperators<FloatVector, ByteVector, DoubleVector>, IDivisionOperators<FloatVector, ShortAtom, DoubleVector>,
    IDivisionOperators<FloatVector, ShortVector, DoubleVector>, IDivisionOperators<FloatVector, IntAtom, DoubleVector>,
    IDivisionOperators<FloatVector, IntVector, DoubleVector>, IDivisionOperators<FloatVector, LongAtom, DoubleVector>,
    IDivisionOperators<FloatVector, LongVector, DoubleVector>, IDivisionOperators<FloatVector, FloatAtom, DoubleVector>,
    IDivisionOperators<FloatVector, FloatVector, DoubleVector>,
    IDivisionOperators<FloatVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<FloatVector, DoubleVector, DoubleVector>,
    IDivisionOperators<FloatVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<FloatVector, TimestampVector, DoubleVector>,
    IDivisionOperators<FloatVector, MonthAtom, DoubleVector>,
    IDivisionOperators<FloatVector, MonthVector, DoubleVector>,
    IDivisionOperators<FloatVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<FloatVector, TimespanVector, DoubleVector>,
    IDivisionOperators<FloatVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<FloatVector, MinuteVector, DoubleVector>,
    IDivisionOperators<FloatVector, SecondAtom, DoubleVector>,
    IDivisionOperators<FloatVector, SecondVector, DoubleVector>
{
}
