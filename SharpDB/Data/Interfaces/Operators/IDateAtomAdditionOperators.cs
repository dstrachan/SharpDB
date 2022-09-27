using System.Numerics;

namespace SharpDB.Data;

public interface IDateAtomAdditionOperators : IAdditionOperators<DateAtom, ByteAtom, DateAtom>,
    IAdditionOperators<DateAtom, ByteVector, DateVector>, IAdditionOperators<DateAtom, ShortAtom, DateAtom>,
    IAdditionOperators<DateAtom, ShortVector, DateVector>, IAdditionOperators<DateAtom, IntAtom, DateAtom>,
    IAdditionOperators<DateAtom, IntVector, DateVector>, IAdditionOperators<DateAtom, LongAtom, DateAtom>,
    IAdditionOperators<DateAtom, LongVector, DateVector>, IAdditionOperators<DateAtom, DateAtom, IntAtom>,
    IAdditionOperators<DateAtom, DateVector, IntVector>, IAdditionOperators<DateAtom, TimespanAtom, TimestampAtom>,
    IAdditionOperators<DateAtom, TimespanVector, TimestampVector>,
    IAdditionOperators<DateAtom, MinuteAtom, TimestampAtom>,
    IAdditionOperators<DateAtom, MinuteVector, TimestampVector>,
    IAdditionOperators<DateAtom, SecondAtom, TimestampAtom>, IAdditionOperators<DateAtom, SecondVector, TimestampVector>
{
}
