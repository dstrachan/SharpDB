using System.Numerics;

namespace SharpDB.Data;

public interface IMonthAtomMultiplyOperators : IMultiplyOperators<MonthAtom, ByteAtom, MonthAtom>,
    IMultiplyOperators<MonthAtom, ByteVector, MonthVector>, IMultiplyOperators<MonthAtom, ShortAtom, MonthAtom>,
    IMultiplyOperators<MonthAtom, ShortVector, MonthVector>, IMultiplyOperators<MonthAtom, IntAtom, MonthAtom>,
    IMultiplyOperators<MonthAtom, IntVector, MonthVector>, IMultiplyOperators<MonthAtom, LongAtom, MonthAtom>,
    IMultiplyOperators<MonthAtom, LongVector, MonthVector>, IMultiplyOperators<MonthAtom, FloatAtom, MonthAtom>,
    IMultiplyOperators<MonthAtom, FloatVector, MonthVector>, IMultiplyOperators<MonthAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<MonthAtom, DoubleVector, DoubleVector>
{
}
