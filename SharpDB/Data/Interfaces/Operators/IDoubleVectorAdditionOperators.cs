using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleVectorAdditionOperators : IAdditionOperators<DoubleVector, ByteAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, ByteVector, DoubleVector>,
    IAdditionOperators<DoubleVector, ShortAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, ShortVector, DoubleVector>,
    IAdditionOperators<DoubleVector, IntAtom, DoubleVector>, IAdditionOperators<DoubleVector, IntVector, DoubleVector>,
    IAdditionOperators<DoubleVector, LongAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, LongVector, DoubleVector>,
    IAdditionOperators<DoubleVector, FloatAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, FloatVector, DoubleVector>,
    IAdditionOperators<DoubleVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, DoubleVector, DoubleVector>,
    IAdditionOperators<DoubleVector, TimestampAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, TimestampVector, DoubleVector>,
    IAdditionOperators<DoubleVector, MonthAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, MonthVector, DoubleVector>,
    IAdditionOperators<DoubleVector, TimespanAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, TimespanVector, DoubleVector>,
    IAdditionOperators<DoubleVector, MinuteAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, MinuteVector, DoubleVector>,
    IAdditionOperators<DoubleVector, SecondAtom, DoubleVector>,
    IAdditionOperators<DoubleVector, SecondVector, DoubleVector>
{
}
