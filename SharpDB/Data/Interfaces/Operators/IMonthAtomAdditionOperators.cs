using System.Numerics;

namespace SharpDB.Data;

public interface IMonthAtomAdditionOperators : IAdditionOperators<MonthAtom, ByteAtom, MonthAtom>,
    IAdditionOperators<MonthAtom, ByteVector, MonthVector>, IAdditionOperators<MonthAtom, ShortAtom, MonthAtom>,
    IAdditionOperators<MonthAtom, ShortVector, MonthVector>, IAdditionOperators<MonthAtom, IntAtom, MonthAtom>,
    IAdditionOperators<MonthAtom, IntVector, MonthVector>, IAdditionOperators<MonthAtom, LongAtom, MonthAtom>,
    IAdditionOperators<MonthAtom, LongVector, MonthVector>, IAdditionOperators<MonthAtom, FloatAtom, MonthAtom>,
    IAdditionOperators<MonthAtom, FloatVector, MonthVector>, IAdditionOperators<MonthAtom, DoubleAtom, DoubleAtom>,
    IAdditionOperators<MonthAtom, DoubleVector, DoubleVector>, IAdditionOperators<MonthAtom, MonthAtom, IntAtom>,
    IAdditionOperators<MonthAtom, MonthVector, IntVector>, IAdditionOperators<MonthAtom, TimespanAtom, TimestampAtom>,
    IAdditionOperators<MonthAtom, TimespanVector, TimestampVector>,
    IAdditionOperators<MonthAtom, MinuteAtom, TimestampAtom>,
    IAdditionOperators<MonthAtom, MinuteVector, TimestampVector>,
    IAdditionOperators<MonthAtom, SecondAtom, TimestampAtom>,
    IAdditionOperators<MonthAtom, SecondVector, TimestampVector>
{
}
