using System.Numerics;

namespace SharpDB.Data;

public interface IFloatAtomSubtractionOperators : ISubtractionOperators<FloatAtom, ByteAtom, FloatAtom>,
    ISubtractionOperators<FloatAtom, ByteVector, FloatVector>, ISubtractionOperators<FloatAtom, ShortAtom, FloatAtom>,
    ISubtractionOperators<FloatAtom, ShortVector, FloatVector>, ISubtractionOperators<FloatAtom, IntAtom, FloatAtom>,
    ISubtractionOperators<FloatAtom, IntVector, FloatVector>, ISubtractionOperators<FloatAtom, LongAtom, FloatAtom>,
    ISubtractionOperators<FloatAtom, LongVector, FloatVector>, ISubtractionOperators<FloatAtom, FloatAtom, FloatAtom>,
    ISubtractionOperators<FloatAtom, FloatVector, FloatVector>, ISubtractionOperators<FloatAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<FloatAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<FloatAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<FloatAtom, TimestampVector, TimestampVector>,
    ISubtractionOperators<FloatAtom, MonthAtom, MonthAtom>, ISubtractionOperators<FloatAtom, MonthVector, MonthVector>,
    ISubtractionOperators<FloatAtom, DateAtom, DateAtom>, ISubtractionOperators<FloatAtom, DateVector, DateVector>,
    ISubtractionOperators<FloatAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<FloatAtom, TimespanVector, TimespanVector>,
    ISubtractionOperators<FloatAtom, MinuteAtom, MinuteAtom>, ISubtractionOperators<FloatAtom, MinuteVector, MinuteVector>,
    ISubtractionOperators<FloatAtom, SecondAtom, SecondAtom>, ISubtractionOperators<FloatAtom, SecondVector, SecondVector>
{
}
