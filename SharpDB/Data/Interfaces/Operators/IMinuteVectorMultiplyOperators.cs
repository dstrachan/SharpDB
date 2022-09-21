using System.Numerics;

namespace SharpDB.Data;

public interface IMinuteVectorMultiplyOperators : IMultiplyOperators<MinuteVector, ByteAtom, MinuteVector>,
    IMultiplyOperators<MinuteVector, ByteVector, MinuteVector>,
    IMultiplyOperators<MinuteVector, ShortAtom, MinuteVector>,
    IMultiplyOperators<MinuteVector, ShortVector, MinuteVector>,
    IMultiplyOperators<MinuteVector, IntAtom, MinuteVector>, IMultiplyOperators<MinuteVector, IntVector, MinuteVector>,
    IMultiplyOperators<MinuteVector, LongAtom, MinuteVector>,
    IMultiplyOperators<MinuteVector, LongVector, MinuteVector>,
    IMultiplyOperators<MinuteVector, FloatAtom, MinuteVector>,
    IMultiplyOperators<MinuteVector, FloatVector, MinuteVector>,
    IMultiplyOperators<MinuteVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<MinuteVector, DoubleVector, DoubleVector>
{
}
