// using System.Numerics;
// using SharpDB.Data;
//
// namespace SharpDB.Tests.Data.Functions;
//
// public class ModuloTests
// {
//     private static void Modulo<T1, T2, T3>(T1 left, T2 right)
//         where T1 : IModulusOperators<T1, T2, T3>
//         where T2 : IModulusOperators<T2, T1, T3>
//     {
//         var result1 = left % right;
//         var result2 = right % left;
//         Assert.That(result1, Is.TypeOf<T3>());
//         Assert.That(result2, Is.TypeOf<T3>());
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
//     public void ByteModuloByteReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, ByteAtom, IntAtom>(_byteAtom, _byteAtom);
//         Modulo<ByteAtom, ByteVector, IntVector>(_byteAtom, _byteVector);
//         Modulo<ByteVector, ByteAtom, IntVector>(_byteVector, _byteAtom);
//         Modulo<ByteVector, ByteVector, IntVector>(_byteVector, _byteVector);
//     }
//
//     [Test]
//     public void ByteModuloShortReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, ShortAtom, IntAtom>(_byteAtom, _shortAtom);
//         Modulo<ByteAtom, ShortVector, IntVector>(_byteAtom, _shortVector);
//         Modulo<ByteVector, ShortAtom, IntVector>(_byteVector, _shortAtom);
//         Modulo<ByteVector, ShortVector, IntVector>(_byteVector, _shortVector);
//     }
//
//     [Test]
//     public void ByteModuloIntReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, IntAtom, IntAtom>(_byteAtom, _intAtom);
//         Modulo<ByteAtom, IntVector, IntVector>(_byteAtom, _intVector);
//         Modulo<ByteVector, IntAtom, IntVector>(_byteVector, _intAtom);
//         Modulo<ByteVector, IntVector, IntVector>(_byteVector, _intVector);
//     }
//
//     [Test]
//     public void ByteModuloLongReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, LongAtom, LongAtom>(_byteAtom, _longAtom);
//         Modulo<ByteAtom, LongVector, LongVector>(_byteAtom, _longVector);
//         Modulo<ByteVector, LongAtom, LongVector>(_byteVector, _longAtom);
//         Modulo<ByteVector, LongVector, LongVector>(_byteVector, _longVector);
//     }
//
//     [Test]
//     public void ByteModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, FloatAtom, FloatAtom>(_byteAtom, _floatAtom);
//         Modulo<ByteAtom, FloatVector, FloatVector>(_byteAtom, _floatVector);
//         Modulo<ByteVector, FloatAtom, FloatVector>(_byteVector, _floatAtom);
//         Modulo<ByteVector, FloatVector, FloatVector>(_byteVector, _floatVector);
//     }
//
//     [Test]
//     public void ByteModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, DoubleAtom, DoubleAtom>(_byteAtom, _doubleAtom);
//         Modulo<ByteAtom, DoubleVector, DoubleVector>(_byteAtom, _doubleVector);
//         Modulo<ByteVector, DoubleAtom, DoubleVector>(_byteVector, _doubleAtom);
//         Modulo<ByteVector, DoubleVector, DoubleVector>(_byteVector, _doubleVector);
//     }
//
//     [Test]
//     public void ByteModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, TimestampAtom, TimestampAtom>(_byteAtom, _timestampAtom);
//         Modulo<ByteAtom, TimestampVector, TimestampVector>(_byteAtom, _timestampVector);
//         Modulo<ByteVector, TimestampAtom, TimestampVector>(_byteVector, _timestampAtom);
//         Modulo<ByteVector, TimestampVector, TimestampVector>(_byteVector, _timestampVector);
//     }
//
//     [Test]
//     public void ByteModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, MonthAtom, MonthAtom>(_byteAtom, _monthAtom);
//         Modulo<ByteAtom, MonthVector, MonthVector>(_byteAtom, _monthVector);
//         Modulo<ByteVector, MonthAtom, MonthVector>(_byteVector, _monthAtom);
//         Modulo<ByteVector, MonthVector, MonthVector>(_byteVector, _monthVector);
//     }
//
//     [Test]
//     public void ByteModuloDateReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, DateAtom, DateAtom>(_byteAtom, _dateAtom);
//         Modulo<ByteAtom, DateVector, DateVector>(_byteAtom, _dateVector);
//         Modulo<ByteVector, DateAtom, DateVector>(_byteVector, _dateAtom);
//         Modulo<ByteVector, DateVector, DateVector>(_byteVector, _dateVector);
//     }
//
//     [Test]
//     public void ByteModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, TimespanAtom, TimespanAtom>(_byteAtom, _timespanAtom);
//         Modulo<ByteAtom, TimespanVector, TimespanVector>(_byteAtom, _timespanVector);
//         Modulo<ByteVector, TimespanAtom, TimespanVector>(_byteVector, _timespanAtom);
//         Modulo<ByteVector, TimespanVector, TimespanVector>(_byteVector, _timespanVector);
//     }
//
//     [Test]
//     public void ByteModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, MinuteAtom, MinuteAtom>(_byteAtom, _minuteAtom);
//         Modulo<ByteAtom, MinuteVector, MinuteVector>(_byteAtom, _minuteVector);
//         Modulo<ByteVector, MinuteAtom, MinuteVector>(_byteVector, _minuteAtom);
//         Modulo<ByteVector, MinuteVector, MinuteVector>(_byteVector, _minuteVector);
//     }
//
//     [Test]
//     public void ByteModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<ByteAtom, SecondAtom, SecondAtom>(_byteAtom, _secondAtom);
//         Modulo<ByteAtom, SecondVector, SecondVector>(_byteAtom, _secondVector);
//         Modulo<ByteVector, SecondAtom, SecondVector>(_byteVector, _secondAtom);
//         Modulo<ByteVector, SecondVector, SecondVector>(_byteVector, _secondVector);
//     }
//
//     [Test]
//     public void ShortModuloByteReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, ByteAtom, IntAtom>(_shortAtom, _byteAtom);
//         Modulo<ShortAtom, ByteVector, IntVector>(_shortAtom, _byteVector);
//         Modulo<ShortVector, ByteAtom, IntVector>(_shortVector, _byteAtom);
//         Modulo<ShortVector, ByteVector, IntVector>(_shortVector, _byteVector);
//     }
//
//     [Test]
//     public void ShortModuloShortReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, ShortAtom, IntAtom>(_shortAtom, _shortAtom);
//         Modulo<ShortAtom, ShortVector, IntVector>(_shortAtom, _shortVector);
//         Modulo<ShortVector, ShortAtom, IntVector>(_shortVector, _shortAtom);
//         Modulo<ShortVector, ShortVector, IntVector>(_shortVector, _shortVector);
//     }
//
//     [Test]
//     public void ShortModuloIntReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, IntAtom, IntAtom>(_shortAtom, _intAtom);
//         Modulo<ShortAtom, IntVector, IntVector>(_shortAtom, _intVector);
//         Modulo<ShortVector, IntAtom, IntVector>(_shortVector, _intAtom);
//         Modulo<ShortVector, IntVector, IntVector>(_shortVector, _intVector);
//     }
//
//     [Test]
//     public void ShortModuloLongReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, LongAtom, LongAtom>(_shortAtom, _longAtom);
//         Modulo<ShortAtom, LongVector, LongVector>(_shortAtom, _longVector);
//         Modulo<ShortVector, LongAtom, LongVector>(_shortVector, _longAtom);
//         Modulo<ShortVector, LongVector, LongVector>(_shortVector, _longVector);
//     }
//
//     [Test]
//     public void ShortModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, FloatAtom, FloatAtom>(_shortAtom, _floatAtom);
//         Modulo<ShortAtom, FloatVector, FloatVector>(_shortAtom, _floatVector);
//         Modulo<ShortVector, FloatAtom, FloatVector>(_shortVector, _floatAtom);
//         Modulo<ShortVector, FloatVector, FloatVector>(_shortVector, _floatVector);
//     }
//
//     [Test]
//     public void ShortModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, DoubleAtom, DoubleAtom>(_shortAtom, _doubleAtom);
//         Modulo<ShortAtom, DoubleVector, DoubleVector>(_shortAtom, _doubleVector);
//         Modulo<ShortVector, DoubleAtom, DoubleVector>(_shortVector, _doubleAtom);
//         Modulo<ShortVector, DoubleVector, DoubleVector>(_shortVector, _doubleVector);
//     }
//
//     [Test]
//     public void ShortModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, TimestampAtom, TimestampAtom>(_shortAtom, _timestampAtom);
//         Modulo<ShortAtom, TimestampVector, TimestampVector>(_shortAtom, _timestampVector);
//         Modulo<ShortVector, TimestampAtom, TimestampVector>(_shortVector, _timestampAtom);
//         Modulo<ShortVector, TimestampVector, TimestampVector>(_shortVector, _timestampVector);
//     }
//
//     [Test]
//     public void ShortModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, MonthAtom, MonthAtom>(_shortAtom, _monthAtom);
//         Modulo<ShortAtom, MonthVector, MonthVector>(_shortAtom, _monthVector);
//         Modulo<ShortVector, MonthAtom, MonthVector>(_shortVector, _monthAtom);
//         Modulo<ShortVector, MonthVector, MonthVector>(_shortVector, _monthVector);
//     }
//
//     [Test]
//     public void ShortModuloDateReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, DateAtom, DateAtom>(_shortAtom, _dateAtom);
//         Modulo<ShortAtom, DateVector, DateVector>(_shortAtom, _dateVector);
//         Modulo<ShortVector, DateAtom, DateVector>(_shortVector, _dateAtom);
//         Modulo<ShortVector, DateVector, DateVector>(_shortVector, _dateVector);
//     }
//
//     [Test]
//     public void ShortModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, TimespanAtom, TimespanAtom>(_shortAtom, _timespanAtom);
//         Modulo<ShortAtom, TimespanVector, TimespanVector>(_shortAtom, _timespanVector);
//         Modulo<ShortVector, TimespanAtom, TimespanVector>(_shortVector, _timespanAtom);
//         Modulo<ShortVector, TimespanVector, TimespanVector>(_shortVector, _timespanVector);
//     }
//
//     [Test]
//     public void ShortModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, MinuteAtom, MinuteAtom>(_shortAtom, _minuteAtom);
//         Modulo<ShortAtom, MinuteVector, MinuteVector>(_shortAtom, _minuteVector);
//         Modulo<ShortVector, MinuteAtom, MinuteVector>(_shortVector, _minuteAtom);
//         Modulo<ShortVector, MinuteVector, MinuteVector>(_shortVector, _minuteVector);
//     }
//
//     [Test]
//     public void ShortModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<ShortAtom, SecondAtom, SecondAtom>(_shortAtom, _secondAtom);
//         Modulo<ShortAtom, SecondVector, SecondVector>(_shortAtom, _secondVector);
//         Modulo<ShortVector, SecondAtom, SecondVector>(_shortVector, _secondAtom);
//         Modulo<ShortVector, SecondVector, SecondVector>(_shortVector, _secondVector);
//     }
//
//     [Test]
//     public void IntModuloByteReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, ByteAtom, IntAtom>(_intAtom, _byteAtom);
//         Modulo<IntAtom, ByteVector, IntVector>(_intAtom, _byteVector);
//         Modulo<IntVector, ByteAtom, IntVector>(_intVector, _byteAtom);
//         Modulo<IntVector, ByteVector, IntVector>(_intVector, _byteVector);
//     }
//
//     [Test]
//     public void IntModuloShortReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, ShortAtom, IntAtom>(_intAtom, _shortAtom);
//         Modulo<IntAtom, ShortVector, IntVector>(_intAtom, _shortVector);
//         Modulo<IntVector, ShortAtom, IntVector>(_intVector, _shortAtom);
//         Modulo<IntVector, ShortVector, IntVector>(_intVector, _shortVector);
//     }
//
//     [Test]
//     public void IntModuloIntReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, IntAtom, IntAtom>(_intAtom, _intAtom);
//         Modulo<IntAtom, IntVector, IntVector>(_intAtom, _intVector);
//         Modulo<IntVector, IntAtom, IntVector>(_intVector, _intAtom);
//         Modulo<IntVector, IntVector, IntVector>(_intVector, _intVector);
//     }
//
//     [Test]
//     public void IntModuloLongReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, LongAtom, LongAtom>(_intAtom, _longAtom);
//         Modulo<IntAtom, LongVector, LongVector>(_intAtom, _longVector);
//         Modulo<IntVector, LongAtom, LongVector>(_intVector, _longAtom);
//         Modulo<IntVector, LongVector, LongVector>(_intVector, _longVector);
//     }
//
//     [Test]
//     public void IntModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, FloatAtom, FloatAtom>(_intAtom, _floatAtom);
//         Modulo<IntAtom, FloatVector, FloatVector>(_intAtom, _floatVector);
//         Modulo<IntVector, FloatAtom, FloatVector>(_intVector, _floatAtom);
//         Modulo<IntVector, FloatVector, FloatVector>(_intVector, _floatVector);
//     }
//
//     [Test]
//     public void IntModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, DoubleAtom, DoubleAtom>(_intAtom, _doubleAtom);
//         Modulo<IntAtom, DoubleVector, DoubleVector>(_intAtom, _doubleVector);
//         Modulo<IntVector, DoubleAtom, DoubleVector>(_intVector, _doubleAtom);
//         Modulo<IntVector, DoubleVector, DoubleVector>(_intVector, _doubleVector);
//     }
//
//     [Test]
//     public void IntModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, TimestampAtom, TimestampAtom>(_intAtom, _timestampAtom);
//         Modulo<IntAtom, TimestampVector, TimestampVector>(_intAtom, _timestampVector);
//         Modulo<IntVector, TimestampAtom, TimestampVector>(_intVector, _timestampAtom);
//         Modulo<IntVector, TimestampVector, TimestampVector>(_intVector, _timestampVector);
//     }
//
//     [Test]
//     public void IntModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, MonthAtom, MonthAtom>(_intAtom, _monthAtom);
//         Modulo<IntAtom, MonthVector, MonthVector>(_intAtom, _monthVector);
//         Modulo<IntVector, MonthAtom, MonthVector>(_intVector, _monthAtom);
//         Modulo<IntVector, MonthVector, MonthVector>(_intVector, _monthVector);
//     }
//
//     [Test]
//     public void IntModuloDateReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, DateAtom, DateAtom>(_intAtom, _dateAtom);
//         Modulo<IntAtom, DateVector, DateVector>(_intAtom, _dateVector);
//         Modulo<IntVector, DateAtom, DateVector>(_intVector, _dateAtom);
//         Modulo<IntVector, DateVector, DateVector>(_intVector, _dateVector);
//     }
//
//     [Test]
//     public void IntModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, TimespanAtom, TimespanAtom>(_intAtom, _timespanAtom);
//         Modulo<IntAtom, TimespanVector, TimespanVector>(_intAtom, _timespanVector);
//         Modulo<IntVector, TimespanAtom, TimespanVector>(_intVector, _timespanAtom);
//         Modulo<IntVector, TimespanVector, TimespanVector>(_intVector, _timespanVector);
//     }
//
//     [Test]
//     public void IntModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, MinuteAtom, MinuteAtom>(_intAtom, _minuteAtom);
//         Modulo<IntAtom, MinuteVector, MinuteVector>(_intAtom, _minuteVector);
//         Modulo<IntVector, MinuteAtom, MinuteVector>(_intVector, _minuteAtom);
//         Modulo<IntVector, MinuteVector, MinuteVector>(_intVector, _minuteVector);
//     }
//
//     [Test]
//     public void IntModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<IntAtom, SecondAtom, SecondAtom>(_intAtom, _secondAtom);
//         Modulo<IntAtom, SecondVector, SecondVector>(_intAtom, _secondVector);
//         Modulo<IntVector, SecondAtom, SecondVector>(_intVector, _secondAtom);
//         Modulo<IntVector, SecondVector, SecondVector>(_intVector, _secondVector);
//     }
//
//     [Test]
//     public void LongModuloByteReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, ByteAtom, LongAtom>(_longAtom, _byteAtom);
//         Modulo<LongAtom, ByteVector, LongVector>(_longAtom, _byteVector);
//         Modulo<LongVector, ByteAtom, LongVector>(_longVector, _byteAtom);
//         Modulo<LongVector, ByteVector, LongVector>(_longVector, _byteVector);
//     }
//
//     [Test]
//     public void LongModuloShortReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, ShortAtom, LongAtom>(_longAtom, _shortAtom);
//         Modulo<LongAtom, ShortVector, LongVector>(_longAtom, _shortVector);
//         Modulo<LongVector, ShortAtom, LongVector>(_longVector, _shortAtom);
//         Modulo<LongVector, ShortVector, LongVector>(_longVector, _shortVector);
//     }
//
//     [Test]
//     public void LongModuloIntReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, IntAtom, LongAtom>(_longAtom, _intAtom);
//         Modulo<LongAtom, IntVector, LongVector>(_longAtom, _intVector);
//         Modulo<LongVector, IntAtom, LongVector>(_longVector, _intAtom);
//         Modulo<LongVector, IntVector, LongVector>(_longVector, _intVector);
//     }
//
//     [Test]
//     public void LongModuloLongReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, LongAtom, LongAtom>(_longAtom, _longAtom);
//         Modulo<LongAtom, LongVector, LongVector>(_longAtom, _longVector);
//         Modulo<LongVector, LongAtom, LongVector>(_longVector, _longAtom);
//         Modulo<LongVector, LongVector, LongVector>(_longVector, _longVector);
//     }
//
//     [Test]
//     public void LongModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, FloatAtom, FloatAtom>(_longAtom, _floatAtom);
//         Modulo<LongAtom, FloatVector, FloatVector>(_longAtom, _floatVector);
//         Modulo<LongVector, FloatAtom, FloatVector>(_longVector, _floatAtom);
//         Modulo<LongVector, FloatVector, FloatVector>(_longVector, _floatVector);
//     }
//
//     [Test]
//     public void LongModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, DoubleAtom, DoubleAtom>(_longAtom, _doubleAtom);
//         Modulo<LongAtom, DoubleVector, DoubleVector>(_longAtom, _doubleVector);
//         Modulo<LongVector, DoubleAtom, DoubleVector>(_longVector, _doubleAtom);
//         Modulo<LongVector, DoubleVector, DoubleVector>(_longVector, _doubleVector);
//     }
//
//     [Test]
//     public void LongModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, TimestampAtom, TimestampAtom>(_longAtom, _timestampAtom);
//         Modulo<LongAtom, TimestampVector, TimestampVector>(_longAtom, _timestampVector);
//         Modulo<LongVector, TimestampAtom, TimestampVector>(_longVector, _timestampAtom);
//         Modulo<LongVector, TimestampVector, TimestampVector>(_longVector, _timestampVector);
//     }
//
//     [Test]
//     public void LongModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, MonthAtom, MonthAtom>(_longAtom, _monthAtom);
//         Modulo<LongAtom, MonthVector, MonthVector>(_longAtom, _monthVector);
//         Modulo<LongVector, MonthAtom, MonthVector>(_longVector, _monthAtom);
//         Modulo<LongVector, MonthVector, MonthVector>(_longVector, _monthVector);
//     }
//
//     [Test]
//     public void LongModuloDateReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, DateAtom, DateAtom>(_longAtom, _dateAtom);
//         Modulo<LongAtom, DateVector, DateVector>(_longAtom, _dateVector);
//         Modulo<LongVector, DateAtom, DateVector>(_longVector, _dateAtom);
//         Modulo<LongVector, DateVector, DateVector>(_longVector, _dateVector);
//     }
//
//     [Test]
//     public void LongModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, TimespanAtom, TimespanAtom>(_longAtom, _timespanAtom);
//         Modulo<LongAtom, TimespanVector, TimespanVector>(_longAtom, _timespanVector);
//         Modulo<LongVector, TimespanAtom, TimespanVector>(_longVector, _timespanAtom);
//         Modulo<LongVector, TimespanVector, TimespanVector>(_longVector, _timespanVector);
//     }
//
//     [Test]
//     public void LongModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, MinuteAtom, MinuteAtom>(_longAtom, _minuteAtom);
//         Modulo<LongAtom, MinuteVector, MinuteVector>(_longAtom, _minuteVector);
//         Modulo<LongVector, MinuteAtom, MinuteVector>(_longVector, _minuteAtom);
//         Modulo<LongVector, MinuteVector, MinuteVector>(_longVector, _minuteVector);
//     }
//
//     [Test]
//     public void LongModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<LongAtom, SecondAtom, SecondAtom>(_longAtom, _secondAtom);
//         Modulo<LongAtom, SecondVector, SecondVector>(_longAtom, _secondVector);
//         Modulo<LongVector, SecondAtom, SecondVector>(_longVector, _secondAtom);
//         Modulo<LongVector, SecondVector, SecondVector>(_longVector, _secondVector);
//     }
//
//     [Test]
//     public void FloatModuloByteReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, ByteAtom, DoubleAtom>(_floatAtom, _byteAtom);
//         Modulo<FloatAtom, ByteVector, DoubleVector>(_floatAtom, _byteVector);
//         Modulo<FloatVector, ByteAtom, DoubleVector>(_floatVector, _byteAtom);
//         Modulo<FloatVector, ByteVector, DoubleVector>(_floatVector, _byteVector);
//     }
//
//     [Test]
//     public void FloatModuloShortReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, ShortAtom, DoubleAtom>(_floatAtom, _shortAtom);
//         Modulo<FloatAtom, ShortVector, DoubleVector>(_floatAtom, _shortVector);
//         Modulo<FloatVector, ShortAtom, DoubleVector>(_floatVector, _shortAtom);
//         Modulo<FloatVector, ShortVector, DoubleVector>(_floatVector, _shortVector);
//     }
//
//     [Test]
//     public void FloatModuloIntReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, IntAtom, DoubleAtom>(_floatAtom, _intAtom);
//         Modulo<FloatAtom, IntVector, DoubleVector>(_floatAtom, _intVector);
//         Modulo<FloatVector, IntAtom, DoubleVector>(_floatVector, _intAtom);
//         Modulo<FloatVector, IntVector, DoubleVector>(_floatVector, _intVector);
//     }
//
//     [Test]
//     public void FloatModuloLongReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, LongAtom, DoubleAtom>(_floatAtom, _longAtom);
//         Modulo<FloatAtom, LongVector, DoubleVector>(_floatAtom, _longVector);
//         Modulo<FloatVector, LongAtom, DoubleVector>(_floatVector, _longAtom);
//         Modulo<FloatVector, LongVector, DoubleVector>(_floatVector, _longVector);
//     }
//
//     [Test]
//     public void FloatModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, FloatAtom, DoubleAtom>(_floatAtom, _floatAtom);
//         Modulo<FloatAtom, FloatVector, DoubleVector>(_floatAtom, _floatVector);
//         Modulo<FloatVector, FloatAtom, DoubleVector>(_floatVector, _floatAtom);
//         Modulo<FloatVector, FloatVector, DoubleVector>(_floatVector, _floatVector);
//     }
//
//     [Test]
//     public void FloatModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, DoubleAtom, DoubleAtom>(_floatAtom, _doubleAtom);
//         Modulo<FloatAtom, DoubleVector, DoubleVector>(_floatAtom, _doubleVector);
//         Modulo<FloatVector, DoubleAtom, DoubleVector>(_floatVector, _doubleAtom);
//         Modulo<FloatVector, DoubleVector, DoubleVector>(_floatVector, _doubleVector);
//     }
//
//     [Test]
//     public void FloatModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, TimestampAtom, DoubleAtom>(_floatAtom, _timestampAtom);
//         Modulo<FloatAtom, TimestampVector, DoubleVector>(_floatAtom, _timestampVector);
//         Modulo<FloatVector, TimestampAtom, DoubleVector>(_floatVector, _timestampAtom);
//         Modulo<FloatVector, TimestampVector, DoubleVector>(_floatVector, _timestampVector);
//     }
//
//     [Test]
//     public void FloatModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, MonthAtom, DoubleAtom>(_floatAtom, _monthAtom);
//         Modulo<FloatAtom, MonthVector, DoubleVector>(_floatAtom, _monthVector);
//         Modulo<FloatVector, MonthAtom, DoubleVector>(_floatVector, _monthAtom);
//         Modulo<FloatVector, MonthVector, DoubleVector>(_floatVector, _monthVector);
//     }
//
//     [Test]
//     public void FloatModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, TimespanAtom, DoubleAtom>(_floatAtom, _timespanAtom);
//         Modulo<FloatAtom, TimespanVector, DoubleVector>(_floatAtom, _timespanVector);
//         Modulo<FloatVector, TimespanAtom, DoubleVector>(_floatVector, _timespanAtom);
//         Modulo<FloatVector, TimespanVector, DoubleVector>(_floatVector, _timespanVector);
//     }
//
//     [Test]
//     public void FloatModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, MinuteAtom, DoubleAtom>(_floatAtom, _minuteAtom);
//         Modulo<FloatAtom, MinuteVector, DoubleVector>(_floatAtom, _minuteVector);
//         Modulo<FloatVector, MinuteAtom, DoubleVector>(_floatVector, _minuteAtom);
//         Modulo<FloatVector, MinuteVector, DoubleVector>(_floatVector, _minuteVector);
//     }
//
//     [Test]
//     public void FloatModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<FloatAtom, SecondAtom, DoubleAtom>(_floatAtom, _secondAtom);
//         Modulo<FloatAtom, SecondVector, DoubleVector>(_floatAtom, _secondVector);
//         Modulo<FloatVector, SecondAtom, DoubleVector>(_floatVector, _secondAtom);
//         Modulo<FloatVector, SecondVector, DoubleVector>(_floatVector, _secondVector);
//     }
//
//     [Test]
//     public void DoubleModuloByteReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, ByteAtom, DoubleAtom>(_doubleAtom, _byteAtom);
//         Modulo<DoubleAtom, ByteVector, DoubleVector>(_doubleAtom, _byteVector);
//         Modulo<DoubleVector, ByteAtom, DoubleVector>(_doubleVector, _byteAtom);
//         Modulo<DoubleVector, ByteVector, DoubleVector>(_doubleVector, _byteVector);
//     }
//
//     [Test]
//     public void DoubleModuloShortReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, ShortAtom, DoubleAtom>(_doubleAtom, _shortAtom);
//         Modulo<DoubleAtom, ShortVector, DoubleVector>(_doubleAtom, _shortVector);
//         Modulo<DoubleVector, ShortAtom, DoubleVector>(_doubleVector, _shortAtom);
//         Modulo<DoubleVector, ShortVector, DoubleVector>(_doubleVector, _shortVector);
//     }
//
//     [Test]
//     public void DoubleModuloIntReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, IntAtom, DoubleAtom>(_doubleAtom, _intAtom);
//         Modulo<DoubleAtom, IntVector, DoubleVector>(_doubleAtom, _intVector);
//         Modulo<DoubleVector, IntAtom, DoubleVector>(_doubleVector, _intAtom);
//         Modulo<DoubleVector, IntVector, DoubleVector>(_doubleVector, _intVector);
//     }
//
//     [Test]
//     public void DoubleModuloLongReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, LongAtom, DoubleAtom>(_doubleAtom, _longAtom);
//         Modulo<DoubleAtom, LongVector, DoubleVector>(_doubleAtom, _longVector);
//         Modulo<DoubleVector, LongAtom, DoubleVector>(_doubleVector, _longAtom);
//         Modulo<DoubleVector, LongVector, DoubleVector>(_doubleVector, _longVector);
//     }
//
//     [Test]
//     public void DoubleModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, FloatAtom, DoubleAtom>(_doubleAtom, _floatAtom);
//         Modulo<DoubleAtom, FloatVector, DoubleVector>(_doubleAtom, _floatVector);
//         Modulo<DoubleVector, FloatAtom, DoubleVector>(_doubleVector, _floatAtom);
//         Modulo<DoubleVector, FloatVector, DoubleVector>(_doubleVector, _floatVector);
//     }
//
//     [Test]
//     public void DoubleModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, DoubleAtom, DoubleAtom>(_doubleAtom, _doubleAtom);
//         Modulo<DoubleAtom, DoubleVector, DoubleVector>(_doubleAtom, _doubleVector);
//         Modulo<DoubleVector, DoubleAtom, DoubleVector>(_doubleVector, _doubleAtom);
//         Modulo<DoubleVector, DoubleVector, DoubleVector>(_doubleVector, _doubleVector);
//     }
//
//     [Test]
//     public void DoubleModuloTimestampReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, TimestampAtom, DoubleAtom>(_doubleAtom, _timestampAtom);
//         Modulo<DoubleAtom, TimestampVector, DoubleVector>(_doubleAtom, _timestampVector);
//         Modulo<DoubleVector, TimestampAtom, DoubleVector>(_doubleVector, _timestampAtom);
//         Modulo<DoubleVector, TimestampVector, DoubleVector>(_doubleVector, _timestampVector);
//     }
//
//     [Test]
//     public void DoubleModuloMonthReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, MonthAtom, DoubleAtom>(_doubleAtom, _monthAtom);
//         Modulo<DoubleAtom, MonthVector, DoubleVector>(_doubleAtom, _monthVector);
//         Modulo<DoubleVector, MonthAtom, DoubleVector>(_doubleVector, _monthAtom);
//         Modulo<DoubleVector, MonthVector, DoubleVector>(_doubleVector, _monthVector);
//     }
//
//     [Test]
//     public void DoubleModuloTimespanReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, TimespanAtom, DoubleAtom>(_doubleAtom, _timespanAtom);
//         Modulo<DoubleAtom, TimespanVector, DoubleVector>(_doubleAtom, _timespanVector);
//         Modulo<DoubleVector, TimespanAtom, DoubleVector>(_doubleVector, _timespanAtom);
//         Modulo<DoubleVector, TimespanVector, DoubleVector>(_doubleVector, _timespanVector);
//     }
//
//     [Test]
//     public void DoubleModuloMinuteReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, MinuteAtom, DoubleAtom>(_doubleAtom, _minuteAtom);
//         Modulo<DoubleAtom, MinuteVector, DoubleVector>(_doubleAtom, _minuteVector);
//         Modulo<DoubleVector, MinuteAtom, DoubleVector>(_doubleVector, _minuteAtom);
//         Modulo<DoubleVector, MinuteVector, DoubleVector>(_doubleVector, _minuteVector);
//     }
//
//     [Test]
//     public void DoubleModuloSecondReturnsCorrectTypes()
//     {
//         Modulo<DoubleAtom, SecondAtom, DoubleAtom>(_doubleAtom, _secondAtom);
//         Modulo<DoubleAtom, SecondVector, DoubleVector>(_doubleAtom, _secondVector);
//         Modulo<DoubleVector, SecondAtom, DoubleVector>(_doubleVector, _secondAtom);
//         Modulo<DoubleVector, SecondVector, DoubleVector>(_doubleVector, _secondVector);
//     }
//
//     [Test]
//     public void TimestampModuloByteReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, ByteAtom, TimespanAtom>(_timestampAtom, _byteAtom);
//         Modulo<TimestampAtom, ByteVector, TimespanVector>(_timestampAtom, _byteVector);
//         Modulo<TimestampVector, ByteAtom, TimespanVector>(_timestampVector, _byteAtom);
//         Modulo<TimestampVector, ByteVector, TimespanVector>(_timestampVector, _byteVector);
//     }
//
//     [Test]
//     public void TimestampModuloShortReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, ShortAtom, TimespanAtom>(_timestampAtom, _shortAtom);
//         Modulo<TimestampAtom, ShortVector, TimespanVector>(_timestampAtom, _shortVector);
//         Modulo<TimestampVector, ShortAtom, TimespanVector>(_timestampVector, _shortAtom);
//         Modulo<TimestampVector, ShortVector, TimespanVector>(_timestampVector, _shortVector);
//     }
//
//     [Test]
//     public void TimestampModuloIntReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, IntAtom, TimespanAtom>(_timestampAtom, _intAtom);
//         Modulo<TimestampAtom, IntVector, TimespanVector>(_timestampAtom, _intVector);
//         Modulo<TimestampVector, IntAtom, TimespanVector>(_timestampVector, _intAtom);
//         Modulo<TimestampVector, IntVector, TimespanVector>(_timestampVector, _intVector);
//     }
//
//     [Test]
//     public void TimestampModuloLongReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, LongAtom, TimespanAtom>(_timestampAtom, _longAtom);
//         Modulo<TimestampAtom, LongVector, TimespanVector>(_timestampAtom, _longVector);
//         Modulo<TimestampVector, LongAtom, TimespanVector>(_timestampVector, _longAtom);
//         Modulo<TimestampVector, LongVector, TimespanVector>(_timestampVector, _longVector);
//     }
//
//     [Test]
//     public void TimestampModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, FloatAtom, TimespanAtom>(_timestampAtom, _floatAtom);
//         Modulo<TimestampAtom, FloatVector, TimespanVector>(_timestampAtom, _floatVector);
//         Modulo<TimestampVector, FloatAtom, TimespanVector>(_timestampVector, _floatAtom);
//         Modulo<TimestampVector, FloatVector, TimespanVector>(_timestampVector, _floatVector);
//     }
//
//     [Test]
//     public void TimestampModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<TimestampAtom, DoubleAtom, DoubleAtom>(_timestampAtom, _doubleAtom);
//         Modulo<TimestampAtom, DoubleVector, DoubleVector>(_timestampAtom, _doubleVector);
//         Modulo<TimestampVector, DoubleAtom, DoubleVector>(_timestampVector, _doubleAtom);
//         Modulo<TimestampVector, DoubleVector, DoubleVector>(_timestampVector, _doubleVector);
//     }
//
//     [Test]
//     public void MonthModuloByteReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, ByteAtom, IntAtom>(_monthAtom, _byteAtom);
//         Modulo<MonthAtom, ByteVector, IntVector>(_monthAtom, _byteVector);
//         Modulo<MonthVector, ByteAtom, IntVector>(_monthVector, _byteAtom);
//         Modulo<MonthVector, ByteVector, IntVector>(_monthVector, _byteVector);
//     }
//
//     [Test]
//     public void MonthModuloShortReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, ShortAtom, IntAtom>(_monthAtom, _shortAtom);
//         Modulo<MonthAtom, ShortVector, IntVector>(_monthAtom, _shortVector);
//         Modulo<MonthVector, ShortAtom, IntVector>(_monthVector, _shortAtom);
//         Modulo<MonthVector, ShortVector, IntVector>(_monthVector, _shortVector);
//     }
//
//     [Test]
//     public void MonthModuloIntReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, IntAtom, IntAtom>(_monthAtom, _intAtom);
//         Modulo<MonthAtom, IntVector, IntVector>(_monthAtom, _intVector);
//         Modulo<MonthVector, IntAtom, IntVector>(_monthVector, _intAtom);
//         Modulo<MonthVector, IntVector, IntVector>(_monthVector, _intVector);
//     }
//
//     [Test]
//     public void MonthModuloLongReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, LongAtom, IntAtom>(_monthAtom, _longAtom);
//         Modulo<MonthAtom, LongVector, IntVector>(_monthAtom, _longVector);
//         Modulo<MonthVector, LongAtom, IntVector>(_monthVector, _longAtom);
//         Modulo<MonthVector, LongVector, IntVector>(_monthVector, _longVector);
//     }
//
//     [Test]
//     public void MonthModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, FloatAtom, IntAtom>(_monthAtom, _floatAtom);
//         Modulo<MonthAtom, FloatVector, IntVector>(_monthAtom, _floatVector);
//         Modulo<MonthVector, FloatAtom, IntVector>(_monthVector, _floatAtom);
//         Modulo<MonthVector, FloatVector, IntVector>(_monthVector, _floatVector);
//     }
//
//     [Test]
//     public void MonthModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<MonthAtom, DoubleAtom, DoubleAtom>(_monthAtom, _doubleAtom);
//         Modulo<MonthAtom, DoubleVector, DoubleVector>(_monthAtom, _doubleVector);
//         Modulo<MonthVector, DoubleAtom, DoubleVector>(_monthVector, _doubleAtom);
//         Modulo<MonthVector, DoubleVector, DoubleVector>(_monthVector, _doubleVector);
//     }
//
//     [Test]
//     public void DateModuloByteReturnsCorrectTypes()
//     {
//         Modulo<DateAtom, ByteAtom, IntAtom>(_dateAtom, _byteAtom);
//         Modulo<DateAtom, ByteVector, IntVector>(_dateAtom, _byteVector);
//         Modulo<DateVector, ByteAtom, IntVector>(_dateVector, _byteAtom);
//         Modulo<DateVector, ByteVector, IntVector>(_dateVector, _byteVector);
//     }
//
//     [Test]
//     public void DateModuloShortReturnsCorrectTypes()
//     {
//         Modulo<DateAtom, ShortAtom, IntAtom>(_dateAtom, _shortAtom);
//         Modulo<DateAtom, ShortVector, IntVector>(_dateAtom, _shortVector);
//         Modulo<DateVector, ShortAtom, IntVector>(_dateVector, _shortAtom);
//         Modulo<DateVector, ShortVector, IntVector>(_dateVector, _shortVector);
//     }
//
//     [Test]
//     public void DateModuloIntReturnsCorrectTypes()
//     {
//         Modulo<DateAtom, IntAtom, IntAtom>(_dateAtom, _intAtom);
//         Modulo<DateAtom, IntVector, IntVector>(_dateAtom, _intVector);
//         Modulo<DateVector, IntAtom, IntVector>(_dateVector, _intAtom);
//         Modulo<DateVector, IntVector, IntVector>(_dateVector, _intVector);
//     }
//
//     [Test]
//     public void DateModuloLongReturnsCorrectTypes()
//     {
//         Modulo<DateAtom, LongAtom, IntAtom>(_dateAtom, _longAtom);
//         Modulo<DateAtom, LongVector, IntVector>(_dateAtom, _longVector);
//         Modulo<DateVector, LongAtom, IntVector>(_dateVector, _longAtom);
//         Modulo<DateVector, LongVector, IntVector>(_dateVector, _longVector);
//     }
//
//     [Test]
//     public void DateModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<DateAtom, FloatAtom, IntAtom>(_dateAtom, _floatAtom);
//         Modulo<DateAtom, FloatVector, IntVector>(_dateAtom, _floatVector);
//         Modulo<DateVector, FloatAtom, IntVector>(_dateVector, _floatAtom);
//         Modulo<DateVector, FloatVector, IntVector>(_dateVector, _floatVector);
//     }
//
//     [Test]
//     public void TimespanModuloByteReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, ByteAtom, TimespanAtom>(_timespanAtom, _byteAtom);
//         Modulo<TimespanAtom, ByteVector, TimespanVector>(_timespanAtom, _byteVector);
//         Modulo<TimespanVector, ByteAtom, TimespanVector>(_timespanVector, _byteAtom);
//         Modulo<TimespanVector, ByteVector, TimespanVector>(_timespanVector, _byteVector);
//     }
//
//     [Test]
//     public void TimespanModuloShortReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, ShortAtom, TimespanAtom>(_timespanAtom, _shortAtom);
//         Modulo<TimespanAtom, ShortVector, TimespanVector>(_timespanAtom, _shortVector);
//         Modulo<TimespanVector, ShortAtom, TimespanVector>(_timespanVector, _shortAtom);
//         Modulo<TimespanVector, ShortVector, TimespanVector>(_timespanVector, _shortVector);
//     }
//
//     [Test]
//     public void TimespanModuloIntReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, IntAtom, TimespanAtom>(_timespanAtom, _intAtom);
//         Modulo<TimespanAtom, IntVector, TimespanVector>(_timespanAtom, _intVector);
//         Modulo<TimespanVector, IntAtom, TimespanVector>(_timespanVector, _intAtom);
//         Modulo<TimespanVector, IntVector, TimespanVector>(_timespanVector, _intVector);
//     }
//
//     [Test]
//     public void TimespanModuloLongReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, LongAtom, TimespanAtom>(_timespanAtom, _longAtom);
//         Modulo<TimespanAtom, LongVector, TimespanVector>(_timespanAtom, _longVector);
//         Modulo<TimespanVector, LongAtom, TimespanVector>(_timespanVector, _longAtom);
//         Modulo<TimespanVector, LongVector, TimespanVector>(_timespanVector, _longVector);
//     }
//
//     [Test]
//     public void TimespanModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, FloatAtom, TimespanAtom>(_timespanAtom, _floatAtom);
//         Modulo<TimespanAtom, FloatVector, TimespanVector>(_timespanAtom, _floatVector);
//         Modulo<TimespanVector, FloatAtom, TimespanVector>(_timespanVector, _floatAtom);
//         Modulo<TimespanVector, FloatVector, TimespanVector>(_timespanVector, _floatVector);
//     }
//
//     [Test]
//     public void TimespanModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<TimespanAtom, DoubleAtom, DoubleAtom>(_timespanAtom, _doubleAtom);
//         Modulo<TimespanAtom, DoubleVector, DoubleVector>(_timespanAtom, _doubleVector);
//         Modulo<TimespanVector, DoubleAtom, DoubleVector>(_timespanVector, _doubleAtom);
//         Modulo<TimespanVector, DoubleVector, DoubleVector>(_timespanVector, _doubleVector);
//     }
//
//     [Test]
//     public void MinuteModuloByteReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, ByteAtom, MinuteAtom>(_minuteAtom, _byteAtom);
//         Modulo<MinuteAtom, ByteVector, MinuteVector>(_minuteAtom, _byteVector);
//         Modulo<MinuteVector, ByteAtom, MinuteVector>(_minuteVector, _byteAtom);
//         Modulo<MinuteVector, ByteVector, MinuteVector>(_minuteVector, _byteVector);
//     }
//
//     [Test]
//     public void MinuteModuloShortReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, ShortAtom, MinuteAtom>(_minuteAtom, _shortAtom);
//         Modulo<MinuteAtom, ShortVector, MinuteVector>(_minuteAtom, _shortVector);
//         Modulo<MinuteVector, ShortAtom, MinuteVector>(_minuteVector, _shortAtom);
//         Modulo<MinuteVector, ShortVector, MinuteVector>(_minuteVector, _shortVector);
//     }
//
//     [Test]
//     public void MinuteModuloIntReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, IntAtom, MinuteAtom>(_minuteAtom, _intAtom);
//         Modulo<MinuteAtom, IntVector, MinuteVector>(_minuteAtom, _intVector);
//         Modulo<MinuteVector, IntAtom, MinuteVector>(_minuteVector, _intAtom);
//         Modulo<MinuteVector, IntVector, MinuteVector>(_minuteVector, _intVector);
//     }
//
//     [Test]
//     public void MinuteModuloLongReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, LongAtom, MinuteAtom>(_minuteAtom, _longAtom);
//         Modulo<MinuteAtom, LongVector, MinuteVector>(_minuteAtom, _longVector);
//         Modulo<MinuteVector, LongAtom, MinuteVector>(_minuteVector, _longAtom);
//         Modulo<MinuteVector, LongVector, MinuteVector>(_minuteVector, _longVector);
//     }
//
//     [Test]
//     public void MinuteModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, FloatAtom, MinuteAtom>(_minuteAtom, _floatAtom);
//         Modulo<MinuteAtom, FloatVector, MinuteVector>(_minuteAtom, _floatVector);
//         Modulo<MinuteVector, FloatAtom, MinuteVector>(_minuteVector, _floatAtom);
//         Modulo<MinuteVector, FloatVector, MinuteVector>(_minuteVector, _floatVector);
//     }
//
//     [Test]
//     public void MinuteModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<MinuteAtom, DoubleAtom, DoubleAtom>(_minuteAtom, _doubleAtom);
//         Modulo<MinuteAtom, DoubleVector, DoubleVector>(_minuteAtom, _doubleVector);
//         Modulo<MinuteVector, DoubleAtom, DoubleVector>(_minuteVector, _doubleAtom);
//         Modulo<MinuteVector, DoubleVector, DoubleVector>(_minuteVector, _doubleVector);
//     }
//
//     [Test]
//     public void SecondModuloByteReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, ByteAtom, SecondAtom>(_secondAtom, _byteAtom);
//         Modulo<SecondAtom, ByteVector, SecondVector>(_secondAtom, _byteVector);
//         Modulo<SecondVector, ByteAtom, SecondVector>(_secondVector, _byteAtom);
//         Modulo<SecondVector, ByteVector, SecondVector>(_secondVector, _byteVector);
//     }
//
//     [Test]
//     public void SecondModuloShortReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, ShortAtom, SecondAtom>(_secondAtom, _shortAtom);
//         Modulo<SecondAtom, ShortVector, SecondVector>(_secondAtom, _shortVector);
//         Modulo<SecondVector, ShortAtom, SecondVector>(_secondVector, _shortAtom);
//         Modulo<SecondVector, ShortVector, SecondVector>(_secondVector, _shortVector);
//     }
//
//     [Test]
//     public void SecondModuloIntReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, IntAtom, SecondAtom>(_secondAtom, _intAtom);
//         Modulo<SecondAtom, IntVector, SecondVector>(_secondAtom, _intVector);
//         Modulo<SecondVector, IntAtom, SecondVector>(_secondVector, _intAtom);
//         Modulo<SecondVector, IntVector, SecondVector>(_secondVector, _intVector);
//     }
//
//     [Test]
//     public void SecondModuloLongReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, LongAtom, SecondAtom>(_secondAtom, _longAtom);
//         Modulo<SecondAtom, LongVector, SecondVector>(_secondAtom, _longVector);
//         Modulo<SecondVector, LongAtom, SecondVector>(_secondVector, _longAtom);
//         Modulo<SecondVector, LongVector, SecondVector>(_secondVector, _longVector);
//     }
//
//     [Test]
//     public void SecondModuloFloatReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, FloatAtom, SecondAtom>(_secondAtom, _floatAtom);
//         Modulo<SecondAtom, FloatVector, SecondVector>(_secondAtom, _floatVector);
//         Modulo<SecondVector, FloatAtom, SecondVector>(_secondVector, _floatAtom);
//         Modulo<SecondVector, FloatVector, SecondVector>(_secondVector, _floatVector);
//     }
//
//     [Test]
//     public void SecondModuloDoubleReturnsCorrectTypes()
//     {
//         Modulo<SecondAtom, DoubleAtom, DoubleAtom>(_secondAtom, _doubleAtom);
//         Modulo<SecondAtom, DoubleVector, DoubleVector>(_secondAtom, _doubleVector);
//         Modulo<SecondVector, DoubleAtom, DoubleVector>(_secondVector, _doubleAtom);
//         Modulo<SecondVector, DoubleVector, DoubleVector>(_secondVector, _doubleVector);
//     }
// }
