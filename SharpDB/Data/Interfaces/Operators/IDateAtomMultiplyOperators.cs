using System.Numerics;

namespace SharpDB.Data;

public interface IDateAtomMultiplyOperators : IMultiplyOperators<DateAtom, ByteAtom, DateAtom>,
    IMultiplyOperators<DateAtom, ByteVector, DateVector>, IMultiplyOperators<DateAtom, ShortAtom, DateAtom>,
    IMultiplyOperators<DateAtom, ShortVector, DateVector>, IMultiplyOperators<DateAtom, IntAtom, DateAtom>,
    IMultiplyOperators<DateAtom, IntVector, DateVector>, IMultiplyOperators<DateAtom, LongAtom, DateAtom>,
    IMultiplyOperators<DateAtom, LongVector, DateVector>, IMultiplyOperators<DateAtom, FloatAtom, DateAtom>,
    IMultiplyOperators<DateAtom, FloatVector, DateVector>
{
}
