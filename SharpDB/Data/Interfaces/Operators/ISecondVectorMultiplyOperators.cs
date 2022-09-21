using System.Numerics;

namespace SharpDB.Data;

public interface ISecondVectorMultiplyOperators : IMultiplyOperators<SecondVector, ByteAtom, SecondVector>,
    IMultiplyOperators<SecondVector, ByteVector, SecondVector>,
    IMultiplyOperators<SecondVector, ShortAtom, SecondVector>,
    IMultiplyOperators<SecondVector, ShortVector, SecondVector>,
    IMultiplyOperators<SecondVector, IntAtom, SecondVector>, IMultiplyOperators<SecondVector, IntVector, SecondVector>,
    IMultiplyOperators<SecondVector, LongAtom, SecondVector>,
    IMultiplyOperators<SecondVector, LongVector, SecondVector>,
    IMultiplyOperators<SecondVector, FloatAtom, SecondVector>,
    IMultiplyOperators<SecondVector, FloatVector, SecondVector>,
    IMultiplyOperators<SecondVector, DoubleAtom, DoubleVector>,
    IMultiplyOperators<SecondVector, DoubleVector, DoubleVector>
{
}
