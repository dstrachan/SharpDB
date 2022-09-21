using System.Numerics;

namespace SharpDB.Data;

public interface ISecondAtomMultiplyOperators : IMultiplyOperators<SecondAtom, ByteAtom, SecondAtom>,
    IMultiplyOperators<SecondAtom, ByteVector, SecondVector>, IMultiplyOperators<SecondAtom, ShortAtom, SecondAtom>,
    IMultiplyOperators<SecondAtom, ShortVector, SecondVector>, IMultiplyOperators<SecondAtom, IntAtom, SecondAtom>,
    IMultiplyOperators<SecondAtom, IntVector, SecondVector>, IMultiplyOperators<SecondAtom, LongAtom, SecondAtom>,
    IMultiplyOperators<SecondAtom, LongVector, SecondVector>, IMultiplyOperators<SecondAtom, FloatAtom, SecondAtom>,
    IMultiplyOperators<SecondAtom, FloatVector, SecondVector>, IMultiplyOperators<SecondAtom, DoubleAtom, DoubleAtom>,
    IMultiplyOperators<SecondAtom, DoubleVector, DoubleVector>
{
}
