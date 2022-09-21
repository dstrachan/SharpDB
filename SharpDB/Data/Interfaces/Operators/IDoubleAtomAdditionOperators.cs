using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleAtomAdditionOperators : IAdditionOperators<DoubleAtom, ByteAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, ByteVector, DoubleVector>, IAdditionOperators<DoubleAtom, ShortAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, ShortVector, DoubleVector>, IAdditionOperators<DoubleAtom, IntAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, IntVector, DoubleVector>, IAdditionOperators<DoubleAtom, LongAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, LongVector, DoubleVector>, IAdditionOperators<DoubleAtom, FloatAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, FloatVector, DoubleVector>, IAdditionOperators<DoubleAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, DoubleVector, DoubleVector>,
    IAdditionOperators<DoubleAtom, TimestampAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, TimestampVector, DoubleVector>,
    IAdditionOperators<DoubleAtom, MonthAtom, DoubleAtom>, IAdditionOperators<DoubleAtom, MonthVector, DoubleVector>,
    IAdditionOperators<DoubleAtom, TimespanAtom, DoubleAtom>,
    IAdditionOperators<DoubleAtom, TimespanVector, DoubleVector>,
    IAdditionOperators<DoubleAtom, MinuteAtom, DoubleAtom>, IAdditionOperators<DoubleAtom, MinuteVector, DoubleVector>,
    IAdditionOperators<DoubleAtom, SecondAtom, DoubleAtom>, IAdditionOperators<DoubleAtom, SecondVector, DoubleVector>
{
}
