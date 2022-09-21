using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteAtomAdditionOperators : IAdditionOperators<MinuteAtom, ByteAtom, MinuteAtom>,
    IAdditionOperators<MinuteAtom, ByteVector, MinuteVector>, IAdditionOperators<MinuteAtom, ShortAtom, MinuteAtom>,
    IAdditionOperators<MinuteAtom, ShortVector, MinuteVector>, IAdditionOperators<MinuteAtom, IntAtom, MinuteAtom>,
    IAdditionOperators<MinuteAtom, IntVector, MinuteVector>, IAdditionOperators<MinuteAtom, LongAtom, MinuteAtom>,
    IAdditionOperators<MinuteAtom, LongVector, MinuteVector>, IAdditionOperators<MinuteAtom, FloatAtom, MinuteAtom>,
    IAdditionOperators<MinuteAtom, FloatVector, MinuteVector>, IAdditionOperators<MinuteAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<MinuteAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<MinuteAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<MinuteAtom, TimestampVector, TimestampVector>,
    IAdditionOperators<MinuteAtom, MonthAtom, TimestampAtom>,
    IAdditionOperators<MinuteAtom, MonthVector, TimestampVector>,
    IAdditionOperators<MinuteAtom, DateAtom, TimestampAtom>,
    IAdditionOperators<MinuteAtom, DateVector, TimestampVector>,
    IAdditionOperators<MinuteAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<MinuteAtom, TimespanVector, TimespanVector>,
    IAdditionOperators<MinuteAtom, MinuteAtom, MinuteAtom>, IAdditionOperators<MinuteAtom, MinuteVector, MinuteVector>,
    IAdditionOperators<MinuteAtom, SecondAtom, SecondAtom>, IAdditionOperators<MinuteAtom, SecondVector, SecondVector>
{
}
