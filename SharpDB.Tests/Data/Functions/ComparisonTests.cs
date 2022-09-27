// using System.Numerics;
// using SharpDB.Data;
//
// namespace SharpDB.Tests.Data.Functions;
//
// public class ComparisonTests
// {
//     private static void Compare<T1, T2, T3>(T1 left, T2 right)
//         where T1 : IComparisonOperators<T1, T2, T3>
//         where T2 : IComparisonOperators<T2, T1, T3>
//     {
//         var result1 = left > right;
//         var result2 = left >= right;
//         var result3 = left < right;
//         var result4 = left <= right;
//         var result5 = right > left;
//         var result6 = right >= left;
//         var result7 = right < left;
//         var result8 = right <= left;
//         Assert.That(result1, Is.TypeOf<T3>());
//         Assert.That(result2, Is.TypeOf<T3>());
//         Assert.That(result3, Is.TypeOf<T3>());
//         Assert.That(result4, Is.TypeOf<T3>());
//         Assert.That(result5, Is.TypeOf<T3>());
//         Assert.That(result6, Is.TypeOf<T3>());
//         Assert.That(result7, Is.TypeOf<T3>());
//         Assert.That(result8, Is.TypeOf<T3>());
//     }
//
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
//     public void ByteCompareByteReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, ByteAtom, BooleanAtom>(_byteAtom, _byteAtom);
//         Compare<ByteAtom, ByteVector, BooleanVector>(_byteAtom, _byteVector);
//         Compare<ByteVector, ByteAtom, BooleanVector>(_byteVector, _byteAtom);
//         Compare<ByteVector, ByteVector, BooleanVector>(_byteVector, _byteVector);
//     }
//
//     [Test]
//     public void ByteCompareShortReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, ShortAtom, BooleanAtom>(_byteAtom, _shortAtom);
//         Compare<ByteAtom, ShortVector, BooleanVector>(_byteAtom, _shortVector);
//         Compare<ByteVector, ShortAtom, BooleanVector>(_byteVector, _shortAtom);
//         Compare<ByteVector, ShortVector, BooleanVector>(_byteVector, _shortVector);
//     }
//
//     [Test]
//     public void ByteCompareIntReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, IntAtom, BooleanAtom>(_byteAtom, _intAtom);
//         Compare<ByteAtom, IntVector, BooleanVector>(_byteAtom, _intVector);
//         Compare<ByteVector, IntAtom, BooleanVector>(_byteVector, _intAtom);
//         Compare<ByteVector, IntVector, BooleanVector>(_byteVector, _intVector);
//     }
//
//     [Test]
//     public void ByteCompareLongReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, LongAtom, BooleanAtom>(_byteAtom, _longAtom);
//         Compare<ByteAtom, LongVector, BooleanVector>(_byteAtom, _longVector);
//         Compare<ByteVector, LongAtom, BooleanVector>(_byteVector, _longAtom);
//         Compare<ByteVector, LongVector, BooleanVector>(_byteVector, _longVector);
//     }
//
//     [Test]
//     public void ByteCompareFloatReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, FloatAtom, BooleanAtom>(_byteAtom, _floatAtom);
//         Compare<ByteAtom, FloatVector, BooleanVector>(_byteAtom, _floatVector);
//         Compare<ByteVector, FloatAtom, BooleanVector>(_byteVector, _floatAtom);
//         Compare<ByteVector, FloatVector, BooleanVector>(_byteVector, _floatVector);
//     }
//
//     [Test]
//     public void ByteCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, DoubleAtom, BooleanAtom>(_byteAtom, _doubleAtom);
//         Compare<ByteAtom, DoubleVector, BooleanVector>(_byteAtom, _doubleVector);
//         Compare<ByteVector, DoubleAtom, BooleanVector>(_byteVector, _doubleAtom);
//         Compare<ByteVector, DoubleVector, BooleanVector>(_byteVector, _doubleVector);
//     }
//
//     [Test]
//     public void ByteCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, TimestampAtom, BooleanAtom>(_byteAtom, _timestampAtom);
//         Compare<ByteAtom, TimestampVector, BooleanVector>(_byteAtom, _timestampVector);
//         Compare<ByteVector, TimestampAtom, BooleanVector>(_byteVector, _timestampAtom);
//         Compare<ByteVector, TimestampVector, BooleanVector>(_byteVector, _timestampVector);
//     }
//
//     [Test]
//     public void ByteCompareMonthReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, MonthAtom, BooleanAtom>(_byteAtom, _monthAtom);
//         Compare<ByteAtom, MonthVector, BooleanVector>(_byteAtom, _monthVector);
//         Compare<ByteVector, MonthAtom, BooleanVector>(_byteVector, _monthAtom);
//         Compare<ByteVector, MonthVector, BooleanVector>(_byteVector, _monthVector);
//     }
//
//     [Test]
//     public void ByteCompareDateReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, DateAtom, BooleanAtom>(_byteAtom, _dateAtom);
//         Compare<ByteAtom, DateVector, BooleanVector>(_byteAtom, _dateVector);
//         Compare<ByteVector, DateAtom, BooleanVector>(_byteVector, _dateAtom);
//         Compare<ByteVector, DateVector, BooleanVector>(_byteVector, _dateVector);
//     }
//
//     [Test]
//     public void ByteCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, TimespanAtom, BooleanAtom>(_byteAtom, _timespanAtom);
//         Compare<ByteAtom, TimespanVector, BooleanVector>(_byteAtom, _timespanVector);
//         Compare<ByteVector, TimespanAtom, BooleanVector>(_byteVector, _timespanAtom);
//         Compare<ByteVector, TimespanVector, BooleanVector>(_byteVector, _timespanVector);
//     }
//
//     [Test]
//     public void ByteCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, MinuteAtom, BooleanAtom>(_byteAtom, _minuteAtom);
//         Compare<ByteAtom, MinuteVector, BooleanVector>(_byteAtom, _minuteVector);
//         Compare<ByteVector, MinuteAtom, BooleanVector>(_byteVector, _minuteAtom);
//         Compare<ByteVector, MinuteVector, BooleanVector>(_byteVector, _minuteVector);
//     }
//
//     [Test]
//     public void ByteCompareSecondReturnsCorrectTypes()
//     {
//         Compare<ByteAtom, SecondAtom, BooleanAtom>(_byteAtom, _secondAtom);
//         Compare<ByteAtom, SecondVector, BooleanVector>(_byteAtom, _secondVector);
//         Compare<ByteVector, SecondAtom, BooleanVector>(_byteVector, _secondAtom);
//         Compare<ByteVector, SecondVector, BooleanVector>(_byteVector, _secondVector);
//     }
//
//     [Test]
//     public void ShortCompareByteReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, ByteAtom, BooleanAtom>(_shortAtom, _byteAtom);
//         Compare<ShortAtom, ByteVector, BooleanVector>(_shortAtom, _byteVector);
//         Compare<ShortVector, ByteAtom, BooleanVector>(_shortVector, _byteAtom);
//         Compare<ShortVector, ByteVector, BooleanVector>(_shortVector, _byteVector);
//     }
//
//     [Test]
//     public void ShortCompareShortReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, ShortAtom, BooleanAtom>(_shortAtom, _shortAtom);
//         Compare<ShortAtom, ShortVector, BooleanVector>(_shortAtom, _shortVector);
//         Compare<ShortVector, ShortAtom, BooleanVector>(_shortVector, _shortAtom);
//         Compare<ShortVector, ShortVector, BooleanVector>(_shortVector, _shortVector);
//     }
//
//     [Test]
//     public void ShortCompareIntReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, IntAtom, BooleanAtom>(_shortAtom, _intAtom);
//         Compare<ShortAtom, IntVector, BooleanVector>(_shortAtom, _intVector);
//         Compare<ShortVector, IntAtom, BooleanVector>(_shortVector, _intAtom);
//         Compare<ShortVector, IntVector, BooleanVector>(_shortVector, _intVector);
//     }
//
//     [Test]
//     public void ShortCompareLongReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, LongAtom, BooleanAtom>(_shortAtom, _longAtom);
//         Compare<ShortAtom, LongVector, BooleanVector>(_shortAtom, _longVector);
//         Compare<ShortVector, LongAtom, BooleanVector>(_shortVector, _longAtom);
//         Compare<ShortVector, LongVector, BooleanVector>(_shortVector, _longVector);
//     }
//
//     [Test]
//     public void ShortCompareFloatReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, FloatAtom, BooleanAtom>(_shortAtom, _floatAtom);
//         Compare<ShortAtom, FloatVector, BooleanVector>(_shortAtom, _floatVector);
//         Compare<ShortVector, FloatAtom, BooleanVector>(_shortVector, _floatAtom);
//         Compare<ShortVector, FloatVector, BooleanVector>(_shortVector, _floatVector);
//     }
//
//     [Test]
//     public void ShortCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, DoubleAtom, BooleanAtom>(_shortAtom, _doubleAtom);
//         Compare<ShortAtom, DoubleVector, BooleanVector>(_shortAtom, _doubleVector);
//         Compare<ShortVector, DoubleAtom, BooleanVector>(_shortVector, _doubleAtom);
//         Compare<ShortVector, DoubleVector, BooleanVector>(_shortVector, _doubleVector);
//     }
//
//     [Test]
//     public void ShortCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, TimestampAtom, BooleanAtom>(_shortAtom, _timestampAtom);
//         Compare<ShortAtom, TimestampVector, BooleanVector>(_shortAtom, _timestampVector);
//         Compare<ShortVector, TimestampAtom, BooleanVector>(_shortVector, _timestampAtom);
//         Compare<ShortVector, TimestampVector, BooleanVector>(_shortVector, _timestampVector);
//     }
//
//     [Test]
//     public void ShortCompareMonthReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, MonthAtom, BooleanAtom>(_shortAtom, _monthAtom);
//         Compare<ShortAtom, MonthVector, BooleanVector>(_shortAtom, _monthVector);
//         Compare<ShortVector, MonthAtom, BooleanVector>(_shortVector, _monthAtom);
//         Compare<ShortVector, MonthVector, BooleanVector>(_shortVector, _monthVector);
//     }
//
//     [Test]
//     public void ShortCompareDateReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, DateAtom, BooleanAtom>(_shortAtom, _dateAtom);
//         Compare<ShortAtom, DateVector, BooleanVector>(_shortAtom, _dateVector);
//         Compare<ShortVector, DateAtom, BooleanVector>(_shortVector, _dateAtom);
//         Compare<ShortVector, DateVector, BooleanVector>(_shortVector, _dateVector);
//     }
//
//     [Test]
//     public void ShortCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, TimespanAtom, BooleanAtom>(_shortAtom, _timespanAtom);
//         Compare<ShortAtom, TimespanVector, BooleanVector>(_shortAtom, _timespanVector);
//         Compare<ShortVector, TimespanAtom, BooleanVector>(_shortVector, _timespanAtom);
//         Compare<ShortVector, TimespanVector, BooleanVector>(_shortVector, _timespanVector);
//     }
//
//     [Test]
//     public void ShortCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, MinuteAtom, BooleanAtom>(_shortAtom, _minuteAtom);
//         Compare<ShortAtom, MinuteVector, BooleanVector>(_shortAtom, _minuteVector);
//         Compare<ShortVector, MinuteAtom, BooleanVector>(_shortVector, _minuteAtom);
//         Compare<ShortVector, MinuteVector, BooleanVector>(_shortVector, _minuteVector);
//     }
//
//     [Test]
//     public void ShortCompareSecondReturnsCorrectTypes()
//     {
//         Compare<ShortAtom, SecondAtom, BooleanAtom>(_shortAtom, _secondAtom);
//         Compare<ShortAtom, SecondVector, BooleanVector>(_shortAtom, _secondVector);
//         Compare<ShortVector, SecondAtom, BooleanVector>(_shortVector, _secondAtom);
//         Compare<ShortVector, SecondVector, BooleanVector>(_shortVector, _secondVector);
//     }
//
//     [Test]
//     public void IntCompareByteReturnsCorrectTypes()
//     {
//         Compare<IntAtom, ByteAtom, BooleanAtom>(_intAtom, _byteAtom);
//         Compare<IntAtom, ByteVector, BooleanVector>(_intAtom, _byteVector);
//         Compare<IntVector, ByteAtom, BooleanVector>(_intVector, _byteAtom);
//         Compare<IntVector, ByteVector, BooleanVector>(_intVector, _byteVector);
//     }
//
//     [Test]
//     public void IntCompareShortReturnsCorrectTypes()
//     {
//         Compare<IntAtom, ShortAtom, BooleanAtom>(_intAtom, _shortAtom);
//         Compare<IntAtom, ShortVector, BooleanVector>(_intAtom, _shortVector);
//         Compare<IntVector, ShortAtom, BooleanVector>(_intVector, _shortAtom);
//         Compare<IntVector, ShortVector, BooleanVector>(_intVector, _shortVector);
//     }
//
//     [Test]
//     public void IntCompareIntReturnsCorrectTypes()
//     {
//         Compare<IntAtom, IntAtom, BooleanAtom>(_intAtom, _intAtom);
//         Compare<IntAtom, IntVector, BooleanVector>(_intAtom, _intVector);
//         Compare<IntVector, IntAtom, BooleanVector>(_intVector, _intAtom);
//         Compare<IntVector, IntVector, BooleanVector>(_intVector, _intVector);
//     }
//
//     [Test]
//     public void IntCompareLongReturnsCorrectTypes()
//     {
//         Compare<IntAtom, LongAtom, BooleanAtom>(_intAtom, _longAtom);
//         Compare<IntAtom, LongVector, BooleanVector>(_intAtom, _longVector);
//         Compare<IntVector, LongAtom, BooleanVector>(_intVector, _longAtom);
//         Compare<IntVector, LongVector, BooleanVector>(_intVector, _longVector);
//     }
//
//     [Test]
//     public void IntCompareFloatReturnsCorrectTypes()
//     {
//         Compare<IntAtom, FloatAtom, BooleanAtom>(_intAtom, _floatAtom);
//         Compare<IntAtom, FloatVector, BooleanVector>(_intAtom, _floatVector);
//         Compare<IntVector, FloatAtom, BooleanVector>(_intVector, _floatAtom);
//         Compare<IntVector, FloatVector, BooleanVector>(_intVector, _floatVector);
//     }
//
//     [Test]
//     public void IntCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<IntAtom, DoubleAtom, BooleanAtom>(_intAtom, _doubleAtom);
//         Compare<IntAtom, DoubleVector, BooleanVector>(_intAtom, _doubleVector);
//         Compare<IntVector, DoubleAtom, BooleanVector>(_intVector, _doubleAtom);
//         Compare<IntVector, DoubleVector, BooleanVector>(_intVector, _doubleVector);
//     }
//
//     [Test]
//     public void IntCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<IntAtom, TimestampAtom, BooleanAtom>(_intAtom, _timestampAtom);
//         Compare<IntAtom, TimestampVector, BooleanVector>(_intAtom, _timestampVector);
//         Compare<IntVector, TimestampAtom, BooleanVector>(_intVector, _timestampAtom);
//         Compare<IntVector, TimestampVector, BooleanVector>(_intVector, _timestampVector);
//     }
//
//     [Test]
//     public void IntCompareMonthReturnsCorrectTypes()
//     {
//         Compare<IntAtom, MonthAtom, BooleanAtom>(_intAtom, _monthAtom);
//         Compare<IntAtom, MonthVector, BooleanVector>(_intAtom, _monthVector);
//         Compare<IntVector, MonthAtom, BooleanVector>(_intVector, _monthAtom);
//         Compare<IntVector, MonthVector, BooleanVector>(_intVector, _monthVector);
//     }
//
//     [Test]
//     public void IntCompareDateReturnsCorrectTypes()
//     {
//         Compare<IntAtom, DateAtom, BooleanAtom>(_intAtom, _dateAtom);
//         Compare<IntAtom, DateVector, BooleanVector>(_intAtom, _dateVector);
//         Compare<IntVector, DateAtom, BooleanVector>(_intVector, _dateAtom);
//         Compare<IntVector, DateVector, BooleanVector>(_intVector, _dateVector);
//     }
//
//     [Test]
//     public void IntCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<IntAtom, TimespanAtom, BooleanAtom>(_intAtom, _timespanAtom);
//         Compare<IntAtom, TimespanVector, BooleanVector>(_intAtom, _timespanVector);
//         Compare<IntVector, TimespanAtom, BooleanVector>(_intVector, _timespanAtom);
//         Compare<IntVector, TimespanVector, BooleanVector>(_intVector, _timespanVector);
//     }
//
//     [Test]
//     public void IntCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<IntAtom, MinuteAtom, BooleanAtom>(_intAtom, _minuteAtom);
//         Compare<IntAtom, MinuteVector, BooleanVector>(_intAtom, _minuteVector);
//         Compare<IntVector, MinuteAtom, BooleanVector>(_intVector, _minuteAtom);
//         Compare<IntVector, MinuteVector, BooleanVector>(_intVector, _minuteVector);
//     }
//
//     [Test]
//     public void IntCompareSecondReturnsCorrectTypes()
//     {
//         Compare<IntAtom, SecondAtom, BooleanAtom>(_intAtom, _secondAtom);
//         Compare<IntAtom, SecondVector, BooleanVector>(_intAtom, _secondVector);
//         Compare<IntVector, SecondAtom, BooleanVector>(_intVector, _secondAtom);
//         Compare<IntVector, SecondVector, BooleanVector>(_intVector, _secondVector);
//     }
//
//     [Test]
//     public void LongCompareByteReturnsCorrectTypes()
//     {
//         Compare<LongAtom, ByteAtom, BooleanAtom>(_longAtom, _byteAtom);
//         Compare<LongAtom, ByteVector, BooleanVector>(_longAtom, _byteVector);
//         Compare<LongVector, ByteAtom, BooleanVector>(_longVector, _byteAtom);
//         Compare<LongVector, ByteVector, BooleanVector>(_longVector, _byteVector);
//     }
//
//     [Test]
//     public void LongCompareShortReturnsCorrectTypes()
//     {
//         Compare<LongAtom, ShortAtom, BooleanAtom>(_longAtom, _shortAtom);
//         Compare<LongAtom, ShortVector, BooleanVector>(_longAtom, _shortVector);
//         Compare<LongVector, ShortAtom, BooleanVector>(_longVector, _shortAtom);
//         Compare<LongVector, ShortVector, BooleanVector>(_longVector, _shortVector);
//     }
//
//     [Test]
//     public void LongCompareIntReturnsCorrectTypes()
//     {
//         Compare<LongAtom, IntAtom, BooleanAtom>(_longAtom, _intAtom);
//         Compare<LongAtom, IntVector, BooleanVector>(_longAtom, _intVector);
//         Compare<LongVector, IntAtom, BooleanVector>(_longVector, _intAtom);
//         Compare<LongVector, IntVector, BooleanVector>(_longVector, _intVector);
//     }
//
//     [Test]
//     public void LongCompareLongReturnsCorrectTypes()
//     {
//         Compare<LongAtom, LongAtom, BooleanAtom>(_longAtom, _longAtom);
//         Compare<LongAtom, LongVector, BooleanVector>(_longAtom, _longVector);
//         Compare<LongVector, LongAtom, BooleanVector>(_longVector, _longAtom);
//         Compare<LongVector, LongVector, BooleanVector>(_longVector, _longVector);
//     }
//
//     [Test]
//     public void LongCompareFloatReturnsCorrectTypes()
//     {
//         Compare<LongAtom, FloatAtom, BooleanAtom>(_longAtom, _floatAtom);
//         Compare<LongAtom, FloatVector, BooleanVector>(_longAtom, _floatVector);
//         Compare<LongVector, FloatAtom, BooleanVector>(_longVector, _floatAtom);
//         Compare<LongVector, FloatVector, BooleanVector>(_longVector, _floatVector);
//     }
//
//     [Test]
//     public void LongCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<LongAtom, DoubleAtom, BooleanAtom>(_longAtom, _doubleAtom);
//         Compare<LongAtom, DoubleVector, BooleanVector>(_longAtom, _doubleVector);
//         Compare<LongVector, DoubleAtom, BooleanVector>(_longVector, _doubleAtom);
//         Compare<LongVector, DoubleVector, BooleanVector>(_longVector, _doubleVector);
//     }
//
//     [Test]
//     public void LongCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<LongAtom, TimestampAtom, BooleanAtom>(_longAtom, _timestampAtom);
//         Compare<LongAtom, TimestampVector, BooleanVector>(_longAtom, _timestampVector);
//         Compare<LongVector, TimestampAtom, BooleanVector>(_longVector, _timestampAtom);
//         Compare<LongVector, TimestampVector, BooleanVector>(_longVector, _timestampVector);
//     }
//
//     [Test]
//     public void LongCompareMonthReturnsCorrectTypes()
//     {
//         Compare<LongAtom, MonthAtom, BooleanAtom>(_longAtom, _monthAtom);
//         Compare<LongAtom, MonthVector, BooleanVector>(_longAtom, _monthVector);
//         Compare<LongVector, MonthAtom, BooleanVector>(_longVector, _monthAtom);
//         Compare<LongVector, MonthVector, BooleanVector>(_longVector, _monthVector);
//     }
//
//     [Test]
//     public void LongCompareDateReturnsCorrectTypes()
//     {
//         Compare<LongAtom, DateAtom, BooleanAtom>(_longAtom, _dateAtom);
//         Compare<LongAtom, DateVector, BooleanVector>(_longAtom, _dateVector);
//         Compare<LongVector, DateAtom, BooleanVector>(_longVector, _dateAtom);
//         Compare<LongVector, DateVector, BooleanVector>(_longVector, _dateVector);
//     }
//
//     [Test]
//     public void LongCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<LongAtom, TimespanAtom, BooleanAtom>(_longAtom, _timespanAtom);
//         Compare<LongAtom, TimespanVector, BooleanVector>(_longAtom, _timespanVector);
//         Compare<LongVector, TimespanAtom, BooleanVector>(_longVector, _timespanAtom);
//         Compare<LongVector, TimespanVector, BooleanVector>(_longVector, _timespanVector);
//     }
//
//     [Test]
//     public void LongCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<LongAtom, MinuteAtom, BooleanAtom>(_longAtom, _minuteAtom);
//         Compare<LongAtom, MinuteVector, BooleanVector>(_longAtom, _minuteVector);
//         Compare<LongVector, MinuteAtom, BooleanVector>(_longVector, _minuteAtom);
//         Compare<LongVector, MinuteVector, BooleanVector>(_longVector, _minuteVector);
//     }
//
//     [Test]
//     public void LongCompareSecondReturnsCorrectTypes()
//     {
//         Compare<LongAtom, SecondAtom, BooleanAtom>(_longAtom, _secondAtom);
//         Compare<LongAtom, SecondVector, BooleanVector>(_longAtom, _secondVector);
//         Compare<LongVector, SecondAtom, BooleanVector>(_longVector, _secondAtom);
//         Compare<LongVector, SecondVector, BooleanVector>(_longVector, _secondVector);
//     }
//
//     [Test]
//     public void FloatCompareByteReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, ByteAtom, BooleanAtom>(_floatAtom, _byteAtom);
//         Compare<FloatAtom, ByteVector, BooleanVector>(_floatAtom, _byteVector);
//         Compare<FloatVector, ByteAtom, BooleanVector>(_floatVector, _byteAtom);
//         Compare<FloatVector, ByteVector, BooleanVector>(_floatVector, _byteVector);
//     }
//
//     [Test]
//     public void FloatCompareShortReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, ShortAtom, BooleanAtom>(_floatAtom, _shortAtom);
//         Compare<FloatAtom, ShortVector, BooleanVector>(_floatAtom, _shortVector);
//         Compare<FloatVector, ShortAtom, BooleanVector>(_floatVector, _shortAtom);
//         Compare<FloatVector, ShortVector, BooleanVector>(_floatVector, _shortVector);
//     }
//
//     [Test]
//     public void FloatCompareIntReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, IntAtom, BooleanAtom>(_floatAtom, _intAtom);
//         Compare<FloatAtom, IntVector, BooleanVector>(_floatAtom, _intVector);
//         Compare<FloatVector, IntAtom, BooleanVector>(_floatVector, _intAtom);
//         Compare<FloatVector, IntVector, BooleanVector>(_floatVector, _intVector);
//     }
//
//     [Test]
//     public void FloatCompareLongReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, LongAtom, BooleanAtom>(_floatAtom, _longAtom);
//         Compare<FloatAtom, LongVector, BooleanVector>(_floatAtom, _longVector);
//         Compare<FloatVector, LongAtom, BooleanVector>(_floatVector, _longAtom);
//         Compare<FloatVector, LongVector, BooleanVector>(_floatVector, _longVector);
//     }
//
//     [Test]
//     public void FloatCompareFloatReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, FloatAtom, BooleanAtom>(_floatAtom, _floatAtom);
//         Compare<FloatAtom, FloatVector, BooleanVector>(_floatAtom, _floatVector);
//         Compare<FloatVector, FloatAtom, BooleanVector>(_floatVector, _floatAtom);
//         Compare<FloatVector, FloatVector, BooleanVector>(_floatVector, _floatVector);
//     }
//
//     [Test]
//     public void FloatCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, DoubleAtom, BooleanAtom>(_floatAtom, _doubleAtom);
//         Compare<FloatAtom, DoubleVector, BooleanVector>(_floatAtom, _doubleVector);
//         Compare<FloatVector, DoubleAtom, BooleanVector>(_floatVector, _doubleAtom);
//         Compare<FloatVector, DoubleVector, BooleanVector>(_floatVector, _doubleVector);
//     }
//
//     [Test]
//     public void FloatCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, TimestampAtom, BooleanAtom>(_floatAtom, _timestampAtom);
//         Compare<FloatAtom, TimestampVector, BooleanVector>(_floatAtom, _timestampVector);
//         Compare<FloatVector, TimestampAtom, BooleanVector>(_floatVector, _timestampAtom);
//         Compare<FloatVector, TimestampVector, BooleanVector>(_floatVector, _timestampVector);
//     }
//
//     [Test]
//     public void FloatCompareMonthReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, MonthAtom, BooleanAtom>(_floatAtom, _monthAtom);
//         Compare<FloatAtom, MonthVector, BooleanVector>(_floatAtom, _monthVector);
//         Compare<FloatVector, MonthAtom, BooleanVector>(_floatVector, _monthAtom);
//         Compare<FloatVector, MonthVector, BooleanVector>(_floatVector, _monthVector);
//     }
//
//     [Test]
//     public void FloatCompareDateReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, DateAtom, BooleanAtom>(_floatAtom, _dateAtom);
//         Compare<FloatAtom, DateVector, BooleanVector>(_floatAtom, _dateVector);
//         Compare<FloatVector, DateAtom, BooleanVector>(_floatVector, _dateAtom);
//         Compare<FloatVector, DateVector, BooleanVector>(_floatVector, _dateVector);
//     }
//
//     [Test]
//     public void FloatCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, TimespanAtom, BooleanAtom>(_floatAtom, _timespanAtom);
//         Compare<FloatAtom, TimespanVector, BooleanVector>(_floatAtom, _timespanVector);
//         Compare<FloatVector, TimespanAtom, BooleanVector>(_floatVector, _timespanAtom);
//         Compare<FloatVector, TimespanVector, BooleanVector>(_floatVector, _timespanVector);
//     }
//
//     [Test]
//     public void FloatCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, MinuteAtom, BooleanAtom>(_floatAtom, _minuteAtom);
//         Compare<FloatAtom, MinuteVector, BooleanVector>(_floatAtom, _minuteVector);
//         Compare<FloatVector, MinuteAtom, BooleanVector>(_floatVector, _minuteAtom);
//         Compare<FloatVector, MinuteVector, BooleanVector>(_floatVector, _minuteVector);
//     }
//
//     [Test]
//     public void FloatCompareSecondReturnsCorrectTypes()
//     {
//         Compare<FloatAtom, SecondAtom, BooleanAtom>(_floatAtom, _secondAtom);
//         Compare<FloatAtom, SecondVector, BooleanVector>(_floatAtom, _secondVector);
//         Compare<FloatVector, SecondAtom, BooleanVector>(_floatVector, _secondAtom);
//         Compare<FloatVector, SecondVector, BooleanVector>(_floatVector, _secondVector);
//     }
//
//     [Test]
//     public void DoubleCompareByteReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, ByteAtom, BooleanAtom>(_doubleAtom, _byteAtom);
//         Compare<DoubleAtom, ByteVector, BooleanVector>(_doubleAtom, _byteVector);
//         Compare<DoubleVector, ByteAtom, BooleanVector>(_doubleVector, _byteAtom);
//         Compare<DoubleVector, ByteVector, BooleanVector>(_doubleVector, _byteVector);
//     }
//
//     [Test]
//     public void DoubleCompareShortReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, ShortAtom, BooleanAtom>(_doubleAtom, _shortAtom);
//         Compare<DoubleAtom, ShortVector, BooleanVector>(_doubleAtom, _shortVector);
//         Compare<DoubleVector, ShortAtom, BooleanVector>(_doubleVector, _shortAtom);
//         Compare<DoubleVector, ShortVector, BooleanVector>(_doubleVector, _shortVector);
//     }
//
//     [Test]
//     public void DoubleCompareIntReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, IntAtom, BooleanAtom>(_doubleAtom, _intAtom);
//         Compare<DoubleAtom, IntVector, BooleanVector>(_doubleAtom, _intVector);
//         Compare<DoubleVector, IntAtom, BooleanVector>(_doubleVector, _intAtom);
//         Compare<DoubleVector, IntVector, BooleanVector>(_doubleVector, _intVector);
//     }
//
//     [Test]
//     public void DoubleCompareLongReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, LongAtom, BooleanAtom>(_doubleAtom, _longAtom);
//         Compare<DoubleAtom, LongVector, BooleanVector>(_doubleAtom, _longVector);
//         Compare<DoubleVector, LongAtom, BooleanVector>(_doubleVector, _longAtom);
//         Compare<DoubleVector, LongVector, BooleanVector>(_doubleVector, _longVector);
//     }
//
//     [Test]
//     public void DoubleCompareFloatReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, FloatAtom, BooleanAtom>(_doubleAtom, _floatAtom);
//         Compare<DoubleAtom, FloatVector, BooleanVector>(_doubleAtom, _floatVector);
//         Compare<DoubleVector, FloatAtom, BooleanVector>(_doubleVector, _floatAtom);
//         Compare<DoubleVector, FloatVector, BooleanVector>(_doubleVector, _floatVector);
//     }
//
//     [Test]
//     public void DoubleCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, DoubleAtom, BooleanAtom>(_doubleAtom, _doubleAtom);
//         Compare<DoubleAtom, DoubleVector, BooleanVector>(_doubleAtom, _doubleVector);
//         Compare<DoubleVector, DoubleAtom, BooleanVector>(_doubleVector, _doubleAtom);
//         Compare<DoubleVector, DoubleVector, BooleanVector>(_doubleVector, _doubleVector);
//     }
//
//     [Test]
//     public void DoubleCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, TimestampAtom, BooleanAtom>(_doubleAtom, _timestampAtom);
//         Compare<DoubleAtom, TimestampVector, BooleanVector>(_doubleAtom, _timestampVector);
//         Compare<DoubleVector, TimestampAtom, BooleanVector>(_doubleVector, _timestampAtom);
//         Compare<DoubleVector, TimestampVector, BooleanVector>(_doubleVector, _timestampVector);
//     }
//
//     [Test]
//     public void DoubleCompareMonthReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, MonthAtom, BooleanAtom>(_doubleAtom, _monthAtom);
//         Compare<DoubleAtom, MonthVector, BooleanVector>(_doubleAtom, _monthVector);
//         Compare<DoubleVector, MonthAtom, BooleanVector>(_doubleVector, _monthAtom);
//         Compare<DoubleVector, MonthVector, BooleanVector>(_doubleVector, _monthVector);
//     }
//
//     [Test]
//     public void DoubleCompareDateReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, DateAtom, BooleanAtom>(_doubleAtom, _dateAtom);
//         Compare<DoubleAtom, DateVector, BooleanVector>(_doubleAtom, _dateVector);
//         Compare<DoubleVector, DateAtom, BooleanVector>(_doubleVector, _dateAtom);
//         Compare<DoubleVector, DateVector, BooleanVector>(_doubleVector, _dateVector);
//     }
//
//     [Test]
//     public void DoubleCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, TimespanAtom, BooleanAtom>(_doubleAtom, _timespanAtom);
//         Compare<DoubleAtom, TimespanVector, BooleanVector>(_doubleAtom, _timespanVector);
//         Compare<DoubleVector, TimespanAtom, BooleanVector>(_doubleVector, _timespanAtom);
//         Compare<DoubleVector, TimespanVector, BooleanVector>(_doubleVector, _timespanVector);
//     }
//
//     [Test]
//     public void DoubleCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, MinuteAtom, BooleanAtom>(_doubleAtom, _minuteAtom);
//         Compare<DoubleAtom, MinuteVector, BooleanVector>(_doubleAtom, _minuteVector);
//         Compare<DoubleVector, MinuteAtom, BooleanVector>(_doubleVector, _minuteAtom);
//         Compare<DoubleVector, MinuteVector, BooleanVector>(_doubleVector, _minuteVector);
//     }
//
//     [Test]
//     public void DoubleCompareSecondReturnsCorrectTypes()
//     {
//         Compare<DoubleAtom, SecondAtom, BooleanAtom>(_doubleAtom, _secondAtom);
//         Compare<DoubleAtom, SecondVector, BooleanVector>(_doubleAtom, _secondVector);
//         Compare<DoubleVector, SecondAtom, BooleanVector>(_doubleVector, _secondAtom);
//         Compare<DoubleVector, SecondVector, BooleanVector>(_doubleVector, _secondVector);
//     }
//
//     [Test]
//     public void TimestampCompareByteReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, ByteAtom, BooleanAtom>(_timestampAtom, _byteAtom);
//         Compare<TimestampAtom, ByteVector, BooleanVector>(_timestampAtom, _byteVector);
//         Compare<TimestampVector, ByteAtom, BooleanVector>(_timestampVector, _byteAtom);
//         Compare<TimestampVector, ByteVector, BooleanVector>(_timestampVector, _byteVector);
//     }
//
//     [Test]
//     public void TimestampCompareShortReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, ShortAtom, BooleanAtom>(_timestampAtom, _shortAtom);
//         Compare<TimestampAtom, ShortVector, BooleanVector>(_timestampAtom, _shortVector);
//         Compare<TimestampVector, ShortAtom, BooleanVector>(_timestampVector, _shortAtom);
//         Compare<TimestampVector, ShortVector, BooleanVector>(_timestampVector, _shortVector);
//     }
//
//     [Test]
//     public void TimestampCompareIntReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, IntAtom, BooleanAtom>(_timestampAtom, _intAtom);
//         Compare<TimestampAtom, IntVector, BooleanVector>(_timestampAtom, _intVector);
//         Compare<TimestampVector, IntAtom, BooleanVector>(_timestampVector, _intAtom);
//         Compare<TimestampVector, IntVector, BooleanVector>(_timestampVector, _intVector);
//     }
//
//     [Test]
//     public void TimestampCompareLongReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, LongAtom, BooleanAtom>(_timestampAtom, _longAtom);
//         Compare<TimestampAtom, LongVector, BooleanVector>(_timestampAtom, _longVector);
//         Compare<TimestampVector, LongAtom, BooleanVector>(_timestampVector, _longAtom);
//         Compare<TimestampVector, LongVector, BooleanVector>(_timestampVector, _longVector);
//     }
//
//     [Test]
//     public void TimestampCompareFloatReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, FloatAtom, BooleanAtom>(_timestampAtom, _floatAtom);
//         Compare<TimestampAtom, FloatVector, BooleanVector>(_timestampAtom, _floatVector);
//         Compare<TimestampVector, FloatAtom, BooleanVector>(_timestampVector, _floatAtom);
//         Compare<TimestampVector, FloatVector, BooleanVector>(_timestampVector, _floatVector);
//     }
//
//     [Test]
//     public void TimestampCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, DoubleAtom, BooleanAtom>(_timestampAtom, _doubleAtom);
//         Compare<TimestampAtom, DoubleVector, BooleanVector>(_timestampAtom, _doubleVector);
//         Compare<TimestampVector, DoubleAtom, BooleanVector>(_timestampVector, _doubleAtom);
//         Compare<TimestampVector, DoubleVector, BooleanVector>(_timestampVector, _doubleVector);
//     }
//
//     [Test]
//     public void TimestampCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, TimestampAtom, BooleanAtom>(_timestampAtom, _timestampAtom);
//         Compare<TimestampAtom, TimestampVector, BooleanVector>(_timestampAtom, _timestampVector);
//         Compare<TimestampVector, TimestampAtom, BooleanVector>(_timestampVector, _timestampAtom);
//         Compare<TimestampVector, TimestampVector, BooleanVector>(_timestampVector, _timestampVector);
//     }
//
//     [Test]
//     public void TimestampCompareMonthReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, MonthAtom, BooleanAtom>(_timestampAtom, _monthAtom);
//         Compare<TimestampAtom, MonthVector, BooleanVector>(_timestampAtom, _monthVector);
//         Compare<TimestampVector, MonthAtom, BooleanVector>(_timestampVector, _monthAtom);
//         Compare<TimestampVector, MonthVector, BooleanVector>(_timestampVector, _monthVector);
//     }
//
//     [Test]
//     public void TimestampCompareDateReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, DateAtom, BooleanAtom>(_timestampAtom, _dateAtom);
//         Compare<TimestampAtom, DateVector, BooleanVector>(_timestampAtom, _dateVector);
//         Compare<TimestampVector, DateAtom, BooleanVector>(_timestampVector, _dateAtom);
//         Compare<TimestampVector, DateVector, BooleanVector>(_timestampVector, _dateVector);
//     }
//
//     [Test]
//     public void TimestampCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, TimespanAtom, BooleanAtom>(_timestampAtom, _timespanAtom);
//         Compare<TimestampAtom, TimespanVector, BooleanVector>(_timestampAtom, _timespanVector);
//         Compare<TimestampVector, TimespanAtom, BooleanVector>(_timestampVector, _timespanAtom);
//         Compare<TimestampVector, TimespanVector, BooleanVector>(_timestampVector, _timespanVector);
//     }
//
//     [Test]
//     public void TimestampCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, MinuteAtom, BooleanAtom>(_timestampAtom, _minuteAtom);
//         Compare<TimestampAtom, MinuteVector, BooleanVector>(_timestampAtom, _minuteVector);
//         Compare<TimestampVector, MinuteAtom, BooleanVector>(_timestampVector, _minuteAtom);
//         Compare<TimestampVector, MinuteVector, BooleanVector>(_timestampVector, _minuteVector);
//     }
//
//     [Test]
//     public void TimestampCompareSecondReturnsCorrectTypes()
//     {
//         Compare<TimestampAtom, SecondAtom, BooleanAtom>(_timestampAtom, _secondAtom);
//         Compare<TimestampAtom, SecondVector, BooleanVector>(_timestampAtom, _secondVector);
//         Compare<TimestampVector, SecondAtom, BooleanVector>(_timestampVector, _secondAtom);
//         Compare<TimestampVector, SecondVector, BooleanVector>(_timestampVector, _secondVector);
//     }
//
//     [Test]
//     public void MonthCompareByteReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, ByteAtom, BooleanAtom>(_monthAtom, _byteAtom);
//         Compare<MonthAtom, ByteVector, BooleanVector>(_monthAtom, _byteVector);
//         Compare<MonthVector, ByteAtom, BooleanVector>(_monthVector, _byteAtom);
//         Compare<MonthVector, ByteVector, BooleanVector>(_monthVector, _byteVector);
//     }
//
//     [Test]
//     public void MonthCompareShortReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, ShortAtom, BooleanAtom>(_monthAtom, _shortAtom);
//         Compare<MonthAtom, ShortVector, BooleanVector>(_monthAtom, _shortVector);
//         Compare<MonthVector, ShortAtom, BooleanVector>(_monthVector, _shortAtom);
//         Compare<MonthVector, ShortVector, BooleanVector>(_monthVector, _shortVector);
//     }
//
//     [Test]
//     public void MonthCompareIntReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, IntAtom, BooleanAtom>(_monthAtom, _intAtom);
//         Compare<MonthAtom, IntVector, BooleanVector>(_monthAtom, _intVector);
//         Compare<MonthVector, IntAtom, BooleanVector>(_monthVector, _intAtom);
//         Compare<MonthVector, IntVector, BooleanVector>(_monthVector, _intVector);
//     }
//
//     [Test]
//     public void MonthCompareLongReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, LongAtom, BooleanAtom>(_monthAtom, _longAtom);
//         Compare<MonthAtom, LongVector, BooleanVector>(_monthAtom, _longVector);
//         Compare<MonthVector, LongAtom, BooleanVector>(_monthVector, _longAtom);
//         Compare<MonthVector, LongVector, BooleanVector>(_monthVector, _longVector);
//     }
//
//     [Test]
//     public void MonthCompareFloatReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, FloatAtom, BooleanAtom>(_monthAtom, _floatAtom);
//         Compare<MonthAtom, FloatVector, BooleanVector>(_monthAtom, _floatVector);
//         Compare<MonthVector, FloatAtom, BooleanVector>(_monthVector, _floatAtom);
//         Compare<MonthVector, FloatVector, BooleanVector>(_monthVector, _floatVector);
//     }
//
//     [Test]
//     public void MonthCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, DoubleAtom, BooleanAtom>(_monthAtom, _doubleAtom);
//         Compare<MonthAtom, DoubleVector, BooleanVector>(_monthAtom, _doubleVector);
//         Compare<MonthVector, DoubleAtom, BooleanVector>(_monthVector, _doubleAtom);
//         Compare<MonthVector, DoubleVector, BooleanVector>(_monthVector, _doubleVector);
//     }
//
//     [Test]
//     public void MonthCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, TimestampAtom, BooleanAtom>(_monthAtom, _timestampAtom);
//         Compare<MonthAtom, TimestampVector, BooleanVector>(_monthAtom, _timestampVector);
//         Compare<MonthVector, TimestampAtom, BooleanVector>(_monthVector, _timestampAtom);
//         Compare<MonthVector, TimestampVector, BooleanVector>(_monthVector, _timestampVector);
//     }
//
//     [Test]
//     public void MonthCompareMonthReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, MonthAtom, BooleanAtom>(_monthAtom, _monthAtom);
//         Compare<MonthAtom, MonthVector, BooleanVector>(_monthAtom, _monthVector);
//         Compare<MonthVector, MonthAtom, BooleanVector>(_monthVector, _monthAtom);
//         Compare<MonthVector, MonthVector, BooleanVector>(_monthVector, _monthVector);
//     }
//
//     [Test]
//     public void MonthCompareDateReturnsCorrectTypes()
//     {
//         Compare<MonthAtom, DateAtom, BooleanAtom>(_monthAtom, _dateAtom);
//         Compare<MonthAtom, DateVector, BooleanVector>(_monthAtom, _dateVector);
//         Compare<MonthVector, DateAtom, BooleanVector>(_monthVector, _dateAtom);
//         Compare<MonthVector, DateVector, BooleanVector>(_monthVector, _dateVector);
//     }
//
//     [Test]
//     public void DateCompareByteReturnsCorrectTypes()
//     {
//         Compare<DateAtom, ByteAtom, BooleanAtom>(_dateAtom, _byteAtom);
//         Compare<DateAtom, ByteVector, BooleanVector>(_dateAtom, _byteVector);
//         Compare<DateVector, ByteAtom, BooleanVector>(_dateVector, _byteAtom);
//         Compare<DateVector, ByteVector, BooleanVector>(_dateVector, _byteVector);
//     }
//
//     [Test]
//     public void DateCompareShortReturnsCorrectTypes()
//     {
//         Compare<DateAtom, ShortAtom, BooleanAtom>(_dateAtom, _shortAtom);
//         Compare<DateAtom, ShortVector, BooleanVector>(_dateAtom, _shortVector);
//         Compare<DateVector, ShortAtom, BooleanVector>(_dateVector, _shortAtom);
//         Compare<DateVector, ShortVector, BooleanVector>(_dateVector, _shortVector);
//     }
//
//     [Test]
//     public void DateCompareIntReturnsCorrectTypes()
//     {
//         Compare<DateAtom, IntAtom, BooleanAtom>(_dateAtom, _intAtom);
//         Compare<DateAtom, IntVector, BooleanVector>(_dateAtom, _intVector);
//         Compare<DateVector, IntAtom, BooleanVector>(_dateVector, _intAtom);
//         Compare<DateVector, IntVector, BooleanVector>(_dateVector, _intVector);
//     }
//
//     [Test]
//     public void DateCompareLongReturnsCorrectTypes()
//     {
//         Compare<DateAtom, LongAtom, BooleanAtom>(_dateAtom, _longAtom);
//         Compare<DateAtom, LongVector, BooleanVector>(_dateAtom, _longVector);
//         Compare<DateVector, LongAtom, BooleanVector>(_dateVector, _longAtom);
//         Compare<DateVector, LongVector, BooleanVector>(_dateVector, _longVector);
//     }
//
//     [Test]
//     public void DateCompareFloatReturnsCorrectTypes()
//     {
//         Compare<DateAtom, FloatAtom, BooleanAtom>(_dateAtom, _floatAtom);
//         Compare<DateAtom, FloatVector, BooleanVector>(_dateAtom, _floatVector);
//         Compare<DateVector, FloatAtom, BooleanVector>(_dateVector, _floatAtom);
//         Compare<DateVector, FloatVector, BooleanVector>(_dateVector, _floatVector);
//     }
//
//     [Test]
//     public void DateCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<DateAtom, DoubleAtom, BooleanAtom>(_dateAtom, _doubleAtom);
//         Compare<DateAtom, DoubleVector, BooleanVector>(_dateAtom, _doubleVector);
//         Compare<DateVector, DoubleAtom, BooleanVector>(_dateVector, _doubleAtom);
//         Compare<DateVector, DoubleVector, BooleanVector>(_dateVector, _doubleVector);
//     }
//
//     [Test]
//     public void DateCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<DateAtom, TimestampAtom, BooleanAtom>(_dateAtom, _timestampAtom);
//         Compare<DateAtom, TimestampVector, BooleanVector>(_dateAtom, _timestampVector);
//         Compare<DateVector, TimestampAtom, BooleanVector>(_dateVector, _timestampAtom);
//         Compare<DateVector, TimestampVector, BooleanVector>(_dateVector, _timestampVector);
//     }
//
//     [Test]
//     public void DateCompareMonthReturnsCorrectTypes()
//     {
//         Compare<DateAtom, MonthAtom, BooleanAtom>(_dateAtom, _monthAtom);
//         Compare<DateAtom, MonthVector, BooleanVector>(_dateAtom, _monthVector);
//         Compare<DateVector, MonthAtom, BooleanVector>(_dateVector, _monthAtom);
//         Compare<DateVector, MonthVector, BooleanVector>(_dateVector, _monthVector);
//     }
//
//     [Test]
//     public void DateCompareDateReturnsCorrectTypes()
//     {
//         Compare<DateAtom, DateAtom, BooleanAtom>(_dateAtom, _dateAtom);
//         Compare<DateAtom, DateVector, BooleanVector>(_dateAtom, _dateVector);
//         Compare<DateVector, DateAtom, BooleanVector>(_dateVector, _dateAtom);
//         Compare<DateVector, DateVector, BooleanVector>(_dateVector, _dateVector);
//     }
//
//     [Test]
//     public void TimespanCompareByteReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, ByteAtom, BooleanAtom>(_timespanAtom, _byteAtom);
//         Compare<TimespanAtom, ByteVector, BooleanVector>(_timespanAtom, _byteVector);
//         Compare<TimespanVector, ByteAtom, BooleanVector>(_timespanVector, _byteAtom);
//         Compare<TimespanVector, ByteVector, BooleanVector>(_timespanVector, _byteVector);
//     }
//
//     [Test]
//     public void TimespanCompareShortReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, ShortAtom, BooleanAtom>(_timespanAtom, _shortAtom);
//         Compare<TimespanAtom, ShortVector, BooleanVector>(_timespanAtom, _shortVector);
//         Compare<TimespanVector, ShortAtom, BooleanVector>(_timespanVector, _shortAtom);
//         Compare<TimespanVector, ShortVector, BooleanVector>(_timespanVector, _shortVector);
//     }
//
//     [Test]
//     public void TimespanCompareIntReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, IntAtom, BooleanAtom>(_timespanAtom, _intAtom);
//         Compare<TimespanAtom, IntVector, BooleanVector>(_timespanAtom, _intVector);
//         Compare<TimespanVector, IntAtom, BooleanVector>(_timespanVector, _intAtom);
//         Compare<TimespanVector, IntVector, BooleanVector>(_timespanVector, _intVector);
//     }
//
//     [Test]
//     public void TimespanCompareLongReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, LongAtom, BooleanAtom>(_timespanAtom, _longAtom);
//         Compare<TimespanAtom, LongVector, BooleanVector>(_timespanAtom, _longVector);
//         Compare<TimespanVector, LongAtom, BooleanVector>(_timespanVector, _longAtom);
//         Compare<TimespanVector, LongVector, BooleanVector>(_timespanVector, _longVector);
//     }
//
//     [Test]
//     public void TimespanCompareFloatReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, FloatAtom, BooleanAtom>(_timespanAtom, _floatAtom);
//         Compare<TimespanAtom, FloatVector, BooleanVector>(_timespanAtom, _floatVector);
//         Compare<TimespanVector, FloatAtom, BooleanVector>(_timespanVector, _floatAtom);
//         Compare<TimespanVector, FloatVector, BooleanVector>(_timespanVector, _floatVector);
//     }
//
//     [Test]
//     public void TimespanCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, DoubleAtom, BooleanAtom>(_timespanAtom, _doubleAtom);
//         Compare<TimespanAtom, DoubleVector, BooleanVector>(_timespanAtom, _doubleVector);
//         Compare<TimespanVector, DoubleAtom, BooleanVector>(_timespanVector, _doubleAtom);
//         Compare<TimespanVector, DoubleVector, BooleanVector>(_timespanVector, _doubleVector);
//     }
//
//     [Test]
//     public void TimespanCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, TimestampAtom, BooleanAtom>(_timespanAtom, _timestampAtom);
//         Compare<TimespanAtom, TimestampVector, BooleanVector>(_timespanAtom, _timestampVector);
//         Compare<TimespanVector, TimestampAtom, BooleanVector>(_timespanVector, _timestampAtom);
//         Compare<TimespanVector, TimestampVector, BooleanVector>(_timespanVector, _timestampVector);
//     }
//
//     [Test]
//     public void TimespanCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, TimespanAtom, BooleanAtom>(_timespanAtom, _timespanAtom);
//         Compare<TimespanAtom, TimespanVector, BooleanVector>(_timespanAtom, _timespanVector);
//         Compare<TimespanVector, TimespanAtom, BooleanVector>(_timespanVector, _timespanAtom);
//         Compare<TimespanVector, TimespanVector, BooleanVector>(_timespanVector, _timespanVector);
//     }
//
//     [Test]
//     public void TimespanCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, MinuteAtom, BooleanAtom>(_timespanAtom, _minuteAtom);
//         Compare<TimespanAtom, MinuteVector, BooleanVector>(_timespanAtom, _minuteVector);
//         Compare<TimespanVector, MinuteAtom, BooleanVector>(_timespanVector, _minuteAtom);
//         Compare<TimespanVector, MinuteVector, BooleanVector>(_timespanVector, _minuteVector);
//     }
//
//     [Test]
//     public void TimespanCompareSecondReturnsCorrectTypes()
//     {
//         Compare<TimespanAtom, SecondAtom, BooleanAtom>(_timespanAtom, _secondAtom);
//         Compare<TimespanAtom, SecondVector, BooleanVector>(_timespanAtom, _secondVector);
//         Compare<TimespanVector, SecondAtom, BooleanVector>(_timespanVector, _secondAtom);
//         Compare<TimespanVector, SecondVector, BooleanVector>(_timespanVector, _secondVector);
//     }
//
//     [Test]
//     public void MinuteCompareByteReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, ByteAtom, BooleanAtom>(_minuteAtom, _byteAtom);
//         Compare<MinuteAtom, ByteVector, BooleanVector>(_minuteAtom, _byteVector);
//         Compare<MinuteVector, ByteAtom, BooleanVector>(_minuteVector, _byteAtom);
//         Compare<MinuteVector, ByteVector, BooleanVector>(_minuteVector, _byteVector);
//     }
//
//     [Test]
//     public void MinuteCompareShortReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, ShortAtom, BooleanAtom>(_minuteAtom, _shortAtom);
//         Compare<MinuteAtom, ShortVector, BooleanVector>(_minuteAtom, _shortVector);
//         Compare<MinuteVector, ShortAtom, BooleanVector>(_minuteVector, _shortAtom);
//         Compare<MinuteVector, ShortVector, BooleanVector>(_minuteVector, _shortVector);
//     }
//
//     [Test]
//     public void MinuteCompareIntReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, IntAtom, BooleanAtom>(_minuteAtom, _intAtom);
//         Compare<MinuteAtom, IntVector, BooleanVector>(_minuteAtom, _intVector);
//         Compare<MinuteVector, IntAtom, BooleanVector>(_minuteVector, _intAtom);
//         Compare<MinuteVector, IntVector, BooleanVector>(_minuteVector, _intVector);
//     }
//
//     [Test]
//     public void MinuteCompareLongReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, LongAtom, BooleanAtom>(_minuteAtom, _longAtom);
//         Compare<MinuteAtom, LongVector, BooleanVector>(_minuteAtom, _longVector);
//         Compare<MinuteVector, LongAtom, BooleanVector>(_minuteVector, _longAtom);
//         Compare<MinuteVector, LongVector, BooleanVector>(_minuteVector, _longVector);
//     }
//
//     [Test]
//     public void MinuteCompareFloatReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, FloatAtom, BooleanAtom>(_minuteAtom, _floatAtom);
//         Compare<MinuteAtom, FloatVector, BooleanVector>(_minuteAtom, _floatVector);
//         Compare<MinuteVector, FloatAtom, BooleanVector>(_minuteVector, _floatAtom);
//         Compare<MinuteVector, FloatVector, BooleanVector>(_minuteVector, _floatVector);
//     }
//
//     [Test]
//     public void MinuteCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, DoubleAtom, BooleanAtom>(_minuteAtom, _doubleAtom);
//         Compare<MinuteAtom, DoubleVector, BooleanVector>(_minuteAtom, _doubleVector);
//         Compare<MinuteVector, DoubleAtom, BooleanVector>(_minuteVector, _doubleAtom);
//         Compare<MinuteVector, DoubleVector, BooleanVector>(_minuteVector, _doubleVector);
//     }
//
//     [Test]
//     public void MinuteCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, TimestampAtom, BooleanAtom>(_minuteAtom, _timestampAtom);
//         Compare<MinuteAtom, TimestampVector, BooleanVector>(_minuteAtom, _timestampVector);
//         Compare<MinuteVector, TimestampAtom, BooleanVector>(_minuteVector, _timestampAtom);
//         Compare<MinuteVector, TimestampVector, BooleanVector>(_minuteVector, _timestampVector);
//     }
//
//     [Test]
//     public void MinuteCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, TimespanAtom, BooleanAtom>(_minuteAtom, _timespanAtom);
//         Compare<MinuteAtom, TimespanVector, BooleanVector>(_minuteAtom, _timespanVector);
//         Compare<MinuteVector, TimespanAtom, BooleanVector>(_minuteVector, _timespanAtom);
//         Compare<MinuteVector, TimespanVector, BooleanVector>(_minuteVector, _timespanVector);
//     }
//
//     [Test]
//     public void MinuteCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, MinuteAtom, BooleanAtom>(_minuteAtom, _minuteAtom);
//         Compare<MinuteAtom, MinuteVector, BooleanVector>(_minuteAtom, _minuteVector);
//         Compare<MinuteVector, MinuteAtom, BooleanVector>(_minuteVector, _minuteAtom);
//         Compare<MinuteVector, MinuteVector, BooleanVector>(_minuteVector, _minuteVector);
//     }
//
//     [Test]
//     public void MinuteCompareSecondReturnsCorrectTypes()
//     {
//         Compare<MinuteAtom, SecondAtom, BooleanAtom>(_minuteAtom, _secondAtom);
//         Compare<MinuteAtom, SecondVector, BooleanVector>(_minuteAtom, _secondVector);
//         Compare<MinuteVector, SecondAtom, BooleanVector>(_minuteVector, _secondAtom);
//         Compare<MinuteVector, SecondVector, BooleanVector>(_minuteVector, _secondVector);
//     }
//
//     [Test]
//     public void SecondCompareByteReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, ByteAtom, BooleanAtom>(_secondAtom, _byteAtom);
//         Compare<SecondAtom, ByteVector, BooleanVector>(_secondAtom, _byteVector);
//         Compare<SecondVector, ByteAtom, BooleanVector>(_secondVector, _byteAtom);
//         Compare<SecondVector, ByteVector, BooleanVector>(_secondVector, _byteVector);
//     }
//
//     [Test]
//     public void SecondCompareShortReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, ShortAtom, BooleanAtom>(_secondAtom, _shortAtom);
//         Compare<SecondAtom, ShortVector, BooleanVector>(_secondAtom, _shortVector);
//         Compare<SecondVector, ShortAtom, BooleanVector>(_secondVector, _shortAtom);
//         Compare<SecondVector, ShortVector, BooleanVector>(_secondVector, _shortVector);
//     }
//
//     [Test]
//     public void SecondCompareIntReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, IntAtom, BooleanAtom>(_secondAtom, _intAtom);
//         Compare<SecondAtom, IntVector, BooleanVector>(_secondAtom, _intVector);
//         Compare<SecondVector, IntAtom, BooleanVector>(_secondVector, _intAtom);
//         Compare<SecondVector, IntVector, BooleanVector>(_secondVector, _intVector);
//     }
//
//     [Test]
//     public void SecondCompareLongReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, LongAtom, BooleanAtom>(_secondAtom, _longAtom);
//         Compare<SecondAtom, LongVector, BooleanVector>(_secondAtom, _longVector);
//         Compare<SecondVector, LongAtom, BooleanVector>(_secondVector, _longAtom);
//         Compare<SecondVector, LongVector, BooleanVector>(_secondVector, _longVector);
//     }
//
//     [Test]
//     public void SecondCompareFloatReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, FloatAtom, BooleanAtom>(_secondAtom, _floatAtom);
//         Compare<SecondAtom, FloatVector, BooleanVector>(_secondAtom, _floatVector);
//         Compare<SecondVector, FloatAtom, BooleanVector>(_secondVector, _floatAtom);
//         Compare<SecondVector, FloatVector, BooleanVector>(_secondVector, _floatVector);
//     }
//
//     [Test]
//     public void SecondCompareDoubleReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, DoubleAtom, BooleanAtom>(_secondAtom, _doubleAtom);
//         Compare<SecondAtom, DoubleVector, BooleanVector>(_secondAtom, _doubleVector);
//         Compare<SecondVector, DoubleAtom, BooleanVector>(_secondVector, _doubleAtom);
//         Compare<SecondVector, DoubleVector, BooleanVector>(_secondVector, _doubleVector);
//     }
//
//     [Test]
//     public void SecondCompareTimestampReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, TimestampAtom, BooleanAtom>(_secondAtom, _timestampAtom);
//         Compare<SecondAtom, TimestampVector, BooleanVector>(_secondAtom, _timestampVector);
//         Compare<SecondVector, TimestampAtom, BooleanVector>(_secondVector, _timestampAtom);
//         Compare<SecondVector, TimestampVector, BooleanVector>(_secondVector, _timestampVector);
//     }
//
//     [Test]
//     public void SecondCompareTimespanReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, TimespanAtom, BooleanAtom>(_secondAtom, _timespanAtom);
//         Compare<SecondAtom, TimespanVector, BooleanVector>(_secondAtom, _timespanVector);
//         Compare<SecondVector, TimespanAtom, BooleanVector>(_secondVector, _timespanAtom);
//         Compare<SecondVector, TimespanVector, BooleanVector>(_secondVector, _timespanVector);
//     }
//
//     [Test]
//     public void SecondCompareMinuteReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, MinuteAtom, BooleanAtom>(_secondAtom, _minuteAtom);
//         Compare<SecondAtom, MinuteVector, BooleanVector>(_secondAtom, _minuteVector);
//         Compare<SecondVector, MinuteAtom, BooleanVector>(_secondVector, _minuteAtom);
//         Compare<SecondVector, MinuteVector, BooleanVector>(_secondVector, _minuteVector);
//     }
//
//     [Test]
//     public void SecondCompareSecondReturnsCorrectTypes()
//     {
//         Compare<SecondAtom, SecondAtom, BooleanAtom>(_secondAtom, _secondAtom);
//         Compare<SecondAtom, SecondVector, BooleanVector>(_secondAtom, _secondVector);
//         Compare<SecondVector, SecondAtom, BooleanVector>(_secondVector, _secondAtom);
//         Compare<SecondVector, SecondVector, BooleanVector>(_secondVector, _secondVector);
//     }
// }
