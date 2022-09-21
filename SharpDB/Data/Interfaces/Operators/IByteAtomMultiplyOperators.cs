using System.Numerics;

namespace SharpDB.Data;

public interface IByteAtomMultiplyOperators : IMultiplyOperators<ByteAtom, ByteAtom, IntAtom>,
    IMultiplyOperators<ByteAtom, ByteVector, IntVector>, IMultiplyOperators<ByteAtom, ShortAtom, IntAtom>,
    IMultiplyOperators<ByteAtom, ShortVector, IntVector>, IMultiplyOperators<ByteAtom, IntAtom, IntAtom>,
    IMultiplyOperators<ByteAtom, IntVector, IntVector>, IMultiplyOperators<ByteAtom, LongAtom, LongAtom>,
    IMultiplyOperators<ByteAtom, LongVector, LongVector>, IMultiplyOperators<ByteAtom, FloatAtom, FloatAtom>,
    IMultiplyOperators<ByteAtom, FloatVector, FloatVector>, IMultiplyOperators<ByteAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<ByteAtom, DoubleVector, DoubleVector>,
    IMultiplyOperators<ByteAtom, TimestampAtom, TimestampAtom>,
    IMultiplyOperators<ByteAtom, TimestampVector, TimestampVector>, IMultiplyOperators<ByteAtom, MonthAtom, MonthAtom>,
    IMultiplyOperators<ByteAtom, MonthVector, MonthVector>, IMultiplyOperators<ByteAtom, DateAtom, DateAtom>,
    IMultiplyOperators<ByteAtom, DateVector, DateVector>, IMultiplyOperators<ByteAtom, TimespanAtom, TimespanAtom>,
    IMultiplyOperators<ByteAtom, TimespanVector, TimespanVector>, IMultiplyOperators<ByteAtom, MinuteAtom, MinuteAtom>,
    IMultiplyOperators<ByteAtom, MinuteVector, MinuteVector>, IMultiplyOperators<ByteAtom, SecondAtom, SecondAtom>,
    IMultiplyOperators<ByteAtom, SecondVector, SecondVector>
{
}
