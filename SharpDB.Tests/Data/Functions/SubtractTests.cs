using System.Numerics;
using SharpDB.Data;

namespace SharpDB.Tests.Data.Functions;

public class SubtractTests
{
    private static void Subtract<T1, T2, T3>(T1 left, T2 right)
        where T1 : ISubtractionOperators<T1, T2, T3>
        where T2 : ISubtractionOperators<T2, T1, T3>
    {
        var result1 = left - right;
        var result2 = right - left;
        Assert.That(result1, Is.TypeOf<T3>());
        Assert.That(result2, Is.TypeOf<T3>());
    }

    private readonly ByteAtom _byteAtom = new(1);
    private readonly ByteVector _byteVector = new(new byte[] { 0, 1 });
    private readonly ShortAtom _shortAtom = new(1);
    private readonly ShortVector _shortVector = new(new short[] { 0, 1 });
    private readonly IntAtom _intAtom = new(1);
    private readonly IntVector _intVector = new(new[] { 0, 1 });
    private readonly LongAtom _longAtom = new(1);
    private readonly LongVector _longVector = new(new long[] { 0, 1 });
    private readonly FloatAtom _floatAtom = new(1);
    private readonly FloatVector _floatVector = new(new float[] { 0, 1 });
    private readonly DoubleAtom _doubleAtom = new(1);
    private readonly DoubleVector _doubleVector = new(new double[] { 0, 1 });
    private readonly TimestampAtom _timestampAtom = new(1);
    private readonly TimestampVector _timestampVector = new(new long[] { 0, 1 });
    private readonly MonthAtom _monthAtom = new(1);
    private readonly MonthVector _monthVector = new(new[] { 0, 1 });
    private readonly DateAtom _dateAtom = new(1);
    private readonly DateVector _dateVector = new(new[] { 0, 1 });
    private readonly TimespanAtom _timespanAtom = new(1);
    private readonly TimespanVector _timespanVector = new(new long[] { 0, 1 });
    private readonly MinuteAtom _minuteAtom = new(1);
    private readonly MinuteVector _minuteVector = new(new[] { 0, 1 });
    private readonly SecondAtom _secondAtom = new(1);
    private readonly SecondVector _secondVector = new(new[] { 0, 1 });

    [Test]
    public void ByteSubtractByteReturnsCorrectTypes()
    {
        Subtract<ByteAtom, ByteAtom, IntAtom>(_byteAtom, _byteAtom);
        Subtract<ByteAtom, ByteVector, IntVector>(_byteAtom, _byteVector);
        Subtract<ByteVector, ByteAtom, IntVector>(_byteVector, _byteAtom);
        Subtract<ByteVector, ByteVector, IntVector>(_byteVector, _byteVector);
    }

    [Test]
    public void ByteSubtractShortReturnsCorrectTypes()
    {
        Subtract<ByteAtom, ShortAtom, IntAtom>(_byteAtom, _shortAtom);
        Subtract<ByteAtom, ShortVector, IntVector>(_byteAtom, _shortVector);
        Subtract<ByteVector, ShortAtom, IntVector>(_byteVector, _shortAtom);
        Subtract<ByteVector, ShortVector, IntVector>(_byteVector, _shortVector);
    }

    [Test]
    public void ByteSubtractIntReturnsCorrectTypes()
    {
        Subtract<ByteAtom, IntAtom, IntAtom>(_byteAtom, _intAtom);
        Subtract<ByteAtom, IntVector, IntVector>(_byteAtom, _intVector);
        Subtract<ByteVector, IntAtom, IntVector>(_byteVector, _intAtom);
        Subtract<ByteVector, IntVector, IntVector>(_byteVector, _intVector);
    }

    [Test]
    public void ByteSubtractLongReturnsCorrectTypes()
    {
        Subtract<ByteAtom, LongAtom, LongAtom>(_byteAtom, _longAtom);
        Subtract<ByteAtom, LongVector, LongVector>(_byteAtom, _longVector);
        Subtract<ByteVector, LongAtom, LongVector>(_byteVector, _longAtom);
        Subtract<ByteVector, LongVector, LongVector>(_byteVector, _longVector);
    }

    [Test]
    public void ByteSubtractFloatReturnsCorrectTypes()
    {
        Subtract<ByteAtom, FloatAtom, FloatAtom>(_byteAtom, _floatAtom);
        Subtract<ByteAtom, FloatVector, FloatVector>(_byteAtom, _floatVector);
        Subtract<ByteVector, FloatAtom, FloatVector>(_byteVector, _floatAtom);
        Subtract<ByteVector, FloatVector, FloatVector>(_byteVector, _floatVector);
    }

