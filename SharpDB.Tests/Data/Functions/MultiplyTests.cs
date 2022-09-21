using System.Numerics;
using SharpDB.Data;

namespace SharpDB.Tests.Data.Functions;

public class MultiplyTests
{
    private static void Multiply<T1, T2, T3>(T1 left, T2 right)
        where T1 : IMultiplyOperators<T1, T2, T3>
        where T2 : IMultiplyOperators<T2, T1, T3>
    {
        var result1 = left * right;
        var result2 = right * left;
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
    public void ByteMultiplyByteReturnsCorrectTypes()
    {
        Multiply<ByteAtom, ByteAtom, IntAtom>(_byteAtom, _byteAtom);
        Multiply<ByteAtom, ByteVector, IntVector>(_byteAtom, _byteVector);
        Multiply<ByteVector, ByteAtom, IntVector>(_byteVector, _byteAtom);
        Multiply<ByteVector, ByteVector, IntVector>(_byteVector, _byteVector);
    }

    [Test]
    public void ByteMultiplyShortReturnsCorrectTypes()
    {
        Multiply<ByteAtom, ShortAtom, IntAtom>(_byteAtom, _shortAtom);
        Multiply<ByteAtom, ShortVector, IntVector>(_byteAtom, _shortVector);
        Multiply<ByteVector, ShortAtom, IntVector>(_byteVector, _shortAtom);
        Multiply<ByteVector, ShortVector, IntVector>(_byteVector, _shortVector);
    }

    [Test]
    public void ByteMultiplyIntReturnsCorrectTypes()
    {
        Multiply<ByteAtom, IntAtom, IntAtom>(_byteAtom, _intAtom);
        Multiply<ByteAtom, IntVector, IntVector>(_byteAtom, _intVector);
        Multiply<ByteVector, IntAtom, IntVector>(_byteVector, _intAtom);
        Multiply<ByteVector, IntVector, IntVector>(_byteVector, _intVector);
    }

    [Test]
    public void ByteMultiplyLongReturnsCorrectTypes()
    {
        Multiply<ByteAtom, LongAtom, LongAtom>(_byteAtom, _longAtom);
        Multiply<ByteAtom, LongVector, LongVector>(_byteAtom, _longVector);
        Multiply<ByteVector, LongAtom, LongVector>(_byteVector, _longAtom);
        Multiply<ByteVector, LongVector, LongVector>(_byteVector, _longVector);
    }

    [Test]
    public void ByteMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<ByteAtom, FloatAtom, FloatAtom>(_byteAtom, _floatAtom);
        Multiply<ByteAtom, FloatVector, FloatVector>(_byteAtom, _floatVector);
        Multiply<ByteVector, FloatAtom, FloatVector>(_byteVector, _floatAtom);
        Multiply<ByteVector, FloatVector, FloatVector>(_byteVector, _floatVector);
    }

