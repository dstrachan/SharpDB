using System.Numerics;

namespace SharpDB.Data;

public interface IByteAtomDivisionOperators : IDivisionOperators<ByteAtom, ByteAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, ByteVector, DoubleVector>, IDivisionOperators<ByteAtom, ShortAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, ShortVector, DoubleVector>, IDivisionOperators<ByteAtom, IntAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, IntVector, DoubleVector>, IDivisionOperators<ByteAtom, LongAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, LongVector, DoubleVector>, IDivisionOperators<ByteAtom, FloatAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, FloatVector, DoubleVector>, IDivisionOperators<ByteAtom, DoubleAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, DoubleVector, DoubleVector>, IDivisionOperators<ByteAtom, TimestampAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, TimestampVector, DoubleVector>, IDivisionOperators<ByteAtom, MonthAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, MonthVector, DoubleVector>, IDivisionOperators<ByteAtom, DateAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, DateVector, DoubleVector>, IDivisionOperators<ByteAtom, TimespanAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, TimespanVector, DoubleVector>, IDivisionOperators<ByteAtom, MinuteAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, MinuteVector, DoubleVector>, IDivisionOperators<ByteAtom, SecondAtom, DoubleAtom>,
    IDivisionOperators<ByteAtom, SecondVector, DoubleVector>
{
}
