using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampAtomAdditionOperators : IAdditionOperators<TimestampAtom, ByteAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, ByteVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, ShortAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, ShortVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, IntAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, IntVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, LongAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, LongVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, FloatAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, FloatVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<TimestampAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<TimestampAtom, TimestampAtom, TimespanAtom>,
    IAdditionOperators<TimestampAtom, TimestampVector, TimespanVector>,
    IAdditionOperators<TimestampAtom, TimespanAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, TimespanVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, MinuteAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, MinuteVector, TimestampVector>,
    IAdditionOperators<TimestampAtom, SecondAtom, TimestampAtom>,
    IAdditionOperators<TimestampAtom, SecondVector, TimestampVector>
{
}
