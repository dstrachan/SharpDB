using System.Numerics;

namespace SharpDB.Data;

public interface IShortAtomAdditionOperators : IAdditionOperators<ShortAtom, ByteAtom, IntAtom>,
    IAdditionOperators<ShortAtom, ByteVector, IntVector>, IAdditionOperators<ShortAtom, ShortAtom, IntAtom>,
    IAdditionOperators<ShortAtom, ShortVector, IntVector>, IAdditionOperators<ShortAtom, IntAtom, IntAtom>,
    IAdditionOperators<ShortAtom, IntVector, IntVector>, IAdditionOperators<ShortAtom, LongAtom, LongAtom>,
    IAdditionOperators<ShortAtom, LongVector, LongVector>, IAdditionOperators<ShortAtom, FloatAtom, FloatAtom>,
    IAdditionOperators<ShortAtom, FloatVector, FloatVector>, IAdditionOperators<ShortAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<ShortAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<ShortAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<ShortAtom, TimestampVector, TimestampVector>,
    IAdditionOperators<ShortAtom, MonthAtom, MonthAtom>, IAdditionOperators<ShortAtom, MonthVector, MonthVector>,
    IAdditionOperators<ShortAtom, DateAtom, DateAtom>, IAdditionOperators<ShortAtom, DateVector, DateVector>,
    IAdditionOperators<ShortAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<ShortAtom, TimespanVector, TimespanVector>,
    IAdditionOperators<ShortAtom, MinuteAtom, MinuteAtom>, IAdditionOperators<ShortAtom, MinuteVector, MinuteVector>,
    IAdditionOperators<ShortAtom, SecondAtom, SecondAtom>, IAdditionOperators<ShortAtom, SecondVector, SecondVector>
{
}
