using System.Numerics;

namespace SharpDB.Data;

public interface ISecondVectorAdditionOperators : IAdditionOperators<SecondVector, ByteAtom, SecondVector>,
    IAdditionOperators<SecondVector, ByteVector, SecondVector>,
    IAdditionOperators<SecondVector, ShortAtom, SecondVector>,
    IAdditionOperators<SecondVector, ShortVector, SecondVector>,
    IAdditionOperators<SecondVector, IntAtom, SecondVector>, IAdditionOperators<SecondVector, IntVector, SecondVector>,
    IAdditionOperators<SecondVector, LongAtom, SecondVector>,
    IAdditionOperators<SecondVector, LongVector, SecondVector>,
    IAdditionOperators<SecondVector, FloatAtom, SecondVector>,
    IAdditionOperators<SecondVector, FloatVector, SecondVector>,
    IAdditionOperators<SecondVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<SecondVector, DoubleVector, DoubleVector>,
    IAdditionOperators<SecondVector, TimestampAtom, TimestampVector>,
    IAdditionOperators<SecondVector, TimestampVector, TimestampVector>,
    IAdditionOperators<SecondVector, MonthAtom, TimestampVector>,
    IAdditionOperators<SecondVector, MonthVector, TimestampVector>,
    IAdditionOperators<SecondVector, DateAtom, TimestampVector>,
    IAdditionOperators<SecondVector, DateVector, TimestampVector>,
    IAdditionOperators<SecondVector, TimespanAtom, TimespanVector>,
    IAdditionOperators<SecondVector, TimespanVector, TimespanVector>,
    IAdditionOperators<SecondVector, MinuteAtom, SecondVector>,
    IAdditionOperators<SecondVector, MinuteVector, SecondVector>,
    IAdditionOperators<SecondVector, SecondAtom, SecondVector>,
    IAdditionOperators<SecondVector, SecondVector, SecondVector>
{
}
