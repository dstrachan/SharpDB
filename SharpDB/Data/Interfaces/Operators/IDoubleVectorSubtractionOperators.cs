using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleVectorSubtractionOperators : ISubtractionOperators<DoubleVector, ByteAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, ByteVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, ShortAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, ShortVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, IntAtom, DoubleVector>, ISubtractionOperators<DoubleVector, IntVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, LongAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, LongVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, FloatAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, FloatVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, TimestampAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, TimestampVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, MonthAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, MonthVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, TimespanAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, TimespanVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, MinuteAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, MinuteVector, DoubleVector>,
    ISubtractionOperators<DoubleVector, SecondAtom, DoubleVector>,
    ISubtractionOperators<DoubleVector, SecondVector, DoubleVector>
{
}
