using System.Numerics;

namespace SharpDB.Data;

public interface ISecondVectorSubtractionOperators : ISubtractionOperators<SecondVector, ByteAtom, SecondVector>,
    ISubtractionOperators<SecondVector, ByteVector, SecondVector>,
    ISubtractionOperators<SecondVector, ShortAtom, SecondVector>,
    ISubtractionOperators<SecondVector, ShortVector, SecondVector>,
    ISubtractionOperators<SecondVector, IntAtom, SecondVector>, ISubtractionOperators<SecondVector, IntVector, SecondVector>,
    ISubtractionOperators<SecondVector, LongAtom, SecondVector>,
    ISubtractionOperators<SecondVector, LongVector, SecondVector>,
    ISubtractionOperators<SecondVector, FloatAtom, SecondVector>,
    ISubtractionOperators<SecondVector, FloatVector, SecondVector>,
    ISubtractionOperators<SecondVector, DoubleAtom, DoubleVector>,
    ISubtractionOperators<SecondVector, DoubleVector, DoubleVector>,
    ISubtractionOperators<SecondVector, TimestampAtom, TimestampVector>,
    ISubtractionOperators<SecondVector, TimestampVector, TimestampVector>,
    ISubtractionOperators<SecondVector, MonthAtom, TimestampVector>,
    ISubtractionOperators<SecondVector, MonthVector, TimestampVector>,
    ISubtractionOperators<SecondVector, DateAtom, TimestampVector>,
    ISubtractionOperators<SecondVector, DateVector, TimestampVector>,
    ISubtractionOperators<SecondVector, TimespanAtom, TimespanVector>,
    ISubtractionOperators<SecondVector, TimespanVector, TimespanVector>,
    ISubtractionOperators<SecondVector, MinuteAtom, SecondVector>,
    ISubtractionOperators<SecondVector, MinuteVector, SecondVector>,
    ISubtractionOperators<SecondVector, SecondAtom, SecondVector>,
    ISubtractionOperators<SecondVector, SecondVector, SecondVector>
{
}