    [Test]
    public void ByteMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<ByteAtom, DoubleAtom, DoubleAtom>(_byteAtom, _doubleAtom);
        Multiply<ByteAtom, DoubleVector, DoubleVector>(_byteAtom, _doubleVector);
        Multiply<ByteVector, DoubleAtom, DoubleVector>(_byteVector, _doubleAtom);
        Multiply<ByteVector, DoubleVector, DoubleVector>(_byteVector, _doubleVector);
    }

    [Test]
    public void ByteMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<ByteAtom, TimestampAtom, TimestampAtom>(_byteAtom, _timestampAtom);
        Multiply<ByteAtom, TimestampVector, TimestampVector>(_byteAtom, _timestampVector);
        Multiply<ByteVector, TimestampAtom, TimestampVector>(_byteVector, _timestampAtom);
        Multiply<ByteVector, TimestampVector, TimestampVector>(_byteVector, _timestampVector);
    }

    [Test]
    public void ByteMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<ByteAtom, MonthAtom, MonthAtom>(_byteAtom, _monthAtom);
        Multiply<ByteAtom, MonthVector, MonthVector>(_byteAtom, _monthVector);
        Multiply<ByteVector, MonthAtom, MonthVector>(_byteVector, _monthAtom);
        Multiply<ByteVector, MonthVector, MonthVector>(_byteVector, _monthVector);
    }

    [Test]
    public void ByteMultiplyDateReturnsCorrectTypes()
    {
        Multiply<ByteAtom, DateAtom, DateAtom>(_byteAtom, _dateAtom);
        Multiply<ByteAtom, DateVector, DateVector>(_byteAtom, _dateVector);
        Multiply<ByteVector, DateAtom, DateVector>(_byteVector, _dateAtom);
        Multiply<ByteVector, DateVector, DateVector>(_byteVector, _dateVector);
    }

    [Test]
    public void ByteMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<ByteAtom, TimespanAtom, TimespanAtom>(_byteAtom, _timespanAtom);
        Multiply<ByteAtom, TimespanVector, TimespanVector>(_byteAtom, _timespanVector);
        Multiply<ByteVector, TimespanAtom, TimespanVector>(_byteVector, _timespanAtom);
        Multiply<ByteVector, TimespanVector, TimespanVector>(_byteVector, _timespanVector);
    }

    [Test]
    public void ByteMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<ByteAtom, MinuteAtom, MinuteAtom>(_byteAtom, _minuteAtom);
        Multiply<ByteAtom, MinuteVector, MinuteVector>(_byteAtom, _minuteVector);
        Multiply<ByteVector, MinuteAtom, MinuteVector>(_byteVector, _minuteAtom);
        Multiply<ByteVector, MinuteVector, MinuteVector>(_byteVector, _minuteVector);
    }

    [Test]
    public void ByteMultiplySecondReturnsCorrectTypes()
    {
        Multiply<ByteAtom, SecondAtom, SecondAtom>(_byteAtom, _secondAtom);
        Multiply<ByteAtom, SecondVector, SecondVector>(_byteAtom, _secondVector);
        Multiply<ByteVector, SecondAtom, SecondVector>(_byteVector, _secondAtom);
        Multiply<ByteVector, SecondVector, SecondVector>(_byteVector, _secondVector);
    }

    [Test]
    public void ShortMultiplyByteReturnsCorrectTypes()
    {
        Multiply<ShortAtom, ByteAtom, IntAtom>(_shortAtom, _byteAtom);
        Multiply<ShortAtom, ByteVector, IntVector>(_shortAtom, _byteVector);
        Multiply<ShortVector, ByteAtom, IntVector>(_shortVector, _byteAtom);
        Multiply<ShortVector, ByteVector, IntVector>(_shortVector, _byteVector);
    }

    [Test]
    public void ShortMultiplyShortReturnsCorrectTypes()
    {
        Multiply<ShortAtom, ShortAtom, IntAtom>(_shortAtom, _shortAtom);
        Multiply<ShortAtom, ShortVector, IntVector>(_shortAtom, _shortVector);
        Multiply<ShortVector, ShortAtom, IntVector>(_shortVector, _shortAtom);
        Multiply<ShortVector, ShortVector, IntVector>(_shortVector, _shortVector);
    }

    [Test]
    public void ShortMultiplyIntReturnsCorrectTypes()
    {
        Multiply<ShortAtom, IntAtom, IntAtom>(_shortAtom, _intAtom);
        Multiply<ShortAtom, IntVector, IntVector>(_shortAtom, _intVector);
        Multiply<ShortVector, IntAtom, IntVector>(_shortVector, _intAtom);
        Multiply<ShortVector, IntVector, IntVector>(_shortVector, _intVector);
    }

    [Test]
    public void ShortMultiplyLongReturnsCorrectTypes()
    {
        Multiply<ShortAtom, LongAtom, LongAtom>(_shortAtom, _longAtom);
        Multiply<ShortAtom, LongVector, LongVector>(_shortAtom, _longVector);
        Multiply<ShortVector, LongAtom, LongVector>(_shortVector, _longAtom);
        Multiply<ShortVector, LongVector, LongVector>(_shortVector, _longVector);
    }

    [Test]
    public void ShortMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<ShortAtom, FloatAtom, FloatAtom>(_shortAtom, _floatAtom);
        Multiply<ShortAtom, FloatVector, FloatVector>(_shortAtom, _floatVector);
        Multiply<ShortVector, FloatAtom, FloatVector>(_shortVector, _floatAtom);
        Multiply<ShortVector, FloatVector, FloatVector>(_shortVector, _floatVector);
    }

    [Test]
    public void ShortMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<ShortAtom, DoubleAtom, DoubleAtom>(_shortAtom, _doubleAtom);
        Multiply<ShortAtom, DoubleVector, DoubleVector>(_shortAtom, _doubleVector);
        Multiply<ShortVector, DoubleAtom, DoubleVector>(_shortVector, _doubleAtom);
        Multiply<ShortVector, DoubleVector, DoubleVector>(_shortVector, _doubleVector);
    }

    [Test]
    public void ShortMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<ShortAtom, TimestampAtom, TimestampAtom>(_shortAtom, _timestampAtom);
        Multiply<ShortAtom, TimestampVector, TimestampVector>(_shortAtom, _timestampVector);
        Multiply<ShortVector, TimestampAtom, TimestampVector>(_shortVector, _timestampAtom);
        Multiply<ShortVector, TimestampVector, TimestampVector>(_shortVector, _timestampVector);
    }

    [Test]
    public void ShortMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<ShortAtom, MonthAtom, MonthAtom>(_shortAtom, _monthAtom);
        Multiply<ShortAtom, MonthVector, MonthVector>(_shortAtom, _monthVector);
        Multiply<ShortVector, MonthAtom, MonthVector>(_shortVector, _monthAtom);
        Multiply<ShortVector, MonthVector, MonthVector>(_shortVector, _monthVector);
    }

    [Test]
    public void ShortMultiplyDateReturnsCorrectTypes()
    {
        Multiply<ShortAtom, DateAtom, DateAtom>(_shortAtom, _dateAtom);
        Multiply<ShortAtom, DateVector, DateVector>(_shortAtom, _dateVector);
        Multiply<ShortVector, DateAtom, DateVector>(_shortVector, _dateAtom);
        Multiply<ShortVector, DateVector, DateVector>(_shortVector, _dateVector);
    }

    [Test]
    public void ShortMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<ShortAtom, TimespanAtom, TimespanAtom>(_shortAtom, _timespanAtom);
        Multiply<ShortAtom, TimespanVector, TimespanVector>(_shortAtom, _timespanVector);
        Multiply<ShortVector, TimespanAtom, TimespanVector>(_shortVector, _timespanAtom);
        Multiply<ShortVector, TimespanVector, TimespanVector>(_shortVector, _timespanVector);
    }

    [Test]
    public void ShortMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<ShortAtom, MinuteAtom, MinuteAtom>(_shortAtom, _minuteAtom);
        Multiply<ShortAtom, MinuteVector, MinuteVector>(_shortAtom, _minuteVector);
        Multiply<ShortVector, MinuteAtom, MinuteVector>(_shortVector, _minuteAtom);
        Multiply<ShortVector, MinuteVector, MinuteVector>(_shortVector, _minuteVector);
    }

    [Test]
    public void ShortMultiplySecondReturnsCorrectTypes()
    {
        Multiply<ShortAtom, SecondAtom, SecondAtom>(_shortAtom, _secondAtom);
        Multiply<ShortAtom, SecondVector, SecondVector>(_shortAtom, _secondVector);
        Multiply<ShortVector, SecondAtom, SecondVector>(_shortVector, _secondAtom);
        Multiply<ShortVector, SecondVector, SecondVector>(_shortVector, _secondVector);
    }

    [Test]
    public void IntMultiplyByteReturnsCorrectTypes()
    {
        Multiply<IntAtom, ByteAtom, IntAtom>(_intAtom, _byteAtom);
        Multiply<IntAtom, ByteVector, IntVector>(_intAtom, _byteVector);
        Multiply<IntVector, ByteAtom, IntVector>(_intVector, _byteAtom);
        Multiply<IntVector, ByteVector, IntVector>(_intVector, _byteVector);
    }

    [Test]
    public void IntMultiplyShortReturnsCorrectTypes()
    {
        Multiply<IntAtom, ShortAtom, IntAtom>(_intAtom, _shortAtom);
        Multiply<IntAtom, ShortVector, IntVector>(_intAtom, _shortVector);
        Multiply<IntVector, ShortAtom, IntVector>(_intVector, _shortAtom);
        Multiply<IntVector, ShortVector, IntVector>(_intVector, _shortVector);
    }

    [Test]
    public void IntMultiplyIntReturnsCorrectTypes()
    {
        Multiply<IntAtom, IntAtom, IntAtom>(_intAtom, _intAtom);
        Multiply<IntAtom, IntVector, IntVector>(_intAtom, _intVector);
        Multiply<IntVector, IntAtom, IntVector>(_intVector, _intAtom);
        Multiply<IntVector, IntVector, IntVector>(_intVector, _intVector);
    }

    [Test]
    public void IntMultiplyLongReturnsCorrectTypes()
    {
        Multiply<IntAtom, LongAtom, LongAtom>(_intAtom, _longAtom);
        Multiply<IntAtom, LongVector, LongVector>(_intAtom, _longVector);
        Multiply<IntVector, LongAtom, LongVector>(_intVector, _longAtom);
        Multiply<IntVector, LongVector, LongVector>(_intVector, _longVector);
    }

    [Test]
    public void IntMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<IntAtom, FloatAtom, FloatAtom>(_intAtom, _floatAtom);
        Multiply<IntAtom, FloatVector, FloatVector>(_intAtom, _floatVector);
        Multiply<IntVector, FloatAtom, FloatVector>(_intVector, _floatAtom);
        Multiply<IntVector, FloatVector, FloatVector>(_intVector, _floatVector);
    }

    [Test]
    public void IntMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<IntAtom, DoubleAtom, DoubleAtom>(_intAtom, _doubleAtom);
        Multiply<IntAtom, DoubleVector, DoubleVector>(_intAtom, _doubleVector);
        Multiply<IntVector, DoubleAtom, DoubleVector>(_intVector, _doubleAtom);
        Multiply<IntVector, DoubleVector, DoubleVector>(_intVector, _doubleVector);
    }

    [Test]
    public void IntMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<IntAtom, TimestampAtom, TimestampAtom>(_intAtom, _timestampAtom);
        Multiply<IntAtom, TimestampVector, TimestampVector>(_intAtom, _timestampVector);
        Multiply<IntVector, TimestampAtom, TimestampVector>(_intVector, _timestampAtom);
        Multiply<IntVector, TimestampVector, TimestampVector>(_intVector, _timestampVector);
    }

    [Test]
    public void IntMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<IntAtom, MonthAtom, MonthAtom>(_intAtom, _monthAtom);
        Multiply<IntAtom, MonthVector, MonthVector>(_intAtom, _monthVector);
        Multiply<IntVector, MonthAtom, MonthVector>(_intVector, _monthAtom);
        Multiply<IntVector, MonthVector, MonthVector>(_intVector, _monthVector);
    }

    [Test]
    public void IntMultiplyDateReturnsCorrectTypes()
    {
        Multiply<IntAtom, DateAtom, DateAtom>(_intAtom, _dateAtom);
        Multiply<IntAtom, DateVector, DateVector>(_intAtom, _dateVector);
        Multiply<IntVector, DateAtom, DateVector>(_intVector, _dateAtom);
        Multiply<IntVector, DateVector, DateVector>(_intVector, _dateVector);
    }

    [Test]
    public void IntMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<IntAtom, TimespanAtom, TimespanAtom>(_intAtom, _timespanAtom);
        Multiply<IntAtom, TimespanVector, TimespanVector>(_intAtom, _timespanVector);
        Multiply<IntVector, TimespanAtom, TimespanVector>(_intVector, _timespanAtom);
        Multiply<IntVector, TimespanVector, TimespanVector>(_intVector, _timespanVector);
    }

    [Test]
    public void IntMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<IntAtom, MinuteAtom, MinuteAtom>(_intAtom, _minuteAtom);
        Multiply<IntAtom, MinuteVector, MinuteVector>(_intAtom, _minuteVector);
        Multiply<IntVector, MinuteAtom, MinuteVector>(_intVector, _minuteAtom);
        Multiply<IntVector, MinuteVector, MinuteVector>(_intVector, _minuteVector);
    }

    [Test]
    public void IntMultiplySecondReturnsCorrectTypes()
    {
        Multiply<IntAtom, SecondAtom, SecondAtom>(_intAtom, _secondAtom);
        Multiply<IntAtom, SecondVector, SecondVector>(_intAtom, _secondVector);
        Multiply<IntVector, SecondAtom, SecondVector>(_intVector, _secondAtom);
        Multiply<IntVector, SecondVector, SecondVector>(_intVector, _secondVector);
    }

    [Test]
    public void LongMultiplyByteReturnsCorrectTypes()
    {
        Multiply<LongAtom, ByteAtom, LongAtom>(_longAtom, _byteAtom);
        Multiply<LongAtom, ByteVector, LongVector>(_longAtom, _byteVector);
        Multiply<LongVector, ByteAtom, LongVector>(_longVector, _byteAtom);
        Multiply<LongVector, ByteVector, LongVector>(_longVector, _byteVector);
    }

    [Test]
    public void LongMultiplyShortReturnsCorrectTypes()
    {
        Multiply<LongAtom, ShortAtom, LongAtom>(_longAtom, _shortAtom);
        Multiply<LongAtom, ShortVector, LongVector>(_longAtom, _shortVector);
        Multiply<LongVector, ShortAtom, LongVector>(_longVector, _shortAtom);
        Multiply<LongVector, ShortVector, LongVector>(_longVector, _shortVector);
    }

    [Test]
    public void LongMultiplyIntReturnsCorrectTypes()
    {
        Multiply<LongAtom, IntAtom, LongAtom>(_longAtom, _intAtom);
        Multiply<LongAtom, IntVector, LongVector>(_longAtom, _intVector);
        Multiply<LongVector, IntAtom, LongVector>(_longVector, _intAtom);
        Multiply<LongVector, IntVector, LongVector>(_longVector, _intVector);
    }

    [Test]
    public void LongMultiplyLongReturnsCorrectTypes()
    {
        Multiply<LongAtom, LongAtom, LongAtom>(_longAtom, _longAtom);
        Multiply<LongAtom, LongVector, LongVector>(_longAtom, _longVector);
        Multiply<LongVector, LongAtom, LongVector>(_longVector, _longAtom);
        Multiply<LongVector, LongVector, LongVector>(_longVector, _longVector);
    }

    [Test]
    public void LongMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<LongAtom, FloatAtom, FloatAtom>(_longAtom, _floatAtom);
        Multiply<LongAtom, FloatVector, FloatVector>(_longAtom, _floatVector);
        Multiply<LongVector, FloatAtom, FloatVector>(_longVector, _floatAtom);
        Multiply<LongVector, FloatVector, FloatVector>(_longVector, _floatVector);
    }

    [Test]
    public void LongMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<LongAtom, DoubleAtom, DoubleAtom>(_longAtom, _doubleAtom);
        Multiply<LongAtom, DoubleVector, DoubleVector>(_longAtom, _doubleVector);
        Multiply<LongVector, DoubleAtom, DoubleVector>(_longVector, _doubleAtom);
        Multiply<LongVector, DoubleVector, DoubleVector>(_longVector, _doubleVector);
    }

    [Test]
    public void LongMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<LongAtom, TimestampAtom, TimestampAtom>(_longAtom, _timestampAtom);
        Multiply<LongAtom, TimestampVector, TimestampVector>(_longAtom, _timestampVector);
        Multiply<LongVector, TimestampAtom, TimestampVector>(_longVector, _timestampAtom);
        Multiply<LongVector, TimestampVector, TimestampVector>(_longVector, _timestampVector);
    }

    [Test]
    public void LongMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<LongAtom, MonthAtom, MonthAtom>(_longAtom, _monthAtom);
        Multiply<LongAtom, MonthVector, MonthVector>(_longAtom, _monthVector);
        Multiply<LongVector, MonthAtom, MonthVector>(_longVector, _monthAtom);
        Multiply<LongVector, MonthVector, MonthVector>(_longVector, _monthVector);
    }

    [Test]
    public void LongMultiplyDateReturnsCorrectTypes()
    {
        Multiply<LongAtom, DateAtom, DateAtom>(_longAtom, _dateAtom);
        Multiply<LongAtom, DateVector, DateVector>(_longAtom, _dateVector);
        Multiply<LongVector, DateAtom, DateVector>(_longVector, _dateAtom);
        Multiply<LongVector, DateVector, DateVector>(_longVector, _dateVector);
    }

    [Test]
    public void LongMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<LongAtom, TimespanAtom, TimespanAtom>(_longAtom, _timespanAtom);
        Multiply<LongAtom, TimespanVector, TimespanVector>(_longAtom, _timespanVector);
        Multiply<LongVector, TimespanAtom, TimespanVector>(_longVector, _timespanAtom);
        Multiply<LongVector, TimespanVector, TimespanVector>(_longVector, _timespanVector);
    }

    [Test]
    public void LongMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<LongAtom, MinuteAtom, MinuteAtom>(_longAtom, _minuteAtom);
        Multiply<LongAtom, MinuteVector, MinuteVector>(_longAtom, _minuteVector);
        Multiply<LongVector, MinuteAtom, MinuteVector>(_longVector, _minuteAtom);
        Multiply<LongVector, MinuteVector, MinuteVector>(_longVector, _minuteVector);
    }

    [Test]
    public void LongMultiplySecondReturnsCorrectTypes()
    {
        Multiply<LongAtom, SecondAtom, SecondAtom>(_longAtom, _secondAtom);
        Multiply<LongAtom, SecondVector, SecondVector>(_longAtom, _secondVector);
        Multiply<LongVector, SecondAtom, SecondVector>(_longVector, _secondAtom);
        Multiply<LongVector, SecondVector, SecondVector>(_longVector, _secondVector);
    }

    [Test]
    public void FloatMultiplyByteReturnsCorrectTypes()
    {
        Multiply<FloatAtom, ByteAtom, FloatAtom>(_floatAtom, _byteAtom);
        Multiply<FloatAtom, ByteVector, FloatVector>(_floatAtom, _byteVector);
        Multiply<FloatVector, ByteAtom, FloatVector>(_floatVector, _byteAtom);
        Multiply<FloatVector, ByteVector, FloatVector>(_floatVector, _byteVector);
    }

    [Test]
    public void FloatMultiplyShortReturnsCorrectTypes()
    {
        Multiply<FloatAtom, ShortAtom, FloatAtom>(_floatAtom, _shortAtom);
        Multiply<FloatAtom, ShortVector, FloatVector>(_floatAtom, _shortVector);
        Multiply<FloatVector, ShortAtom, FloatVector>(_floatVector, _shortAtom);
        Multiply<FloatVector, ShortVector, FloatVector>(_floatVector, _shortVector);
    }

    [Test]
    public void FloatMultiplyIntReturnsCorrectTypes()
    {
        Multiply<FloatAtom, IntAtom, FloatAtom>(_floatAtom, _intAtom);
        Multiply<FloatAtom, IntVector, FloatVector>(_floatAtom, _intVector);
        Multiply<FloatVector, IntAtom, FloatVector>(_floatVector, _intAtom);
        Multiply<FloatVector, IntVector, FloatVector>(_floatVector, _intVector);
    }

    [Test]
    public void FloatMultiplyLongReturnsCorrectTypes()
    {
        Multiply<FloatAtom, LongAtom, FloatAtom>(_floatAtom, _longAtom);
        Multiply<FloatAtom, LongVector, FloatVector>(_floatAtom, _longVector);
        Multiply<FloatVector, LongAtom, FloatVector>(_floatVector, _longAtom);
        Multiply<FloatVector, LongVector, FloatVector>(_floatVector, _longVector);
    }

    [Test]
    public void FloatMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<FloatAtom, FloatAtom, FloatAtom>(_floatAtom, _floatAtom);
        Multiply<FloatAtom, FloatVector, FloatVector>(_floatAtom, _floatVector);
        Multiply<FloatVector, FloatAtom, FloatVector>(_floatVector, _floatAtom);
        Multiply<FloatVector, FloatVector, FloatVector>(_floatVector, _floatVector);
    }

    [Test]
    public void FloatMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<FloatAtom, DoubleAtom, DoubleAtom>(_floatAtom, _doubleAtom);
        Multiply<FloatAtom, DoubleVector, DoubleVector>(_floatAtom, _doubleVector);
        Multiply<FloatVector, DoubleAtom, DoubleVector>(_floatVector, _doubleAtom);
        Multiply<FloatVector, DoubleVector, DoubleVector>(_floatVector, _doubleVector);
    }

    [Test]
    public void FloatMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<FloatAtom, TimestampAtom, TimestampAtom>(_floatAtom, _timestampAtom);
        Multiply<FloatAtom, TimestampVector, TimestampVector>(_floatAtom, _timestampVector);
        Multiply<FloatVector, TimestampAtom, TimestampVector>(_floatVector, _timestampAtom);
        Multiply<FloatVector, TimestampVector, TimestampVector>(_floatVector, _timestampVector);
    }

    [Test]
    public void FloatMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<FloatAtom, MonthAtom, MonthAtom>(_floatAtom, _monthAtom);
        Multiply<FloatAtom, MonthVector, MonthVector>(_floatAtom, _monthVector);
        Multiply<FloatVector, MonthAtom, MonthVector>(_floatVector, _monthAtom);
        Multiply<FloatVector, MonthVector, MonthVector>(_floatVector, _monthVector);
    }

    [Test]
    public void FloatMultiplyDateReturnsCorrectTypes()
    {
        Multiply<FloatAtom, DateAtom, DateAtom>(_floatAtom, _dateAtom);
        Multiply<FloatAtom, DateVector, DateVector>(_floatAtom, _dateVector);
        Multiply<FloatVector, DateAtom, DateVector>(_floatVector, _dateAtom);
        Multiply<FloatVector, DateVector, DateVector>(_floatVector, _dateVector);
    }

    [Test]
    public void FloatMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<FloatAtom, TimespanAtom, TimespanAtom>(_floatAtom, _timespanAtom);
        Multiply<FloatAtom, TimespanVector, TimespanVector>(_floatAtom, _timespanVector);
        Multiply<FloatVector, TimespanAtom, TimespanVector>(_floatVector, _timespanAtom);
        Multiply<FloatVector, TimespanVector, TimespanVector>(_floatVector, _timespanVector);
    }

    [Test]
    public void FloatMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<FloatAtom, MinuteAtom, MinuteAtom>(_floatAtom, _minuteAtom);
        Multiply<FloatAtom, MinuteVector, MinuteVector>(_floatAtom, _minuteVector);
        Multiply<FloatVector, MinuteAtom, MinuteVector>(_floatVector, _minuteAtom);
        Multiply<FloatVector, MinuteVector, MinuteVector>(_floatVector, _minuteVector);
    }

    [Test]
    public void FloatMultiplySecondReturnsCorrectTypes()
    {
        Multiply<FloatAtom, SecondAtom, SecondAtom>(_floatAtom, _secondAtom);
        Multiply<FloatAtom, SecondVector, SecondVector>(_floatAtom, _secondVector);
        Multiply<FloatVector, SecondAtom, SecondVector>(_floatVector, _secondAtom);
        Multiply<FloatVector, SecondVector, SecondVector>(_floatVector, _secondVector);
    }

    [Test]
    public void DoubleMultiplyByteReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, ByteAtom, DoubleAtom>(_doubleAtom, _byteAtom);
        Multiply<DoubleAtom, ByteVector, DoubleVector>(_doubleAtom, _byteVector);
        Multiply<DoubleVector, ByteAtom, DoubleVector>(_doubleVector, _byteAtom);
        Multiply<DoubleVector, ByteVector, DoubleVector>(_doubleVector, _byteVector);
    }

    [Test]
    public void DoubleMultiplyShortReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, ShortAtom, DoubleAtom>(_doubleAtom, _shortAtom);
        Multiply<DoubleAtom, ShortVector, DoubleVector>(_doubleAtom, _shortVector);
        Multiply<DoubleVector, ShortAtom, DoubleVector>(_doubleVector, _shortAtom);
        Multiply<DoubleVector, ShortVector, DoubleVector>(_doubleVector, _shortVector);
    }

    [Test]
    public void DoubleMultiplyIntReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, IntAtom, DoubleAtom>(_doubleAtom, _intAtom);
        Multiply<DoubleAtom, IntVector, DoubleVector>(_doubleAtom, _intVector);
        Multiply<DoubleVector, IntAtom, DoubleVector>(_doubleVector, _intAtom);
        Multiply<DoubleVector, IntVector, DoubleVector>(_doubleVector, _intVector);
    }

    [Test]
    public void DoubleMultiplyLongReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, LongAtom, DoubleAtom>(_doubleAtom, _longAtom);
        Multiply<DoubleAtom, LongVector, DoubleVector>(_doubleAtom, _longVector);
        Multiply<DoubleVector, LongAtom, DoubleVector>(_doubleVector, _longAtom);
        Multiply<DoubleVector, LongVector, DoubleVector>(_doubleVector, _longVector);
    }

    [Test]
    public void DoubleMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, FloatAtom, DoubleAtom>(_doubleAtom, _floatAtom);
        Multiply<DoubleAtom, FloatVector, DoubleVector>(_doubleAtom, _floatVector);
        Multiply<DoubleVector, FloatAtom, DoubleVector>(_doubleVector, _floatAtom);
        Multiply<DoubleVector, FloatVector, DoubleVector>(_doubleVector, _floatVector);
    }

    [Test]
    public void DoubleMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, DoubleAtom, DoubleAtom>(_doubleAtom, _doubleAtom);
        Multiply<DoubleAtom, DoubleVector, DoubleVector>(_doubleAtom, _doubleVector);
        Multiply<DoubleVector, DoubleAtom, DoubleVector>(_doubleVector, _doubleAtom);
        Multiply<DoubleVector, DoubleVector, DoubleVector>(_doubleVector, _doubleVector);
    }

    [Test]
    public void DoubleMultiplyTimestampReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, TimestampAtom, DoubleAtom>(_doubleAtom, _timestampAtom);
        Multiply<DoubleAtom, TimestampVector, DoubleVector>(_doubleAtom, _timestampVector);
        Multiply<DoubleVector, TimestampAtom, DoubleVector>(_doubleVector, _timestampAtom);
        Multiply<DoubleVector, TimestampVector, DoubleVector>(_doubleVector, _timestampVector);
    }

    [Test]
    public void DoubleMultiplyMonthReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, MonthAtom, DoubleAtom>(_doubleAtom, _monthAtom);
        Multiply<DoubleAtom, MonthVector, DoubleVector>(_doubleAtom, _monthVector);
        Multiply<DoubleVector, MonthAtom, DoubleVector>(_doubleVector, _monthAtom);
        Multiply<DoubleVector, MonthVector, DoubleVector>(_doubleVector, _monthVector);
    }

    [Test]
    public void DoubleMultiplyTimespanReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, TimespanAtom, DoubleAtom>(_doubleAtom, _timespanAtom);
        Multiply<DoubleAtom, TimespanVector, DoubleVector>(_doubleAtom, _timespanVector);
        Multiply<DoubleVector, TimespanAtom, DoubleVector>(_doubleVector, _timespanAtom);
        Multiply<DoubleVector, TimespanVector, DoubleVector>(_doubleVector, _timespanVector);
    }

    [Test]
    public void DoubleMultiplyMinuteReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, MinuteAtom, DoubleAtom>(_doubleAtom, _minuteAtom);
        Multiply<DoubleAtom, MinuteVector, DoubleVector>(_doubleAtom, _minuteVector);
        Multiply<DoubleVector, MinuteAtom, DoubleVector>(_doubleVector, _minuteAtom);
        Multiply<DoubleVector, MinuteVector, DoubleVector>(_doubleVector, _minuteVector);
    }

    [Test]
    public void DoubleMultiplySecondReturnsCorrectTypes()
    {
        Multiply<DoubleAtom, SecondAtom, DoubleAtom>(_doubleAtom, _secondAtom);
        Multiply<DoubleAtom, SecondVector, DoubleVector>(_doubleAtom, _secondVector);
        Multiply<DoubleVector, SecondAtom, DoubleVector>(_doubleVector, _secondAtom);
        Multiply<DoubleVector, SecondVector, DoubleVector>(_doubleVector, _secondVector);
    }

    [Test]
    public void TimestampMultiplyByteReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, ByteAtom, TimestampAtom>(_timestampAtom, _byteAtom);
        Multiply<TimestampAtom, ByteVector, TimestampVector>(_timestampAtom, _byteVector);
        Multiply<TimestampVector, ByteAtom, TimestampVector>(_timestampVector, _byteAtom);
        Multiply<TimestampVector, ByteVector, TimestampVector>(_timestampVector, _byteVector);
    }

    [Test]
    public void TimestampMultiplyShortReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, ShortAtom, TimestampAtom>(_timestampAtom, _shortAtom);
        Multiply<TimestampAtom, ShortVector, TimestampVector>(_timestampAtom, _shortVector);
        Multiply<TimestampVector, ShortAtom, TimestampVector>(_timestampVector, _shortAtom);
        Multiply<TimestampVector, ShortVector, TimestampVector>(_timestampVector, _shortVector);
    }

    [Test]
    public void TimestampMultiplyIntReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, IntAtom, TimestampAtom>(_timestampAtom, _intAtom);
        Multiply<TimestampAtom, IntVector, TimestampVector>(_timestampAtom, _intVector);
        Multiply<TimestampVector, IntAtom, TimestampVector>(_timestampVector, _intAtom);
        Multiply<TimestampVector, IntVector, TimestampVector>(_timestampVector, _intVector);
    }

    [Test]
    public void TimestampMultiplyLongReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, LongAtom, TimestampAtom>(_timestampAtom, _longAtom);
        Multiply<TimestampAtom, LongVector, TimestampVector>(_timestampAtom, _longVector);
        Multiply<TimestampVector, LongAtom, TimestampVector>(_timestampVector, _longAtom);
        Multiply<TimestampVector, LongVector, TimestampVector>(_timestampVector, _longVector);
    }

    [Test]
    public void TimestampMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, FloatAtom, TimestampAtom>(_timestampAtom, _floatAtom);
        Multiply<TimestampAtom, FloatVector, TimestampVector>(_timestampAtom, _floatVector);
        Multiply<TimestampVector, FloatAtom, TimestampVector>(_timestampVector, _floatAtom);
        Multiply<TimestampVector, FloatVector, TimestampVector>(_timestampVector, _floatVector);
    }

    [Test]
    public void TimestampMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<TimestampAtom, DoubleAtom, DoubleAtom>(_timestampAtom, _doubleAtom);
        Multiply<TimestampAtom, DoubleVector, DoubleVector>(_timestampAtom, _doubleVector);
        Multiply<TimestampVector, DoubleAtom, DoubleVector>(_timestampVector, _doubleAtom);
        Multiply<TimestampVector, DoubleVector, DoubleVector>(_timestampVector, _doubleVector);
    }

    [Test]
    public void MonthMultiplyByteReturnsCorrectTypes()
    {
        Multiply<MonthAtom, ByteAtom, MonthAtom>(_monthAtom, _byteAtom);
        Multiply<MonthAtom, ByteVector, MonthVector>(_monthAtom, _byteVector);
        Multiply<MonthVector, ByteAtom, MonthVector>(_monthVector, _byteAtom);
        Multiply<MonthVector, ByteVector, MonthVector>(_monthVector, _byteVector);
    }

    [Test]
    public void MonthMultiplyShortReturnsCorrectTypes()
    {
        Multiply<MonthAtom, ShortAtom, MonthAtom>(_monthAtom, _shortAtom);
        Multiply<MonthAtom, ShortVector, MonthVector>(_monthAtom, _shortVector);
        Multiply<MonthVector, ShortAtom, MonthVector>(_monthVector, _shortAtom);
        Multiply<MonthVector, ShortVector, MonthVector>(_monthVector, _shortVector);
    }

    [Test]
    public void MonthMultiplyIntReturnsCorrectTypes()
    {
        Multiply<MonthAtom, IntAtom, MonthAtom>(_monthAtom, _intAtom);
        Multiply<MonthAtom, IntVector, MonthVector>(_monthAtom, _intVector);
        Multiply<MonthVector, IntAtom, MonthVector>(_monthVector, _intAtom);
        Multiply<MonthVector, IntVector, MonthVector>(_monthVector, _intVector);
    }

    [Test]
    public void MonthMultiplyLongReturnsCorrectTypes()
    {
        Multiply<MonthAtom, LongAtom, MonthAtom>(_monthAtom, _longAtom);
        Multiply<MonthAtom, LongVector, MonthVector>(_monthAtom, _longVector);
        Multiply<MonthVector, LongAtom, MonthVector>(_monthVector, _longAtom);
        Multiply<MonthVector, LongVector, MonthVector>(_monthVector, _longVector);
    }

    [Test]
    public void MonthMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<MonthAtom, FloatAtom, MonthAtom>(_monthAtom, _floatAtom);
        Multiply<MonthAtom, FloatVector, MonthVector>(_monthAtom, _floatVector);
        Multiply<MonthVector, FloatAtom, MonthVector>(_monthVector, _floatAtom);
        Multiply<MonthVector, FloatVector, MonthVector>(_monthVector, _floatVector);
    }

    [Test]
    public void MonthMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<MonthAtom, DoubleAtom, DoubleAtom>(_monthAtom, _doubleAtom);
        Multiply<MonthAtom, DoubleVector, DoubleVector>(_monthAtom, _doubleVector);
        Multiply<MonthVector, DoubleAtom, DoubleVector>(_monthVector, _doubleAtom);
        Multiply<MonthVector, DoubleVector, DoubleVector>(_monthVector, _doubleVector);
    }

    [Test]
    public void DateMultiplyByteReturnsCorrectTypes()
    {
        Multiply<DateAtom, ByteAtom, DateAtom>(_dateAtom, _byteAtom);
        Multiply<DateAtom, ByteVector, DateVector>(_dateAtom, _byteVector);
        Multiply<DateVector, ByteAtom, DateVector>(_dateVector, _byteAtom);
        Multiply<DateVector, ByteVector, DateVector>(_dateVector, _byteVector);
    }

    [Test]
    public void DateMultiplyShortReturnsCorrectTypes()
    {
        Multiply<DateAtom, ShortAtom, DateAtom>(_dateAtom, _shortAtom);
        Multiply<DateAtom, ShortVector, DateVector>(_dateAtom, _shortVector);
        Multiply<DateVector, ShortAtom, DateVector>(_dateVector, _shortAtom);
        Multiply<DateVector, ShortVector, DateVector>(_dateVector, _shortVector);
    }

    [Test]
    public void DateMultiplyIntReturnsCorrectTypes()
    {
        Multiply<DateAtom, IntAtom, DateAtom>(_dateAtom, _intAtom);
        Multiply<DateAtom, IntVector, DateVector>(_dateAtom, _intVector);
        Multiply<DateVector, IntAtom, DateVector>(_dateVector, _intAtom);
        Multiply<DateVector, IntVector, DateVector>(_dateVector, _intVector);
    }

    [Test]
    public void DateMultiplyLongReturnsCorrectTypes()
    {
        Multiply<DateAtom, LongAtom, DateAtom>(_dateAtom, _longAtom);
        Multiply<DateAtom, LongVector, DateVector>(_dateAtom, _longVector);
        Multiply<DateVector, LongAtom, DateVector>(_dateVector, _longAtom);
        Multiply<DateVector, LongVector, DateVector>(_dateVector, _longVector);
    }

    [Test]
    public void DateMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<DateAtom, FloatAtom, DateAtom>(_dateAtom, _floatAtom);
        Multiply<DateAtom, FloatVector, DateVector>(_dateAtom, _floatVector);
        Multiply<DateVector, FloatAtom, DateVector>(_dateVector, _floatAtom);
        Multiply<DateVector, FloatVector, DateVector>(_dateVector, _floatVector);
    }

    [Test]
    public void TimespanMultiplyByteReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, ByteAtom, TimespanAtom>(_timespanAtom, _byteAtom);
        Multiply<TimespanAtom, ByteVector, TimespanVector>(_timespanAtom, _byteVector);
        Multiply<TimespanVector, ByteAtom, TimespanVector>(_timespanVector, _byteAtom);
        Multiply<TimespanVector, ByteVector, TimespanVector>(_timespanVector, _byteVector);
    }

    [Test]
    public void TimespanMultiplyShortReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, ShortAtom, TimespanAtom>(_timespanAtom, _shortAtom);
        Multiply<TimespanAtom, ShortVector, TimespanVector>(_timespanAtom, _shortVector);
        Multiply<TimespanVector, ShortAtom, TimespanVector>(_timespanVector, _shortAtom);
        Multiply<TimespanVector, ShortVector, TimespanVector>(_timespanVector, _shortVector);
    }

    [Test]
    public void TimespanMultiplyIntReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, IntAtom, TimespanAtom>(_timespanAtom, _intAtom);
        Multiply<TimespanAtom, IntVector, TimespanVector>(_timespanAtom, _intVector);
        Multiply<TimespanVector, IntAtom, TimespanVector>(_timespanVector, _intAtom);
        Multiply<TimespanVector, IntVector, TimespanVector>(_timespanVector, _intVector);
    }

    [Test]
    public void TimespanMultiplyLongReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, LongAtom, TimespanAtom>(_timespanAtom, _longAtom);
        Multiply<TimespanAtom, LongVector, TimespanVector>(_timespanAtom, _longVector);
        Multiply<TimespanVector, LongAtom, TimespanVector>(_timespanVector, _longAtom);
        Multiply<TimespanVector, LongVector, TimespanVector>(_timespanVector, _longVector);
    }

    [Test]
    public void TimespanMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, FloatAtom, TimespanAtom>(_timespanAtom, _floatAtom);
        Multiply<TimespanAtom, FloatVector, TimespanVector>(_timespanAtom, _floatVector);
        Multiply<TimespanVector, FloatAtom, TimespanVector>(_timespanVector, _floatAtom);
        Multiply<TimespanVector, FloatVector, TimespanVector>(_timespanVector, _floatVector);
    }

    [Test]
    public void TimespanMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<TimespanAtom, DoubleAtom, DoubleAtom>(_timespanAtom, _doubleAtom);
        Multiply<TimespanAtom, DoubleVector, DoubleVector>(_timespanAtom, _doubleVector);
        Multiply<TimespanVector, DoubleAtom, DoubleVector>(_timespanVector, _doubleAtom);
        Multiply<TimespanVector, DoubleVector, DoubleVector>(_timespanVector, _doubleVector);
    }

    [Test]
    public void MinuteMultiplyByteReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, ByteAtom, MinuteAtom>(_minuteAtom, _byteAtom);
        Multiply<MinuteAtom, ByteVector, MinuteVector>(_minuteAtom, _byteVector);
        Multiply<MinuteVector, ByteAtom, MinuteVector>(_minuteVector, _byteAtom);
        Multiply<MinuteVector, ByteVector, MinuteVector>(_minuteVector, _byteVector);
    }

    [Test]
    public void MinuteMultiplyShortReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, ShortAtom, MinuteAtom>(_minuteAtom, _shortAtom);
        Multiply<MinuteAtom, ShortVector, MinuteVector>(_minuteAtom, _shortVector);
        Multiply<MinuteVector, ShortAtom, MinuteVector>(_minuteVector, _shortAtom);
        Multiply<MinuteVector, ShortVector, MinuteVector>(_minuteVector, _shortVector);
    }

    [Test]
    public void MinuteMultiplyIntReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, IntAtom, MinuteAtom>(_minuteAtom, _intAtom);
        Multiply<MinuteAtom, IntVector, MinuteVector>(_minuteAtom, _intVector);
        Multiply<MinuteVector, IntAtom, MinuteVector>(_minuteVector, _intAtom);
        Multiply<MinuteVector, IntVector, MinuteVector>(_minuteVector, _intVector);
    }

    [Test]
    public void MinuteMultiplyLongReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, LongAtom, MinuteAtom>(_minuteAtom, _longAtom);
        Multiply<MinuteAtom, LongVector, MinuteVector>(_minuteAtom, _longVector);
        Multiply<MinuteVector, LongAtom, MinuteVector>(_minuteVector, _longAtom);
        Multiply<MinuteVector, LongVector, MinuteVector>(_minuteVector, _longVector);
    }

    [Test]
    public void MinuteMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, FloatAtom, MinuteAtom>(_minuteAtom, _floatAtom);
        Multiply<MinuteAtom, FloatVector, MinuteVector>(_minuteAtom, _floatVector);
        Multiply<MinuteVector, FloatAtom, MinuteVector>(_minuteVector, _floatAtom);
        Multiply<MinuteVector, FloatVector, MinuteVector>(_minuteVector, _floatVector);
    }

    [Test]
    public void MinuteMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<MinuteAtom, DoubleAtom, DoubleAtom>(_minuteAtom, _doubleAtom);
        Multiply<MinuteAtom, DoubleVector, DoubleVector>(_minuteAtom, _doubleVector);
        Multiply<MinuteVector, DoubleAtom, DoubleVector>(_minuteVector, _doubleAtom);
        Multiply<MinuteVector, DoubleVector, DoubleVector>(_minuteVector, _doubleVector);
    }

    [Test]
    public void SecondMultiplyByteReturnsCorrectTypes()
    {
        Multiply<SecondAtom, ByteAtom, SecondAtom>(_secondAtom, _byteAtom);
        Multiply<SecondAtom, ByteVector, SecondVector>(_secondAtom, _byteVector);
        Multiply<SecondVector, ByteAtom, SecondVector>(_secondVector, _byteAtom);
        Multiply<SecondVector, ByteVector, SecondVector>(_secondVector, _byteVector);
    }

    [Test]
    public void SecondMultiplyShortReturnsCorrectTypes()
    {
        Multiply<SecondAtom, ShortAtom, SecondAtom>(_secondAtom, _shortAtom);
        Multiply<SecondAtom, ShortVector, SecondVector>(_secondAtom, _shortVector);
        Multiply<SecondVector, ShortAtom, SecondVector>(_secondVector, _shortAtom);
        Multiply<SecondVector, ShortVector, SecondVector>(_secondVector, _shortVector);
    }

    [Test]
    public void SecondMultiplyIntReturnsCorrectTypes()
    {
        Multiply<SecondAtom, IntAtom, SecondAtom>(_secondAtom, _intAtom);
        Multiply<SecondAtom, IntVector, SecondVector>(_secondAtom, _intVector);
        Multiply<SecondVector, IntAtom, SecondVector>(_secondVector, _intAtom);
        Multiply<SecondVector, IntVector, SecondVector>(_secondVector, _intVector);
    }

    [Test]
    public void SecondMultiplyLongReturnsCorrectTypes()
    {
        Multiply<SecondAtom, LongAtom, SecondAtom>(_secondAtom, _longAtom);
        Multiply<SecondAtom, LongVector, SecondVector>(_secondAtom, _longVector);
        Multiply<SecondVector, LongAtom, SecondVector>(_secondVector, _longAtom);
        Multiply<SecondVector, LongVector, SecondVector>(_secondVector, _longVector);
    }

    [Test]
    public void SecondMultiplyFloatReturnsCorrectTypes()
    {
        Multiply<SecondAtom, FloatAtom, SecondAtom>(_secondAtom, _floatAtom);
        Multiply<SecondAtom, FloatVector, SecondVector>(_secondAtom, _floatVector);
        Multiply<SecondVector, FloatAtom, SecondVector>(_secondVector, _floatAtom);
        Multiply<SecondVector, FloatVector, SecondVector>(_secondVector, _floatVector);
    }

    [Test]
    public void SecondMultiplyDoubleReturnsCorrectTypes()
    {
        Multiply<SecondAtom, DoubleAtom, DoubleAtom>(_secondAtom, _doubleAtom);
        Multiply<SecondAtom, DoubleVector, DoubleVector>(_secondAtom, _doubleVector);
        Multiply<SecondVector, DoubleAtom, DoubleVector>(_secondVector, _doubleAtom);
        Multiply<SecondVector, DoubleVector, DoubleVector>(_secondVector, _doubleVector);
    }
}
