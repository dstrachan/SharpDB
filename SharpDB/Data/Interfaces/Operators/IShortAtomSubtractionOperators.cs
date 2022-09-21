using System.Numerics;

namespace SharpDB.Data;

public interface IShortAtomSubtractionOperators : ISubtractionOperators<ShortAtom, ByteAtom, IntAtom>,
    ISubtractionOperators<ShortAtom, ByteVector, IntVector>, ISubtractionOperators<ShortAtom, ShortAtom, IntAtom>,
    ISubtractionOperators<ShortAtom, ShortVector, IntVector>, ISubtractionOperators<ShortAtom, IntAtom, IntAtom>,
    ISubtractionOperators<ShortAtom, IntVector, IntVector>, ISubtractionOperators<ShortAtom, LongAtom, LongAtom>,
    ISubtractionOperators<ShortAtom, LongVector, LongVector>, ISubtractionOperators<ShortAtom, FloatAtom, FloatAtom>,
    ISubtractionOperators<ShortAtom, FloatVector, FloatVector>, ISubtractionOperators<ShortAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<ShortAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<ShortAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<ShortAtom, TimestampVector, TimestampVector>,
    ISubtractionOperators<ShortAtom, MonthAtom, MonthAtom>, ISubtractionOperators<ShortAtom, MonthVector, MonthVector>,
    ISubtractionOperators<ShortAtom, DateAtom, DateAtom>, ISubtractionOperators<ShortAtom, DateVector, DateVector>,
    ISubtractionOperators<ShortAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<ShortAtom, TimespanVector, TimespanVector>,
    ISubtractionOperators<ShortAtom, MinuteAtom, MinuteAtom>, ISubtractionOperators<ShortAtom, MinuteVector, MinuteVector>,
    ISubtractionOperators<ShortAtom, SecondAtom, SecondAtom>, ISubtractionOperators<ShortAtom, SecondVector, SecondVector>
{
}
