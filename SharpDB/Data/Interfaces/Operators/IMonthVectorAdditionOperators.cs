using System.Numerics;

namespace SharpDB.Data;

public interface IMonthVectorAdditionOperators : IAdditionOperators<MonthVector, ByteAtom, MonthVector>,
    IAdditionOperators<MonthVector, ByteVector, MonthVector>, IAdditionOperators<MonthVector, ShortAtom, MonthVector>,
    IAdditionOperators<MonthVector, ShortVector, MonthVector>, IAdditionOperators<MonthVector, IntAtom, MonthVector>,
    IAdditionOperators<MonthVector, IntVector, MonthVector>, IAdditionOperators<MonthVector, LongAtom, MonthVector>,
    IAdditionOperators<MonthVector, LongVector, MonthVector>, IAdditionOperators<MonthVector, FloatAtom, MonthVector>,
    IAdditionOperators<MonthVector, FloatVector, MonthVector>,
    IAdditionOperators<MonthVector, DoubleAtom, DoubleVector>,
    IAdditionOperators<MonthVector, DoubleVector, DoubleVector>, IAdditionOperators<MonthVector, MonthAtom, IntVector>,
    IAdditionOperators<MonthVector, MonthVector, IntVector>,
    IAdditionOperators<MonthVector, TimespanAtom, TimestampVector>,
    IAdditionOperators<MonthVector, TimespanVector, TimestampVector>,
    IAdditionOperators<MonthVector, MinuteAtom, TimestampVector>,
    IAdditionOperators<MonthVector, MinuteVector, TimestampVector>,
    IAdditionOperators<MonthVector, SecondAtom, TimestampVector>,
    IAdditionOperators<MonthVector, SecondVector, TimestampVector>
{
}
