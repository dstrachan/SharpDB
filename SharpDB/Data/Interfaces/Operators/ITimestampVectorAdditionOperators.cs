using System.Numerics;

namespace SharpDB.Data;

public interface ITimestampVectorAdditionOperators : IAdditionOperators<TimestampVector, ByteAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, ByteVector, TimestampVector>,
    IAdditionOperators<TimestampVector, ShortAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, ShortVector, TimestampVector>,
    IAdditionOperators<TimestampVector, IntAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, IntVector, TimestampVector>,
    IAdditionOperators<TimestampVector, LongAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, LongVector, TimestampVector>,
    IAdditionOperators<TimestampVector, FloatAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, FloatVector, TimestampVector>,
    IAdditionOperators<TimestampVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<TimestampVector, DoubleVector, DoubleVector>,
    IAdditionOperators<TimestampVector, TimestampAtom, TimespanVector>,
    IAdditionOperators<TimestampVector, TimestampVector, TimespanVector>,
    IAdditionOperators<TimestampVector, TimespanAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, TimespanVector, TimestampVector>,
    IAdditionOperators<TimestampVector, MinuteAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, MinuteVector, TimestampVector>,
    IAdditionOperators<TimestampVector, SecondAtom, TimestampVector>,
    IAdditionOperators<TimestampVector, SecondVector, TimestampVector>
{
}
