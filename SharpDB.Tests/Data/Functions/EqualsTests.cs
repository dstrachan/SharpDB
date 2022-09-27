// using System.Numerics;
// using SharpDB.Data;
//
// namespace SharpDB.Tests.Data.Functions;
//
// public class EqualsTests
// {
//     private static void Equals<T1, T2, T3>(T1 left, T2 right)
//         where T1 : IEqualityOperators<T1, T2, T3>
//         where T2 : IEqualityOperators<T2, T1, T3>
//     {
//         var result1 = left == right;
//         var result2 = left != right;
//         var result3 = right == left;
//         var result4 = right != left;
//         Assert.That(result1, Is.TypeOf<T3>());
//         Assert.That(result2, Is.TypeOf<T3>());
//         Assert.That(result3, Is.TypeOf<T3>());
//         Assert.That(result4, Is.TypeOf<T3>());
//     }
//
//     private readonly BooleanAtom _booleanAtom = new(true);
//     private readonly BooleanVector _booleanVector = new(new[] { false, true });
//     private readonly GuidAtom _guidAtom = new(Guid.Empty);
//     private readonly GuidVector _guidVector = new(new[] { Guid.Empty, Guid.Empty });
//     private readonly ByteAtom _byteAtom = new(1);
//     private readonly ByteVector _byteVector = new(new byte[] { 0, 1 });
//     private readonly ShortAtom _shortAtom = new(1);
//     private readonly ShortVector _shortVector = new(new short[] { 0, 1 });
//     private readonly IntAtom _intAtom = new(1);
//     private readonly IntVector _intVector = new(new[] { 0, 1 });
//     private readonly LongAtom _longAtom = new(1);
//     private readonly LongVector _longVector = new(new long[] { 0, 1 });
//     private readonly FloatAtom _floatAtom = new(1);
//     private readonly FloatVector _floatVector = new(new float[] { 0, 1 });
//     private readonly DoubleAtom _doubleAtom = new(1);
//     private readonly DoubleVector _doubleVector = new(new double[] { 0, 1 });
//     private readonly CharAtom _charAtom = new('a');
//     private readonly CharVector _charVector = new(new[] { 'a', 'b' });
//     private readonly SymbolAtom _symbolAtom = new("a");
//     private readonly SymbolVector _symbolVector = new(new[] { "a", "b" });
//     private readonly TimestampAtom _timestampAtom = new(1);
//     private readonly TimestampVector _timestampVector = new(new long[] { 0, 1 });
//     private readonly MonthAtom _monthAtom = new(1);
//     private readonly MonthVector _monthVector = new(new[] { 0, 1 });
//     private readonly DateAtom _dateAtom = new(1);
//     private readonly DateVector _dateVector = new(new[] { 0, 1 });
//     private readonly TimespanAtom _timespanAtom = new(1);
//     private readonly TimespanVector _timespanVector = new(new long[] { 0, 1 });
//     private readonly MinuteAtom _minuteAtom = new(1);
//     private readonly MinuteVector _minuteVector = new(new[] { 0, 1 });
//     private readonly SecondAtom _secondAtom = new(1);
//     private readonly SecondVector _secondVector = new(new[] { 0, 1 });
//
//     [Test]
//     public void BooleanEqualsBooleanReturnsCorrectTypes()
//     {
//         Equals<BooleanAtom, BooleanAtom, BooleanAtom>(_booleanAtom, _booleanAtom);
//         Equals<BooleanAtom, BooleanVector, BooleanVector>(_booleanAtom, _booleanVector);
//         Equals<BooleanVector, BooleanAtom, BooleanVector>(_booleanVector, _booleanAtom);
//         Equals<BooleanVector, BooleanVector, BooleanVector>(_booleanVector, _booleanVector);
//     }
//
//     [Test]
//     public void GuidEqualsGuidReturnsCorrectTypes()
//     {
//         Equals<GuidAtom, GuidAtom, BooleanAtom>(_guidAtom, _guidAtom);
//         Equals<GuidAtom, GuidVector, BooleanVector>(_guidAtom, _guidVector);
//         Equals<GuidVector, GuidAtom, BooleanVector>(_guidVector, _guidAtom);
//         Equals<GuidVector, GuidVector, BooleanVector>(_guidVector, _guidVector);
//     }
//
//     [Test]
//     public void ByteEqualsByteReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, ByteAtom, BooleanAtom>(_byteAtom, _byteAtom);
//         Equals<ByteAtom, ByteVector, BooleanVector>(_byteAtom, _byteVector);
//         Equals<ByteVector, ByteAtom, BooleanVector>(_byteVector, _byteAtom);
//         Equals<ByteVector, ByteVector, BooleanVector>(_byteVector, _byteVector);
//     }
//
//     [Test]
//     public void ByteEqualsShortReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, ShortAtom, BooleanAtom>(_byteAtom, _shortAtom);
//         Equals<ByteAtom, ShortVector, BooleanVector>(_byteAtom, _shortVector);
//         Equals<ByteVector, ShortAtom, BooleanVector>(_byteVector, _shortAtom);
//         Equals<ByteVector, ShortVector, BooleanVector>(_byteVector, _shortVector);
//     }
//
//     [Test]
//     public void ByteEqualsIntReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, IntAtom, BooleanAtom>(_byteAtom, _intAtom);
//         Equals<ByteAtom, IntVector, BooleanVector>(_byteAtom, _intVector);
//         Equals<ByteVector, IntAtom, BooleanVector>(_byteVector, _intAtom);
//         Equals<ByteVector, IntVector, BooleanVector>(_byteVector, _intVector);
//     }
//
//     [Test]
//     public void ByteEqualsLongReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, LongAtom, BooleanAtom>(_byteAtom, _longAtom);
//         Equals<ByteAtom, LongVector, BooleanVector>(_byteAtom, _longVector);
//         Equals<ByteVector, LongAtom, BooleanVector>(_byteVector, _longAtom);
//         Equals<ByteVector, LongVector, BooleanVector>(_byteVector, _longVector);
//     }
//
//     [Test]
//     public void ByteEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, FloatAtom, BooleanAtom>(_byteAtom, _floatAtom);
//         Equals<ByteAtom, FloatVector, BooleanVector>(_byteAtom, _floatVector);
//         Equals<ByteVector, FloatAtom, BooleanVector>(_byteVector, _floatAtom);
//         Equals<ByteVector, FloatVector, BooleanVector>(_byteVector, _floatVector);
//     }
//
//     [Test]
//     public void ByteEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, DoubleAtom, BooleanAtom>(_byteAtom, _doubleAtom);
//         Equals<ByteAtom, DoubleVector, BooleanVector>(_byteAtom, _doubleVector);
//         Equals<ByteVector, DoubleAtom, BooleanVector>(_byteVector, _doubleAtom);
//         Equals<ByteVector, DoubleVector, BooleanVector>(_byteVector, _doubleVector);
//     }
//
//     [Test]
//     public void ByteEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, TimestampAtom, BooleanAtom>(_byteAtom, _timestampAtom);
//         Equals<ByteAtom, TimestampVector, BooleanVector>(_byteAtom, _timestampVector);
//         Equals<ByteVector, TimestampAtom, BooleanVector>(_byteVector, _timestampAtom);
//         Equals<ByteVector, TimestampVector, BooleanVector>(_byteVector, _timestampVector);
//     }
//
//     [Test]
//     public void ByteEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, MonthAtom, BooleanAtom>(_byteAtom, _monthAtom);
//         Equals<ByteAtom, MonthVector, BooleanVector>(_byteAtom, _monthVector);
//         Equals<ByteVector, MonthAtom, BooleanVector>(_byteVector, _monthAtom);
//         Equals<ByteVector, MonthVector, BooleanVector>(_byteVector, _monthVector);
//     }
//
//     [Test]
//     public void ByteEqualsDateReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, DateAtom, BooleanAtom>(_byteAtom, _dateAtom);
//         Equals<ByteAtom, DateVector, BooleanVector>(_byteAtom, _dateVector);
//         Equals<ByteVector, DateAtom, BooleanVector>(_byteVector, _dateAtom);
//         Equals<ByteVector, DateVector, BooleanVector>(_byteVector, _dateVector);
//     }
//
//     [Test]
//     public void ByteEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, TimespanAtom, BooleanAtom>(_byteAtom, _timespanAtom);
//         Equals<ByteAtom, TimespanVector, BooleanVector>(_byteAtom, _timespanVector);
//         Equals<ByteVector, TimespanAtom, BooleanVector>(_byteVector, _timespanAtom);
//         Equals<ByteVector, TimespanVector, BooleanVector>(_byteVector, _timespanVector);
//     }
//
//     [Test]
//     public void ByteEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, MinuteAtom, BooleanAtom>(_byteAtom, _minuteAtom);
//         Equals<ByteAtom, MinuteVector, BooleanVector>(_byteAtom, _minuteVector);
//         Equals<ByteVector, MinuteAtom, BooleanVector>(_byteVector, _minuteAtom);
//         Equals<ByteVector, MinuteVector, BooleanVector>(_byteVector, _minuteVector);
//     }
//
//     [Test]
//     public void ByteEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<ByteAtom, SecondAtom, BooleanAtom>(_byteAtom, _secondAtom);
//         Equals<ByteAtom, SecondVector, BooleanVector>(_byteAtom, _secondVector);
//         Equals<ByteVector, SecondAtom, BooleanVector>(_byteVector, _secondAtom);
//         Equals<ByteVector, SecondVector, BooleanVector>(_byteVector, _secondVector);
//     }
//
//     [Test]
//     public void ShortEqualsByteReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, ByteAtom, BooleanAtom>(_shortAtom, _byteAtom);
//         Equals<ShortAtom, ByteVector, BooleanVector>(_shortAtom, _byteVector);
//         Equals<ShortVector, ByteAtom, BooleanVector>(_shortVector, _byteAtom);
//         Equals<ShortVector, ByteVector, BooleanVector>(_shortVector, _byteVector);
//     }
//
//     [Test]
//     public void ShortEqualsShortReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, ShortAtom, BooleanAtom>(_shortAtom, _shortAtom);
//         Equals<ShortAtom, ShortVector, BooleanVector>(_shortAtom, _shortVector);
//         Equals<ShortVector, ShortAtom, BooleanVector>(_shortVector, _shortAtom);
//         Equals<ShortVector, ShortVector, BooleanVector>(_shortVector, _shortVector);
//     }
//
//     [Test]
//     public void ShortEqualsIntReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, IntAtom, BooleanAtom>(_shortAtom, _intAtom);
//         Equals<ShortAtom, IntVector, BooleanVector>(_shortAtom, _intVector);
//         Equals<ShortVector, IntAtom, BooleanVector>(_shortVector, _intAtom);
//         Equals<ShortVector, IntVector, BooleanVector>(_shortVector, _intVector);
//     }
//
//     [Test]
//     public void ShortEqualsLongReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, LongAtom, BooleanAtom>(_shortAtom, _longAtom);
//         Equals<ShortAtom, LongVector, BooleanVector>(_shortAtom, _longVector);
//         Equals<ShortVector, LongAtom, BooleanVector>(_shortVector, _longAtom);
//         Equals<ShortVector, LongVector, BooleanVector>(_shortVector, _longVector);
//     }
//
//     [Test]
//     public void ShortEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, FloatAtom, BooleanAtom>(_shortAtom, _floatAtom);
//         Equals<ShortAtom, FloatVector, BooleanVector>(_shortAtom, _floatVector);
//         Equals<ShortVector, FloatAtom, BooleanVector>(_shortVector, _floatAtom);
//         Equals<ShortVector, FloatVector, BooleanVector>(_shortVector, _floatVector);
//     }
//
//     [Test]
//     public void ShortEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, DoubleAtom, BooleanAtom>(_shortAtom, _doubleAtom);
//         Equals<ShortAtom, DoubleVector, BooleanVector>(_shortAtom, _doubleVector);
//         Equals<ShortVector, DoubleAtom, BooleanVector>(_shortVector, _doubleAtom);
//         Equals<ShortVector, DoubleVector, BooleanVector>(_shortVector, _doubleVector);
//     }
//
//     [Test]
//     public void ShortEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, TimestampAtom, BooleanAtom>(_shortAtom, _timestampAtom);
//         Equals<ShortAtom, TimestampVector, BooleanVector>(_shortAtom, _timestampVector);
//         Equals<ShortVector, TimestampAtom, BooleanVector>(_shortVector, _timestampAtom);
//         Equals<ShortVector, TimestampVector, BooleanVector>(_shortVector, _timestampVector);
//     }
//
//     [Test]
//     public void ShortEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, MonthAtom, BooleanAtom>(_shortAtom, _monthAtom);
//         Equals<ShortAtom, MonthVector, BooleanVector>(_shortAtom, _monthVector);
//         Equals<ShortVector, MonthAtom, BooleanVector>(_shortVector, _monthAtom);
//         Equals<ShortVector, MonthVector, BooleanVector>(_shortVector, _monthVector);
//     }
//
//     [Test]
//     public void ShortEqualsDateReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, DateAtom, BooleanAtom>(_shortAtom, _dateAtom);
//         Equals<ShortAtom, DateVector, BooleanVector>(_shortAtom, _dateVector);
//         Equals<ShortVector, DateAtom, BooleanVector>(_shortVector, _dateAtom);
//         Equals<ShortVector, DateVector, BooleanVector>(_shortVector, _dateVector);
//     }
//
//     [Test]
//     public void ShortEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, TimespanAtom, BooleanAtom>(_shortAtom, _timespanAtom);
//         Equals<ShortAtom, TimespanVector, BooleanVector>(_shortAtom, _timespanVector);
//         Equals<ShortVector, TimespanAtom, BooleanVector>(_shortVector, _timespanAtom);
//         Equals<ShortVector, TimespanVector, BooleanVector>(_shortVector, _timespanVector);
//     }
//
//     [Test]
//     public void ShortEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, MinuteAtom, BooleanAtom>(_shortAtom, _minuteAtom);
//         Equals<ShortAtom, MinuteVector, BooleanVector>(_shortAtom, _minuteVector);
//         Equals<ShortVector, MinuteAtom, BooleanVector>(_shortVector, _minuteAtom);
//         Equals<ShortVector, MinuteVector, BooleanVector>(_shortVector, _minuteVector);
//     }
//
//     [Test]
//     public void ShortEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<ShortAtom, SecondAtom, BooleanAtom>(_shortAtom, _secondAtom);
//         Equals<ShortAtom, SecondVector, BooleanVector>(_shortAtom, _secondVector);
//         Equals<ShortVector, SecondAtom, BooleanVector>(_shortVector, _secondAtom);
//         Equals<ShortVector, SecondVector, BooleanVector>(_shortVector, _secondVector);
//     }
//
//     [Test]
//     public void IntEqualsByteReturnsCorrectTypes()
//     {
//         Equals<IntAtom, ByteAtom, BooleanAtom>(_intAtom, _byteAtom);
//         Equals<IntAtom, ByteVector, BooleanVector>(_intAtom, _byteVector);
//         Equals<IntVector, ByteAtom, BooleanVector>(_intVector, _byteAtom);
//         Equals<IntVector, ByteVector, BooleanVector>(_intVector, _byteVector);
//     }
//
//     [Test]
//     public void IntEqualsShortReturnsCorrectTypes()
//     {
//         Equals<IntAtom, ShortAtom, BooleanAtom>(_intAtom, _shortAtom);
//         Equals<IntAtom, ShortVector, BooleanVector>(_intAtom, _shortVector);
//         Equals<IntVector, ShortAtom, BooleanVector>(_intVector, _shortAtom);
//         Equals<IntVector, ShortVector, BooleanVector>(_intVector, _shortVector);
//     }
//
//     [Test]
//     public void IntEqualsIntReturnsCorrectTypes()
//     {
//         Equals<IntAtom, IntAtom, BooleanAtom>(_intAtom, _intAtom);
//         Equals<IntAtom, IntVector, BooleanVector>(_intAtom, _intVector);
//         Equals<IntVector, IntAtom, BooleanVector>(_intVector, _intAtom);
//         Equals<IntVector, IntVector, BooleanVector>(_intVector, _intVector);
//     }
//
//     [Test]
//     public void IntEqualsLongReturnsCorrectTypes()
//     {
//         Equals<IntAtom, LongAtom, BooleanAtom>(_intAtom, _longAtom);
//         Equals<IntAtom, LongVector, BooleanVector>(_intAtom, _longVector);
//         Equals<IntVector, LongAtom, BooleanVector>(_intVector, _longAtom);
//         Equals<IntVector, LongVector, BooleanVector>(_intVector, _longVector);
//     }
//
//     [Test]
//     public void IntEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<IntAtom, FloatAtom, BooleanAtom>(_intAtom, _floatAtom);
//         Equals<IntAtom, FloatVector, BooleanVector>(_intAtom, _floatVector);
//         Equals<IntVector, FloatAtom, BooleanVector>(_intVector, _floatAtom);
//         Equals<IntVector, FloatVector, BooleanVector>(_intVector, _floatVector);
//     }
//
//     [Test]
//     public void IntEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<IntAtom, DoubleAtom, BooleanAtom>(_intAtom, _doubleAtom);
//         Equals<IntAtom, DoubleVector, BooleanVector>(_intAtom, _doubleVector);
//         Equals<IntVector, DoubleAtom, BooleanVector>(_intVector, _doubleAtom);
//         Equals<IntVector, DoubleVector, BooleanVector>(_intVector, _doubleVector);
//     }
//
//     [Test]
//     public void IntEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<IntAtom, TimestampAtom, BooleanAtom>(_intAtom, _timestampAtom);
//         Equals<IntAtom, TimestampVector, BooleanVector>(_intAtom, _timestampVector);
//         Equals<IntVector, TimestampAtom, BooleanVector>(_intVector, _timestampAtom);
//         Equals<IntVector, TimestampVector, BooleanVector>(_intVector, _timestampVector);
//     }
//
//     [Test]
//     public void IntEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<IntAtom, MonthAtom, BooleanAtom>(_intAtom, _monthAtom);
//         Equals<IntAtom, MonthVector, BooleanVector>(_intAtom, _monthVector);
//         Equals<IntVector, MonthAtom, BooleanVector>(_intVector, _monthAtom);
//         Equals<IntVector, MonthVector, BooleanVector>(_intVector, _monthVector);
//     }
//
//     [Test]
//     public void IntEqualsDateReturnsCorrectTypes()
//     {
//         Equals<IntAtom, DateAtom, BooleanAtom>(_intAtom, _dateAtom);
//         Equals<IntAtom, DateVector, BooleanVector>(_intAtom, _dateVector);
//         Equals<IntVector, DateAtom, BooleanVector>(_intVector, _dateAtom);
//         Equals<IntVector, DateVector, BooleanVector>(_intVector, _dateVector);
//     }
//
//     [Test]
//     public void IntEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<IntAtom, TimespanAtom, BooleanAtom>(_intAtom, _timespanAtom);
//         Equals<IntAtom, TimespanVector, BooleanVector>(_intAtom, _timespanVector);
//         Equals<IntVector, TimespanAtom, BooleanVector>(_intVector, _timespanAtom);
//         Equals<IntVector, TimespanVector, BooleanVector>(_intVector, _timespanVector);
//     }
//
//     [Test]
//     public void IntEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<IntAtom, MinuteAtom, BooleanAtom>(_intAtom, _minuteAtom);
//         Equals<IntAtom, MinuteVector, BooleanVector>(_intAtom, _minuteVector);
//         Equals<IntVector, MinuteAtom, BooleanVector>(_intVector, _minuteAtom);
//         Equals<IntVector, MinuteVector, BooleanVector>(_intVector, _minuteVector);
//     }
//
//     [Test]
//     public void IntEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<IntAtom, SecondAtom, BooleanAtom>(_intAtom, _secondAtom);
//         Equals<IntAtom, SecondVector, BooleanVector>(_intAtom, _secondVector);
//         Equals<IntVector, SecondAtom, BooleanVector>(_intVector, _secondAtom);
//         Equals<IntVector, SecondVector, BooleanVector>(_intVector, _secondVector);
//     }
//
//     [Test]
//     public void LongEqualsByteReturnsCorrectTypes()
//     {
//         Equals<LongAtom, ByteAtom, BooleanAtom>(_longAtom, _byteAtom);
//         Equals<LongAtom, ByteVector, BooleanVector>(_longAtom, _byteVector);
//         Equals<LongVector, ByteAtom, BooleanVector>(_longVector, _byteAtom);
//         Equals<LongVector, ByteVector, BooleanVector>(_longVector, _byteVector);
//     }
//
//     [Test]
//     public void LongEqualsShortReturnsCorrectTypes()
//     {
//         Equals<LongAtom, ShortAtom, BooleanAtom>(_longAtom, _shortAtom);
//         Equals<LongAtom, ShortVector, BooleanVector>(_longAtom, _shortVector);
//         Equals<LongVector, ShortAtom, BooleanVector>(_longVector, _shortAtom);
//         Equals<LongVector, ShortVector, BooleanVector>(_longVector, _shortVector);
//     }
//
//     [Test]
//     public void LongEqualsIntReturnsCorrectTypes()
//     {
//         Equals<LongAtom, IntAtom, BooleanAtom>(_longAtom, _intAtom);
//         Equals<LongAtom, IntVector, BooleanVector>(_longAtom, _intVector);
//         Equals<LongVector, IntAtom, BooleanVector>(_longVector, _intAtom);
//         Equals<LongVector, IntVector, BooleanVector>(_longVector, _intVector);
//     }
//
//     [Test]
//     public void LongEqualsLongReturnsCorrectTypes()
//     {
//         Equals<LongAtom, LongAtom, BooleanAtom>(_longAtom, _longAtom);
//         Equals<LongAtom, LongVector, BooleanVector>(_longAtom, _longVector);
//         Equals<LongVector, LongAtom, BooleanVector>(_longVector, _longAtom);
//         Equals<LongVector, LongVector, BooleanVector>(_longVector, _longVector);
//     }
//
//     [Test]
//     public void LongEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<LongAtom, FloatAtom, BooleanAtom>(_longAtom, _floatAtom);
//         Equals<LongAtom, FloatVector, BooleanVector>(_longAtom, _floatVector);
//         Equals<LongVector, FloatAtom, BooleanVector>(_longVector, _floatAtom);
//         Equals<LongVector, FloatVector, BooleanVector>(_longVector, _floatVector);
//     }
//
//     [Test]
//     public void LongEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<LongAtom, DoubleAtom, BooleanAtom>(_longAtom, _doubleAtom);
//         Equals<LongAtom, DoubleVector, BooleanVector>(_longAtom, _doubleVector);
//         Equals<LongVector, DoubleAtom, BooleanVector>(_longVector, _doubleAtom);
//         Equals<LongVector, DoubleVector, BooleanVector>(_longVector, _doubleVector);
//     }
//
//     [Test]
//     public void LongEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<LongAtom, TimestampAtom, BooleanAtom>(_longAtom, _timestampAtom);
//         Equals<LongAtom, TimestampVector, BooleanVector>(_longAtom, _timestampVector);
//         Equals<LongVector, TimestampAtom, BooleanVector>(_longVector, _timestampAtom);
//         Equals<LongVector, TimestampVector, BooleanVector>(_longVector, _timestampVector);
//     }
//
//     [Test]
//     public void LongEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<LongAtom, MonthAtom, BooleanAtom>(_longAtom, _monthAtom);
//         Equals<LongAtom, MonthVector, BooleanVector>(_longAtom, _monthVector);
//         Equals<LongVector, MonthAtom, BooleanVector>(_longVector, _monthAtom);
//         Equals<LongVector, MonthVector, BooleanVector>(_longVector, _monthVector);
//     }
//
//     [Test]
//     public void LongEqualsDateReturnsCorrectTypes()
//     {
//         Equals<LongAtom, DateAtom, BooleanAtom>(_longAtom, _dateAtom);
//         Equals<LongAtom, DateVector, BooleanVector>(_longAtom, _dateVector);
//         Equals<LongVector, DateAtom, BooleanVector>(_longVector, _dateAtom);
//         Equals<LongVector, DateVector, BooleanVector>(_longVector, _dateVector);
//     }
//
//     [Test]
//     public void LongEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<LongAtom, TimespanAtom, BooleanAtom>(_longAtom, _timespanAtom);
//         Equals<LongAtom, TimespanVector, BooleanVector>(_longAtom, _timespanVector);
//         Equals<LongVector, TimespanAtom, BooleanVector>(_longVector, _timespanAtom);
//         Equals<LongVector, TimespanVector, BooleanVector>(_longVector, _timespanVector);
//     }
//
//     [Test]
//     public void LongEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<LongAtom, MinuteAtom, BooleanAtom>(_longAtom, _minuteAtom);
//         Equals<LongAtom, MinuteVector, BooleanVector>(_longAtom, _minuteVector);
//         Equals<LongVector, MinuteAtom, BooleanVector>(_longVector, _minuteAtom);
//         Equals<LongVector, MinuteVector, BooleanVector>(_longVector, _minuteVector);
//     }
//
//     [Test]
//     public void LongEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<LongAtom, SecondAtom, BooleanAtom>(_longAtom, _secondAtom);
//         Equals<LongAtom, SecondVector, BooleanVector>(_longAtom, _secondVector);
//         Equals<LongVector, SecondAtom, BooleanVector>(_longVector, _secondAtom);
//         Equals<LongVector, SecondVector, BooleanVector>(_longVector, _secondVector);
//     }
//
//     [Test]
//     public void FloatEqualsByteReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, ByteAtom, BooleanAtom>(_floatAtom, _byteAtom);
//         Equals<FloatAtom, ByteVector, BooleanVector>(_floatAtom, _byteVector);
//         Equals<FloatVector, ByteAtom, BooleanVector>(_floatVector, _byteAtom);
//         Equals<FloatVector, ByteVector, BooleanVector>(_floatVector, _byteVector);
//     }
//
//     [Test]
//     public void FloatEqualsShortReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, ShortAtom, BooleanAtom>(_floatAtom, _shortAtom);
//         Equals<FloatAtom, ShortVector, BooleanVector>(_floatAtom, _shortVector);
//         Equals<FloatVector, ShortAtom, BooleanVector>(_floatVector, _shortAtom);
//         Equals<FloatVector, ShortVector, BooleanVector>(_floatVector, _shortVector);
//     }
//
//     [Test]
//     public void FloatEqualsIntReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, IntAtom, BooleanAtom>(_floatAtom, _intAtom);
//         Equals<FloatAtom, IntVector, BooleanVector>(_floatAtom, _intVector);
//         Equals<FloatVector, IntAtom, BooleanVector>(_floatVector, _intAtom);
//         Equals<FloatVector, IntVector, BooleanVector>(_floatVector, _intVector);
//     }
//
//     [Test]
//     public void FloatEqualsLongReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, LongAtom, BooleanAtom>(_floatAtom, _longAtom);
//         Equals<FloatAtom, LongVector, BooleanVector>(_floatAtom, _longVector);
//         Equals<FloatVector, LongAtom, BooleanVector>(_floatVector, _longAtom);
//         Equals<FloatVector, LongVector, BooleanVector>(_floatVector, _longVector);
//     }
//
//     [Test]
//     public void FloatEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, FloatAtom, BooleanAtom>(_floatAtom, _floatAtom);
//         Equals<FloatAtom, FloatVector, BooleanVector>(_floatAtom, _floatVector);
//         Equals<FloatVector, FloatAtom, BooleanVector>(_floatVector, _floatAtom);
//         Equals<FloatVector, FloatVector, BooleanVector>(_floatVector, _floatVector);
//     }
//
//     [Test]
//     public void FloatEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, DoubleAtom, BooleanAtom>(_floatAtom, _doubleAtom);
//         Equals<FloatAtom, DoubleVector, BooleanVector>(_floatAtom, _doubleVector);
//         Equals<FloatVector, DoubleAtom, BooleanVector>(_floatVector, _doubleAtom);
//         Equals<FloatVector, DoubleVector, BooleanVector>(_floatVector, _doubleVector);
//     }
//
//     [Test]
//     public void FloatEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, TimestampAtom, BooleanAtom>(_floatAtom, _timestampAtom);
//         Equals<FloatAtom, TimestampVector, BooleanVector>(_floatAtom, _timestampVector);
//         Equals<FloatVector, TimestampAtom, BooleanVector>(_floatVector, _timestampAtom);
//         Equals<FloatVector, TimestampVector, BooleanVector>(_floatVector, _timestampVector);
//     }
//
//     [Test]
//     public void FloatEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, MonthAtom, BooleanAtom>(_floatAtom, _monthAtom);
//         Equals<FloatAtom, MonthVector, BooleanVector>(_floatAtom, _monthVector);
//         Equals<FloatVector, MonthAtom, BooleanVector>(_floatVector, _monthAtom);
//         Equals<FloatVector, MonthVector, BooleanVector>(_floatVector, _monthVector);
//     }
//
//     [Test]
//     public void FloatEqualsDateReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, DateAtom, BooleanAtom>(_floatAtom, _dateAtom);
//         Equals<FloatAtom, DateVector, BooleanVector>(_floatAtom, _dateVector);
//         Equals<FloatVector, DateAtom, BooleanVector>(_floatVector, _dateAtom);
//         Equals<FloatVector, DateVector, BooleanVector>(_floatVector, _dateVector);
//     }
//
//     [Test]
//     public void FloatEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, TimespanAtom, BooleanAtom>(_floatAtom, _timespanAtom);
//         Equals<FloatAtom, TimespanVector, BooleanVector>(_floatAtom, _timespanVector);
//         Equals<FloatVector, TimespanAtom, BooleanVector>(_floatVector, _timespanAtom);
//         Equals<FloatVector, TimespanVector, BooleanVector>(_floatVector, _timespanVector);
//     }
//
//     [Test]
//     public void FloatEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, MinuteAtom, BooleanAtom>(_floatAtom, _minuteAtom);
//         Equals<FloatAtom, MinuteVector, BooleanVector>(_floatAtom, _minuteVector);
//         Equals<FloatVector, MinuteAtom, BooleanVector>(_floatVector, _minuteAtom);
//         Equals<FloatVector, MinuteVector, BooleanVector>(_floatVector, _minuteVector);
//     }
//
//     [Test]
//     public void FloatEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<FloatAtom, SecondAtom, BooleanAtom>(_floatAtom, _secondAtom);
//         Equals<FloatAtom, SecondVector, BooleanVector>(_floatAtom, _secondVector);
//         Equals<FloatVector, SecondAtom, BooleanVector>(_floatVector, _secondAtom);
//         Equals<FloatVector, SecondVector, BooleanVector>(_floatVector, _secondVector);
//     }
//
//     [Test]
//     public void DoubleEqualsByteReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, ByteAtom, BooleanAtom>(_doubleAtom, _byteAtom);
//         Equals<DoubleAtom, ByteVector, BooleanVector>(_doubleAtom, _byteVector);
//         Equals<DoubleVector, ByteAtom, BooleanVector>(_doubleVector, _byteAtom);
//         Equals<DoubleVector, ByteVector, BooleanVector>(_doubleVector, _byteVector);
//     }
//
//     [Test]
//     public void DoubleEqualsShortReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, ShortAtom, BooleanAtom>(_doubleAtom, _shortAtom);
//         Equals<DoubleAtom, ShortVector, BooleanVector>(_doubleAtom, _shortVector);
//         Equals<DoubleVector, ShortAtom, BooleanVector>(_doubleVector, _shortAtom);
//         Equals<DoubleVector, ShortVector, BooleanVector>(_doubleVector, _shortVector);
//     }
//
//     [Test]
//     public void DoubleEqualsIntReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, IntAtom, BooleanAtom>(_doubleAtom, _intAtom);
//         Equals<DoubleAtom, IntVector, BooleanVector>(_doubleAtom, _intVector);
//         Equals<DoubleVector, IntAtom, BooleanVector>(_doubleVector, _intAtom);
//         Equals<DoubleVector, IntVector, BooleanVector>(_doubleVector, _intVector);
//     }
//
//     [Test]
//     public void DoubleEqualsLongReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, LongAtom, BooleanAtom>(_doubleAtom, _longAtom);
//         Equals<DoubleAtom, LongVector, BooleanVector>(_doubleAtom, _longVector);
//         Equals<DoubleVector, LongAtom, BooleanVector>(_doubleVector, _longAtom);
//         Equals<DoubleVector, LongVector, BooleanVector>(_doubleVector, _longVector);
//     }
//
//     [Test]
//     public void DoubleEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, FloatAtom, BooleanAtom>(_doubleAtom, _floatAtom);
//         Equals<DoubleAtom, FloatVector, BooleanVector>(_doubleAtom, _floatVector);
//         Equals<DoubleVector, FloatAtom, BooleanVector>(_doubleVector, _floatAtom);
//         Equals<DoubleVector, FloatVector, BooleanVector>(_doubleVector, _floatVector);
//     }
//
//     [Test]
//     public void DoubleEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, DoubleAtom, BooleanAtom>(_doubleAtom, _doubleAtom);
//         Equals<DoubleAtom, DoubleVector, BooleanVector>(_doubleAtom, _doubleVector);
//         Equals<DoubleVector, DoubleAtom, BooleanVector>(_doubleVector, _doubleAtom);
//         Equals<DoubleVector, DoubleVector, BooleanVector>(_doubleVector, _doubleVector);
//     }
//
//     [Test]
//     public void DoubleEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, TimestampAtom, BooleanAtom>(_doubleAtom, _timestampAtom);
//         Equals<DoubleAtom, TimestampVector, BooleanVector>(_doubleAtom, _timestampVector);
//         Equals<DoubleVector, TimestampAtom, BooleanVector>(_doubleVector, _timestampAtom);
//         Equals<DoubleVector, TimestampVector, BooleanVector>(_doubleVector, _timestampVector);
//     }
//
//     [Test]
//     public void DoubleEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, MonthAtom, BooleanAtom>(_doubleAtom, _monthAtom);
//         Equals<DoubleAtom, MonthVector, BooleanVector>(_doubleAtom, _monthVector);
//         Equals<DoubleVector, MonthAtom, BooleanVector>(_doubleVector, _monthAtom);
//         Equals<DoubleVector, MonthVector, BooleanVector>(_doubleVector, _monthVector);
//     }
//
//     [Test]
//     public void DoubleEqualsDateReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, DateAtom, BooleanAtom>(_doubleAtom, _dateAtom);
//         Equals<DoubleAtom, DateVector, BooleanVector>(_doubleAtom, _dateVector);
//         Equals<DoubleVector, DateAtom, BooleanVector>(_doubleVector, _dateAtom);
//         Equals<DoubleVector, DateVector, BooleanVector>(_doubleVector, _dateVector);
//     }
//
//     [Test]
//     public void DoubleEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, TimespanAtom, BooleanAtom>(_doubleAtom, _timespanAtom);
//         Equals<DoubleAtom, TimespanVector, BooleanVector>(_doubleAtom, _timespanVector);
//         Equals<DoubleVector, TimespanAtom, BooleanVector>(_doubleVector, _timespanAtom);
//         Equals<DoubleVector, TimespanVector, BooleanVector>(_doubleVector, _timespanVector);
//     }
//
//     [Test]
//     public void DoubleEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, MinuteAtom, BooleanAtom>(_doubleAtom, _minuteAtom);
//         Equals<DoubleAtom, MinuteVector, BooleanVector>(_doubleAtom, _minuteVector);
//         Equals<DoubleVector, MinuteAtom, BooleanVector>(_doubleVector, _minuteAtom);
//         Equals<DoubleVector, MinuteVector, BooleanVector>(_doubleVector, _minuteVector);
//     }
//
//     [Test]
//     public void DoubleEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<DoubleAtom, SecondAtom, BooleanAtom>(_doubleAtom, _secondAtom);
//         Equals<DoubleAtom, SecondVector, BooleanVector>(_doubleAtom, _secondVector);
//         Equals<DoubleVector, SecondAtom, BooleanVector>(_doubleVector, _secondAtom);
//         Equals<DoubleVector, SecondVector, BooleanVector>(_doubleVector, _secondVector);
//     }
//
//     [Test]
//     public void CharEqualsCharReturnsCorrectTypes()
//     {
//         Equals<CharAtom, CharAtom, BooleanAtom>(_charAtom, _charAtom);
//         Equals<CharAtom, CharVector, BooleanVector>(_charAtom, _charVector);
//         Equals<CharVector, CharAtom, BooleanVector>(_charVector, _charAtom);
//         Equals<CharVector, CharVector, BooleanVector>(_charVector, _charVector);
//     }
//
//     [Test]
//     public void SymbolEqualsSymbolReturnsCorrectTypes()
//     {
//         Equals<SymbolAtom, SymbolAtom, BooleanAtom>(_symbolAtom, _symbolAtom);
//         Equals<SymbolAtom, SymbolVector, BooleanVector>(_symbolAtom, _symbolVector);
//         Equals<SymbolVector, SymbolAtom, BooleanVector>(_symbolVector, _symbolAtom);
//         Equals<SymbolVector, SymbolVector, BooleanVector>(_symbolVector, _symbolVector);
//     }
//
//     [Test]
//     public void TimestampEqualsByteReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, ByteAtom, BooleanAtom>(_timestampAtom, _byteAtom);
//         Equals<TimestampAtom, ByteVector, BooleanVector>(_timestampAtom, _byteVector);
//         Equals<TimestampVector, ByteAtom, BooleanVector>(_timestampVector, _byteAtom);
//         Equals<TimestampVector, ByteVector, BooleanVector>(_timestampVector, _byteVector);
//     }
//
//     [Test]
//     public void TimestampEqualsShortReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, ShortAtom, BooleanAtom>(_timestampAtom, _shortAtom);
//         Equals<TimestampAtom, ShortVector, BooleanVector>(_timestampAtom, _shortVector);
//         Equals<TimestampVector, ShortAtom, BooleanVector>(_timestampVector, _shortAtom);
//         Equals<TimestampVector, ShortVector, BooleanVector>(_timestampVector, _shortVector);
//     }
//
//     [Test]
//     public void TimestampEqualsIntReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, IntAtom, BooleanAtom>(_timestampAtom, _intAtom);
//         Equals<TimestampAtom, IntVector, BooleanVector>(_timestampAtom, _intVector);
//         Equals<TimestampVector, IntAtom, BooleanVector>(_timestampVector, _intAtom);
//         Equals<TimestampVector, IntVector, BooleanVector>(_timestampVector, _intVector);
//     }
//
//     [Test]
//     public void TimestampEqualsLongReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, LongAtom, BooleanAtom>(_timestampAtom, _longAtom);
//         Equals<TimestampAtom, LongVector, BooleanVector>(_timestampAtom, _longVector);
//         Equals<TimestampVector, LongAtom, BooleanVector>(_timestampVector, _longAtom);
//         Equals<TimestampVector, LongVector, BooleanVector>(_timestampVector, _longVector);
//     }
//
//     [Test]
//     public void TimestampEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, FloatAtom, BooleanAtom>(_timestampAtom, _floatAtom);
//         Equals<TimestampAtom, FloatVector, BooleanVector>(_timestampAtom, _floatVector);
//         Equals<TimestampVector, FloatAtom, BooleanVector>(_timestampVector, _floatAtom);
//         Equals<TimestampVector, FloatVector, BooleanVector>(_timestampVector, _floatVector);
//     }
//
//     [Test]
//     public void TimestampEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, DoubleAtom, BooleanAtom>(_timestampAtom, _doubleAtom);
//         Equals<TimestampAtom, DoubleVector, BooleanVector>(_timestampAtom, _doubleVector);
//         Equals<TimestampVector, DoubleAtom, BooleanVector>(_timestampVector, _doubleAtom);
//         Equals<TimestampVector, DoubleVector, BooleanVector>(_timestampVector, _doubleVector);
//     }
//
//     [Test]
//     public void TimestampEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, TimestampAtom, BooleanAtom>(_timestampAtom, _timestampAtom);
//         Equals<TimestampAtom, TimestampVector, BooleanVector>(_timestampAtom, _timestampVector);
//         Equals<TimestampVector, TimestampAtom, BooleanVector>(_timestampVector, _timestampAtom);
//         Equals<TimestampVector, TimestampVector, BooleanVector>(_timestampVector, _timestampVector);
//     }
//
//     [Test]
//     public void TimestampEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, MonthAtom, BooleanAtom>(_timestampAtom, _monthAtom);
//         Equals<TimestampAtom, MonthVector, BooleanVector>(_timestampAtom, _monthVector);
//         Equals<TimestampVector, MonthAtom, BooleanVector>(_timestampVector, _monthAtom);
//         Equals<TimestampVector, MonthVector, BooleanVector>(_timestampVector, _monthVector);
//     }
//
//     [Test]
//     public void TimestampEqualsDateReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, DateAtom, BooleanAtom>(_timestampAtom, _dateAtom);
//         Equals<TimestampAtom, DateVector, BooleanVector>(_timestampAtom, _dateVector);
//         Equals<TimestampVector, DateAtom, BooleanVector>(_timestampVector, _dateAtom);
//         Equals<TimestampVector, DateVector, BooleanVector>(_timestampVector, _dateVector);
//     }
//
//     [Test]
//     public void TimestampEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, TimespanAtom, BooleanAtom>(_timestampAtom, _timespanAtom);
//         Equals<TimestampAtom, TimespanVector, BooleanVector>(_timestampAtom, _timespanVector);
//         Equals<TimestampVector, TimespanAtom, BooleanVector>(_timestampVector, _timespanAtom);
//         Equals<TimestampVector, TimespanVector, BooleanVector>(_timestampVector, _timespanVector);
//     }
//
//     [Test]
//     public void TimestampEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, MinuteAtom, BooleanAtom>(_timestampAtom, _minuteAtom);
//         Equals<TimestampAtom, MinuteVector, BooleanVector>(_timestampAtom, _minuteVector);
//         Equals<TimestampVector, MinuteAtom, BooleanVector>(_timestampVector, _minuteAtom);
//         Equals<TimestampVector, MinuteVector, BooleanVector>(_timestampVector, _minuteVector);
//     }
//
//     [Test]
//     public void TimestampEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<TimestampAtom, SecondAtom, BooleanAtom>(_timestampAtom, _secondAtom);
//         Equals<TimestampAtom, SecondVector, BooleanVector>(_timestampAtom, _secondVector);
//         Equals<TimestampVector, SecondAtom, BooleanVector>(_timestampVector, _secondAtom);
//         Equals<TimestampVector, SecondVector, BooleanVector>(_timestampVector, _secondVector);
//     }
//
//     [Test]
//     public void MonthEqualsByteReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, ByteAtom, BooleanAtom>(_monthAtom, _byteAtom);
//         Equals<MonthAtom, ByteVector, BooleanVector>(_monthAtom, _byteVector);
//         Equals<MonthVector, ByteAtom, BooleanVector>(_monthVector, _byteAtom);
//         Equals<MonthVector, ByteVector, BooleanVector>(_monthVector, _byteVector);
//     }
//
//     [Test]
//     public void MonthEqualsShortReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, ShortAtom, BooleanAtom>(_monthAtom, _shortAtom);
//         Equals<MonthAtom, ShortVector, BooleanVector>(_monthAtom, _shortVector);
//         Equals<MonthVector, ShortAtom, BooleanVector>(_monthVector, _shortAtom);
//         Equals<MonthVector, ShortVector, BooleanVector>(_monthVector, _shortVector);
//     }
//
//     [Test]
//     public void MonthEqualsIntReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, IntAtom, BooleanAtom>(_monthAtom, _intAtom);
//         Equals<MonthAtom, IntVector, BooleanVector>(_monthAtom, _intVector);
//         Equals<MonthVector, IntAtom, BooleanVector>(_monthVector, _intAtom);
//         Equals<MonthVector, IntVector, BooleanVector>(_monthVector, _intVector);
//     }
//
//     [Test]
//     public void MonthEqualsLongReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, LongAtom, BooleanAtom>(_monthAtom, _longAtom);
//         Equals<MonthAtom, LongVector, BooleanVector>(_monthAtom, _longVector);
//         Equals<MonthVector, LongAtom, BooleanVector>(_monthVector, _longAtom);
//         Equals<MonthVector, LongVector, BooleanVector>(_monthVector, _longVector);
//     }
//
//     [Test]
//     public void MonthEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, FloatAtom, BooleanAtom>(_monthAtom, _floatAtom);
//         Equals<MonthAtom, FloatVector, BooleanVector>(_monthAtom, _floatVector);
//         Equals<MonthVector, FloatAtom, BooleanVector>(_monthVector, _floatAtom);
//         Equals<MonthVector, FloatVector, BooleanVector>(_monthVector, _floatVector);
//     }
//
//     [Test]
//     public void MonthEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, DoubleAtom, BooleanAtom>(_monthAtom, _doubleAtom);
//         Equals<MonthAtom, DoubleVector, BooleanVector>(_monthAtom, _doubleVector);
//         Equals<MonthVector, DoubleAtom, BooleanVector>(_monthVector, _doubleAtom);
//         Equals<MonthVector, DoubleVector, BooleanVector>(_monthVector, _doubleVector);
//     }
//
//     [Test]
//     public void MonthEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, TimestampAtom, BooleanAtom>(_monthAtom, _timestampAtom);
//         Equals<MonthAtom, TimestampVector, BooleanVector>(_monthAtom, _timestampVector);
//         Equals<MonthVector, TimestampAtom, BooleanVector>(_monthVector, _timestampAtom);
//         Equals<MonthVector, TimestampVector, BooleanVector>(_monthVector, _timestampVector);
//     }
//
//     [Test]
//     public void MonthEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, MonthAtom, BooleanAtom>(_monthAtom, _monthAtom);
//         Equals<MonthAtom, MonthVector, BooleanVector>(_monthAtom, _monthVector);
//         Equals<MonthVector, MonthAtom, BooleanVector>(_monthVector, _monthAtom);
//         Equals<MonthVector, MonthVector, BooleanVector>(_monthVector, _monthVector);
//     }
//
//     [Test]
//     public void MonthEqualsDateReturnsCorrectTypes()
//     {
//         Equals<MonthAtom, DateAtom, BooleanAtom>(_monthAtom, _dateAtom);
//         Equals<MonthAtom, DateVector, BooleanVector>(_monthAtom, _dateVector);
//         Equals<MonthVector, DateAtom, BooleanVector>(_monthVector, _dateAtom);
//         Equals<MonthVector, DateVector, BooleanVector>(_monthVector, _dateVector);
//     }
//
//     [Test]
//     public void DateEqualsByteReturnsCorrectTypes()
//     {
//         Equals<DateAtom, ByteAtom, BooleanAtom>(_dateAtom, _byteAtom);
//         Equals<DateAtom, ByteVector, BooleanVector>(_dateAtom, _byteVector);
//         Equals<DateVector, ByteAtom, BooleanVector>(_dateVector, _byteAtom);
//         Equals<DateVector, ByteVector, BooleanVector>(_dateVector, _byteVector);
//     }
//
//     [Test]
//     public void DateEqualsShortReturnsCorrectTypes()
//     {
//         Equals<DateAtom, ShortAtom, BooleanAtom>(_dateAtom, _shortAtom);
//         Equals<DateAtom, ShortVector, BooleanVector>(_dateAtom, _shortVector);
//         Equals<DateVector, ShortAtom, BooleanVector>(_dateVector, _shortAtom);
//         Equals<DateVector, ShortVector, BooleanVector>(_dateVector, _shortVector);
//     }
//
//     [Test]
//     public void DateEqualsIntReturnsCorrectTypes()
//     {
//         Equals<DateAtom, IntAtom, BooleanAtom>(_dateAtom, _intAtom);
//         Equals<DateAtom, IntVector, BooleanVector>(_dateAtom, _intVector);
//         Equals<DateVector, IntAtom, BooleanVector>(_dateVector, _intAtom);
//         Equals<DateVector, IntVector, BooleanVector>(_dateVector, _intVector);
//     }
//
//     [Test]
//     public void DateEqualsLongReturnsCorrectTypes()
//     {
//         Equals<DateAtom, LongAtom, BooleanAtom>(_dateAtom, _longAtom);
//         Equals<DateAtom, LongVector, BooleanVector>(_dateAtom, _longVector);
//         Equals<DateVector, LongAtom, BooleanVector>(_dateVector, _longAtom);
//         Equals<DateVector, LongVector, BooleanVector>(_dateVector, _longVector);
//     }
//
//     [Test]
//     public void DateEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<DateAtom, FloatAtom, BooleanAtom>(_dateAtom, _floatAtom);
//         Equals<DateAtom, FloatVector, BooleanVector>(_dateAtom, _floatVector);
//         Equals<DateVector, FloatAtom, BooleanVector>(_dateVector, _floatAtom);
//         Equals<DateVector, FloatVector, BooleanVector>(_dateVector, _floatVector);
//     }
//
//     [Test]
//     public void DateEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<DateAtom, DoubleAtom, BooleanAtom>(_dateAtom, _doubleAtom);
//         Equals<DateAtom, DoubleVector, BooleanVector>(_dateAtom, _doubleVector);
//         Equals<DateVector, DoubleAtom, BooleanVector>(_dateVector, _doubleAtom);
//         Equals<DateVector, DoubleVector, BooleanVector>(_dateVector, _doubleVector);
//     }
//
//     [Test]
//     public void DateEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<DateAtom, TimestampAtom, BooleanAtom>(_dateAtom, _timestampAtom);
//         Equals<DateAtom, TimestampVector, BooleanVector>(_dateAtom, _timestampVector);
//         Equals<DateVector, TimestampAtom, BooleanVector>(_dateVector, _timestampAtom);
//         Equals<DateVector, TimestampVector, BooleanVector>(_dateVector, _timestampVector);
//     }
//
//     [Test]
//     public void DateEqualsMonthReturnsCorrectTypes()
//     {
//         Equals<DateAtom, MonthAtom, BooleanAtom>(_dateAtom, _monthAtom);
//         Equals<DateAtom, MonthVector, BooleanVector>(_dateAtom, _monthVector);
//         Equals<DateVector, MonthAtom, BooleanVector>(_dateVector, _monthAtom);
//         Equals<DateVector, MonthVector, BooleanVector>(_dateVector, _monthVector);
//     }
//
//     [Test]
//     public void DateEqualsDateReturnsCorrectTypes()
//     {
//         Equals<DateAtom, DateAtom, BooleanAtom>(_dateAtom, _dateAtom);
//         Equals<DateAtom, DateVector, BooleanVector>(_dateAtom, _dateVector);
//         Equals<DateVector, DateAtom, BooleanVector>(_dateVector, _dateAtom);
//         Equals<DateVector, DateVector, BooleanVector>(_dateVector, _dateVector);
//     }
//
//     [Test]
//     public void TimespanEqualsByteReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, ByteAtom, BooleanAtom>(_timespanAtom, _byteAtom);
//         Equals<TimespanAtom, ByteVector, BooleanVector>(_timespanAtom, _byteVector);
//         Equals<TimespanVector, ByteAtom, BooleanVector>(_timespanVector, _byteAtom);
//         Equals<TimespanVector, ByteVector, BooleanVector>(_timespanVector, _byteVector);
//     }
//
//     [Test]
//     public void TimespanEqualsShortReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, ShortAtom, BooleanAtom>(_timespanAtom, _shortAtom);
//         Equals<TimespanAtom, ShortVector, BooleanVector>(_timespanAtom, _shortVector);
//         Equals<TimespanVector, ShortAtom, BooleanVector>(_timespanVector, _shortAtom);
//         Equals<TimespanVector, ShortVector, BooleanVector>(_timespanVector, _shortVector);
//     }
//
//     [Test]
//     public void TimespanEqualsIntReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, IntAtom, BooleanAtom>(_timespanAtom, _intAtom);
//         Equals<TimespanAtom, IntVector, BooleanVector>(_timespanAtom, _intVector);
//         Equals<TimespanVector, IntAtom, BooleanVector>(_timespanVector, _intAtom);
//         Equals<TimespanVector, IntVector, BooleanVector>(_timespanVector, _intVector);
//     }
//
//     [Test]
//     public void TimespanEqualsLongReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, LongAtom, BooleanAtom>(_timespanAtom, _longAtom);
//         Equals<TimespanAtom, LongVector, BooleanVector>(_timespanAtom, _longVector);
//         Equals<TimespanVector, LongAtom, BooleanVector>(_timespanVector, _longAtom);
//         Equals<TimespanVector, LongVector, BooleanVector>(_timespanVector, _longVector);
//     }
//
//     [Test]
//     public void TimespanEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, FloatAtom, BooleanAtom>(_timespanAtom, _floatAtom);
//         Equals<TimespanAtom, FloatVector, BooleanVector>(_timespanAtom, _floatVector);
//         Equals<TimespanVector, FloatAtom, BooleanVector>(_timespanVector, _floatAtom);
//         Equals<TimespanVector, FloatVector, BooleanVector>(_timespanVector, _floatVector);
//     }
//
//     [Test]
//     public void TimespanEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, DoubleAtom, BooleanAtom>(_timespanAtom, _doubleAtom);
//         Equals<TimespanAtom, DoubleVector, BooleanVector>(_timespanAtom, _doubleVector);
//         Equals<TimespanVector, DoubleAtom, BooleanVector>(_timespanVector, _doubleAtom);
//         Equals<TimespanVector, DoubleVector, BooleanVector>(_timespanVector, _doubleVector);
//     }
//
//     [Test]
//     public void TimespanEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, TimestampAtom, BooleanAtom>(_timespanAtom, _timestampAtom);
//         Equals<TimespanAtom, TimestampVector, BooleanVector>(_timespanAtom, _timestampVector);
//         Equals<TimespanVector, TimestampAtom, BooleanVector>(_timespanVector, _timestampAtom);
//         Equals<TimespanVector, TimestampVector, BooleanVector>(_timespanVector, _timestampVector);
//     }
//
//     [Test]
//     public void TimespanEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, TimespanAtom, BooleanAtom>(_timespanAtom, _timespanAtom);
//         Equals<TimespanAtom, TimespanVector, BooleanVector>(_timespanAtom, _timespanVector);
//         Equals<TimespanVector, TimespanAtom, BooleanVector>(_timespanVector, _timespanAtom);
//         Equals<TimespanVector, TimespanVector, BooleanVector>(_timespanVector, _timespanVector);
//     }
//
//     [Test]
//     public void TimespanEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, MinuteAtom, BooleanAtom>(_timespanAtom, _minuteAtom);
//         Equals<TimespanAtom, MinuteVector, BooleanVector>(_timespanAtom, _minuteVector);
//         Equals<TimespanVector, MinuteAtom, BooleanVector>(_timespanVector, _minuteAtom);
//         Equals<TimespanVector, MinuteVector, BooleanVector>(_timespanVector, _minuteVector);
//     }
//
//     [Test]
//     public void TimespanEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<TimespanAtom, SecondAtom, BooleanAtom>(_timespanAtom, _secondAtom);
//         Equals<TimespanAtom, SecondVector, BooleanVector>(_timespanAtom, _secondVector);
//         Equals<TimespanVector, SecondAtom, BooleanVector>(_timespanVector, _secondAtom);
//         Equals<TimespanVector, SecondVector, BooleanVector>(_timespanVector, _secondVector);
//     }
//
//     [Test]
//     public void MinuteEqualsByteReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, ByteAtom, BooleanAtom>(_minuteAtom, _byteAtom);
//         Equals<MinuteAtom, ByteVector, BooleanVector>(_minuteAtom, _byteVector);
//         Equals<MinuteVector, ByteAtom, BooleanVector>(_minuteVector, _byteAtom);
//         Equals<MinuteVector, ByteVector, BooleanVector>(_minuteVector, _byteVector);
//     }
//
//     [Test]
//     public void MinuteEqualsShortReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, ShortAtom, BooleanAtom>(_minuteAtom, _shortAtom);
//         Equals<MinuteAtom, ShortVector, BooleanVector>(_minuteAtom, _shortVector);
//         Equals<MinuteVector, ShortAtom, BooleanVector>(_minuteVector, _shortAtom);
//         Equals<MinuteVector, ShortVector, BooleanVector>(_minuteVector, _shortVector);
//     }
//
//     [Test]
//     public void MinuteEqualsIntReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, IntAtom, BooleanAtom>(_minuteAtom, _intAtom);
//         Equals<MinuteAtom, IntVector, BooleanVector>(_minuteAtom, _intVector);
//         Equals<MinuteVector, IntAtom, BooleanVector>(_minuteVector, _intAtom);
//         Equals<MinuteVector, IntVector, BooleanVector>(_minuteVector, _intVector);
//     }
//
//     [Test]
//     public void MinuteEqualsLongReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, LongAtom, BooleanAtom>(_minuteAtom, _longAtom);
//         Equals<MinuteAtom, LongVector, BooleanVector>(_minuteAtom, _longVector);
//         Equals<MinuteVector, LongAtom, BooleanVector>(_minuteVector, _longAtom);
//         Equals<MinuteVector, LongVector, BooleanVector>(_minuteVector, _longVector);
//     }
//
//     [Test]
//     public void MinuteEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, FloatAtom, BooleanAtom>(_minuteAtom, _floatAtom);
//         Equals<MinuteAtom, FloatVector, BooleanVector>(_minuteAtom, _floatVector);
//         Equals<MinuteVector, FloatAtom, BooleanVector>(_minuteVector, _floatAtom);
//         Equals<MinuteVector, FloatVector, BooleanVector>(_minuteVector, _floatVector);
//     }
//
//     [Test]
//     public void MinuteEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, DoubleAtom, BooleanAtom>(_minuteAtom, _doubleAtom);
//         Equals<MinuteAtom, DoubleVector, BooleanVector>(_minuteAtom, _doubleVector);
//         Equals<MinuteVector, DoubleAtom, BooleanVector>(_minuteVector, _doubleAtom);
//         Equals<MinuteVector, DoubleVector, BooleanVector>(_minuteVector, _doubleVector);
//     }
//
//     [Test]
//     public void MinuteEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, TimestampAtom, BooleanAtom>(_minuteAtom, _timestampAtom);
//         Equals<MinuteAtom, TimestampVector, BooleanVector>(_minuteAtom, _timestampVector);
//         Equals<MinuteVector, TimestampAtom, BooleanVector>(_minuteVector, _timestampAtom);
//         Equals<MinuteVector, TimestampVector, BooleanVector>(_minuteVector, _timestampVector);
//     }
//
//     [Test]
//     public void MinuteEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, TimespanAtom, BooleanAtom>(_minuteAtom, _timespanAtom);
//         Equals<MinuteAtom, TimespanVector, BooleanVector>(_minuteAtom, _timespanVector);
//         Equals<MinuteVector, TimespanAtom, BooleanVector>(_minuteVector, _timespanAtom);
//         Equals<MinuteVector, TimespanVector, BooleanVector>(_minuteVector, _timespanVector);
//     }
//
//     [Test]
//     public void MinuteEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, MinuteAtom, BooleanAtom>(_minuteAtom, _minuteAtom);
//         Equals<MinuteAtom, MinuteVector, BooleanVector>(_minuteAtom, _minuteVector);
//         Equals<MinuteVector, MinuteAtom, BooleanVector>(_minuteVector, _minuteAtom);
//         Equals<MinuteVector, MinuteVector, BooleanVector>(_minuteVector, _minuteVector);
//     }
//
//     [Test]
//     public void MinuteEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<MinuteAtom, SecondAtom, BooleanAtom>(_minuteAtom, _secondAtom);
//         Equals<MinuteAtom, SecondVector, BooleanVector>(_minuteAtom, _secondVector);
//         Equals<MinuteVector, SecondAtom, BooleanVector>(_minuteVector, _secondAtom);
//         Equals<MinuteVector, SecondVector, BooleanVector>(_minuteVector, _secondVector);
//     }
//
//     [Test]
//     public void SecondEqualsByteReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, ByteAtom, BooleanAtom>(_secondAtom, _byteAtom);
//         Equals<SecondAtom, ByteVector, BooleanVector>(_secondAtom, _byteVector);
//         Equals<SecondVector, ByteAtom, BooleanVector>(_secondVector, _byteAtom);
//         Equals<SecondVector, ByteVector, BooleanVector>(_secondVector, _byteVector);
//     }
//
//     [Test]
//     public void SecondEqualsShortReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, ShortAtom, BooleanAtom>(_secondAtom, _shortAtom);
//         Equals<SecondAtom, ShortVector, BooleanVector>(_secondAtom, _shortVector);
//         Equals<SecondVector, ShortAtom, BooleanVector>(_secondVector, _shortAtom);
//         Equals<SecondVector, ShortVector, BooleanVector>(_secondVector, _shortVector);
//     }
//
//     [Test]
//     public void SecondEqualsIntReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, IntAtom, BooleanAtom>(_secondAtom, _intAtom);
//         Equals<SecondAtom, IntVector, BooleanVector>(_secondAtom, _intVector);
//         Equals<SecondVector, IntAtom, BooleanVector>(_secondVector, _intAtom);
//         Equals<SecondVector, IntVector, BooleanVector>(_secondVector, _intVector);
//     }
//
//     [Test]
//     public void SecondEqualsLongReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, LongAtom, BooleanAtom>(_secondAtom, _longAtom);
//         Equals<SecondAtom, LongVector, BooleanVector>(_secondAtom, _longVector);
//         Equals<SecondVector, LongAtom, BooleanVector>(_secondVector, _longAtom);
//         Equals<SecondVector, LongVector, BooleanVector>(_secondVector, _longVector);
//     }
//
//     [Test]
//     public void SecondEqualsFloatReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, FloatAtom, BooleanAtom>(_secondAtom, _floatAtom);
//         Equals<SecondAtom, FloatVector, BooleanVector>(_secondAtom, _floatVector);
//         Equals<SecondVector, FloatAtom, BooleanVector>(_secondVector, _floatAtom);
//         Equals<SecondVector, FloatVector, BooleanVector>(_secondVector, _floatVector);
//     }
//
//     [Test]
//     public void SecondEqualsDoubleReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, DoubleAtom, BooleanAtom>(_secondAtom, _doubleAtom);
//         Equals<SecondAtom, DoubleVector, BooleanVector>(_secondAtom, _doubleVector);
//         Equals<SecondVector, DoubleAtom, BooleanVector>(_secondVector, _doubleAtom);
//         Equals<SecondVector, DoubleVector, BooleanVector>(_secondVector, _doubleVector);
//     }
//
//     [Test]
//     public void SecondEqualsTimestampReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, TimestampAtom, BooleanAtom>(_secondAtom, _timestampAtom);
//         Equals<SecondAtom, TimestampVector, BooleanVector>(_secondAtom, _timestampVector);
//         Equals<SecondVector, TimestampAtom, BooleanVector>(_secondVector, _timestampAtom);
//         Equals<SecondVector, TimestampVector, BooleanVector>(_secondVector, _timestampVector);
//     }
//
//     [Test]
//     public void SecondEqualsTimespanReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, TimespanAtom, BooleanAtom>(_secondAtom, _timespanAtom);
//         Equals<SecondAtom, TimespanVector, BooleanVector>(_secondAtom, _timespanVector);
//         Equals<SecondVector, TimespanAtom, BooleanVector>(_secondVector, _timespanAtom);
//         Equals<SecondVector, TimespanVector, BooleanVector>(_secondVector, _timespanVector);
//     }
//
//     [Test]
//     public void SecondEqualsMinuteReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, MinuteAtom, BooleanAtom>(_secondAtom, _minuteAtom);
//         Equals<SecondAtom, MinuteVector, BooleanVector>(_secondAtom, _minuteVector);
//         Equals<SecondVector, MinuteAtom, BooleanVector>(_secondVector, _minuteAtom);
//         Equals<SecondVector, MinuteVector, BooleanVector>(_secondVector, _minuteVector);
//     }
//
//     [Test]
//     public void SecondEqualsSecondReturnsCorrectTypes()
//     {
//         Equals<SecondAtom, SecondAtom, BooleanAtom>(_secondAtom, _secondAtom);
//         Equals<SecondAtom, SecondVector, BooleanVector>(_secondAtom, _secondVector);
//         Equals<SecondVector, SecondAtom, BooleanVector>(_secondVector, _secondAtom);
//         Equals<SecondVector, SecondVector, BooleanVector>(_secondVector, _secondVector);
//     }
// }