    [Test]
    public void ByteSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<ByteAtom, DoubleAtom, DoubleAtom>(_byteAtom, _doubleAtom);
        Subtract<ByteAtom, DoubleVector, DoubleVector>(_byteAtom, _doubleVector);
        Subtract<ByteVector, DoubleAtom, DoubleVector>(_byteVector, _doubleAtom);
        Subtract<ByteVector, DoubleVector, DoubleVector>(_byteVector, _doubleVector);
    }

    [Test]
    public void ByteSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<ByteAtom, TimestampAtom, TimestampAtom>(_byteAtom, _timestampAtom);
        Subtract<ByteAtom, TimestampVector, TimestampVector>(_byteAtom, _timestampVector);
        Subtract<ByteVector, TimestampAtom, TimestampVector>(_byteVector, _timestampAtom);
        Subtract<ByteVector, TimestampVector, TimestampVector>(_byteVector, _timestampVector);
    }

    [Test]
    public void ByteSubtractMonthReturnsCorrectTypes()
    {
        Subtract<ByteAtom, MonthAtom, MonthAtom>(_byteAtom, _monthAtom);
        Subtract<ByteAtom, MonthVector, MonthVector>(_byteAtom, _monthVector);
        Subtract<ByteVector, MonthAtom, MonthVector>(_byteVector, _monthAtom);
        Subtract<ByteVector, MonthVector, MonthVector>(_byteVector, _monthVector);
    }

    [Test]
    public void ByteSubtractDateReturnsCorrectTypes()
    {
        Subtract<ByteAtom, DateAtom, DateAtom>(_byteAtom, _dateAtom);
        Subtract<ByteAtom, DateVector, DateVector>(_byteAtom, _dateVector);
        Subtract<ByteVector, DateAtom, DateVector>(_byteVector, _dateAtom);
        Subtract<ByteVector, DateVector, DateVector>(_byteVector, _dateVector);
    }

    [Test]
    public void ByteSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<ByteAtom, TimespanAtom, TimespanAtom>(_byteAtom, _timespanAtom);
        Subtract<ByteAtom, TimespanVector, TimespanVector>(_byteAtom, _timespanVector);
        Subtract<ByteVector, TimespanAtom, TimespanVector>(_byteVector, _timespanAtom);
        Subtract<ByteVector, TimespanVector, TimespanVector>(_byteVector, _timespanVector);
    }

    [Test]
    public void ByteSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<ByteAtom, MinuteAtom, MinuteAtom>(_byteAtom, _minuteAtom);
        Subtract<ByteAtom, MinuteVector, MinuteVector>(_byteAtom, _minuteVector);
        Subtract<ByteVector, MinuteAtom, MinuteVector>(_byteVector, _minuteAtom);
        Subtract<ByteVector, MinuteVector, MinuteVector>(_byteVector, _minuteVector);
    }

    [Test]
    public void ByteSubtractSecondReturnsCorrectTypes()
    {
        Subtract<ByteAtom, SecondAtom, SecondAtom>(_byteAtom, _secondAtom);
        Subtract<ByteAtom, SecondVector, SecondVector>(_byteAtom, _secondVector);
        Subtract<ByteVector, SecondAtom, SecondVector>(_byteVector, _secondAtom);
        Subtract<ByteVector, SecondVector, SecondVector>(_byteVector, _secondVector);
    }

    [Test]
    public void ShortSubtractByteReturnsCorrectTypes()
    {
        Subtract<ShortAtom, ByteAtom, IntAtom>(_shortAtom, _byteAtom);
        Subtract<ShortAtom, ByteVector, IntVector>(_shortAtom, _byteVector);
        Subtract<ShortVector, ByteAtom, IntVector>(_shortVector, _byteAtom);
        Subtract<ShortVector, ByteVector, IntVector>(_shortVector, _byteVector);
    }

    [Test]
    public void ShortSubtractShortReturnsCorrectTypes()
    {
        Subtract<ShortAtom, ShortAtom, IntAtom>(_shortAtom, _shortAtom);
        Subtract<ShortAtom, ShortVector, IntVector>(_shortAtom, _shortVector);
        Subtract<ShortVector, ShortAtom, IntVector>(_shortVector, _shortAtom);
        Subtract<ShortVector, ShortVector, IntVector>(_shortVector, _shortVector);
    }

    [Test]
    public void ShortSubtractIntReturnsCorrectTypes()
    {
        Subtract<ShortAtom, IntAtom, IntAtom>(_shortAtom, _intAtom);
        Subtract<ShortAtom, IntVector, IntVector>(_shortAtom, _intVector);
        Subtract<ShortVector, IntAtom, IntVector>(_shortVector, _intAtom);
        Subtract<ShortVector, IntVector, IntVector>(_shortVector, _intVector);
    }

    [Test]
    public void ShortSubtractLongReturnsCorrectTypes()
    {
        Subtract<ShortAtom, LongAtom, LongAtom>(_shortAtom, _longAtom);
        Subtract<ShortAtom, LongVector, LongVector>(_shortAtom, _longVector);
        Subtract<ShortVector, LongAtom, LongVector>(_shortVector, _longAtom);
        Subtract<ShortVector, LongVector, LongVector>(_shortVector, _longVector);
    }

    [Test]
    public void ShortSubtractFloatReturnsCorrectTypes()
    {
        Subtract<ShortAtom, FloatAtom, FloatAtom>(_shortAtom, _floatAtom);
        Subtract<ShortAtom, FloatVector, FloatVector>(_shortAtom, _floatVector);
        Subtract<ShortVector, FloatAtom, FloatVector>(_shortVector, _floatAtom);
        Subtract<ShortVector, FloatVector, FloatVector>(_shortVector, _floatVector);
    }

    [Test]
    public void ShortSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<ShortAtom, DoubleAtom, DoubleAtom>(_shortAtom, _doubleAtom);
        Subtract<ShortAtom, DoubleVector, DoubleVector>(_shortAtom, _doubleVector);
        Subtract<ShortVector, DoubleAtom, DoubleVector>(_shortVector, _doubleAtom);
        Subtract<ShortVector, DoubleVector, DoubleVector>(_shortVector, _doubleVector);
    }

    [Test]
    public void ShortSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<ShortAtom, TimestampAtom, TimestampAtom>(_shortAtom, _timestampAtom);
        Subtract<ShortAtom, TimestampVector, TimestampVector>(_shortAtom, _timestampVector);
        Subtract<ShortVector, TimestampAtom, TimestampVector>(_shortVector, _timestampAtom);
        Subtract<ShortVector, TimestampVector, TimestampVector>(_shortVector, _timestampVector);
    }

    [Test]
    public void ShortSubtractMonthReturnsCorrectTypes()
    {
        Subtract<ShortAtom, MonthAtom, MonthAtom>(_shortAtom, _monthAtom);
        Subtract<ShortAtom, MonthVector, MonthVector>(_shortAtom, _monthVector);
        Subtract<ShortVector, MonthAtom, MonthVector>(_shortVector, _monthAtom);
        Subtract<ShortVector, MonthVector, MonthVector>(_shortVector, _monthVector);
    }

    [Test]
    public void ShortSubtractDateReturnsCorrectTypes()
    {
        Subtract<ShortAtom, DateAtom, DateAtom>(_shortAtom, _dateAtom);
        Subtract<ShortAtom, DateVector, DateVector>(_shortAtom, _dateVector);
        Subtract<ShortVector, DateAtom, DateVector>(_shortVector, _dateAtom);
        Subtract<ShortVector, DateVector, DateVector>(_shortVector, _dateVector);
    }

    [Test]
    public void ShortSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<ShortAtom, TimespanAtom, TimespanAtom>(_shortAtom, _timespanAtom);
        Subtract<ShortAtom, TimespanVector, TimespanVector>(_shortAtom, _timespanVector);
        Subtract<ShortVector, TimespanAtom, TimespanVector>(_shortVector, _timespanAtom);
        Subtract<ShortVector, TimespanVector, TimespanVector>(_shortVector, _timespanVector);
    }

    [Test]
    public void ShortSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<ShortAtom, MinuteAtom, MinuteAtom>(_shortAtom, _minuteAtom);
        Subtract<ShortAtom, MinuteVector, MinuteVector>(_shortAtom, _minuteVector);
        Subtract<ShortVector, MinuteAtom, MinuteVector>(_shortVector, _minuteAtom);
        Subtract<ShortVector, MinuteVector, MinuteVector>(_shortVector, _minuteVector);
    }

    [Test]
    public void ShortSubtractSecondReturnsCorrectTypes()
    {
        Subtract<ShortAtom, SecondAtom, SecondAtom>(_shortAtom, _secondAtom);
        Subtract<ShortAtom, SecondVector, SecondVector>(_shortAtom, _secondVector);
        Subtract<ShortVector, SecondAtom, SecondVector>(_shortVector, _secondAtom);
        Subtract<ShortVector, SecondVector, SecondVector>(_shortVector, _secondVector);
    }

    [Test]
    public void IntSubtractByteReturnsCorrectTypes()
    {
        Subtract<IntAtom, ByteAtom, IntAtom>(_intAtom, _byteAtom);
        Subtract<IntAtom, ByteVector, IntVector>(_intAtom, _byteVector);
        Subtract<IntVector, ByteAtom, IntVector>(_intVector, _byteAtom);
        Subtract<IntVector, ByteVector, IntVector>(_intVector, _byteVector);
    }

    [Test]
    public void IntSubtractShortReturnsCorrectTypes()
    {
        Subtract<IntAtom, ShortAtom, IntAtom>(_intAtom, _shortAtom);
        Subtract<IntAtom, ShortVector, IntVector>(_intAtom, _shortVector);
        Subtract<IntVector, ShortAtom, IntVector>(_intVector, _shortAtom);
        Subtract<IntVector, ShortVector, IntVector>(_intVector, _shortVector);
    }

    [Test]
    public void IntSubtractIntReturnsCorrectTypes()
    {
        Subtract<IntAtom, IntAtom, IntAtom>(_intAtom, _intAtom);
        Subtract<IntAtom, IntVector, IntVector>(_intAtom, _intVector);
        Subtract<IntVector, IntAtom, IntVector>(_intVector, _intAtom);
        Subtract<IntVector, IntVector, IntVector>(_intVector, _intVector);
    }

    [Test]
    public void IntSubtractLongReturnsCorrectTypes()
    {
        Subtract<IntAtom, LongAtom, LongAtom>(_intAtom, _longAtom);
        Subtract<IntAtom, LongVector, LongVector>(_intAtom, _longVector);
        Subtract<IntVector, LongAtom, LongVector>(_intVector, _longAtom);
        Subtract<IntVector, LongVector, LongVector>(_intVector, _longVector);
    }

    [Test]
    public void IntSubtractFloatReturnsCorrectTypes()
    {
        Subtract<IntAtom, FloatAtom, FloatAtom>(_intAtom, _floatAtom);
        Subtract<IntAtom, FloatVector, FloatVector>(_intAtom, _floatVector);
        Subtract<IntVector, FloatAtom, FloatVector>(_intVector, _floatAtom);
        Subtract<IntVector, FloatVector, FloatVector>(_intVector, _floatVector);
    }

    [Test]
    public void IntSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<IntAtom, DoubleAtom, DoubleAtom>(_intAtom, _doubleAtom);
        Subtract<IntAtom, DoubleVector, DoubleVector>(_intAtom, _doubleVector);
        Subtract<IntVector, DoubleAtom, DoubleVector>(_intVector, _doubleAtom);
        Subtract<IntVector, DoubleVector, DoubleVector>(_intVector, _doubleVector);
    }

    [Test]
    public void IntSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<IntAtom, TimestampAtom, TimestampAtom>(_intAtom, _timestampAtom);
        Subtract<IntAtom, TimestampVector, TimestampVector>(_intAtom, _timestampVector);
        Subtract<IntVector, TimestampAtom, TimestampVector>(_intVector, _timestampAtom);
        Subtract<IntVector, TimestampVector, TimestampVector>(_intVector, _timestampVector);
    }

    [Test]
    public void IntSubtractMonthReturnsCorrectTypes()
    {
        Subtract<IntAtom, MonthAtom, MonthAtom>(_intAtom, _monthAtom);
        Subtract<IntAtom, MonthVector, MonthVector>(_intAtom, _monthVector);
        Subtract<IntVector, MonthAtom, MonthVector>(_intVector, _monthAtom);
        Subtract<IntVector, MonthVector, MonthVector>(_intVector, _monthVector);
    }

    [Test]
    public void IntSubtractDateReturnsCorrectTypes()
    {
        Subtract<IntAtom, DateAtom, DateAtom>(_intAtom, _dateAtom);
        Subtract<IntAtom, DateVector, DateVector>(_intAtom, _dateVector);
        Subtract<IntVector, DateAtom, DateVector>(_intVector, _dateAtom);
        Subtract<IntVector, DateVector, DateVector>(_intVector, _dateVector);
    }

    [Test]
    public void IntSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<IntAtom, TimespanAtom, TimespanAtom>(_intAtom, _timespanAtom);
        Subtract<IntAtom, TimespanVector, TimespanVector>(_intAtom, _timespanVector);
        Subtract<IntVector, TimespanAtom, TimespanVector>(_intVector, _timespanAtom);
        Subtract<IntVector, TimespanVector, TimespanVector>(_intVector, _timespanVector);
    }

    [Test]
    public void IntSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<IntAtom, MinuteAtom, MinuteAtom>(_intAtom, _minuteAtom);
        Subtract<IntAtom, MinuteVector, MinuteVector>(_intAtom, _minuteVector);
        Subtract<IntVector, MinuteAtom, MinuteVector>(_intVector, _minuteAtom);
        Subtract<IntVector, MinuteVector, MinuteVector>(_intVector, _minuteVector);
    }

    [Test]
    public void IntSubtractSecondReturnsCorrectTypes()
    {
        Subtract<IntAtom, SecondAtom, SecondAtom>(_intAtom, _secondAtom);
        Subtract<IntAtom, SecondVector, SecondVector>(_intAtom, _secondVector);
        Subtract<IntVector, SecondAtom, SecondVector>(_intVector, _secondAtom);
        Subtract<IntVector, SecondVector, SecondVector>(_intVector, _secondVector);
    }

    [Test]
    public void LongSubtractByteReturnsCorrectTypes()
    {
        Subtract<LongAtom, ByteAtom, LongAtom>(_longAtom, _byteAtom);
        Subtract<LongAtom, ByteVector, LongVector>(_longAtom, _byteVector);
        Subtract<LongVector, ByteAtom, LongVector>(_longVector, _byteAtom);
        Subtract<LongVector, ByteVector, LongVector>(_longVector, _byteVector);
    }

    [Test]
    public void LongSubtractShortReturnsCorrectTypes()
    {
        Subtract<LongAtom, ShortAtom, LongAtom>(_longAtom, _shortAtom);
        Subtract<LongAtom, ShortVector, LongVector>(_longAtom, _shortVector);
        Subtract<LongVector, ShortAtom, LongVector>(_longVector, _shortAtom);
        Subtract<LongVector, ShortVector, LongVector>(_longVector, _shortVector);
    }

    [Test]
    public void LongSubtractIntReturnsCorrectTypes()
    {
        Subtract<LongAtom, IntAtom, LongAtom>(_longAtom, _intAtom);
        Subtract<LongAtom, IntVector, LongVector>(_longAtom, _intVector);
        Subtract<LongVector, IntAtom, LongVector>(_longVector, _intAtom);
        Subtract<LongVector, IntVector, LongVector>(_longVector, _intVector);
    }

    [Test]
    public void LongSubtractLongReturnsCorrectTypes()
    {
        Subtract<LongAtom, LongAtom, LongAtom>(_longAtom, _longAtom);
        Subtract<LongAtom, LongVector, LongVector>(_longAtom, _longVector);
        Subtract<LongVector, LongAtom, LongVector>(_longVector, _longAtom);
        Subtract<LongVector, LongVector, LongVector>(_longVector, _longVector);
    }

    [Test]
    public void LongSubtractFloatReturnsCorrectTypes()
    {
        Subtract<LongAtom, FloatAtom, FloatAtom>(_longAtom, _floatAtom);
        Subtract<LongAtom, FloatVector, FloatVector>(_longAtom, _floatVector);
        Subtract<LongVector, FloatAtom, FloatVector>(_longVector, _floatAtom);
        Subtract<LongVector, FloatVector, FloatVector>(_longVector, _floatVector);
    }

    [Test]
    public void LongSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<LongAtom, DoubleAtom, DoubleAtom>(_longAtom, _doubleAtom);
        Subtract<LongAtom, DoubleVector, DoubleVector>(_longAtom, _doubleVector);
        Subtract<LongVector, DoubleAtom, DoubleVector>(_longVector, _doubleAtom);
        Subtract<LongVector, DoubleVector, DoubleVector>(_longVector, _doubleVector);
    }

    [Test]
    public void LongSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<LongAtom, TimestampAtom, TimestampAtom>(_longAtom, _timestampAtom);
        Subtract<LongAtom, TimestampVector, TimestampVector>(_longAtom, _timestampVector);
        Subtract<LongVector, TimestampAtom, TimestampVector>(_longVector, _timestampAtom);
        Subtract<LongVector, TimestampVector, TimestampVector>(_longVector, _timestampVector);
    }

    [Test]
    public void LongSubtractMonthReturnsCorrectTypes()
    {
        Subtract<LongAtom, MonthAtom, MonthAtom>(_longAtom, _monthAtom);
        Subtract<LongAtom, MonthVector, MonthVector>(_longAtom, _monthVector);
        Subtract<LongVector, MonthAtom, MonthVector>(_longVector, _monthAtom);
        Subtract<LongVector, MonthVector, MonthVector>(_longVector, _monthVector);
    }

    [Test]
    public void LongSubtractDateReturnsCorrectTypes()
    {
        Subtract<LongAtom, DateAtom, DateAtom>(_longAtom, _dateAtom);
        Subtract<LongAtom, DateVector, DateVector>(_longAtom, _dateVector);
        Subtract<LongVector, DateAtom, DateVector>(_longVector, _dateAtom);
        Subtract<LongVector, DateVector, DateVector>(_longVector, _dateVector);
    }

    [Test]
    public void LongSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<LongAtom, TimespanAtom, TimespanAtom>(_longAtom, _timespanAtom);
        Subtract<LongAtom, TimespanVector, TimespanVector>(_longAtom, _timespanVector);
        Subtract<LongVector, TimespanAtom, TimespanVector>(_longVector, _timespanAtom);
        Subtract<LongVector, TimespanVector, TimespanVector>(_longVector, _timespanVector);
    }

    [Test]
    public void LongSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<LongAtom, MinuteAtom, MinuteAtom>(_longAtom, _minuteAtom);
        Subtract<LongAtom, MinuteVector, MinuteVector>(_longAtom, _minuteVector);
        Subtract<LongVector, MinuteAtom, MinuteVector>(_longVector, _minuteAtom);
        Subtract<LongVector, MinuteVector, MinuteVector>(_longVector, _minuteVector);
    }

    [Test]
    public void LongSubtractSecondReturnsCorrectTypes()
    {
        Subtract<LongAtom, SecondAtom, SecondAtom>(_longAtom, _secondAtom);
        Subtract<LongAtom, SecondVector, SecondVector>(_longAtom, _secondVector);
        Subtract<LongVector, SecondAtom, SecondVector>(_longVector, _secondAtom);
        Subtract<LongVector, SecondVector, SecondVector>(_longVector, _secondVector);
    }

    [Test]
    public void FloatSubtractByteReturnsCorrectTypes()
    {
        Subtract<FloatAtom, ByteAtom, FloatAtom>(_floatAtom, _byteAtom);
        Subtract<FloatAtom, ByteVector, FloatVector>(_floatAtom, _byteVector);
        Subtract<FloatVector, ByteAtom, FloatVector>(_floatVector, _byteAtom);
        Subtract<FloatVector, ByteVector, FloatVector>(_floatVector, _byteVector);
    }

    [Test]
    public void FloatSubtractShortReturnsCorrectTypes()
    {
        Subtract<FloatAtom, ShortAtom, FloatAtom>(_floatAtom, _shortAtom);
        Subtract<FloatAtom, ShortVector, FloatVector>(_floatAtom, _shortVector);
        Subtract<FloatVector, ShortAtom, FloatVector>(_floatVector, _shortAtom);
        Subtract<FloatVector, ShortVector, FloatVector>(_floatVector, _shortVector);
    }

    [Test]
    public void FloatSubtractIntReturnsCorrectTypes()
    {
        Subtract<FloatAtom, IntAtom, FloatAtom>(_floatAtom, _intAtom);
        Subtract<FloatAtom, IntVector, FloatVector>(_floatAtom, _intVector);
        Subtract<FloatVector, IntAtom, FloatVector>(_floatVector, _intAtom);
        Subtract<FloatVector, IntVector, FloatVector>(_floatVector, _intVector);
    }

    [Test]
    public void FloatSubtractLongReturnsCorrectTypes()
    {
        Subtract<FloatAtom, LongAtom, FloatAtom>(_floatAtom, _longAtom);
        Subtract<FloatAtom, LongVector, FloatVector>(_floatAtom, _longVector);
        Subtract<FloatVector, LongAtom, FloatVector>(_floatVector, _longAtom);
        Subtract<FloatVector, LongVector, FloatVector>(_floatVector, _longVector);
    }

    [Test]
    public void FloatSubtractFloatReturnsCorrectTypes()
    {
        Subtract<FloatAtom, FloatAtom, FloatAtom>(_floatAtom, _floatAtom);
        Subtract<FloatAtom, FloatVector, FloatVector>(_floatAtom, _floatVector);
        Subtract<FloatVector, FloatAtom, FloatVector>(_floatVector, _floatAtom);
        Subtract<FloatVector, FloatVector, FloatVector>(_floatVector, _floatVector);
    }

    [Test]
    public void FloatSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<FloatAtom, DoubleAtom, DoubleAtom>(_floatAtom, _doubleAtom);
        Subtract<FloatAtom, DoubleVector, DoubleVector>(_floatAtom, _doubleVector);
        Subtract<FloatVector, DoubleAtom, DoubleVector>(_floatVector, _doubleAtom);
        Subtract<FloatVector, DoubleVector, DoubleVector>(_floatVector, _doubleVector);
    }

    [Test]
    public void FloatSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<FloatAtom, TimestampAtom, TimestampAtom>(_floatAtom, _timestampAtom);
        Subtract<FloatAtom, TimestampVector, TimestampVector>(_floatAtom, _timestampVector);
        Subtract<FloatVector, TimestampAtom, TimestampVector>(_floatVector, _timestampAtom);
        Subtract<FloatVector, TimestampVector, TimestampVector>(_floatVector, _timestampVector);
    }

    [Test]
    public void FloatSubtractMonthReturnsCorrectTypes()
    {
        Subtract<FloatAtom, MonthAtom, MonthAtom>(_floatAtom, _monthAtom);
        Subtract<FloatAtom, MonthVector, MonthVector>(_floatAtom, _monthVector);
        Subtract<FloatVector, MonthAtom, MonthVector>(_floatVector, _monthAtom);
        Subtract<FloatVector, MonthVector, MonthVector>(_floatVector, _monthVector);
    }

    [Test]
    public void FloatSubtractDateReturnsCorrectTypes()
    {
        Subtract<FloatAtom, DateAtom, DateAtom>(_floatAtom, _dateAtom);
        Subtract<FloatAtom, DateVector, DateVector>(_floatAtom, _dateVector);
        Subtract<FloatVector, DateAtom, DateVector>(_floatVector, _dateAtom);
        Subtract<FloatVector, DateVector, DateVector>(_floatVector, _dateVector);
    }

    [Test]
    public void FloatSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<FloatAtom, TimespanAtom, TimespanAtom>(_floatAtom, _timespanAtom);
        Subtract<FloatAtom, TimespanVector, TimespanVector>(_floatAtom, _timespanVector);
        Subtract<FloatVector, TimespanAtom, TimespanVector>(_floatVector, _timespanAtom);
        Subtract<FloatVector, TimespanVector, TimespanVector>(_floatVector, _timespanVector);
    }

    [Test]
    public void FloatSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<FloatAtom, MinuteAtom, MinuteAtom>(_floatAtom, _minuteAtom);
        Subtract<FloatAtom, MinuteVector, MinuteVector>(_floatAtom, _minuteVector);
        Subtract<FloatVector, MinuteAtom, MinuteVector>(_floatVector, _minuteAtom);
        Subtract<FloatVector, MinuteVector, MinuteVector>(_floatVector, _minuteVector);
    }

    [Test]
    public void FloatSubtractSecondReturnsCorrectTypes()
    {
        Subtract<FloatAtom, SecondAtom, SecondAtom>(_floatAtom, _secondAtom);
        Subtract<FloatAtom, SecondVector, SecondVector>(_floatAtom, _secondVector);
        Subtract<FloatVector, SecondAtom, SecondVector>(_floatVector, _secondAtom);
        Subtract<FloatVector, SecondVector, SecondVector>(_floatVector, _secondVector);
    }

    [Test]
    public void DoubleSubtractByteReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, ByteAtom, DoubleAtom>(_doubleAtom, _byteAtom);
        Subtract<DoubleAtom, ByteVector, DoubleVector>(_doubleAtom, _byteVector);
        Subtract<DoubleVector, ByteAtom, DoubleVector>(_doubleVector, _byteAtom);
        Subtract<DoubleVector, ByteVector, DoubleVector>(_doubleVector, _byteVector);
    }

    [Test]
    public void DoubleSubtractShortReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, ShortAtom, DoubleAtom>(_doubleAtom, _shortAtom);
        Subtract<DoubleAtom, ShortVector, DoubleVector>(_doubleAtom, _shortVector);
        Subtract<DoubleVector, ShortAtom, DoubleVector>(_doubleVector, _shortAtom);
        Subtract<DoubleVector, ShortVector, DoubleVector>(_doubleVector, _shortVector);
    }

    [Test]
    public void DoubleSubtractIntReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, IntAtom, DoubleAtom>(_doubleAtom, _intAtom);
        Subtract<DoubleAtom, IntVector, DoubleVector>(_doubleAtom, _intVector);
        Subtract<DoubleVector, IntAtom, DoubleVector>(_doubleVector, _intAtom);
        Subtract<DoubleVector, IntVector, DoubleVector>(_doubleVector, _intVector);
    }

    [Test]
    public void DoubleSubtractLongReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, LongAtom, DoubleAtom>(_doubleAtom, _longAtom);
        Subtract<DoubleAtom, LongVector, DoubleVector>(_doubleAtom, _longVector);
        Subtract<DoubleVector, LongAtom, DoubleVector>(_doubleVector, _longAtom);
        Subtract<DoubleVector, LongVector, DoubleVector>(_doubleVector, _longVector);
    }

    [Test]
    public void DoubleSubtractFloatReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, FloatAtom, DoubleAtom>(_doubleAtom, _floatAtom);
        Subtract<DoubleAtom, FloatVector, DoubleVector>(_doubleAtom, _floatVector);
        Subtract<DoubleVector, FloatAtom, DoubleVector>(_doubleVector, _floatAtom);
        Subtract<DoubleVector, FloatVector, DoubleVector>(_doubleVector, _floatVector);
    }

    [Test]
    public void DoubleSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, DoubleAtom, DoubleAtom>(_doubleAtom, _doubleAtom);
        Subtract<DoubleAtom, DoubleVector, DoubleVector>(_doubleAtom, _doubleVector);
        Subtract<DoubleVector, DoubleAtom, DoubleVector>(_doubleVector, _doubleAtom);
        Subtract<DoubleVector, DoubleVector, DoubleVector>(_doubleVector, _doubleVector);
    }

    [Test]
    public void DoubleSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, TimestampAtom, DoubleAtom>(_doubleAtom, _timestampAtom);
        Subtract<DoubleAtom, TimestampVector, DoubleVector>(_doubleAtom, _timestampVector);
        Subtract<DoubleVector, TimestampAtom, DoubleVector>(_doubleVector, _timestampAtom);
        Subtract<DoubleVector, TimestampVector, DoubleVector>(_doubleVector, _timestampVector);
    }

    [Test]
    public void DoubleSubtractMonthReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, MonthAtom, DoubleAtom>(_doubleAtom, _monthAtom);
        Subtract<DoubleAtom, MonthVector, DoubleVector>(_doubleAtom, _monthVector);
        Subtract<DoubleVector, MonthAtom, DoubleVector>(_doubleVector, _monthAtom);
        Subtract<DoubleVector, MonthVector, DoubleVector>(_doubleVector, _monthVector);
    }

    [Test]
    public void DoubleSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, TimespanAtom, DoubleAtom>(_doubleAtom, _timespanAtom);
        Subtract<DoubleAtom, TimespanVector, DoubleVector>(_doubleAtom, _timespanVector);
        Subtract<DoubleVector, TimespanAtom, DoubleVector>(_doubleVector, _timespanAtom);
        Subtract<DoubleVector, TimespanVector, DoubleVector>(_doubleVector, _timespanVector);
    }

    [Test]
    public void DoubleSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, MinuteAtom, DoubleAtom>(_doubleAtom, _minuteAtom);
        Subtract<DoubleAtom, MinuteVector, DoubleVector>(_doubleAtom, _minuteVector);
        Subtract<DoubleVector, MinuteAtom, DoubleVector>(_doubleVector, _minuteAtom);
        Subtract<DoubleVector, MinuteVector, DoubleVector>(_doubleVector, _minuteVector);
    }

    [Test]
    public void DoubleSubtractSecondReturnsCorrectTypes()
    {
        Subtract<DoubleAtom, SecondAtom, DoubleAtom>(_doubleAtom, _secondAtom);
        Subtract<DoubleAtom, SecondVector, DoubleVector>(_doubleAtom, _secondVector);
        Subtract<DoubleVector, SecondAtom, DoubleVector>(_doubleVector, _secondAtom);
        Subtract<DoubleVector, SecondVector, DoubleVector>(_doubleVector, _secondVector);
    }

    [Test]
    public void TimestampSubtractByteReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, ByteAtom, TimestampAtom>(_timestampAtom, _byteAtom);
        Subtract<TimestampAtom, ByteVector, TimestampVector>(_timestampAtom, _byteVector);
        Subtract<TimestampVector, ByteAtom, TimestampVector>(_timestampVector, _byteAtom);
        Subtract<TimestampVector, ByteVector, TimestampVector>(_timestampVector, _byteVector);
    }

    [Test]
    public void TimestampSubtractShortReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, ShortAtom, TimestampAtom>(_timestampAtom, _shortAtom);
        Subtract<TimestampAtom, ShortVector, TimestampVector>(_timestampAtom, _shortVector);
        Subtract<TimestampVector, ShortAtom, TimestampVector>(_timestampVector, _shortAtom);
        Subtract<TimestampVector, ShortVector, TimestampVector>(_timestampVector, _shortVector);
    }

    [Test]
    public void TimestampSubtractIntReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, IntAtom, TimestampAtom>(_timestampAtom, _intAtom);
        Subtract<TimestampAtom, IntVector, TimestampVector>(_timestampAtom, _intVector);
        Subtract<TimestampVector, IntAtom, TimestampVector>(_timestampVector, _intAtom);
        Subtract<TimestampVector, IntVector, TimestampVector>(_timestampVector, _intVector);
    }

    [Test]
    public void TimestampSubtractLongReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, LongAtom, TimestampAtom>(_timestampAtom, _longAtom);
        Subtract<TimestampAtom, LongVector, TimestampVector>(_timestampAtom, _longVector);
        Subtract<TimestampVector, LongAtom, TimestampVector>(_timestampVector, _longAtom);
        Subtract<TimestampVector, LongVector, TimestampVector>(_timestampVector, _longVector);
    }

    [Test]
    public void TimestampSubtractFloatReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, FloatAtom, TimestampAtom>(_timestampAtom, _floatAtom);
        Subtract<TimestampAtom, FloatVector, TimestampVector>(_timestampAtom, _floatVector);
        Subtract<TimestampVector, FloatAtom, TimestampVector>(_timestampVector, _floatAtom);
        Subtract<TimestampVector, FloatVector, TimestampVector>(_timestampVector, _floatVector);
    }

    [Test]
    public void TimestampSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, DoubleAtom, DoubleAtom>(_timestampAtom, _doubleAtom);
        Subtract<TimestampAtom, DoubleVector, DoubleVector>(_timestampAtom, _doubleVector);
        Subtract<TimestampVector, DoubleAtom, DoubleVector>(_timestampVector, _doubleAtom);
        Subtract<TimestampVector, DoubleVector, DoubleVector>(_timestampVector, _doubleVector);
    }

    [Test]
    public void TimestampSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, TimestampAtom, TimespanAtom>(_timestampAtom, _timestampAtom);
        Subtract<TimestampAtom, TimestampVector, TimespanVector>(_timestampAtom, _timestampVector);
        Subtract<TimestampVector, TimestampAtom, TimespanVector>(_timestampVector, _timestampAtom);
        Subtract<TimestampVector, TimestampVector, TimespanVector>(_timestampVector, _timestampVector);
    }

    [Test]
    public void TimestampSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, TimespanAtom, TimestampAtom>(_timestampAtom, _timespanAtom);
        Subtract<TimestampAtom, TimespanVector, TimestampVector>(_timestampAtom, _timespanVector);
        Subtract<TimestampVector, TimespanAtom, TimestampVector>(_timestampVector, _timespanAtom);
        Subtract<TimestampVector, TimespanVector, TimestampVector>(_timestampVector, _timespanVector);
    }

    [Test]
    public void TimestampSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, MinuteAtom, TimestampAtom>(_timestampAtom, _minuteAtom);
        Subtract<TimestampAtom, MinuteVector, TimestampVector>(_timestampAtom, _minuteVector);
        Subtract<TimestampVector, MinuteAtom, TimestampVector>(_timestampVector, _minuteAtom);
        Subtract<TimestampVector, MinuteVector, TimestampVector>(_timestampVector, _minuteVector);
    }

    [Test]
    public void TimestampSubtractSecondReturnsCorrectTypes()
    {
        Subtract<TimestampAtom, SecondAtom, TimestampAtom>(_timestampAtom, _secondAtom);
        Subtract<TimestampAtom, SecondVector, TimestampVector>(_timestampAtom, _secondVector);
        Subtract<TimestampVector, SecondAtom, TimestampVector>(_timestampVector, _secondAtom);
        Subtract<TimestampVector, SecondVector, TimestampVector>(_timestampVector, _secondVector);
    }

    [Test]
    public void MonthSubtractByteReturnsCorrectTypes()
    {
        Subtract<MonthAtom, ByteAtom, MonthAtom>(_monthAtom, _byteAtom);
        Subtract<MonthAtom, ByteVector, MonthVector>(_monthAtom, _byteVector);
        Subtract<MonthVector, ByteAtom, MonthVector>(_monthVector, _byteAtom);
        Subtract<MonthVector, ByteVector, MonthVector>(_monthVector, _byteVector);
    }

    [Test]
    public void MonthSubtractShortReturnsCorrectTypes()
    {
        Subtract<MonthAtom, ShortAtom, MonthAtom>(_monthAtom, _shortAtom);
        Subtract<MonthAtom, ShortVector, MonthVector>(_monthAtom, _shortVector);
        Subtract<MonthVector, ShortAtom, MonthVector>(_monthVector, _shortAtom);
        Subtract<MonthVector, ShortVector, MonthVector>(_monthVector, _shortVector);
    }

    [Test]
    public void MonthSubtractIntReturnsCorrectTypes()
    {
        Subtract<MonthAtom, IntAtom, MonthAtom>(_monthAtom, _intAtom);
        Subtract<MonthAtom, IntVector, MonthVector>(_monthAtom, _intVector);
        Subtract<MonthVector, IntAtom, MonthVector>(_monthVector, _intAtom);
        Subtract<MonthVector, IntVector, MonthVector>(_monthVector, _intVector);
    }

    [Test]
    public void MonthSubtractLongReturnsCorrectTypes()
    {
        Subtract<MonthAtom, LongAtom, MonthAtom>(_monthAtom, _longAtom);
        Subtract<MonthAtom, LongVector, MonthVector>(_monthAtom, _longVector);
        Subtract<MonthVector, LongAtom, MonthVector>(_monthVector, _longAtom);
        Subtract<MonthVector, LongVector, MonthVector>(_monthVector, _longVector);
    }

    [Test]
    public void MonthSubtractFloatReturnsCorrectTypes()
    {
        Subtract<MonthAtom, FloatAtom, MonthAtom>(_monthAtom, _floatAtom);
        Subtract<MonthAtom, FloatVector, MonthVector>(_monthAtom, _floatVector);
        Subtract<MonthVector, FloatAtom, MonthVector>(_monthVector, _floatAtom);
        Subtract<MonthVector, FloatVector, MonthVector>(_monthVector, _floatVector);
    }

    [Test]
    public void MonthSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<MonthAtom, DoubleAtom, DoubleAtom>(_monthAtom, _doubleAtom);
        Subtract<MonthAtom, DoubleVector, DoubleVector>(_monthAtom, _doubleVector);
        Subtract<MonthVector, DoubleAtom, DoubleVector>(_monthVector, _doubleAtom);
        Subtract<MonthVector, DoubleVector, DoubleVector>(_monthVector, _doubleVector);
    }

    [Test]
    public void MonthSubtractMonthReturnsCorrectTypes()
    {
        Subtract<MonthAtom, MonthAtom, IntAtom>(_monthAtom, _monthAtom);
        Subtract<MonthAtom, MonthVector, IntVector>(_monthAtom, _monthVector);
        Subtract<MonthVector, MonthAtom, IntVector>(_monthVector, _monthAtom);
        Subtract<MonthVector, MonthVector, IntVector>(_monthVector, _monthVector);
    }

    [Test]
    public void MonthSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<MonthAtom, TimespanAtom, TimestampAtom>(_monthAtom, _timespanAtom);
        Subtract<MonthAtom, TimespanVector, TimestampVector>(_monthAtom, _timespanVector);
        Subtract<MonthVector, TimespanAtom, TimestampVector>(_monthVector, _timespanAtom);
        Subtract<MonthVector, TimespanVector, TimestampVector>(_monthVector, _timespanVector);
    }

    [Test]
    public void MonthSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<MonthAtom, MinuteAtom, TimestampAtom>(_monthAtom, _minuteAtom);
        Subtract<MonthAtom, MinuteVector, TimestampVector>(_monthAtom, _minuteVector);
        Subtract<MonthVector, MinuteAtom, TimestampVector>(_monthVector, _minuteAtom);
        Subtract<MonthVector, MinuteVector, TimestampVector>(_monthVector, _minuteVector);
    }

    [Test]
    public void MonthSubtractSecondReturnsCorrectTypes()
    {
        Subtract<MonthAtom, SecondAtom, TimestampAtom>(_monthAtom, _secondAtom);
        Subtract<MonthAtom, SecondVector, TimestampVector>(_monthAtom, _secondVector);
        Subtract<MonthVector, SecondAtom, TimestampVector>(_monthVector, _secondAtom);
        Subtract<MonthVector, SecondVector, TimestampVector>(_monthVector, _secondVector);
    }

    [Test]
    public void DateSubtractByteReturnsCorrectTypes()
    {
        Subtract<DateAtom, ByteAtom, DateAtom>(_dateAtom, _byteAtom);
        Subtract<DateAtom, ByteVector, DateVector>(_dateAtom, _byteVector);
        Subtract<DateVector, ByteAtom, DateVector>(_dateVector, _byteAtom);
        Subtract<DateVector, ByteVector, DateVector>(_dateVector, _byteVector);
    }

    [Test]
    public void DateSubtractShortReturnsCorrectTypes()
    {
        Subtract<DateAtom, ShortAtom, DateAtom>(_dateAtom, _shortAtom);
        Subtract<DateAtom, ShortVector, DateVector>(_dateAtom, _shortVector);
        Subtract<DateVector, ShortAtom, DateVector>(_dateVector, _shortAtom);
        Subtract<DateVector, ShortVector, DateVector>(_dateVector, _shortVector);
    }

    [Test]
    public void DateSubtractIntReturnsCorrectTypes()
    {
        Subtract<DateAtom, IntAtom, DateAtom>(_dateAtom, _intAtom);
        Subtract<DateAtom, IntVector, DateVector>(_dateAtom, _intVector);
        Subtract<DateVector, IntAtom, DateVector>(_dateVector, _intAtom);
        Subtract<DateVector, IntVector, DateVector>(_dateVector, _intVector);
    }

    [Test]
    public void DateSubtractLongReturnsCorrectTypes()
    {
        Subtract<DateAtom, LongAtom, DateAtom>(_dateAtom, _longAtom);
        Subtract<DateAtom, LongVector, DateVector>(_dateAtom, _longVector);
        Subtract<DateVector, LongAtom, DateVector>(_dateVector, _longAtom);
        Subtract<DateVector, LongVector, DateVector>(_dateVector, _longVector);
    }

    [Test]
    public void DateSubtractFloatReturnsCorrectTypes()
    {
        Subtract<DateAtom, FloatAtom, DateAtom>(_dateAtom, _floatAtom);
        Subtract<DateAtom, FloatVector, DateVector>(_dateAtom, _floatVector);
        Subtract<DateVector, FloatAtom, DateVector>(_dateVector, _floatAtom);
        Subtract<DateVector, FloatVector, DateVector>(_dateVector, _floatVector);
    }

    [Test]
    public void DateSubtractDateReturnsCorrectTypes()
    {
        Subtract<DateAtom, DateAtom, IntAtom>(_dateAtom, _dateAtom);
        Subtract<DateAtom, DateVector, IntVector>(_dateAtom, _dateVector);
        Subtract<DateVector, DateAtom, IntVector>(_dateVector, _dateAtom);
        Subtract<DateVector, DateVector, IntVector>(_dateVector, _dateVector);
    }

    [Test]
    public void DateSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<DateAtom, TimespanAtom, TimestampAtom>(_dateAtom, _timespanAtom);
        Subtract<DateAtom, TimespanVector, TimestampVector>(_dateAtom, _timespanVector);
        Subtract<DateVector, TimespanAtom, TimestampVector>(_dateVector, _timespanAtom);
        Subtract<DateVector, TimespanVector, TimestampVector>(_dateVector, _timespanVector);
    }

    [Test]
    public void DateSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<DateAtom, MinuteAtom, TimestampAtom>(_dateAtom, _minuteAtom);
        Subtract<DateAtom, MinuteVector, TimestampVector>(_dateAtom, _minuteVector);
        Subtract<DateVector, MinuteAtom, TimestampVector>(_dateVector, _minuteAtom);
        Subtract<DateVector, MinuteVector, TimestampVector>(_dateVector, _minuteVector);
    }

    [Test]
    public void DateSubtractSecondReturnsCorrectTypes()
    {
        Subtract<DateAtom, SecondAtom, TimestampAtom>(_dateAtom, _secondAtom);
        Subtract<DateAtom, SecondVector, TimestampVector>(_dateAtom, _secondVector);
        Subtract<DateVector, SecondAtom, TimestampVector>(_dateVector, _secondAtom);
        Subtract<DateVector, SecondVector, TimestampVector>(_dateVector, _secondVector);
    }

    [Test]
    public void TimespanSubtractByteReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, ByteAtom, TimespanAtom>(_timespanAtom, _byteAtom);
        Subtract<TimespanAtom, ByteVector, TimespanVector>(_timespanAtom, _byteVector);
        Subtract<TimespanVector, ByteAtom, TimespanVector>(_timespanVector, _byteAtom);
        Subtract<TimespanVector, ByteVector, TimespanVector>(_timespanVector, _byteVector);
    }

    [Test]
    public void TimespanSubtractShortReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, ShortAtom, TimespanAtom>(_timespanAtom, _shortAtom);
        Subtract<TimespanAtom, ShortVector, TimespanVector>(_timespanAtom, _shortVector);
        Subtract<TimespanVector, ShortAtom, TimespanVector>(_timespanVector, _shortAtom);
        Subtract<TimespanVector, ShortVector, TimespanVector>(_timespanVector, _shortVector);
    }

    [Test]
    public void TimespanSubtractIntReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, IntAtom, TimespanAtom>(_timespanAtom, _intAtom);
        Subtract<TimespanAtom, IntVector, TimespanVector>(_timespanAtom, _intVector);
        Subtract<TimespanVector, IntAtom, TimespanVector>(_timespanVector, _intAtom);
        Subtract<TimespanVector, IntVector, TimespanVector>(_timespanVector, _intVector);
    }

    [Test]
    public void TimespanSubtractLongReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, LongAtom, TimespanAtom>(_timespanAtom, _longAtom);
        Subtract<TimespanAtom, LongVector, TimespanVector>(_timespanAtom, _longVector);
        Subtract<TimespanVector, LongAtom, TimespanVector>(_timespanVector, _longAtom);
        Subtract<TimespanVector, LongVector, TimespanVector>(_timespanVector, _longVector);
    }

    [Test]
    public void TimespanSubtractFloatReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, FloatAtom, TimespanAtom>(_timespanAtom, _floatAtom);
        Subtract<TimespanAtom, FloatVector, TimespanVector>(_timespanAtom, _floatVector);
        Subtract<TimespanVector, FloatAtom, TimespanVector>(_timespanVector, _floatAtom);
        Subtract<TimespanVector, FloatVector, TimespanVector>(_timespanVector, _floatVector);
    }

    [Test]
    public void TimespanSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, DoubleAtom, DoubleAtom>(_timespanAtom, _doubleAtom);
        Subtract<TimespanAtom, DoubleVector, DoubleVector>(_timespanAtom, _doubleVector);
        Subtract<TimespanVector, DoubleAtom, DoubleVector>(_timespanVector, _doubleAtom);
        Subtract<TimespanVector, DoubleVector, DoubleVector>(_timespanVector, _doubleVector);
    }

    [Test]
    public void TimespanSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, TimestampAtom, TimestampAtom>(_timespanAtom, _timestampAtom);
        Subtract<TimespanAtom, TimestampVector, TimestampVector>(_timespanAtom, _timestampVector);
        Subtract<TimespanVector, TimestampAtom, TimestampVector>(_timespanVector, _timestampAtom);
        Subtract<TimespanVector, TimestampVector, TimestampVector>(_timespanVector, _timestampVector);
    }

    [Test]
    public void TimespanSubtractMonthReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, MonthAtom, TimestampAtom>(_timespanAtom, _monthAtom);
        Subtract<TimespanAtom, MonthVector, TimestampVector>(_timespanAtom, _monthVector);
        Subtract<TimespanVector, MonthAtom, TimestampVector>(_timespanVector, _monthAtom);
        Subtract<TimespanVector, MonthVector, TimestampVector>(_timespanVector, _monthVector);
    }

    [Test]
    public void TimespanSubtractDateReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, DateAtom, TimestampAtom>(_timespanAtom, _dateAtom);
        Subtract<TimespanAtom, DateVector, TimestampVector>(_timespanAtom, _dateVector);
        Subtract<TimespanVector, DateAtom, TimestampVector>(_timespanVector, _dateAtom);
        Subtract<TimespanVector, DateVector, TimestampVector>(_timespanVector, _dateVector);
    }

    [Test]
    public void TimespanSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, TimespanAtom, TimespanAtom>(_timespanAtom, _timespanAtom);
        Subtract<TimespanAtom, TimespanVector, TimespanVector>(_timespanAtom, _timespanVector);
        Subtract<TimespanVector, TimespanAtom, TimespanVector>(_timespanVector, _timespanAtom);
        Subtract<TimespanVector, TimespanVector, TimespanVector>(_timespanVector, _timespanVector);
    }

    [Test]
    public void TimespanSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, MinuteAtom, TimespanAtom>(_timespanAtom, _minuteAtom);
        Subtract<TimespanAtom, MinuteVector, TimespanVector>(_timespanAtom, _minuteVector);
        Subtract<TimespanVector, MinuteAtom, TimespanVector>(_timespanVector, _minuteAtom);
        Subtract<TimespanVector, MinuteVector, TimespanVector>(_timespanVector, _minuteVector);
    }

    [Test]
    public void TimespanSubtractSecondReturnsCorrectTypes()
    {
        Subtract<TimespanAtom, SecondAtom, TimespanAtom>(_timespanAtom, _secondAtom);
        Subtract<TimespanAtom, SecondVector, TimespanVector>(_timespanAtom, _secondVector);
        Subtract<TimespanVector, SecondAtom, TimespanVector>(_timespanVector, _secondAtom);
        Subtract<TimespanVector, SecondVector, TimespanVector>(_timespanVector, _secondVector);
    }

    [Test]
    public void MinuteSubtractByteReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, ByteAtom, MinuteAtom>(_minuteAtom, _byteAtom);
        Subtract<MinuteAtom, ByteVector, MinuteVector>(_minuteAtom, _byteVector);
        Subtract<MinuteVector, ByteAtom, MinuteVector>(_minuteVector, _byteAtom);
        Subtract<MinuteVector, ByteVector, MinuteVector>(_minuteVector, _byteVector);
    }

    [Test]
    public void MinuteSubtractShortReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, ShortAtom, MinuteAtom>(_minuteAtom, _shortAtom);
        Subtract<MinuteAtom, ShortVector, MinuteVector>(_minuteAtom, _shortVector);
        Subtract<MinuteVector, ShortAtom, MinuteVector>(_minuteVector, _shortAtom);
        Subtract<MinuteVector, ShortVector, MinuteVector>(_minuteVector, _shortVector);
    }

    [Test]
    public void MinuteSubtractIntReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, IntAtom, MinuteAtom>(_minuteAtom, _intAtom);
        Subtract<MinuteAtom, IntVector, MinuteVector>(_minuteAtom, _intVector);
        Subtract<MinuteVector, IntAtom, MinuteVector>(_minuteVector, _intAtom);
        Subtract<MinuteVector, IntVector, MinuteVector>(_minuteVector, _intVector);
    }

    [Test]
    public void MinuteSubtractLongReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, LongAtom, MinuteAtom>(_minuteAtom, _longAtom);
        Subtract<MinuteAtom, LongVector, MinuteVector>(_minuteAtom, _longVector);
        Subtract<MinuteVector, LongAtom, MinuteVector>(_minuteVector, _longAtom);
        Subtract<MinuteVector, LongVector, MinuteVector>(_minuteVector, _longVector);
    }

    [Test]
    public void MinuteSubtractFloatReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, FloatAtom, MinuteAtom>(_minuteAtom, _floatAtom);
        Subtract<MinuteAtom, FloatVector, MinuteVector>(_minuteAtom, _floatVector);
        Subtract<MinuteVector, FloatAtom, MinuteVector>(_minuteVector, _floatAtom);
        Subtract<MinuteVector, FloatVector, MinuteVector>(_minuteVector, _floatVector);
    }

    [Test]
    public void MinuteSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, DoubleAtom, DoubleAtom>(_minuteAtom, _doubleAtom);
        Subtract<MinuteAtom, DoubleVector, DoubleVector>(_minuteAtom, _doubleVector);
        Subtract<MinuteVector, DoubleAtom, DoubleVector>(_minuteVector, _doubleAtom);
        Subtract<MinuteVector, DoubleVector, DoubleVector>(_minuteVector, _doubleVector);
    }

    [Test]
    public void MinuteSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, TimestampAtom, TimestampAtom>(_minuteAtom, _timestampAtom);
        Subtract<MinuteAtom, TimestampVector, TimestampVector>(_minuteAtom, _timestampVector);
        Subtract<MinuteVector, TimestampAtom, TimestampVector>(_minuteVector, _timestampAtom);
        Subtract<MinuteVector, TimestampVector, TimestampVector>(_minuteVector, _timestampVector);
    }

    [Test]
    public void MinuteSubtractMonthReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, MonthAtom, TimestampAtom>(_minuteAtom, _monthAtom);
        Subtract<MinuteAtom, MonthVector, TimestampVector>(_minuteAtom, _monthVector);
        Subtract<MinuteVector, MonthAtom, TimestampVector>(_minuteVector, _monthAtom);
        Subtract<MinuteVector, MonthVector, TimestampVector>(_minuteVector, _monthVector);
    }

    [Test]
    public void MinuteSubtractDateReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, DateAtom, TimestampAtom>(_minuteAtom, _dateAtom);
        Subtract<MinuteAtom, DateVector, TimestampVector>(_minuteAtom, _dateVector);
        Subtract<MinuteVector, DateAtom, TimestampVector>(_minuteVector, _dateAtom);
        Subtract<MinuteVector, DateVector, TimestampVector>(_minuteVector, _dateVector);
    }

    [Test]
    public void MinuteSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, TimespanAtom, TimespanAtom>(_minuteAtom, _timespanAtom);
        Subtract<MinuteAtom, TimespanVector, TimespanVector>(_minuteAtom, _timespanVector);
        Subtract<MinuteVector, TimespanAtom, TimespanVector>(_minuteVector, _timespanAtom);
        Subtract<MinuteVector, TimespanVector, TimespanVector>(_minuteVector, _timespanVector);
    }

    [Test]
    public void MinuteSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, MinuteAtom, MinuteAtom>(_minuteAtom, _minuteAtom);
        Subtract<MinuteAtom, MinuteVector, MinuteVector>(_minuteAtom, _minuteVector);
        Subtract<MinuteVector, MinuteAtom, MinuteVector>(_minuteVector, _minuteAtom);
        Subtract<MinuteVector, MinuteVector, MinuteVector>(_minuteVector, _minuteVector);
    }

    [Test]
    public void MinuteSubtractSecondReturnsCorrectTypes()
    {
        Subtract<MinuteAtom, SecondAtom, SecondAtom>(_minuteAtom, _secondAtom);
        Subtract<MinuteAtom, SecondVector, SecondVector>(_minuteAtom, _secondVector);
        Subtract<MinuteVector, SecondAtom, SecondVector>(_minuteVector, _secondAtom);
        Subtract<MinuteVector, SecondVector, SecondVector>(_minuteVector, _secondVector);
    }

    [Test]
    public void SecondSubtractByteReturnsCorrectTypes()
    {
        Subtract<SecondAtom, ByteAtom, SecondAtom>(_secondAtom, _byteAtom);
        Subtract<SecondAtom, ByteVector, SecondVector>(_secondAtom, _byteVector);
        Subtract<SecondVector, ByteAtom, SecondVector>(_secondVector, _byteAtom);
        Subtract<SecondVector, ByteVector, SecondVector>(_secondVector, _byteVector);
    }

    [Test]
    public void SecondSubtractShortReturnsCorrectTypes()
    {
        Subtract<SecondAtom, ShortAtom, SecondAtom>(_secondAtom, _shortAtom);
        Subtract<SecondAtom, ShortVector, SecondVector>(_secondAtom, _shortVector);
        Subtract<SecondVector, ShortAtom, SecondVector>(_secondVector, _shortAtom);
        Subtract<SecondVector, ShortVector, SecondVector>(_secondVector, _shortVector);
    }

    [Test]
    public void SecondSubtractIntReturnsCorrectTypes()
    {
        Subtract<SecondAtom, IntAtom, SecondAtom>(_secondAtom, _intAtom);
        Subtract<SecondAtom, IntVector, SecondVector>(_secondAtom, _intVector);
        Subtract<SecondVector, IntAtom, SecondVector>(_secondVector, _intAtom);
        Subtract<SecondVector, IntVector, SecondVector>(_secondVector, _intVector);
    }

    [Test]
    public void SecondSubtractLongReturnsCorrectTypes()
    {
        Subtract<SecondAtom, LongAtom, SecondAtom>(_secondAtom, _longAtom);
        Subtract<SecondAtom, LongVector, SecondVector>(_secondAtom, _longVector);
        Subtract<SecondVector, LongAtom, SecondVector>(_secondVector, _longAtom);
        Subtract<SecondVector, LongVector, SecondVector>(_secondVector, _longVector);
    }

    [Test]
    public void SecondSubtractFloatReturnsCorrectTypes()
    {
        Subtract<SecondAtom, FloatAtom, SecondAtom>(_secondAtom, _floatAtom);
        Subtract<SecondAtom, FloatVector, SecondVector>(_secondAtom, _floatVector);
        Subtract<SecondVector, FloatAtom, SecondVector>(_secondVector, _floatAtom);
        Subtract<SecondVector, FloatVector, SecondVector>(_secondVector, _floatVector);
    }

    [Test]
    public void SecondSubtractDoubleReturnsCorrectTypes()
    {
        Subtract<SecondAtom, DoubleAtom, DoubleAtom>(_secondAtom, _doubleAtom);
        Subtract<SecondAtom, DoubleVector, DoubleVector>(_secondAtom, _doubleVector);
        Subtract<SecondVector, DoubleAtom, DoubleVector>(_secondVector, _doubleAtom);
        Subtract<SecondVector, DoubleVector, DoubleVector>(_secondVector, _doubleVector);
    }

    [Test]
    public void SecondSubtractTimestampReturnsCorrectTypes()
    {
        Subtract<SecondAtom, TimestampAtom, TimestampAtom>(_secondAtom, _timestampAtom);
        Subtract<SecondAtom, TimestampVector, TimestampVector>(_secondAtom, _timestampVector);
        Subtract<SecondVector, TimestampAtom, TimestampVector>(_secondVector, _timestampAtom);
        Subtract<SecondVector, TimestampVector, TimestampVector>(_secondVector, _timestampVector);
    }

    [Test]
    public void SecondSubtractMonthReturnsCorrectTypes()
    {
        Subtract<SecondAtom, MonthAtom, TimestampAtom>(_secondAtom, _monthAtom);
        Subtract<SecondAtom, MonthVector, TimestampVector>(_secondAtom, _monthVector);
        Subtract<SecondVector, MonthAtom, TimestampVector>(_secondVector, _monthAtom);
        Subtract<SecondVector, MonthVector, TimestampVector>(_secondVector, _monthVector);
    }

    [Test]
    public void SecondSubtractDateReturnsCorrectTypes()
    {
        Subtract<SecondAtom, DateAtom, TimestampAtom>(_secondAtom, _dateAtom);
        Subtract<SecondAtom, DateVector, TimestampVector>(_secondAtom, _dateVector);
        Subtract<SecondVector, DateAtom, TimestampVector>(_secondVector, _dateAtom);
        Subtract<SecondVector, DateVector, TimestampVector>(_secondVector, _dateVector);
    }

    [Test]
    public void SecondSubtractTimespanReturnsCorrectTypes()
    {
        Subtract<SecondAtom, TimespanAtom, TimespanAtom>(_secondAtom, _timespanAtom);
        Subtract<SecondAtom, TimespanVector, TimespanVector>(_secondAtom, _timespanVector);
        Subtract<SecondVector, TimespanAtom, TimespanVector>(_secondVector, _timespanAtom);
        Subtract<SecondVector, TimespanVector, TimespanVector>(_secondVector, _timespanVector);
    }

    [Test]
    public void SecondSubtractMinuteReturnsCorrectTypes()
    {
        Subtract<SecondAtom, MinuteAtom, SecondAtom>(_secondAtom, _minuteAtom);
        Subtract<SecondAtom, MinuteVector, SecondVector>(_secondAtom, _minuteVector);
        Subtract<SecondVector, MinuteAtom, SecondVector>(_secondVector, _minuteAtom);
        Subtract<SecondVector, MinuteVector, SecondVector>(_secondVector, _minuteVector);
    }

    [Test]
    public void SecondSubtractSecondReturnsCorrectTypes()
    {
        Subtract<SecondAtom, SecondAtom, SecondAtom>(_secondAtom, _secondAtom);
        Subtract<SecondAtom, SecondVector, SecondVector>(_secondAtom, _secondVector);
        Subtract<SecondVector, SecondAtom, SecondVector>(_secondVector, _secondAtom);
        Subtract<SecondVector, SecondVector, SecondVector>(_secondVector, _secondVector);
    }
}
