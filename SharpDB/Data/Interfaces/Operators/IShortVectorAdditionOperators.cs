using System.Numerics;

namespace SharpDB.Data;

public interface IShortVectorAdditionOperators : IAdditionOperators<ShortVector, ByteAtom, IntVector>,
    IAdditionOperators<ShortVector, ByteVector, IntVector>, IAdditionOperators<ShortVector, ShortAtom, IntVector>,
    IAdditionOperators<ShortVector, ShortVector, IntVector>, IAdditionOperators<ShortVector, IntAtom, IntVector>,
    IAdditionOperators<ShortVector, IntVector, IntVector>, IAdditionOperators<ShortVector, LongAtom, LongVector>,
    IAdditionOperators<ShortVector, LongVector, LongVector>, IAdditionOperators<ShortVector, FloatAtom, FloatVector>,
    IAdditionOperators<ShortVector, FloatVector, FloatVector>,
    IAdditionOperators<ShortVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<ShortVector, DoubleVector, DoubleVector>,
    IAdditionOperators<ShortVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<ShortVector, TimestampVector, TimestampVector>,
    IAdditionOperators<ShortVector, MonthAtom, MonthVector>, IAdditionOperators<ShortVector, MonthVector, MonthVector>,
    IAdditionOperators<ShortVector, DateAtom, DateVector>, IAdditionOperators<ShortVector, DateVector, DateVector>,
    IAdditionOperators<ShortVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<ShortVector, TimespanVector, TimespanVector>,
    IAdditionOperators<ShortVector, MinuteAtom, MinuteVector>,
    IAdditionOperators<ShortVector, MinuteVector, MinuteVector>,
    IAdditionOperators<ShortVector, SecondAtom, SecondVector>,
    IAdditionOperators<ShortVector, SecondVector, SecondVector>
{
}
