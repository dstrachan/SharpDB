using System.Numerics;

namespace SharpDB.Data;

public interface ISecondAtomAdditionOperators : IAdditionOperators<SecondAtom, ByteAtom, SecondAtom>,
    IAdditionOperators<SecondAtom, ByteVector, SecondVector>, IAdditionOperators<SecondAtom, ShortAtom, SecondAtom>,
    IAdditionOperators<SecondAtom, ShortVector, SecondVector>, IAdditionOperators<SecondAtom, IntAtom, SecondAtom>,
    IAdditionOperators<SecondAtom, IntVector, SecondVector>, IAdditionOperators<SecondAtom, LongAtom, SecondAtom>,
    IAdditionOperators<SecondAtom, LongVector, SecondVector>, IAdditionOperators<SecondAtom, FloatAtom, SecondAtom>,
    IAdditionOperators<SecondAtom, FloatVector, SecondVector>, IAdditionOperators<SecondAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<SecondAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<SecondAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<SecondAtom, TimestampVector, TimestampVector>,
    IAdditionOperators<SecondAtom, MonthAtom, TimestampAtom>,
    IAdditionOperators<SecondAtom, MonthVector, TimestampVector>,
    IAdditionOperators<SecondAtom, DateAtom, TimestampAtom>,
    IAdditionOperators<SecondAtom, DateVector, TimestampVector>,
    IAdditionOperators<SecondAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<SecondAtom, TimespanVector, TimespanVector>,
    IAdditionOperators<SecondAtom, MinuteAtom, SecondAtom>, IAdditionOperators<SecondAtom, MinuteVector, SecondVector>,
    IAdditionOperators<SecondAtom, SecondAtom, SecondAtom>, IAdditionOperators<SecondAtom, SecondVector, SecondVector>
{
}
