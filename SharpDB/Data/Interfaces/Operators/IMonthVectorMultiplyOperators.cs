using System.Numerics;

namespace SharpDB.Data;

public interface IMonthVectorMultiplyOperators : IMultiplyOperators<MonthVector, ByteAtom, MonthVector>,
    IMultiplyOperators<MonthVector, ByteVector, MonthVector>, IMultiplyOperators<MonthVector, ShortAtom, MonthVector>,
    IMultiplyOperators<MonthVector, ShortVector, MonthVector>, IMultiplyOperators<MonthVector, IntAtom, MonthVector>,
    IMultiplyOperators<MonthVector, IntVector, MonthVector>, IMultiplyOperators<MonthVector, LongAtom, MonthVector>,
    IMultiplyOperators<MonthVector, LongVector, MonthVector>, IMultiplyOperators<MonthVector, FloatAtom, MonthVector>,
    IMultiplyOperators<MonthVector, FloatVector, MonthVector>,
    IMultiplyOperators<MonthVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<MonthVector, DoubleVector, DoubleVector>
{
}
