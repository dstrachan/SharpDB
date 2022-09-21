using System.Numerics;
using SharpDB.Data;

namespace SharpDB.Tests.Data.Functions;

public class DivideTests
{
    private static void Divide<T1, T2, T3>(T1 left, T2 right)
        where T1 : IDivisionOperators<T1, T2, T3>
        where T2 : IDivisionOperators<T2, T1, T3>
    {
        var result1 = left / right;
        var result2 = right / left;
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
    public void ByteDivideByteReturnsCorrectTypes()
    {
        Divide<ByteAtom, ByteAtom, DoubleAtom>(_byteAtom, _byteAtom);
        Divide<ByteAtom, ByteVector, DoubleVector>(_byteAtom, _byteVector);
        Divide<ByteVector, ByteAtom, DoubleVector>(_byteVector, _byteAtom);
        Divide<ByteVector, ByteVector, DoubleVector>(_byteVector, _byteVector);
    }

    [Test]
    public void ByteDivideShortReturnsCorrectTypes()
    {
        Divide<ByteAtom, ShortAtom, DoubleAtom>(_byteAtom, _shortAtom);
        Divide<ByteAtom, ShortVector, DoubleVector>(_byteAtom, _shortVector);
        Divide<ByteVector, ShortAtom, DoubleVector>(_byteVector, _shortAtom);
        Divide<ByteVector, ShortVector, DoubleVector>(_byteVector, _shortVector);
    }

    [Test]
    public void ByteDivideIntReturnsCorrectTypes()
    {
        Divide<ByteAtom, IntAtom, DoubleAtom>(_byteAtom, _intAtom);
        Divide<ByteAtom, IntVector, DoubleVector>(_byteAtom, _intVector);
        Divide<ByteVector, IntAtom, DoubleVector>(_byteVector, _intAtom);
        Divide<ByteVector, IntVector, DoubleVector>(_byteVector, _intVector);
    }

    [Test]
    public void ByteDivideLongReturnsCorrectTypes()
    {
        Divide<ByteAtom, LongAtom, DoubleAtom>(_byteAtom, _longAtom);
        Divide<ByteAtom, LongVector, DoubleVector>(_byteAtom, _longVector);
        Divide<ByteVector, LongAtom, DoubleVector>(_byteVector, _longAtom);
        Divide<ByteVector, LongVector, DoubleVector>(_byteVector, _longVector);
    }

    [Test]
    public void ByteDivideFloatReturnsCorrectTypes()
    {
        Divide<ByteAtom, FloatAtom, DoubleAtom>(_byteAtom, _floatAtom);
        Divide<ByteAtom, FloatVector, DoubleVector>(_byteAtom, _floatVector);
        Divide<ByteVector, FloatAtom, DoubleVector>(_byteVector, _floatAtom);
        Divide<ByteVector, FloatVector, DoubleVector>(_byteVector, _floatVector);
    }

    [Test]
    public void ByteDivideDoubleReturnsCorrectTypes()
    {
        Divide<ByteAtom, DoubleAtom, DoubleAtom>(_byteAtom, _doubleAtom);
        Divide<ByteAtom, DoubleVector, DoubleVector>(_byteAtom, _doubleVector);
        Divide<ByteVector, DoubleAtom, DoubleVector>(_byteVector, _doubleAtom);
        Divide<ByteVector, DoubleVector, DoubleVector>(_byteVector, _doubleVector);
    }

    [Test]
    public void ByteDivideTimestampReturnsCorrectTypes()
    {
        Divide<ByteAtom, TimestampAtom, DoubleAtom>(_byteAtom, _timestampAtom);
        Divide<ByteAtom, TimestampVector, DoubleVector>(_byteAtom, _timestampVector);
        Divide<ByteVector, TimestampAtom, DoubleVector>(_byteVector, _timestampAtom);
        Divide<ByteVector, TimestampVector, DoubleVector>(_byteVector, _timestampVector);
    }

    [Test]
    public void ByteDivideMonthReturnsCorrectTypes()
    {
        Divide<ByteAtom, MonthAtom, DoubleAtom>(_byteAtom, _monthAtom);
        Divide<ByteAtom, MonthVector, DoubleVector>(_byteAtom, _monthVector);
        Divide<ByteVector, MonthAtom, DoubleVector>(_byteVector, _monthAtom);
        Divide<ByteVector, MonthVector, DoubleVector>(_byteVector, _monthVector);
    }

    [Test]
    public void ByteDivideDateReturnsCorrectTypes()
    {
        Divide<ByteAtom, DateAtom, DoubleAtom>(_byteAtom, _dateAtom);
        Divide<ByteAtom, DateVector, DoubleVector>(_byteAtom, _dateVector);
        Divide<ByteVector, DateAtom, DoubleVector>(_byteVector, _dateAtom);
        Divide<ByteVector, DateVector, DoubleVector>(_byteVector, _dateVector);
    }

    [Test]
    public void ByteDivideTimespanReturnsCorrectTypes()
    {
        Divide<ByteAtom, TimespanAtom, DoubleAtom>(_byteAtom, _timespanAtom);
        Divide<ByteAtom, TimespanVector, DoubleVector>(_byteAtom, _timespanVector);
        Divide<ByteVector, TimespanAtom, DoubleVector>(_byteVector, _timespanAtom);
        Divide<ByteVector, TimespanVector, DoubleVector>(_byteVector, _timespanVector);
    }

    [Test]
    public void ByteDivideMinuteReturnsCorrectTypes()
    {
        Divide<ByteAtom, MinuteAtom, DoubleAtom>(_byteAtom, _minuteAtom);
        Divide<ByteAtom, MinuteVector, DoubleVector>(_byteAtom, _minuteVector);
        Divide<ByteVector, MinuteAtom, DoubleVector>(_byteVector, _minuteAtom);
        Divide<ByteVector, MinuteVector, DoubleVector>(_byteVector, _minuteVector);
    }

    [Test]
    public void ByteDivideSecondReturnsCorrectTypes()
    {
        Divide<ByteAtom, SecondAtom, DoubleAtom>(_byteAtom, _secondAtom);
        Divide<ByteAtom, SecondVector, DoubleVector>(_byteAtom, _secondVector);
        Divide<ByteVector, SecondAtom, DoubleVector>(_byteVector, _secondAtom);
        Divide<ByteVector, SecondVector, DoubleVector>(_byteVector, _secondVector);
    }

    [Test]
    public void ShortDivideByteReturnsCorrectTypes()
    {
        Divide<ShortAtom, ByteAtom, DoubleAtom>(_shortAtom, _byteAtom);
        Divide<ShortAtom, ByteVector, DoubleVector>(_shortAtom, _byteVector);
        Divide<ShortVector, ByteAtom, DoubleVector>(_shortVector, _byteAtom);
        Divide<ShortVector, ByteVector, DoubleVector>(_shortVector, _byteVector);
    }

    [Test]
    public void ShortDivideShortReturnsCorrectTypes()
    {
        Divide<ShortAtom, ShortAtom, DoubleAtom>(_shortAtom, _shortAtom);
        Divide<ShortAtom, ShortVector, DoubleVector>(_shortAtom, _shortVector);
        Divide<ShortVector, ShortAtom, DoubleVector>(_shortVector, _shortAtom);
        Divide<ShortVector, ShortVector, DoubleVector>(_shortVector, _shortVector);
    }

    [Test]
    public void ShortDivideIntReturnsCorrectTypes()
    {
        Divide<ShortAtom, IntAtom, DoubleAtom>(_shortAtom, _intAtom);
        Divide<ShortAtom, IntVector, DoubleVector>(_shortAtom, _intVector);
        Divide<ShortVector, IntAtom, DoubleVector>(_shortVector, _intAtom);
        Divide<ShortVector, IntVector, DoubleVector>(_shortVector, _intVector);
    }

    [Test]
    public void ShortDivideLongReturnsCorrectTypes()
    {
        Divide<ShortAtom, LongAtom, DoubleAtom>(_shortAtom, _longAtom);
        Divide<ShortAtom, LongVector, DoubleVector>(_shortAtom, _longVector);
        Divide<ShortVector, LongAtom, DoubleVector>(_shortVector, _longAtom);
        Divide<ShortVector, LongVector, DoubleVector>(_shortVector, _longVector);
    }

    [Test]
    public void ShortDivideFloatReturnsCorrectTypes()
    {
        Divide<ShortAtom, FloatAtom, DoubleAtom>(_shortAtom, _floatAtom);
        Divide<ShortAtom, FloatVector, DoubleVector>(_shortAtom, _floatVector);
        Divide<ShortVector, FloatAtom, DoubleVector>(_shortVector, _floatAtom);
        Divide<ShortVector, FloatVector, DoubleVector>(_shortVector, _floatVector);
    }

    [Test]
    public void ShortDivideDoubleReturnsCorrectTypes()
    {
        Divide<ShortAtom, DoubleAtom, DoubleAtom>(_shortAtom, _doubleAtom);
        Divide<ShortAtom, DoubleVector, DoubleVector>(_shortAtom, _doubleVector);
        Divide<ShortVector, DoubleAtom, DoubleVector>(_shortVector, _doubleAtom);
        Divide<ShortVector, DoubleVector, DoubleVector>(_shortVector, _doubleVector);
    }

    [Test]
    public void ShortDivideTimestampReturnsCorrectTypes()
    {
        Divide<ShortAtom, TimestampAtom, DoubleAtom>(_shortAtom, _timestampAtom);
        Divide<ShortAtom, TimestampVector, DoubleVector>(_shortAtom, _timestampVector);
        Divide<ShortVector, TimestampAtom, DoubleVector>(_shortVector, _timestampAtom);
        Divide<ShortVector, TimestampVector, DoubleVector>(_shortVector, _timestampVector);
    }

    [Test]
    public void ShortDivideMonthReturnsCorrectTypes()
    {
        Divide<ShortAtom, MonthAtom, DoubleAtom>(_shortAtom, _monthAtom);
        Divide<ShortAtom, MonthVector, DoubleVector>(_shortAtom, _monthVector);
        Divide<ShortVector, MonthAtom, DoubleVector>(_shortVector, _monthAtom);
        Divide<ShortVector, MonthVector, DoubleVector>(_shortVector, _monthVector);
    }

    [Test]
    public void ShortDivideDateReturnsCorrectTypes()
    {
        Divide<ShortAtom, DateAtom, DoubleAtom>(_shortAtom, _dateAtom);
        Divide<ShortAtom, DateVector, DoubleVector>(_shortAtom, _dateVector);
        Divide<ShortVector, DateAtom, DoubleVector>(_shortVector, _dateAtom);
        Divide<ShortVector, DateVector, DoubleVector>(_shortVector, _dateVector);
    }

    [Test]
    public void ShortDivideTimespanReturnsCorrectTypes()
    {
        Divide<ShortAtom, TimespanAtom, DoubleAtom>(_shortAtom, _timespanAtom);
        Divide<ShortAtom, TimespanVector, DoubleVector>(_shortAtom, _timespanVector);
        Divide<ShortVector, TimespanAtom, DoubleVector>(_shortVector, _timespanAtom);
        Divide<ShortVector, TimespanVector, DoubleVector>(_shortVector, _timespanVector);
    }

    [Test]
    public void ShortDivideMinuteReturnsCorrectTypes()
    {
        Divide<ShortAtom, MinuteAtom, DoubleAtom>(_shortAtom, _minuteAtom);
        Divide<ShortAtom, MinuteVector, DoubleVector>(_shortAtom, _minuteVector);
        Divide<ShortVector, MinuteAtom, DoubleVector>(_shortVector, _minuteAtom);
        Divide<ShortVector, MinuteVector, DoubleVector>(_shortVector, _minuteVector);
    }

    [Test]
    public void ShortDivideSecondReturnsCorrectTypes()
    {
        Divide<ShortAtom, SecondAtom, DoubleAtom>(_shortAtom, _secondAtom);
        Divide<ShortAtom, SecondVector, DoubleVector>(_shortAtom, _secondVector);
        Divide<ShortVector, SecondAtom, DoubleVector>(_shortVector, _secondAtom);
        Divide<ShortVector, SecondVector, DoubleVector>(_shortVector, _secondVector);
    }

    [Test]
    public void IntDivideByteReturnsCorrectTypes()
    {
        Divide<IntAtom, ByteAtom, DoubleAtom>(_intAtom, _byteAtom);
        Divide<IntAtom, ByteVector, DoubleVector>(_intAtom, _byteVector);
        Divide<IntVector, ByteAtom, DoubleVector>(_intVector, _byteAtom);
        Divide<IntVector, ByteVector, DoubleVector>(_intVector, _byteVector);
    }

    [Test]
    public void IntDivideShortReturnsCorrectTypes()
    {
        Divide<IntAtom, ShortAtom, DoubleAtom>(_intAtom, _shortAtom);
        Divide<IntAtom, ShortVector, DoubleVector>(_intAtom, _shortVector);
        Divide<IntVector, ShortAtom, DoubleVector>(_intVector, _shortAtom);
        Divide<IntVector, ShortVector, DoubleVector>(_intVector, _shortVector);
    }

    [Test]
    public void IntDivideIntReturnsCorrectTypes()
    {
        Divide<IntAtom, IntAtom, DoubleAtom>(_intAtom, _intAtom);
        Divide<IntAtom, IntVector, DoubleVector>(_intAtom, _intVector);
        Divide<IntVector, IntAtom, DoubleVector>(_intVector, _intAtom);
        Divide<IntVector, IntVector, DoubleVector>(_intVector, _intVector);
    }

    [Test]
    public void IntDivideLongReturnsCorrectTypes()
    {
        Divide<IntAtom, LongAtom, DoubleAtom>(_intAtom, _longAtom);
        Divide<IntAtom, LongVector, DoubleVector>(_intAtom, _longVector);
        Divide<IntVector, LongAtom, DoubleVector>(_intVector, _longAtom);
        Divide<IntVector, LongVector, DoubleVector>(_intVector, _longVector);
    }

    [Test]
    public void IntDivideFloatReturnsCorrectTypes()
    {
        Divide<IntAtom, FloatAtom, DoubleAtom>(_intAtom, _floatAtom);
        Divide<IntAtom, FloatVector, DoubleVector>(_intAtom, _floatVector);
        Divide<IntVector, FloatAtom, DoubleVector>(_intVector, _floatAtom);
        Divide<IntVector, FloatVector, DoubleVector>(_intVector, _floatVector);
    }

    [Test]
    public void IntDivideDoubleReturnsCorrectTypes()
    {
        Divide<IntAtom, DoubleAtom, DoubleAtom>(_intAtom, _doubleAtom);
        Divide<IntAtom, DoubleVector, DoubleVector>(_intAtom, _doubleVector);
        Divide<IntVector, DoubleAtom, DoubleVector>(_intVector, _doubleAtom);
        Divide<IntVector, DoubleVector, DoubleVector>(_intVector, _doubleVector);
    }

    [Test]
    public void IntDivideTimestampReturnsCorrectTypes()
    {
        Divide<IntAtom, TimestampAtom, DoubleAtom>(_intAtom, _timestampAtom);
        Divide<IntAtom, TimestampVector, DoubleVector>(_intAtom, _timestampVector);
        Divide<IntVector, TimestampAtom, DoubleVector>(_intVector, _timestampAtom);
        Divide<IntVector, TimestampVector, DoubleVector>(_intVector, _timestampVector);
    }

    [Test]
    public void IntDivideMonthReturnsCorrectTypes()
    {
        Divide<IntAtom, MonthAtom, DoubleAtom>(_intAtom, _monthAtom);
        Divide<IntAtom, MonthVector, DoubleVector>(_intAtom, _monthVector);
        Divide<IntVector, MonthAtom, DoubleVector>(_intVector, _monthAtom);
        Divide<IntVector, MonthVector, DoubleVector>(_intVector, _monthVector);
    }

    [Test]
    public void IntDivideDateReturnsCorrectTypes()
    {
        Divide<IntAtom, DateAtom, DoubleAtom>(_intAtom, _dateAtom);
        Divide<IntAtom, DateVector, DoubleVector>(_intAtom, _dateVector);
        Divide<IntVector, DateAtom, DoubleVector>(_intVector, _dateAtom);
        Divide<IntVector, DateVector, DoubleVector>(_intVector, _dateVector);
    }

    [Test]
    public void IntDivideTimespanReturnsCorrectTypes()
    {
        Divide<IntAtom, TimespanAtom, DoubleAtom>(_intAtom, _timespanAtom);
        Divide<IntAtom, TimespanVector, DoubleVector>(_intAtom, _timespanVector);
        Divide<IntVector, TimespanAtom, DoubleVector>(_intVector, _timespanAtom);
        Divide<IntVector, TimespanVector, DoubleVector>(_intVector, _timespanVector);
    }

    [Test]
    public void IntDivideMinuteReturnsCorrectTypes()
    {
        Divide<IntAtom, MinuteAtom, DoubleAtom>(_intAtom, _minuteAtom);
        Divide<IntAtom, MinuteVector, DoubleVector>(_intAtom, _minuteVector);
        Divide<IntVector, MinuteAtom, DoubleVector>(_intVector, _minuteAtom);
        Divide<IntVector, MinuteVector, DoubleVector>(_intVector, _minuteVector);
    }

    [Test]
    public void IntDivideSecondReturnsCorrectTypes()
    {
        Divide<IntAtom, SecondAtom, DoubleAtom>(_intAtom, _secondAtom);
        Divide<IntAtom, SecondVector, DoubleVector>(_intAtom, _secondVector);
        Divide<IntVector, SecondAtom, DoubleVector>(_intVector, _secondAtom);
        Divide<IntVector, SecondVector, DoubleVector>(_intVector, _secondVector);
    }

    [Test]
    public void LongDivideByteReturnsCorrectTypes()
    {
        Divide<LongAtom, ByteAtom, DoubleAtom>(_longAtom, _byteAtom);
        Divide<LongAtom, ByteVector, DoubleVector>(_longAtom, _byteVector);
        Divide<LongVector, ByteAtom, DoubleVector>(_longVector, _byteAtom);
        Divide<LongVector, ByteVector, DoubleVector>(_longVector, _byteVector);
    }

    [Test]
    public void LongDivideShortReturnsCorrectTypes()
    {
        Divide<LongAtom, ShortAtom, DoubleAtom>(_longAtom, _shortAtom);
        Divide<LongAtom, ShortVector, DoubleVector>(_longAtom, _shortVector);
        Divide<LongVector, ShortAtom, DoubleVector>(_longVector, _shortAtom);
        Divide<LongVector, ShortVector, DoubleVector>(_longVector, _shortVector);
    }

    [Test]
    public void LongDivideIntReturnsCorrectTypes()
    {
        Divide<LongAtom, IntAtom, DoubleAtom>(_longAtom, _intAtom);
        Divide<LongAtom, IntVector, DoubleVector>(_longAtom, _intVector);
        Divide<LongVector, IntAtom, DoubleVector>(_longVector, _intAtom);
        Divide<LongVector, IntVector, DoubleVector>(_longVector, _intVector);
    }

    [Test]
    public void LongDivideLongReturnsCorrectTypes()
    {
        Divide<LongAtom, LongAtom, DoubleAtom>(_longAtom, _longAtom);
        Divide<LongAtom, LongVector, DoubleVector>(_longAtom, _longVector);
        Divide<LongVector, LongAtom, DoubleVector>(_longVector, _longAtom);
        Divide<LongVector, LongVector, DoubleVector>(_longVector, _longVector);
    }

    [Test]
    public void LongDivideFloatReturnsCorrectTypes()
    {
        Divide<LongAtom, FloatAtom, DoubleAtom>(_longAtom, _floatAtom);
        Divide<LongAtom, FloatVector, DoubleVector>(_longAtom, _floatVector);
        Divide<LongVector, FloatAtom, DoubleVector>(_longVector, _floatAtom);
        Divide<LongVector, FloatVector, DoubleVector>(_longVector, _floatVector);
    }

    [Test]
    public void LongDivideDoubleReturnsCorrectTypes()
    {
        Divide<LongAtom, DoubleAtom, DoubleAtom>(_longAtom, _doubleAtom);
        Divide<LongAtom, DoubleVector, DoubleVector>(_longAtom, _doubleVector);
        Divide<LongVector, DoubleAtom, DoubleVector>(_longVector, _doubleAtom);
        Divide<LongVector, DoubleVector, DoubleVector>(_longVector, _doubleVector);
    }

    [Test]
    public void LongDivideTimestampReturnsCorrectTypes()
    {
        Divide<LongAtom, TimestampAtom, DoubleAtom>(_longAtom, _timestampAtom);
        Divide<LongAtom, TimestampVector, DoubleVector>(_longAtom, _timestampVector);
        Divide<LongVector, TimestampAtom, DoubleVector>(_longVector, _timestampAtom);
        Divide<LongVector, TimestampVector, DoubleVector>(_longVector, _timestampVector);
    }

    [Test]
    public void LongDivideMonthReturnsCorrectTypes()
    {
        Divide<LongAtom, MonthAtom, DoubleAtom>(_longAtom, _monthAtom);
        Divide<LongAtom, MonthVector, DoubleVector>(_longAtom, _monthVector);
        Divide<LongVector, MonthAtom, DoubleVector>(_longVector, _monthAtom);
        Divide<LongVector, MonthVector, DoubleVector>(_longVector, _monthVector);
    }

    [Test]
    public void LongDivideDateReturnsCorrectTypes()
    {
        Divide<LongAtom, DateAtom, DoubleAtom>(_longAtom, _dateAtom);
        Divide<LongAtom, DateVector, DoubleVector>(_longAtom, _dateVector);
        Divide<LongVector, DateAtom, DoubleVector>(_longVector, _dateAtom);
        Divide<LongVector, DateVector, DoubleVector>(_longVector, _dateVector);
    }

    [Test]
    public void LongDivideTimespanReturnsCorrectTypes()
    {
        Divide<LongAtom, TimespanAtom, DoubleAtom>(_longAtom, _timespanAtom);
        Divide<LongAtom, TimespanVector, DoubleVector>(_longAtom, _timespanVector);
        Divide<LongVector, TimespanAtom, DoubleVector>(_longVector, _timespanAtom);
        Divide<LongVector, TimespanVector, DoubleVector>(_longVector, _timespanVector);
    }

    [Test]
    public void LongDivideMinuteReturnsCorrectTypes()
    {
        Divide<LongAtom, MinuteAtom, DoubleAtom>(_longAtom, _minuteAtom);
        Divide<LongAtom, MinuteVector, DoubleVector>(_longAtom, _minuteVector);
        Divide<LongVector, MinuteAtom, DoubleVector>(_longVector, _minuteAtom);
        Divide<LongVector, MinuteVector, DoubleVector>(_longVector, _minuteVector);
    }

    [Test]
    public void LongDivideSecondReturnsCorrectTypes()
    {
        Divide<LongAtom, SecondAtom, DoubleAtom>(_longAtom, _secondAtom);
        Divide<LongAtom, SecondVector, DoubleVector>(_longAtom, _secondVector);
        Divide<LongVector, SecondAtom, DoubleVector>(_longVector, _secondAtom);
        Divide<LongVector, SecondVector, DoubleVector>(_longVector, _secondVector);
    }

    [Test]
    public void FloatDivideByteReturnsCorrectTypes()
    {
        Divide<FloatAtom, ByteAtom, DoubleAtom>(_floatAtom, _byteAtom);
        Divide<FloatAtom, ByteVector, DoubleVector>(_floatAtom, _byteVector);
        Divide<FloatVector, ByteAtom, DoubleVector>(_floatVector, _byteAtom);
        Divide<FloatVector, ByteVector, DoubleVector>(_floatVector, _byteVector);
    }

    [Test]
    public void FloatDivideShortReturnsCorrectTypes()
    {
        Divide<FloatAtom, ShortAtom, DoubleAtom>(_floatAtom, _shortAtom);
        Divide<FloatAtom, ShortVector, DoubleVector>(_floatAtom, _shortVector);
        Divide<FloatVector, ShortAtom, DoubleVector>(_floatVector, _shortAtom);
        Divide<FloatVector, ShortVector, DoubleVector>(_floatVector, _shortVector);
    }

    [Test]
    public void FloatDivideIntReturnsCorrectTypes()
    {
        Divide<FloatAtom, IntAtom, DoubleAtom>(_floatAtom, _intAtom);
        Divide<FloatAtom, IntVector, DoubleVector>(_floatAtom, _intVector);
        Divide<FloatVector, IntAtom, DoubleVector>(_floatVector, _intAtom);
        Divide<FloatVector, IntVector, DoubleVector>(_floatVector, _intVector);
    }

    [Test]
    public void FloatDivideLongReturnsCorrectTypes()
    {
        Divide<FloatAtom, LongAtom, DoubleAtom>(_floatAtom, _longAtom);
        Divide<FloatAtom, LongVector, DoubleVector>(_floatAtom, _longVector);
        Divide<FloatVector, LongAtom, DoubleVector>(_floatVector, _longAtom);
        Divide<FloatVector, LongVector, DoubleVector>(_floatVector, _longVector);
    }

    [Test]
    public void FloatDivideFloatReturnsCorrectTypes()
    {
        Divide<FloatAtom, FloatAtom, DoubleAtom>(_floatAtom, _floatAtom);
        Divide<FloatAtom, FloatVector, DoubleVector>(_floatAtom, _floatVector);
        Divide<FloatVector, FloatAtom, DoubleVector>(_floatVector, _floatAtom);
        Divide<FloatVector, FloatVector, DoubleVector>(_floatVector, _floatVector);
    }

    [Test]
    public void FloatDivideDoubleReturnsCorrectTypes()
    {
        Divide<FloatAtom, DoubleAtom, DoubleAtom>(_floatAtom, _doubleAtom);
        Divide<FloatAtom, DoubleVector, DoubleVector>(_floatAtom, _doubleVector);
        Divide<FloatVector, DoubleAtom, DoubleVector>(_floatVector, _doubleAtom);
        Divide<FloatVector, DoubleVector, DoubleVector>(_floatVector, _doubleVector);
    }

    [Test]
    public void FloatDivideTimestampReturnsCorrectTypes()
    {
        Divide<FloatAtom, TimestampAtom, DoubleAtom>(_floatAtom, _timestampAtom);
        Divide<FloatAtom, TimestampVector, DoubleVector>(_floatAtom, _timestampVector);
        Divide<FloatVector, TimestampAtom, DoubleVector>(_floatVector, _timestampAtom);
        Divide<FloatVector, TimestampVector, DoubleVector>(_floatVector, _timestampVector);
    }

    [Test]
    public void FloatDivideMonthReturnsCorrectTypes()
    {
        Divide<FloatAtom, MonthAtom, DoubleAtom>(_floatAtom, _monthAtom);
        Divide<FloatAtom, MonthVector, DoubleVector>(_floatAtom, _monthVector);
        Divide<FloatVector, MonthAtom, DoubleVector>(_floatVector, _monthAtom);
        Divide<FloatVector, MonthVector, DoubleVector>(_floatVector, _monthVector);
    }

    [Test]
    public void FloatDivideDateReturnsCorrectTypes()
    {
        Divide<FloatAtom, DateAtom, DoubleAtom>(_floatAtom, _dateAtom);
        Divide<FloatAtom, DateVector, DoubleVector>(_floatAtom, _dateVector);
        Divide<FloatVector, DateAtom, DoubleVector>(_floatVector, _dateAtom);
        Divide<FloatVector, DateVector, DoubleVector>(_floatVector, _dateVector);
    }

    [Test]
    public void FloatDivideTimespanReturnsCorrectTypes()
    {
        Divide<FloatAtom, TimespanAtom, DoubleAtom>(_floatAtom, _timespanAtom);
        Divide<FloatAtom, TimespanVector, DoubleVector>(_floatAtom, _timespanVector);
        Divide<FloatVector, TimespanAtom, DoubleVector>(_floatVector, _timespanAtom);
        Divide<FloatVector, TimespanVector, DoubleVector>(_floatVector, _timespanVector);
    }

    [Test]
    public void FloatDivideMinuteReturnsCorrectTypes()
    {
        Divide<FloatAtom, MinuteAtom, DoubleAtom>(_floatAtom, _minuteAtom);
        Divide<FloatAtom, MinuteVector, DoubleVector>(_floatAtom, _minuteVector);
        Divide<FloatVector, MinuteAtom, DoubleVector>(_floatVector, _minuteAtom);
        Divide<FloatVector, MinuteVector, DoubleVector>(_floatVector, _minuteVector);
    }

    [Test]
    public void FloatDivideSecondReturnsCorrectTypes()
    {
        Divide<FloatAtom, SecondAtom, DoubleAtom>(_floatAtom, _secondAtom);
        Divide<FloatAtom, SecondVector, DoubleVector>(_floatAtom, _secondVector);
        Divide<FloatVector, SecondAtom, DoubleVector>(_floatVector, _secondAtom);
        Divide<FloatVector, SecondVector, DoubleVector>(_floatVector, _secondVector);
    }

    [Test]
    public void DoubleDivideByteReturnsCorrectTypes()
    {
        Divide<DoubleAtom, ByteAtom, DoubleAtom>(_doubleAtom, _byteAtom);
        Divide<DoubleAtom, ByteVector, DoubleVector>(_doubleAtom, _byteVector);
        Divide<DoubleVector, ByteAtom, DoubleVector>(_doubleVector, _byteAtom);
        Divide<DoubleVector, ByteVector, DoubleVector>(_doubleVector, _byteVector);
    }

    [Test]
    public void DoubleDivideShortReturnsCorrectTypes()
    {
        Divide<DoubleAtom, ShortAtom, DoubleAtom>(_doubleAtom, _shortAtom);
        Divide<DoubleAtom, ShortVector, DoubleVector>(_doubleAtom, _shortVector);
        Divide<DoubleVector, ShortAtom, DoubleVector>(_doubleVector, _shortAtom);
        Divide<DoubleVector, ShortVector, DoubleVector>(_doubleVector, _shortVector);
    }

    [Test]
    public void DoubleDivideIntReturnsCorrectTypes()
    {
        Divide<DoubleAtom, IntAtom, DoubleAtom>(_doubleAtom, _intAtom);
        Divide<DoubleAtom, IntVector, DoubleVector>(_doubleAtom, _intVector);
        Divide<DoubleVector, IntAtom, DoubleVector>(_doubleVector, _intAtom);
        Divide<DoubleVector, IntVector, DoubleVector>(_doubleVector, _intVector);
    }

    [Test]
    public void DoubleDivideLongReturnsCorrectTypes()
    {
        Divide<DoubleAtom, LongAtom, DoubleAtom>(_doubleAtom, _longAtom);
        Divide<DoubleAtom, LongVector, DoubleVector>(_doubleAtom, _longVector);
        Divide<DoubleVector, LongAtom, DoubleVector>(_doubleVector, _longAtom);
        Divide<DoubleVector, LongVector, DoubleVector>(_doubleVector, _longVector);
    }

    [Test]
    public void DoubleDivideFloatReturnsCorrectTypes()
    {
        Divide<DoubleAtom, FloatAtom, DoubleAtom>(_doubleAtom, _floatAtom);
        Divide<DoubleAtom, FloatVector, DoubleVector>(_doubleAtom, _floatVector);
        Divide<DoubleVector, FloatAtom, DoubleVector>(_doubleVector, _floatAtom);
        Divide<DoubleVector, FloatVector, DoubleVector>(_doubleVector, _floatVector);
    }

    [Test]
    public void DoubleDivideDoubleReturnsCorrectTypes()
    {
        Divide<DoubleAtom, DoubleAtom, DoubleAtom>(_doubleAtom, _doubleAtom);
        Divide<DoubleAtom, DoubleVector, DoubleVector>(_doubleAtom, _doubleVector);
        Divide<DoubleVector, DoubleAtom, DoubleVector>(_doubleVector, _doubleAtom);
        Divide<DoubleVector, DoubleVector, DoubleVector>(_doubleVector, _doubleVector);
    }

    [Test]
    public void DoubleDivideTimestampReturnsCorrectTypes()
    {
        Divide<DoubleAtom, TimestampAtom, DoubleAtom>(_doubleAtom, _timestampAtom);
        Divide<DoubleAtom, TimestampVector, DoubleVector>(_doubleAtom, _timestampVector);
        Divide<DoubleVector, TimestampAtom, DoubleVector>(_doubleVector, _timestampAtom);
        Divide<DoubleVector, TimestampVector, DoubleVector>(_doubleVector, _timestampVector);
    }

    [Test]
    public void DoubleDivideMonthReturnsCorrectTypes()
    {
        Divide<DoubleAtom, MonthAtom, DoubleAtom>(_doubleAtom, _monthAtom);
        Divide<DoubleAtom, MonthVector, DoubleVector>(_doubleAtom, _monthVector);
        Divide<DoubleVector, MonthAtom, DoubleVector>(_doubleVector, _monthAtom);
        Divide<DoubleVector, MonthVector, DoubleVector>(_doubleVector, _monthVector);
    }

    [Test]
    public void DoubleDivideDateReturnsCorrectTypes()
    {
        Divide<DoubleAtom, DateAtom, DoubleAtom>(_doubleAtom, _dateAtom);
        Divide<DoubleAtom, DateVector, DoubleVector>(_doubleAtom, _dateVector);
        Divide<DoubleVector, DateAtom, DoubleVector>(_doubleVector, _dateAtom);
        Divide<DoubleVector, DateVector, DoubleVector>(_doubleVector, _dateVector);
    }

    [Test]
    public void DoubleDivideTimespanReturnsCorrectTypes()
    {
        Divide<DoubleAtom, TimespanAtom, DoubleAtom>(_doubleAtom, _timespanAtom);
        Divide<DoubleAtom, TimespanVector, DoubleVector>(_doubleAtom, _timespanVector);
        Divide<DoubleVector, TimespanAtom, DoubleVector>(_doubleVector, _timespanAtom);
        Divide<DoubleVector, TimespanVector, DoubleVector>(_doubleVector, _timespanVector);
    }

    [Test]
    public void DoubleDivideMinuteReturnsCorrectTypes()
    {
        Divide<DoubleAtom, MinuteAtom, DoubleAtom>(_doubleAtom, _minuteAtom);
        Divide<DoubleAtom, MinuteVector, DoubleVector>(_doubleAtom, _minuteVector);
        Divide<DoubleVector, MinuteAtom, DoubleVector>(_doubleVector, _minuteAtom);
        Divide<DoubleVector, MinuteVector, DoubleVector>(_doubleVector, _minuteVector);
    }

    [Test]
    public void DoubleDivideSecondReturnsCorrectTypes()
    {
        Divide<DoubleAtom, SecondAtom, DoubleAtom>(_doubleAtom, _secondAtom);
        Divide<DoubleAtom, SecondVector, DoubleVector>(_doubleAtom, _secondVector);
        Divide<DoubleVector, SecondAtom, DoubleVector>(_doubleVector, _secondAtom);
        Divide<DoubleVector, SecondVector, DoubleVector>(_doubleVector, _secondVector);
    }

    [Test]
    public void TimestampDivideByteReturnsCorrectTypes()
    {
        Divide<TimestampAtom, ByteAtom, DoubleAtom>(_timestampAtom, _byteAtom);
        Divide<TimestampAtom, ByteVector, DoubleVector>(_timestampAtom, _byteVector);
        Divide<TimestampVector, ByteAtom, DoubleVector>(_timestampVector, _byteAtom);
        Divide<TimestampVector, ByteVector, DoubleVector>(_timestampVector, _byteVector);
    }

    [Test]
    public void TimestampDivideShortReturnsCorrectTypes()
    {
        Divide<TimestampAtom, ShortAtom, DoubleAtom>(_timestampAtom, _shortAtom);
        Divide<TimestampAtom, ShortVector, DoubleVector>(_timestampAtom, _shortVector);
        Divide<TimestampVector, ShortAtom, DoubleVector>(_timestampVector, _shortAtom);
        Divide<TimestampVector, ShortVector, DoubleVector>(_timestampVector, _shortVector);
    }

    [Test]
    public void TimestampDivideIntReturnsCorrectTypes()
    {
        Divide<TimestampAtom, IntAtom, DoubleAtom>(_timestampAtom, _intAtom);
        Divide<TimestampAtom, IntVector, DoubleVector>(_timestampAtom, _intVector);
        Divide<TimestampVector, IntAtom, DoubleVector>(_timestampVector, _intAtom);
        Divide<TimestampVector, IntVector, DoubleVector>(_timestampVector, _intVector);
    }

    [Test]
    public void TimestampDivideLongReturnsCorrectTypes()
    {
        Divide<TimestampAtom, LongAtom, DoubleAtom>(_timestampAtom, _longAtom);
        Divide<TimestampAtom, LongVector, DoubleVector>(_timestampAtom, _longVector);
        Divide<TimestampVector, LongAtom, DoubleVector>(_timestampVector, _longAtom);
        Divide<TimestampVector, LongVector, DoubleVector>(_timestampVector, _longVector);
    }

    [Test]
    public void TimestampDivideFloatReturnsCorrectTypes()
    {
        Divide<TimestampAtom, FloatAtom, DoubleAtom>(_timestampAtom, _floatAtom);
        Divide<TimestampAtom, FloatVector, DoubleVector>(_timestampAtom, _floatVector);
        Divide<TimestampVector, FloatAtom, DoubleVector>(_timestampVector, _floatAtom);
        Divide<TimestampVector, FloatVector, DoubleVector>(_timestampVector, _floatVector);
    }

    [Test]
    public void TimestampDivideDoubleReturnsCorrectTypes()
    {
        Divide<TimestampAtom, DoubleAtom, DoubleAtom>(_timestampAtom, _doubleAtom);
        Divide<TimestampAtom, DoubleVector, DoubleVector>(_timestampAtom, _doubleVector);
        Divide<TimestampVector, DoubleAtom, DoubleVector>(_timestampVector, _doubleAtom);
        Divide<TimestampVector, DoubleVector, DoubleVector>(_timestampVector, _doubleVector);
    }

    [Test]
    public void TimestampDivideTimestampReturnsCorrectTypes()
    {
        Divide<TimestampAtom, TimestampAtom, DoubleAtom>(_timestampAtom, _timestampAtom);
        Divide<TimestampAtom, TimestampVector, DoubleVector>(_timestampAtom, _timestampVector);
        Divide<TimestampVector, TimestampAtom, DoubleVector>(_timestampVector, _timestampAtom);
        Divide<TimestampVector, TimestampVector, DoubleVector>(_timestampVector, _timestampVector);
    }

    [Test]
    public void TimestampDivideMonthReturnsCorrectTypes()
    {
        Divide<TimestampAtom, MonthAtom, DoubleAtom>(_timestampAtom, _monthAtom);
        Divide<TimestampAtom, MonthVector, DoubleVector>(_timestampAtom, _monthVector);
        Divide<TimestampVector, MonthAtom, DoubleVector>(_timestampVector, _monthAtom);
        Divide<TimestampVector, MonthVector, DoubleVector>(_timestampVector, _monthVector);
    }

    [Test]
    public void TimestampDivideDateReturnsCorrectTypes()
    {
        Divide<TimestampAtom, DateAtom, DoubleAtom>(_timestampAtom, _dateAtom);
        Divide<TimestampAtom, DateVector, DoubleVector>(_timestampAtom, _dateVector);
        Divide<TimestampVector, DateAtom, DoubleVector>(_timestampVector, _dateAtom);
        Divide<TimestampVector, DateVector, DoubleVector>(_timestampVector, _dateVector);
    }

    [Test]
    public void TimestampDivideTimespanReturnsCorrectTypes()
    {
        Divide<TimestampAtom, TimespanAtom, DoubleAtom>(_timestampAtom, _timespanAtom);
        Divide<TimestampAtom, TimespanVector, DoubleVector>(_timestampAtom, _timespanVector);
        Divide<TimestampVector, TimespanAtom, DoubleVector>(_timestampVector, _timespanAtom);
        Divide<TimestampVector, TimespanVector, DoubleVector>(_timestampVector, _timespanVector);
    }

    [Test]
    public void TimestampDivideMinuteReturnsCorrectTypes()
    {
        Divide<TimestampAtom, MinuteAtom, DoubleAtom>(_timestampAtom, _minuteAtom);
        Divide<TimestampAtom, MinuteVector, DoubleVector>(_timestampAtom, _minuteVector);
        Divide<TimestampVector, MinuteAtom, DoubleVector>(_timestampVector, _minuteAtom);
        Divide<TimestampVector, MinuteVector, DoubleVector>(_timestampVector, _minuteVector);
    }

    [Test]
    public void TimestampDivideSecondReturnsCorrectTypes()
    {
        Divide<TimestampAtom, SecondAtom, DoubleAtom>(_timestampAtom, _secondAtom);
        Divide<TimestampAtom, SecondVector, DoubleVector>(_timestampAtom, _secondVector);
        Divide<TimestampVector, SecondAtom, DoubleVector>(_timestampVector, _secondAtom);
        Divide<TimestampVector, SecondVector, DoubleVector>(_timestampVector, _secondVector);
    }

    [Test]
    public void MonthDivideByteReturnsCorrectTypes()
    {
        Divide<MonthAtom, ByteAtom, DoubleAtom>(_monthAtom, _byteAtom);
        Divide<MonthAtom, ByteVector, DoubleVector>(_monthAtom, _byteVector);
        Divide<MonthVector, ByteAtom, DoubleVector>(_monthVector, _byteAtom);
        Divide<MonthVector, ByteVector, DoubleVector>(_monthVector, _byteVector);
    }

    [Test]
    public void MonthDivideShortReturnsCorrectTypes()
    {
        Divide<MonthAtom, ShortAtom, DoubleAtom>(_monthAtom, _shortAtom);
        Divide<MonthAtom, ShortVector, DoubleVector>(_monthAtom, _shortVector);
        Divide<MonthVector, ShortAtom, DoubleVector>(_monthVector, _shortAtom);
        Divide<MonthVector, ShortVector, DoubleVector>(_monthVector, _shortVector);
    }

    [Test]
    public void MonthDivideIntReturnsCorrectTypes()
    {
        Divide<MonthAtom, IntAtom, DoubleAtom>(_monthAtom, _intAtom);
        Divide<MonthAtom, IntVector, DoubleVector>(_monthAtom, _intVector);
        Divide<MonthVector, IntAtom, DoubleVector>(_monthVector, _intAtom);
        Divide<MonthVector, IntVector, DoubleVector>(_monthVector, _intVector);
    }

    [Test]
    public void MonthDivideLongReturnsCorrectTypes()
    {
        Divide<MonthAtom, LongAtom, DoubleAtom>(_monthAtom, _longAtom);
        Divide<MonthAtom, LongVector, DoubleVector>(_monthAtom, _longVector);
        Divide<MonthVector, LongAtom, DoubleVector>(_monthVector, _longAtom);
        Divide<MonthVector, LongVector, DoubleVector>(_monthVector, _longVector);
    }

    [Test]
    public void MonthDivideFloatReturnsCorrectTypes()
    {
        Divide<MonthAtom, FloatAtom, DoubleAtom>(_monthAtom, _floatAtom);
        Divide<MonthAtom, FloatVector, DoubleVector>(_monthAtom, _floatVector);
        Divide<MonthVector, FloatAtom, DoubleVector>(_monthVector, _floatAtom);
        Divide<MonthVector, FloatVector, DoubleVector>(_monthVector, _floatVector);
    }

    [Test]
    public void MonthDivideDoubleReturnsCorrectTypes()
    {
        Divide<MonthAtom, DoubleAtom, DoubleAtom>(_monthAtom, _doubleAtom);
        Divide<MonthAtom, DoubleVector, DoubleVector>(_monthAtom, _doubleVector);
        Divide<MonthVector, DoubleAtom, DoubleVector>(_monthVector, _doubleAtom);
        Divide<MonthVector, DoubleVector, DoubleVector>(_monthVector, _doubleVector);
    }

    [Test]
    public void MonthDivideTimestampReturnsCorrectTypes()
    {
        Divide<MonthAtom, TimestampAtom, DoubleAtom>(_monthAtom, _timestampAtom);
        Divide<MonthAtom, TimestampVector, DoubleVector>(_monthAtom, _timestampVector);
        Divide<MonthVector, TimestampAtom, DoubleVector>(_monthVector, _timestampAtom);
        Divide<MonthVector, TimestampVector, DoubleVector>(_monthVector, _timestampVector);
    }

    [Test]
    public void MonthDivideMonthReturnsCorrectTypes()
    {
        Divide<MonthAtom, MonthAtom, DoubleAtom>(_monthAtom, _monthAtom);
        Divide<MonthAtom, MonthVector, DoubleVector>(_monthAtom, _monthVector);
        Divide<MonthVector, MonthAtom, DoubleVector>(_monthVector, _monthAtom);
        Divide<MonthVector, MonthVector, DoubleVector>(_monthVector, _monthVector);
    }

    [Test]
    public void MonthDivideDateReturnsCorrectTypes()
    {
        Divide<MonthAtom, DateAtom, DoubleAtom>(_monthAtom, _dateAtom);
        Divide<MonthAtom, DateVector, DoubleVector>(_monthAtom, _dateVector);
        Divide<MonthVector, DateAtom, DoubleVector>(_monthVector, _dateAtom);
        Divide<MonthVector, DateVector, DoubleVector>(_monthVector, _dateVector);
    }

    [Test]
    public void MonthDivideTimespanReturnsCorrectTypes()
    {
        Divide<MonthAtom, TimespanAtom, DoubleAtom>(_monthAtom, _timespanAtom);
        Divide<MonthAtom, TimespanVector, DoubleVector>(_monthAtom, _timespanVector);
        Divide<MonthVector, TimespanAtom, DoubleVector>(_monthVector, _timespanAtom);
        Divide<MonthVector, TimespanVector, DoubleVector>(_monthVector, _timespanVector);
    }

    [Test]
    public void MonthDivideMinuteReturnsCorrectTypes()
    {
        Divide<MonthAtom, MinuteAtom, DoubleAtom>(_monthAtom, _minuteAtom);
        Divide<MonthAtom, MinuteVector, DoubleVector>(_monthAtom, _minuteVector);
        Divide<MonthVector, MinuteAtom, DoubleVector>(_monthVector, _minuteAtom);
        Divide<MonthVector, MinuteVector, DoubleVector>(_monthVector, _minuteVector);
    }

    [Test]
    public void MonthDivideSecondReturnsCorrectTypes()
    {
        Divide<MonthAtom, SecondAtom, DoubleAtom>(_monthAtom, _secondAtom);
        Divide<MonthAtom, SecondVector, DoubleVector>(_monthAtom, _secondVector);
        Divide<MonthVector, SecondAtom, DoubleVector>(_monthVector, _secondAtom);
        Divide<MonthVector, SecondVector, DoubleVector>(_monthVector, _secondVector);
    }

    [Test]
    public void DateDivideByteReturnsCorrectTypes()
    {
        Divide<DateAtom, ByteAtom, DoubleAtom>(_dateAtom, _byteAtom);
        Divide<DateAtom, ByteVector, DoubleVector>(_dateAtom, _byteVector);
        Divide<DateVector, ByteAtom, DoubleVector>(_dateVector, _byteAtom);
        Divide<DateVector, ByteVector, DoubleVector>(_dateVector, _byteVector);
    }

    [Test]
    public void DateDivideShortReturnsCorrectTypes()
    {
        Divide<DateAtom, ShortAtom, DoubleAtom>(_dateAtom, _shortAtom);
        Divide<DateAtom, ShortVector, DoubleVector>(_dateAtom, _shortVector);
        Divide<DateVector, ShortAtom, DoubleVector>(_dateVector, _shortAtom);
        Divide<DateVector, ShortVector, DoubleVector>(_dateVector, _shortVector);
    }

    [Test]
    public void DateDivideIntReturnsCorrectTypes()
    {
        Divide<DateAtom, IntAtom, DoubleAtom>(_dateAtom, _intAtom);
        Divide<DateAtom, IntVector, DoubleVector>(_dateAtom, _intVector);
        Divide<DateVector, IntAtom, DoubleVector>(_dateVector, _intAtom);
        Divide<DateVector, IntVector, DoubleVector>(_dateVector, _intVector);
    }

    [Test]
    public void DateDivideLongReturnsCorrectTypes()
    {
        Divide<DateAtom, LongAtom, DoubleAtom>(_dateAtom, _longAtom);
        Divide<DateAtom, LongVector, DoubleVector>(_dateAtom, _longVector);
        Divide<DateVector, LongAtom, DoubleVector>(_dateVector, _longAtom);
        Divide<DateVector, LongVector, DoubleVector>(_dateVector, _longVector);
    }

    [Test]
    public void DateDivideFloatReturnsCorrectTypes()
    {
        Divide<DateAtom, FloatAtom, DoubleAtom>(_dateAtom, _floatAtom);
        Divide<DateAtom, FloatVector, DoubleVector>(_dateAtom, _floatVector);
        Divide<DateVector, FloatAtom, DoubleVector>(_dateVector, _floatAtom);
        Divide<DateVector, FloatVector, DoubleVector>(_dateVector, _floatVector);
    }

    [Test]
    public void DateDivideDoubleReturnsCorrectTypes()
    {
        Divide<DateAtom, DoubleAtom, DoubleAtom>(_dateAtom, _doubleAtom);
        Divide<DateAtom, DoubleVector, DoubleVector>(_dateAtom, _doubleVector);
        Divide<DateVector, DoubleAtom, DoubleVector>(_dateVector, _doubleAtom);
        Divide<DateVector, DoubleVector, DoubleVector>(_dateVector, _doubleVector);
    }

    [Test]
    public void DateDivideTimestampReturnsCorrectTypes()
    {
        Divide<DateAtom, TimestampAtom, DoubleAtom>(_dateAtom, _timestampAtom);
        Divide<DateAtom, TimestampVector, DoubleVector>(_dateAtom, _timestampVector);
        Divide<DateVector, TimestampAtom, DoubleVector>(_dateVector, _timestampAtom);
        Divide<DateVector, TimestampVector, DoubleVector>(_dateVector, _timestampVector);
    }

    [Test]
    public void DateDivideMonthReturnsCorrectTypes()
    {
        Divide<DateAtom, MonthAtom, DoubleAtom>(_dateAtom, _monthAtom);
        Divide<DateAtom, MonthVector, DoubleVector>(_dateAtom, _monthVector);
        Divide<DateVector, MonthAtom, DoubleVector>(_dateVector, _monthAtom);
        Divide<DateVector, MonthVector, DoubleVector>(_dateVector, _monthVector);
    }

    [Test]
    public void DateDivideDateReturnsCorrectTypes()
    {
        Divide<DateAtom, DateAtom, DoubleAtom>(_dateAtom, _dateAtom);
        Divide<DateAtom, DateVector, DoubleVector>(_dateAtom, _dateVector);
        Divide<DateVector, DateAtom, DoubleVector>(_dateVector, _dateAtom);
        Divide<DateVector, DateVector, DoubleVector>(_dateVector, _dateVector);
    }

    [Test]
    public void DateDivideTimespanReturnsCorrectTypes()
    {
        Divide<DateAtom, TimespanAtom, DoubleAtom>(_dateAtom, _timespanAtom);
        Divide<DateAtom, TimespanVector, DoubleVector>(_dateAtom, _timespanVector);
        Divide<DateVector, TimespanAtom, DoubleVector>(_dateVector, _timespanAtom);
        Divide<DateVector, TimespanVector, DoubleVector>(_dateVector, _timespanVector);
    }

    [Test]
    public void DateDivideMinuteReturnsCorrectTypes()
    {
        Divide<DateAtom, MinuteAtom, DoubleAtom>(_dateAtom, _minuteAtom);
        Divide<DateAtom, MinuteVector, DoubleVector>(_dateAtom, _minuteVector);
        Divide<DateVector, MinuteAtom, DoubleVector>(_dateVector, _minuteAtom);
        Divide<DateVector, MinuteVector, DoubleVector>(_dateVector, _minuteVector);
    }

    [Test]
    public void DateDivideSecondReturnsCorrectTypes()
    {
        Divide<DateAtom, SecondAtom, DoubleAtom>(_dateAtom, _secondAtom);
        Divide<DateAtom, SecondVector, DoubleVector>(_dateAtom, _secondVector);
        Divide<DateVector, SecondAtom, DoubleVector>(_dateVector, _secondAtom);
        Divide<DateVector, SecondVector, DoubleVector>(_dateVector, _secondVector);
    }

    [Test]
    public void TimespanDivideByteReturnsCorrectTypes()
    {
        Divide<TimespanAtom, ByteAtom, DoubleAtom>(_timespanAtom, _byteAtom);
        Divide<TimespanAtom, ByteVector, DoubleVector>(_timespanAtom, _byteVector);
        Divide<TimespanVector, ByteAtom, DoubleVector>(_timespanVector, _byteAtom);
        Divide<TimespanVector, ByteVector, DoubleVector>(_timespanVector, _byteVector);
    }

    [Test]
    public void TimespanDivideShortReturnsCorrectTypes()
    {
        Divide<TimespanAtom, ShortAtom, DoubleAtom>(_timespanAtom, _shortAtom);
        Divide<TimespanAtom, ShortVector, DoubleVector>(_timespanAtom, _shortVector);
        Divide<TimespanVector, ShortAtom, DoubleVector>(_timespanVector, _shortAtom);
        Divide<TimespanVector, ShortVector, DoubleVector>(_timespanVector, _shortVector);
    }

    [Test]
    public void TimespanDivideIntReturnsCorrectTypes()
    {
        Divide<TimespanAtom, IntAtom, DoubleAtom>(_timespanAtom, _intAtom);
        Divide<TimespanAtom, IntVector, DoubleVector>(_timespanAtom, _intVector);
        Divide<TimespanVector, IntAtom, DoubleVector>(_timespanVector, _intAtom);
        Divide<TimespanVector, IntVector, DoubleVector>(_timespanVector, _intVector);
    }

    [Test]
    public void TimespanDivideLongReturnsCorrectTypes()
    {
        Divide<TimespanAtom, LongAtom, DoubleAtom>(_timespanAtom, _longAtom);
        Divide<TimespanAtom, LongVector, DoubleVector>(_timespanAtom, _longVector);
        Divide<TimespanVector, LongAtom, DoubleVector>(_timespanVector, _longAtom);
        Divide<TimespanVector, LongVector, DoubleVector>(_timespanVector, _longVector);
    }

    [Test]
    public void TimespanDivideFloatReturnsCorrectTypes()
    {
        Divide<TimespanAtom, FloatAtom, DoubleAtom>(_timespanAtom, _floatAtom);
        Divide<TimespanAtom, FloatVector, DoubleVector>(_timespanAtom, _floatVector);
        Divide<TimespanVector, FloatAtom, DoubleVector>(_timespanVector, _floatAtom);
        Divide<TimespanVector, FloatVector, DoubleVector>(_timespanVector, _floatVector);
    }

    [Test]
    public void TimespanDivideDoubleReturnsCorrectTypes()
    {
        Divide<TimespanAtom, DoubleAtom, DoubleAtom>(_timespanAtom, _doubleAtom);
        Divide<TimespanAtom, DoubleVector, DoubleVector>(_timespanAtom, _doubleVector);
        Divide<TimespanVector, DoubleAtom, DoubleVector>(_timespanVector, _doubleAtom);
        Divide<TimespanVector, DoubleVector, DoubleVector>(_timespanVector, _doubleVector);
    }

    [Test]
    public void TimespanDivideTimestampReturnsCorrectTypes()
    {
        Divide<TimespanAtom, TimestampAtom, DoubleAtom>(_timespanAtom, _timestampAtom);
        Divide<TimespanAtom, TimestampVector, DoubleVector>(_timespanAtom, _timestampVector);
        Divide<TimespanVector, TimestampAtom, DoubleVector>(_timespanVector, _timestampAtom);
        Divide<TimespanVector, TimestampVector, DoubleVector>(_timespanVector, _timestampVector);
    }

    [Test]
    public void TimespanDivideMonthReturnsCorrectTypes()
    {
        Divide<TimespanAtom, MonthAtom, DoubleAtom>(_timespanAtom, _monthAtom);
        Divide<TimespanAtom, MonthVector, DoubleVector>(_timespanAtom, _monthVector);
        Divide<TimespanVector, MonthAtom, DoubleVector>(_timespanVector, _monthAtom);
        Divide<TimespanVector, MonthVector, DoubleVector>(_timespanVector, _monthVector);
    }

    [Test]
    public void TimespanDivideDateReturnsCorrectTypes()
    {
        Divide<TimespanAtom, DateAtom, DoubleAtom>(_timespanAtom, _dateAtom);
        Divide<TimespanAtom, DateVector, DoubleVector>(_timespanAtom, _dateVector);
        Divide<TimespanVector, DateAtom, DoubleVector>(_timespanVector, _dateAtom);
        Divide<TimespanVector, DateVector, DoubleVector>(_timespanVector, _dateVector);
    }

    [Test]
    public void TimespanDivideTimespanReturnsCorrectTypes()
    {
        Divide<TimespanAtom, TimespanAtom, DoubleAtom>(_timespanAtom, _timespanAtom);
        Divide<TimespanAtom, TimespanVector, DoubleVector>(_timespanAtom, _timespanVector);
        Divide<TimespanVector, TimespanAtom, DoubleVector>(_timespanVector, _timespanAtom);
        Divide<TimespanVector, TimespanVector, DoubleVector>(_timespanVector, _timespanVector);
    }

    [Test]
    public void TimespanDivideMinuteReturnsCorrectTypes()
    {
        Divide<TimespanAtom, MinuteAtom, DoubleAtom>(_timespanAtom, _minuteAtom);
        Divide<TimespanAtom, MinuteVector, DoubleVector>(_timespanAtom, _minuteVector);
        Divide<TimespanVector, MinuteAtom, DoubleVector>(_timespanVector, _minuteAtom);
        Divide<TimespanVector, MinuteVector, DoubleVector>(_timespanVector, _minuteVector);
    }

    [Test]
    public void TimespanDivideSecondReturnsCorrectTypes()
    {
        Divide<TimespanAtom, SecondAtom, DoubleAtom>(_timespanAtom, _secondAtom);
        Divide<TimespanAtom, SecondVector, DoubleVector>(_timespanAtom, _secondVector);
        Divide<TimespanVector, SecondAtom, DoubleVector>(_timespanVector, _secondAtom);
        Divide<TimespanVector, SecondVector, DoubleVector>(_timespanVector, _secondVector);
    }

    [Test]
    public void MinuteDivideByteReturnsCorrectTypes()
    {
        Divide<MinuteAtom, ByteAtom, DoubleAtom>(_minuteAtom, _byteAtom);
        Divide<MinuteAtom, ByteVector, DoubleVector>(_minuteAtom, _byteVector);
        Divide<MinuteVector, ByteAtom, DoubleVector>(_minuteVector, _byteAtom);
        Divide<MinuteVector, ByteVector, DoubleVector>(_minuteVector, _byteVector);
    }

    [Test]
    public void MinuteDivideShortReturnsCorrectTypes()
    {
        Divide<MinuteAtom, ShortAtom, DoubleAtom>(_minuteAtom, _shortAtom);
        Divide<MinuteAtom, ShortVector, DoubleVector>(_minuteAtom, _shortVector);
        Divide<MinuteVector, ShortAtom, DoubleVector>(_minuteVector, _shortAtom);
        Divide<MinuteVector, ShortVector, DoubleVector>(_minuteVector, _shortVector);
    }

    [Test]
    public void MinuteDivideIntReturnsCorrectTypes()
    {
        Divide<MinuteAtom, IntAtom, DoubleAtom>(_minuteAtom, _intAtom);
        Divide<MinuteAtom, IntVector, DoubleVector>(_minuteAtom, _intVector);
        Divide<MinuteVector, IntAtom, DoubleVector>(_minuteVector, _intAtom);
        Divide<MinuteVector, IntVector, DoubleVector>(_minuteVector, _intVector);
    }

    [Test]
    public void MinuteDivideLongReturnsCorrectTypes()
    {
        Divide<MinuteAtom, LongAtom, DoubleAtom>(_minuteAtom, _longAtom);
        Divide<MinuteAtom, LongVector, DoubleVector>(_minuteAtom, _longVector);
        Divide<MinuteVector, LongAtom, DoubleVector>(_minuteVector, _longAtom);
        Divide<MinuteVector, LongVector, DoubleVector>(_minuteVector, _longVector);
    }

    [Test]
    public void MinuteDivideFloatReturnsCorrectTypes()
    {
        Divide<MinuteAtom, FloatAtom, DoubleAtom>(_minuteAtom, _floatAtom);
        Divide<MinuteAtom, FloatVector, DoubleVector>(_minuteAtom, _floatVector);
        Divide<MinuteVector, FloatAtom, DoubleVector>(_minuteVector, _floatAtom);
        Divide<MinuteVector, FloatVector, DoubleVector>(_minuteVector, _floatVector);
    }

    [Test]
    public void MinuteDivideDoubleReturnsCorrectTypes()
    {
        Divide<MinuteAtom, DoubleAtom, DoubleAtom>(_minuteAtom, _doubleAtom);
        Divide<MinuteAtom, DoubleVector, DoubleVector>(_minuteAtom, _doubleVector);
        Divide<MinuteVector, DoubleAtom, DoubleVector>(_minuteVector, _doubleAtom);
        Divide<MinuteVector, DoubleVector, DoubleVector>(_minuteVector, _doubleVector);
    }

    [Test]
    public void MinuteDivideTimestampReturnsCorrectTypes()
    {
        Divide<MinuteAtom, TimestampAtom, DoubleAtom>(_minuteAtom, _timestampAtom);
        Divide<MinuteAtom, TimestampVector, DoubleVector>(_minuteAtom, _timestampVector);
        Divide<MinuteVector, TimestampAtom, DoubleVector>(_minuteVector, _timestampAtom);
        Divide<MinuteVector, TimestampVector, DoubleVector>(_minuteVector, _timestampVector);
    }

    [Test]
    public void MinuteDivideMonthReturnsCorrectTypes()
    {
        Divide<MinuteAtom, MonthAtom, DoubleAtom>(_minuteAtom, _monthAtom);
        Divide<MinuteAtom, MonthVector, DoubleVector>(_minuteAtom, _monthVector);
        Divide<MinuteVector, MonthAtom, DoubleVector>(_minuteVector, _monthAtom);
        Divide<MinuteVector, MonthVector, DoubleVector>(_minuteVector, _monthVector);
    }

    [Test]
    public void MinuteDivideDateReturnsCorrectTypes()
    {
        Divide<MinuteAtom, DateAtom, DoubleAtom>(_minuteAtom, _dateAtom);
        Divide<MinuteAtom, DateVector, DoubleVector>(_minuteAtom, _dateVector);
        Divide<MinuteVector, DateAtom, DoubleVector>(_minuteVector, _dateAtom);
        Divide<MinuteVector, DateVector, DoubleVector>(_minuteVector, _dateVector);
    }

    [Test]
    public void MinuteDivideTimespanReturnsCorrectTypes()
    {
        Divide<MinuteAtom, TimespanAtom, DoubleAtom>(_minuteAtom, _timespanAtom);
        Divide<MinuteAtom, TimespanVector, DoubleVector>(_minuteAtom, _timespanVector);
        Divide<MinuteVector, TimespanAtom, DoubleVector>(_minuteVector, _timespanAtom);
        Divide<MinuteVector, TimespanVector, DoubleVector>(_minuteVector, _timespanVector);
    }

    [Test]
    public void MinuteDivideMinuteReturnsCorrectTypes()
    {
        Divide<MinuteAtom, MinuteAtom, DoubleAtom>(_minuteAtom, _minuteAtom);
        Divide<MinuteAtom, MinuteVector, DoubleVector>(_minuteAtom, _minuteVector);
        Divide<MinuteVector, MinuteAtom, DoubleVector>(_minuteVector, _minuteAtom);
        Divide<MinuteVector, MinuteVector, DoubleVector>(_minuteVector, _minuteVector);
    }

    [Test]
    public void MinuteDivideSecondReturnsCorrectTypes()
    {
        Divide<MinuteAtom, SecondAtom, DoubleAtom>(_minuteAtom, _secondAtom);
        Divide<MinuteAtom, SecondVector, DoubleVector>(_minuteAtom, _secondVector);
        Divide<MinuteVector, SecondAtom, DoubleVector>(_minuteVector, _secondAtom);
        Divide<MinuteVector, SecondVector, DoubleVector>(_minuteVector, _secondVector);
    }

    [Test]
    public void SecondDivideByteReturnsCorrectTypes()
    {
        Divide<SecondAtom, ByteAtom, DoubleAtom>(_secondAtom, _byteAtom);
        Divide<SecondAtom, ByteVector, DoubleVector>(_secondAtom, _byteVector);
        Divide<SecondVector, ByteAtom, DoubleVector>(_secondVector, _byteAtom);
        Divide<SecondVector, ByteVector, DoubleVector>(_secondVector, _byteVector);
    }

    [Test]
    public void SecondDivideShortReturnsCorrectTypes()
    {
        Divide<SecondAtom, ShortAtom, DoubleAtom>(_secondAtom, _shortAtom);
        Divide<SecondAtom, ShortVector, DoubleVector>(_secondAtom, _shortVector);
        Divide<SecondVector, ShortAtom, DoubleVector>(_secondVector, _shortAtom);
        Divide<SecondVector, ShortVector, DoubleVector>(_secondVector, _shortVector);
    }

    [Test]
    public void SecondDivideIntReturnsCorrectTypes()
    {
        Divide<SecondAtom, IntAtom, DoubleAtom>(_secondAtom, _intAtom);
        Divide<SecondAtom, IntVector, DoubleVector>(_secondAtom, _intVector);
        Divide<SecondVector, IntAtom, DoubleVector>(_secondVector, _intAtom);
        Divide<SecondVector, IntVector, DoubleVector>(_secondVector, _intVector);
    }

    [Test]
    public void SecondDivideLongReturnsCorrectTypes()
    {
        Divide<SecondAtom, LongAtom, DoubleAtom>(_secondAtom, _longAtom);
        Divide<SecondAtom, LongVector, DoubleVector>(_secondAtom, _longVector);
        Divide<SecondVector, LongAtom, DoubleVector>(_secondVector, _longAtom);
        Divide<SecondVector, LongVector, DoubleVector>(_secondVector, _longVector);
    }

    [Test]
    public void SecondDivideFloatReturnsCorrectTypes()
    {
        Divide<SecondAtom, FloatAtom, DoubleAtom>(_secondAtom, _floatAtom);
        Divide<SecondAtom, FloatVector, DoubleVector>(_secondAtom, _floatVector);
        Divide<SecondVector, FloatAtom, DoubleVector>(_secondVector, _floatAtom);
        Divide<SecondVector, FloatVector, DoubleVector>(_secondVector, _floatVector);
    }

    [Test]
    public void SecondDivideDoubleReturnsCorrectTypes()
    {
        Divide<SecondAtom, DoubleAtom, DoubleAtom>(_secondAtom, _doubleAtom);
        Divide<SecondAtom, DoubleVector, DoubleVector>(_secondAtom, _doubleVector);
        Divide<SecondVector, DoubleAtom, DoubleVector>(_secondVector, _doubleAtom);
        Divide<SecondVector, DoubleVector, DoubleVector>(_secondVector, _doubleVector);
    }

    [Test]
    public void SecondDivideTimestampReturnsCorrectTypes()
    {
        Divide<SecondAtom, TimestampAtom, DoubleAtom>(_secondAtom, _timestampAtom);
        Divide<SecondAtom, TimestampVector, DoubleVector>(_secondAtom, _timestampVector);
        Divide<SecondVector, TimestampAtom, DoubleVector>(_secondVector, _timestampAtom);
        Divide<SecondVector, TimestampVector, DoubleVector>(_secondVector, _timestampVector);
    }

    [Test]
    public void SecondDivideMonthReturnsCorrectTypes()
    {
        Divide<SecondAtom, MonthAtom, DoubleAtom>(_secondAtom, _monthAtom);
        Divide<SecondAtom, MonthVector, DoubleVector>(_secondAtom, _monthVector);
        Divide<SecondVector, MonthAtom, DoubleVector>(_secondVector, _monthAtom);
        Divide<SecondVector, MonthVector, DoubleVector>(_secondVector, _monthVector);
    }

    [Test]
    public void SecondDivideDateReturnsCorrectTypes()
    {
        Divide<SecondAtom, DateAtom, DoubleAtom>(_secondAtom, _dateAtom);
        Divide<SecondAtom, DateVector, DoubleVector>(_secondAtom, _dateVector);
        Divide<SecondVector, DateAtom, DoubleVector>(_secondVector, _dateAtom);
        Divide<SecondVector, DateVector, DoubleVector>(_secondVector, _dateVector);
    }

    [Test]
    public void SecondDivideTimespanReturnsCorrectTypes()
    {
        Divide<SecondAtom, TimespanAtom, DoubleAtom>(_secondAtom, _timespanAtom);
        Divide<SecondAtom, TimespanVector, DoubleVector>(_secondAtom, _timespanVector);
        Divide<SecondVector, TimespanAtom, DoubleVector>(_secondVector, _timespanAtom);
        Divide<SecondVector, TimespanVector, DoubleVector>(_secondVector, _timespanVector);
    }

    [Test]
    public void SecondDivideMinuteReturnsCorrectTypes()
    {
        Divide<SecondAtom, MinuteAtom, DoubleAtom>(_secondAtom, _minuteAtom);
        Divide<SecondAtom, MinuteVector, DoubleVector>(_secondAtom, _minuteVector);
        Divide<SecondVector, MinuteAtom, DoubleVector>(_secondVector, _minuteAtom);
        Divide<SecondVector, MinuteVector, DoubleVector>(_secondVector, _minuteVector);
    }

    [Test]
    public void SecondDivideSecondReturnsCorrectTypes()
    {
        Divide<SecondAtom, SecondAtom, DoubleAtom>(_secondAtom, _secondAtom);
        Divide<SecondAtom, SecondVector, DoubleVector>(_secondAtom, _secondVector);
        Divide<SecondVector, SecondAtom, DoubleVector>(_secondVector, _secondAtom);
        Divide<SecondVector, SecondVector, DoubleVector>(_secondVector, _secondVector);
    }
}
