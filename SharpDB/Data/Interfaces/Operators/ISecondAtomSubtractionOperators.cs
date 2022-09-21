using System.Numerics;

namespace SharpDB.Data;

public interface ISecondAtomSubtractionOperators : ISubtractionOperators<SecondAtom, ByteAtom, SecondAtom>,
    ISubtractionOperators<SecondAtom, ByteVector, SecondVector>, ISubtractionOperators<SecondAtom, ShortAtom, SecondAtom>,
    ISubtractionOperators<SecondAtom, ShortVector, SecondVector>, ISubtractionOperators<SecondAtom, IntAtom, SecondAtom>,
    ISubtractionOperators<SecondAtom, IntVector, SecondVector>, ISubtractionOperators<SecondAtom, LongAtom, SecondAtom>,
    ISubtractionOperators<SecondAtom, LongVector, SecondVector>, ISubtractionOperators<SecondAtom, FloatAtom, SecondAtom>,
    ISubtractionOperators<SecondAtom, FloatVector, SecondVector>, ISubtractionOperators<SecondAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<SecondAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<SecondAtom, TimestampAtom, TimestampAtom>,
    ISubtractionOperators<SecondAtom, TimestampVector, TimestampVector>,
    ISubtractionOperators<SecondAtom, MonthAtom, TimestampAtom>,
    ISubtractionOperators<SecondAtom, MonthVector, TimestampVector>,
    ISubtractionOperators<SecondAtom, DateAtom, TimestampAtom>,
    ISubtractionOperators<SecondAtom, DateVector, TimestampVector>,
    ISubtractionOperators<SecondAtom, TimespanAtom, TimespanAtom>,
    ISubtractionOperators<SecondAtom, TimespanVector, TimespanVector>,
    ISubtractionOperators<SecondAtom, MinuteAtom, SecondAtom>, ISubtractionOperators<SecondAtom, MinuteVector, SecondVector>,
    ISubtractionOperators<SecondAtom, SecondAtom, SecondAtom>, ISubtractionOperators<SecondAtom, SecondVector, SecondVector>
{
}
