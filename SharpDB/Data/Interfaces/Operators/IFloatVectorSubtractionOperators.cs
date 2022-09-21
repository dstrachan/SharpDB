using System.Numerics;

namespace SharpDB.Data;

public interface IFloatVectorSubtractionOperators : ISubtractionOperators<FloatVector, ByteAtom, FloatVector>,
    ISubtractionOperators<FloatVector, ByteVector, FloatVector>, ISubtractionOperators<FloatVector, ShortAtom, FloatVector>,
    ISubtractionOperators<FloatVector, ShortVector, FloatVector>, ISubtractionOperators<FloatVector, IntAtom, FloatVector>,
    ISubtractionOperators<FloatVector, IntVector, FloatVector>, ISubtractionOperators<FloatVector, LongAtom, FloatVector>,
    ISubtractionOperators<FloatVector, LongVector, FloatVector>, ISubtractionOperators<FloatVector, FloatAtom, FloatVector>,
    ISubtractionOperators<FloatVector, FloatVector, FloatVector>,
    ISubtractionOperators<FloatVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<FloatVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<FloatVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<FloatVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<FloatVector, MonthAtom, MonthVector>, ISubtractionOperators<FloatVector, MonthVector, MonthVector>,
    ISubtractionOperators<FloatVector, DateAtom, DateVector>, ISubtractionOperators<FloatVector, DateVector, DateVector>,
    ISubtractionOperators<FloatVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<FloatVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<FloatVector, MinuteAtom, MinuteVector>,
    ISubtractionOperators<FloatVector, MinuteVector, MinuteVector>,
    ISubtractionOperators<FloatVector, SecondAtom, SecondVector>,
    ISubtractionOperators<FloatVector, SecondVector, SecondVector>
{
}
