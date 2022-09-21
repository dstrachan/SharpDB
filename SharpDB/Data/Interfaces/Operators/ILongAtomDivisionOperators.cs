using System.Numerics;

namespace SharpDB.Data;

public interface ILongAtomDivisionOperators : IDivisionOperators<LongAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, ByteVector, DoubleVector>, IDivisionOperators<LongAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, ShortVector, DoubleVector>, IDivisionOperators<LongAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, IntVector, DoubleVector>, IDivisionOperators<LongAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, LongVector, DoubleVector>, IDivisionOperators<LongAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, FloatVector, DoubleVector>, IDivisionOperators<LongAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, DoubleVector, DoubleVector>, IDivisionOperators<LongAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, TimestampVector, DoubleVector>, IDivisionOperators<LongAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, MonthVector, DoubleVector>, IDivisionOperators<LongAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, DateVector, DoubleVector>, IDivisionOperators<LongAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, TimespanVector, DoubleVector>, IDivisionOperators<LongAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, MinuteVector, DoubleVector>, IDivisionOperators<LongAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<LongAtom, SecondVector, DoubleVector>
{
}
