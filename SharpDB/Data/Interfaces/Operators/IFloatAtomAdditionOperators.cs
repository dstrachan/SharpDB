using System.Numerics;

namespace SharpDB.Data;

public interface IFloatAtomAdditionOperators : IAdditionOperators<FloatAtom, ByteAtom, FloatAtom>,
    IAdditionOperators<FloatAtom, ByteVector, FloatVector>, IAdditionOperators<FloatAtom, ShortAtom, FloatAtom>,
    IAdditionOperators<FloatAtom, ShortVector, FloatVector>, IAdditionOperators<FloatAtom, IntAtom, FloatAtom>,
    IAdditionOperators<FloatAtom, IntVector, FloatVector>, IAdditionOperators<FloatAtom, LongAtom, FloatAtom>,
    IAdditionOperators<FloatAtom, LongVector, FloatVector>, IAdditionOperators<FloatAtom, FloatAtom, FloatAtom>,
    IAdditionOperators<FloatAtom, FloatVector, FloatVector>, IAdditionOperators<FloatAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<FloatAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<FloatAtom, TimestampAtom, TimestampAtom>,
    IAdditionOperators<FloatAtom, TimestampVector, TimestampVector>,
    IAdditionOperators<FloatAtom, MonthAtom, MonthAtom>, IAdditionOperators<FloatAtom, MonthVector, MonthVector>,
    IAdditionOperators<FloatAtom, TimespanAtom, TimespanAtom>,
    IAdditionOperators<FloatAtom, TimespanVector, TimespanVector>,
    IAdditionOperators<FloatAtom, MinuteAtom, MinuteAtom>, IAdditionOperators<FloatAtom, MinuteVector, MinuteVector>,
    IAdditionOperators<FloatAtom, SecondAtom, SecondAtom>, IAdditionOperators<FloatAtom, SecondVector, SecondVector>
{
}
