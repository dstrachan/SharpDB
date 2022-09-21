using System.Numerics;

namespace SharpDB.Data;

public interface IDateVectorMultiplyOperators : IMultiplyOperators<DateVector, ByteAtom, DateVector>,
    IMultiplyOperators<DateVector, ByteVector, DateVector>, IMultiplyOperators<DateVector, ShortAtom, DateVector>,
    IMultiplyOperators<DateVector, ShortVector, DateVector>, IMultiplyOperators<DateVector, IntAtom, DateVector>,
    IMultiplyOperators<DateVector, IntVector, DateVector>, IMultiplyOperators<DateVector, LongAtom, DateVector>,
    IMultiplyOperators<DateVector, LongVector, DateVector>, IMultiplyOperators<DateVector, FloatAtom, DateVector>,
    IMultiplyOperators<DateVector, FloatVector, DateVector>
{
}
