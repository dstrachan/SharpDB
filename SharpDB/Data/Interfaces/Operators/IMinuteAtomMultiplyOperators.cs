using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteAtomMultiplyOperators : IMultiplyOperators<MinuteAtom, ByteAtom, MinuteAtom>,
    IMultiplyOperators<MinuteAtom, ByteVector, MinuteVector>, IMultiplyOperators<MinuteAtom, ShortAtom, MinuteAtom>,
    IMultiplyOperators<MinuteAtom, ShortVector, MinuteVector>, IMultiplyOperators<MinuteAtom, IntAtom, MinuteAtom>,
    IMultiplyOperators<MinuteAtom, IntVector, MinuteVector>, IMultiplyOperators<MinuteAtom, LongAtom, MinuteAtom>,
    IMultiplyOperators<MinuteAtom, LongVector, MinuteVector>, IMultiplyOperators<MinuteAtom, FloatAtom, MinuteAtom>,
    IMultiplyOperators<MinuteAtom, FloatVector, MinuteVector>, IMultiplyOperators<MinuteAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<MinuteAtom, DoubleVector, DoubleVector>
{
}
