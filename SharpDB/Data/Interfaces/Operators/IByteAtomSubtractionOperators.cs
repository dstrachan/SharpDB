using System.Numerics;

namespace SharpDB.Data;

public interface IByteAtomSubtractionOperators : ISubtractionOperators<ByteAtom, ByteAtom, IntAtom>,
    ISubtractionOperators<ByteAtom, ByteVector, IntVector>, ISubtractionOperators<ByteAtom, ShortAtom, IntAtom>,
    ISubtractionOperators<ByteAtom, ShortVector, IntVector>, ISubtractionOperators<ByteAtom, IntAtom, IntAtom>,
    ISubtractionOperators<ByteAtom, IntVector, IntVector>, ISubtractionOperators<ByteAtom, LongAtom, LongAtom>,
    ISubtractionOperators<ByteAtom, LongVector, LongVector>, ISubtractionOperators<ByteAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<ByteAtom, TimestampVector, TimestampVector>, ISubtractionOperators<ByteAtom, MonthAtom, MonthAtom>,
    ISubtractionOperators<ByteAtom, MonthVector, MonthVector>, ISubtractionOperators<ByteAtom, DateAtom, DateAtom>,
    ISubtractionOperators<ByteAtom, DateVector, DateVector>, ISubtractionOperators<ByteAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<ByteAtom, TimespanVector, TimespanVector>, ISubtractionOperators<ByteAtom, MinuteAtom, MinuteAtom>,
    ISubtractionOperators<ByteAtom, MinuteVector, MinuteVector>, ISubtractionOperators<ByteAtom, FloatAtom, FloatAtom>,
    ISubtractionOperators<ByteAtom, FloatVector, FloatVector>, ISubtractionOperators<ByteAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<ByteAtom, DoubleVector, DoubleVector>, ISubtractionOperators<ByteAtom, SecondAtom, SecondAtom>,
    ISubtractionOperators<ByteAtom, SecondVector, SecondVector>
{
}
