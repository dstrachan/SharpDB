using System.Numerics;

namespace SharpDB.Data;

public interface IByteVectorSubtractionOperators : ISubtractionOperators<ByteVector, ByteAtom, IntVector>,
    ISubtractionOperators<ByteVector, ByteVector, IntVector>, ISubtractionOperators<ByteVector, ShortAtom, IntVector>,
    ISubtractionOperators<ByteVector, ShortVector, IntVector>, ISubtractionOperators<ByteVector, IntAtom, IntVector>,
    ISubtractionOperators<ByteVector, IntVector, IntVector>, ISubtractionOperators<ByteVector, LongAtom, LongVector>,
    ISubtractionOperators<ByteVector, LongVector, LongVector>,
    ISubtractionOperators<ByteVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<ByteVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<ByteVector, MonthAtom, MonthVector>, ISubtractionOperators<ByteVector, MonthVector, MonthVector>,
    ISubtractionOperators<ByteVector, DateAtom, DateVector>, ISubtractionOperators<ByteVector, DateVector, DateVector>,
    ISubtractionOperators<ByteVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<ByteVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<ByteVector, MinuteAtom, MinuteVector>,
    ISubtractionOperators<ByteVector, MinuteVector, MinuteVector>, ISubtractionOperators<ByteVector, FloatAtom, FloatVector>,
    ISubtractionOperators<ByteVector, FloatVector, FloatVector>, ISubtractionOperators<ByteVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<ByteVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<ByteVector, SecondAtom, SecondVector>, ISubtractionOperators<ByteVector, SecondVector, SecondVector>
{
}
