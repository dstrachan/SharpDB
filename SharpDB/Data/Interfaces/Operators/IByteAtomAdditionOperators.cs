using System.Numerics;

namespace SharpDB.Data;

public interface IByteAtomAdditionOperators : IAdditionOperators<ByteAtom, ByteAtom, IntAtom>,
    IAdditionOperators<ByteAtom, ByteVector, IntVector>, IAdditionOperators<ByteAtom, ShortAtom, IntAtom>,
    IAdditionOperators<ByteAtom, ShortVector, IntVector>, IAdditionOperators<ByteAtom, IntAtom, IntAtom>,
    IAdditionOperators<ByteAtom, IntVector, IntVector>, IAdditionOperators<ByteAtom, LongAtom, LongAtom>,
    IAdditionOperators<ByteAtom, LongVector, LongVector>, IAdditionOperators<ByteAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<ByteAtom, TimestampVector, TimestampVector>, IAdditionOperators<ByteAtom, MonthAtom, MonthAtom>,
    IAdditionOperators<ByteAtom, MonthVector, MonthVector>, IAdditionOperators<ByteAtom, DateAtom, DateAtom>,
    IAdditionOperators<ByteAtom, DateVector, DateVector>, IAdditionOperators<ByteAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<ByteAtom, TimespanVector, TimespanVector>, IAdditionOperators<ByteAtom, MinuteAtom, MinuteAtom>,
    IAdditionOperators<ByteAtom, MinuteVector, MinuteVector>, IAdditionOperators<ByteAtom, FloatAtom, FloatAtom>,
    IAdditionOperators<ByteAtom, FloatVector, FloatVector>, IAdditionOperators<ByteAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<ByteAtom, DoubleVector, DoubleVector>, IAdditionOperators<ByteAtom, SecondAtom, SecondAtom>,
    IAdditionOperators<ByteAtom, SecondVector, SecondVector>
{
}
