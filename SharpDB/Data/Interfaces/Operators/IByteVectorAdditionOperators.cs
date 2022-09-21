using System.Numerics;

namespace SharpDB.Data;

public interface IByteVectorAdditionOperators : IAdditionOperators<ByteVector, ByteAtom, IntVector>,
    IAdditionOperators<ByteVector, ByteVector, IntVector>, IAdditionOperators<ByteVector, ShortAtom, IntVector>,
    IAdditionOperators<ByteVector, ShortVector, IntVector>, IAdditionOperators<ByteVector, IntAtom, IntVector>,
    IAdditionOperators<ByteVector, IntVector, IntVector>, IAdditionOperators<ByteVector, LongAtom, LongVector>,
    IAdditionOperators<ByteVector, LongVector, LongVector>,
    IAdditionOperators<ByteVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<ByteVector, TimestampVector, TimestampVector>,
    IAdditionOperators<ByteVector, MonthAtom, MonthVector>, IAdditionOperators<ByteVector, MonthVector, MonthVector>,
    IAdditionOperators<ByteVector, DateAtom, DateVector>, IAdditionOperators<ByteVector, DateVector, DateVector>,
    IAdditionOperators<ByteVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<ByteVector, TimespanVector, TimespanVector>,
    IAdditionOperators<ByteVector, MinuteAtom, MinuteVector>,
    IAdditionOperators<ByteVector, MinuteVector, MinuteVector>, IAdditionOperators<ByteVector, FloatAtom, FloatVector>,
    IAdditionOperators<ByteVector, FloatVector, FloatVector>, IAdditionOperators<ByteVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<ByteVector, DoubleVector, DoubleVector>,
    IAdditionOperators<ByteVector, SecondAtom, SecondVector>, IAdditionOperators<ByteVector, SecondVector, SecondVector>
{
}
