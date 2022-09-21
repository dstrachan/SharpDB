using System.Numerics;

namespace SharpDB.Data;

public interface IByteVectorDivisionOperators : IDivisionOperators<ByteVector, ByteAtom, DoubleVector>,
    IDivisionOperators<ByteVector, ByteVector, DoubleVector>, IDivisionOperators<ByteVector, ShortAtom, DoubleVector>,
    IDivisionOperators<ByteVector, ShortVector, DoubleVector>, IDivisionOperators<ByteVector, IntAtom, DoubleVector>,
    IDivisionOperators<ByteVector, IntVector, DoubleVector>, IDivisionOperators<ByteVector, LongAtom, DoubleVector>,
    IDivisionOperators<ByteVector, LongVector, DoubleVector>, IDivisionOperators<ByteVector, FloatAtom, DoubleVector>,
    IDivisionOperators<ByteVector, FloatVector, DoubleVector>, IDivisionOperators<ByteVector, DoubleAtom, DoubleVector>,
    IDivisionOperators<ByteVector, DoubleVector, DoubleVector>,
    IDivisionOperators<ByteVector, TimestampAtom, DoubleVector>,
    IDivisionOperators<ByteVector, TimestampVector, DoubleVector>,
    IDivisionOperators<ByteVector, MonthAtom, DoubleVector>, IDivisionOperators<ByteVector, MonthVector, DoubleVector>,
    IDivisionOperators<ByteVector, DateAtom, DoubleVector>, IDivisionOperators<ByteVector, DateVector, DoubleVector>,
    IDivisionOperators<ByteVector, TimespanAtom, DoubleVector>,
    IDivisionOperators<ByteVector, TimespanVector, DoubleVector>,
    IDivisionOperators<ByteVector, MinuteAtom, DoubleVector>,
    IDivisionOperators<ByteVector, MinuteVector, DoubleVector>,
    IDivisionOperators<ByteVector, SecondAtom, DoubleVector>, IDivisionOperators<ByteVector, SecondVector, DoubleVector>
{
}
