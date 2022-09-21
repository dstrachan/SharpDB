using System.Numerics;

namespace SharpDB.Data;

public interface IDateVectorAdditionOperators : IAdditionOperators<DateVector, ByteAtom, DateVector>,
    IAdditionOperators<DateVector, ByteVector, DateVector>, IAdditionOperators<DateVector, ShortAtom, DateVector>,
    IAdditionOperators<DateVector, ShortVector, DateVector>, IAdditionOperators<DateVector, IntAtom, DateVector>,
    IAdditionOperators<DateVector, IntVector, DateVector>, IAdditionOperators<DateVector, LongAtom, DateVector>,
    IAdditionOperators<DateVector, LongVector, DateVector>, IAdditionOperators<DateVector, FloatAtom, DateVector>,
    IAdditionOperators<DateVector, FloatVector, DateVector>, IAdditionOperators<DateVector, DateAtom, IntVector>,
    IAdditionOperators<DateVector, DateVector, IntVector>,
    IAdditionOperators<DateVector, TimespanAtom, TimestampVector>,
    IAdditionOperators<DateVector, TimespanVector, TimestampVector>,
    IAdditionOperators<DateVector, MinuteAtom, TimestampVector>,
    IAdditionOperators<DateVector, MinuteVector, TimestampVector>,
    IAdditionOperators<DateVector, SecondAtom, TimestampVector>,
    IAdditionOperators<DateVector, SecondVector, TimestampVector>
{
}
