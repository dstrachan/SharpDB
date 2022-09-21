using System.Numerics;

namespace SharpDB.Data;

public interface IDoubleAtomSubtractionOperators : ISubtractionOperators<DoubleAtom, ByteAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, ByteVector, DoubleVector>, ISubtractionOperators<DoubleAtom, ShortAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, ShortVector, DoubleVector>, ISubtractionOperators<DoubleAtom, IntAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, IntVector, DoubleVector>, ISubtractionOperators<DoubleAtom, LongAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, LongVector, DoubleVector>, ISubtractionOperators<DoubleAtom, FloatAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, FloatVector, DoubleVector>, ISubtractionOperators<DoubleAtom, DoubleAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, DoubleVector, DoubleVector>,
    ISubtractionOperators<DoubleAtom, TimestampAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, TimestampVector, DoubleVector>,
    ISubtractionOperators<DoubleAtom, MonthAtom, DoubleAtom>, ISubtractionOperators<DoubleAtom, MonthVector, DoubleVector>,
    ISubtractionOperators<DoubleAtom, TimespanAtom, DoubleAtom>,
    ISubtractionOperators<DoubleAtom, TimespanVector, DoubleVector>,
    ISubtractionOperators<DoubleAtom, MinuteAtom, DoubleAtom>, ISubtractionOperators<DoubleAtom, MinuteVector, DoubleVector>,
    ISubtractionOperators<DoubleAtom, SecondAtom, DoubleAtom>, ISubtractionOperators<DoubleAtom, SecondVector, DoubleVector>
{
}
