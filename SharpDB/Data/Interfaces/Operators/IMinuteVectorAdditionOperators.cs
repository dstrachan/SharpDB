using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteVectorAdditionOperators : IAdditionOperators<MinuteVector, ByteAtom, MinuteVector>,
    IAdditionOperators<MinuteVector, ByteVector, MinuteVector>,
    IAdditionOperators<MinuteVector, ShortAtom, MinuteVector>,
    IAdditionOperators<MinuteVector, ShortVector, MinuteVector>,
    IAdditionOperators<MinuteVector, IntAtom, MinuteVector>, IAdditionOperators<MinuteVector, IntVector, MinuteVector>,
    IAdditionOperators<MinuteVector, LongAtom, MinuteVector>,
    IAdditionOperators<MinuteVector, LongVector, MinuteVector>,
    IAdditionOperators<MinuteVector, FloatAtom, MinuteVector>,
    IAdditionOperators<MinuteVector, FloatVector, MinuteVector>,
    IAdditionOperators<MinuteVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<MinuteVector, DoubleVector, DoubleVector>,
    IAdditionOperators<MinuteVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<MinuteVector, TimestampVector, TimestampVector>,
    IAdditionOperators<MinuteVector, MonthAtom, TimestampVector>,
    IAdditionOperators<MinuteVector, MonthVector, TimestampVector>,
    IAdditionOperators<MinuteVector, DateAtom, TimestampVector>,
    IAdditionOperators<MinuteVector, DateVector, TimestampVector>,
    IAdditionOperators<MinuteVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<MinuteVector, TimespanVector, TimespanVector>,
    IAdditionOperators<MinuteVector, MinuteAtom, MinuteVector>,
    IAdditionOperators<MinuteVector, MinuteVector, MinuteVector>,
    IAdditionOperators<MinuteVector, SecondAtom, SecondVector>,
    IAdditionOperators<MinuteVector, SecondVector, SecondVector>
{
}
