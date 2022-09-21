using System.Numerics;
using SharpDB.Data;

namespace SharpDB.Tests.Data.Functions;

public class AddTests
{
    private static void Add<T1, T2, T3>(T1 left, T2 right)
        where T1 : IAdditionOperators<T1, T2, T3>
        where T2 : IAdditionOperators<T2, T1, T3>
    {
        var result1 = left + right;
        var result2 = right + left;
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
    public void ByteAddByteReturnsCorrectTypes()
    {
        Add<ByteAtom, ByteAtom, IntAtom>(_byteAtom, _byteAtom);
        Add<ByteAtom, ByteVector, IntVector>(_byteAtom, _byteVector);
        Add<ByteVector, ByteAtom, IntVector>(_byteVector, _byteAtom);
        Add<ByteVector, ByteVector, IntVector>(_byteVector, _byteVector);
    }

    [Test]
    public void ByteAddShortReturnsCorrectTypes()
    {
        Add<ByteAtom, ShortAtom, IntAtom>(_byteAtom, _shortAtom);
        Add<ByteAtom, ShortVector, IntVector>(_byteAtom, _shortVector);
        Add<ByteVector, ShortAtom, IntVector>(_byteVector, _shortAtom);
        Add<ByteVector, ShortVector, IntVector>(_byteVector, _shortVector);
    }

    [Test]
    public void ByteAddIntReturnsCorrectTypes()
    {
        Add<ByteAtom, IntAtom, IntAtom>(_byteAtom, _intAtom);
        Add<ByteAtom, IntVector, IntVector>(_byteAtom, _intVector);
        Add<ByteVector, IntAtom, IntVector>(_byteVector, _intAtom);
        Add<ByteVector, IntVector, IntVector>(_byteVector, _intVector);
    }

    [Test]
    public void ByteAddLongReturnsCorrectTypes()
    {
        Add<ByteAtom, LongAtom, LongAtom>(_byteAtom, _longAtom);
        Add<ByteAtom, LongVector, LongVector>(_byteAtom, _longVector);
        Add<ByteVector, LongAtom, LongVector>(_byteVector, _longAtom);
        Add<ByteVector, LongVector, LongVector>(_byteVector, _longVector);
    }

    [Test]
    public void ByteAddFloatReturnsCorrectTypes()
    {
        Add<ByteAtom, FloatAtom, FloatAtom>(_byteAtom, _floatAtom);
        Add<ByteAtom, FloatVector, FloatVector>(_byteAtom, _floatVector);
        Add<ByteVector, FloatAtom, FloatVector>(_byteVector, _floatAtom);
        Add<ByteVector, FloatVector, FloatVector>(_byteVector, _floatVector);
    }

    [Test]
    public void ByteAddDoubleReturnsCorrectTypes()
    {
        Add<ByteAtom, DoubleAtom, DoubleAtom>(_byteAtom, _doubleAtom);
        Add<ByteAtom, DoubleVector, DoubleVector>(_byteAtom, _doubleVector);
        Add<ByteVector, DoubleAtom, DoubleVector>(_byteVector, _doubleAtom);
        Add<ByteVector, DoubleVector, DoubleVector>(_byteVector, _doubleVector);
    }

    [Test]
    public void ByteAddTimestampReturnsCorrectTypes()
    {
        Add<ByteAtom, TimestampAtom, TimestampAtom>(_byteAtom, _timestampAtom);
        Add<ByteAtom, TimestampVector, TimestampVector>(_byteAtom, _timestampVector);
        Add<ByteVector, TimestampAtom, TimestampVector>(_byteVector, _timestampAtom);
        Add<ByteVector, TimestampVector, TimestampVector>(_byteVector, _timestampVector);
    }

    [Test]
    public void ByteAddMonthReturnsCorrectTypes()
    {
        Add<ByteAtom, MonthAtom, MonthAtom>(_byteAtom, _monthAtom);
        Add<ByteAtom, MonthVector, MonthVector>(_byteAtom, _monthVector);
        Add<ByteVector, MonthAtom, MonthVector>(_byteVector, _monthAtom);
        Add<ByteVector, MonthVector, MonthVector>(_byteVector, _monthVector);
    }

    [Test]
    public void ByteAddDateReturnsCorrectTypes()
    {
        Add<ByteAtom, DateAtom, DateAtom>(_byteAtom, _dateAtom);
        Add<ByteAtom, DateVector, DateVector>(_byteAtom, _dateVector);
        Add<ByteVector, DateAtom, DateVector>(_byteVector, _dateAtom);
        Add<ByteVector, DateVector, DateVector>(_byteVector, _dateVector);
    }

    [Test]
    public void ByteAddTimespanReturnsCorrectTypes()
    {
        Add<ByteAtom, TimespanAtom, TimespanAtom>(_byteAtom, _timespanAtom);
        Add<ByteAtom, TimespanVector, TimespanVector>(_byteAtom, _timespanVector);
        Add<ByteVector, TimespanAtom, TimespanVector>(_byteVector, _timespanAtom);
        Add<ByteVector, TimespanVector, TimespanVector>(_byteVector, _timespanVector);
    }

    [Test]
    public void ByteAddMinuteReturnsCorrectTypes()
    {
        Add<ByteAtom, MinuteAtom, MinuteAtom>(_byteAtom, _minuteAtom);
        Add<ByteAtom, MinuteVector, MinuteVector>(_byteAtom, _minuteVector);
        Add<ByteVector, MinuteAtom, MinuteVector>(_byteVector, _minuteAtom);
        Add<ByteVector, MinuteVector, MinuteVector>(_byteVector, _minuteVector);
    }

    [Test]
    public void ByteAddSecondReturnsCorrectTypes()
    {
        Add<ByteAtom, SecondAtom, SecondAtom>(_byteAtom, _secondAtom);
        Add<ByteAtom, SecondVector, SecondVector>(_byteAtom, _secondVector);
        Add<ByteVector, SecondAtom, SecondVector>(_byteVector, _secondAtom);
        Add<ByteVector, SecondVector, SecondVector>(_byteVector, _secondVector);
    }

    [Test]
    public void ShortAddByteReturnsCorrectTypes()
    {
        Add<ShortAtom, ByteAtom, IntAtom>(_shortAtom, _byteAtom);
        Add<ShortAtom, ByteVector, IntVector>(_shortAtom, _byteVector);
        Add<ShortVector, ByteAtom, IntVector>(_shortVector, _byteAtom);
        Add<ShortVector, ByteVector, IntVector>(_shortVector, _byteVector);
    }

    [Test]
    public void ShortAddShortReturnsCorrectTypes()
    {
        Add<ShortAtom, ShortAtom, IntAtom>(_shortAtom, _shortAtom);
        Add<ShortAtom, ShortVector, IntVector>(_shortAtom, _shortVector);
        Add<ShortVector, ShortAtom, IntVector>(_shortVector, _shortAtom);
        Add<ShortVector, ShortVector, IntVector>(_shortVector, _shortVector);
    }

    [Test]
    public void ShortAddIntReturnsCorrectTypes()
    {
        Add<ShortAtom, IntAtom, IntAtom>(_shortAtom, _intAtom);
        Add<ShortAtom, IntVector, IntVector>(_shortAtom, _intVector);
        Add<ShortVector, IntAtom, IntVector>(_shortVector, _intAtom);
        Add<ShortVector, IntVector, IntVector>(_shortVector, _intVector);
    }

    [Test]
    public void ShortAddLongReturnsCorrectTypes()
    {
        Add<ShortAtom, LongAtom, LongAtom>(_shortAtom, _longAtom);
        Add<ShortAtom, LongVector, LongVector>(_shortAtom, _longVector);
        Add<ShortVector, LongAtom, LongVector>(_shortVector, _longAtom);
        Add<ShortVector, LongVector, LongVector>(_shortVector, _longVector);
    }

    [Test]
    public void ShortAddFloatReturnsCorrectTypes()
    {
        Add<ShortAtom, FloatAtom, FloatAtom>(_shortAtom, _floatAtom);
        Add<ShortAtom, FloatVector, FloatVector>(_shortAtom, _floatVector);
        Add<ShortVector, FloatAtom, FloatVector>(_shortVector, _floatAtom);
        Add<ShortVector, FloatVector, FloatVector>(_shortVector, _floatVector);
    }

    [Test]
    public void ShortAddDoubleReturnsCorrectTypes()
    {
        Add<ShortAtom, DoubleAtom, DoubleAtom>(_shortAtom, _doubleAtom);
        Add<ShortAtom, DoubleVector, DoubleVector>(_shortAtom, _doubleVector);
        Add<ShortVector, DoubleAtom, DoubleVector>(_shortVector, _doubleAtom);
        Add<ShortVector, DoubleVector, DoubleVector>(_shortVector, _doubleVector);
    }

    [Test]
    public void ShortAddTimestampReturnsCorrectTypes()
    {
        Add<ShortAtom, TimestampAtom, TimestampAtom>(_shortAtom, _timestampAtom);
        Add<ShortAtom, TimestampVector, TimestampVector>(_shortAtom, _timestampVector);
        Add<ShortVector, TimestampAtom, TimestampVector>(_shortVector, _timestampAtom);
        Add<ShortVector, TimestampVector, TimestampVector>(_shortVector, _timestampVector);
    }

    [Test]
    public void ShortAddMonthReturnsCorrectTypes()
    {
        Add<ShortAtom, MonthAtom, MonthAtom>(_shortAtom, _monthAtom);
        Add<ShortAtom, MonthVector, MonthVector>(_shortAtom, _monthVector);
        Add<ShortVector, MonthAtom, MonthVector>(_shortVector, _monthAtom);
        Add<ShortVector, MonthVector, MonthVector>(_shortVector, _monthVector);
    }

    [Test]
    public void ShortAddDateReturnsCorrectTypes()
    {
        Add<ShortAtom, DateAtom, DateAtom>(_shortAtom, _dateAtom);
        Add<ShortAtom, DateVector, DateVector>(_shortAtom, _dateVector);
        Add<ShortVector, DateAtom, DateVector>(_shortVector, _dateAtom);
        Add<ShortVector, DateVector, DateVector>(_shortVector, _dateVector);
    }

    [Test]
    public void ShortAddTimespanReturnsCorrectTypes()
    {
        Add<ShortAtom, TimespanAtom, TimespanAtom>(_shortAtom, _timespanAtom);
        Add<ShortAtom, TimespanVector, TimespanVector>(_shortAtom, _timespanVector);
        Add<ShortVector, TimespanAtom, TimespanVector>(_shortVector, _timespanAtom);
        Add<ShortVector, TimespanVector, TimespanVector>(_shortVector, _timespanVector);
    }

    [Test]
    public void ShortAddMinuteReturnsCorrectTypes()
    {
        Add<ShortAtom, MinuteAtom, MinuteAtom>(_shortAtom, _minuteAtom);
        Add<ShortAtom, MinuteVector, MinuteVector>(_shortAtom, _minuteVector);
        Add<ShortVector, MinuteAtom, MinuteVector>(_shortVector, _minuteAtom);
        Add<ShortVector, MinuteVector, MinuteVector>(_shortVector, _minuteVector);
    }

    [Test]
    public void ShortAddSecondReturnsCorrectTypes()
    {
        Add<ShortAtom, SecondAtom, SecondAtom>(_shortAtom, _secondAtom);
        Add<ShortAtom, SecondVector, SecondVector>(_shortAtom, _secondVector);
        Add<ShortVector, SecondAtom, SecondVector>(_shortVector, _secondAtom);
        Add<ShortVector, SecondVector, SecondVector>(_shortVector, _secondVector);
    }

    [Test]
    public void IntAddByteReturnsCorrectTypes()
    {
        Add<IntAtom, ByteAtom, IntAtom>(_intAtom, _byteAtom);
        Add<IntAtom, ByteVector, IntVector>(_intAtom, _byteVector);
        Add<IntVector, ByteAtom, IntVector>(_intVector, _byteAtom);
        Add<IntVector, ByteVector, IntVector>(_intVector, _byteVector);
    }

    [Test]
    public void IntAddShortReturnsCorrectTypes()
    {
        Add<IntAtom, ShortAtom, IntAtom>(_intAtom, _shortAtom);
        Add<IntAtom, ShortVector, IntVector>(_intAtom, _shortVector);
        Add<IntVector, ShortAtom, IntVector>(_intVector, _shortAtom);
        Add<IntVector, ShortVector, IntVector>(_intVector, _shortVector);
    }

    [Test]
    public void IntAddIntReturnsCorrectTypes()
    {
        Add<IntAtom, IntAtom, IntAtom>(_intAtom, _intAtom);
        Add<IntAtom, IntVector, IntVector>(_intAtom, _intVector);
        Add<IntVector, IntAtom, IntVector>(_intVector, _intAtom);
        Add<IntVector, IntVector, IntVector>(_intVector, _intVector);
    }

    [Test]
    public void IntAddLongReturnsCorrectTypes()
    {
        Add<IntAtom, LongAtom, LongAtom>(_intAtom, _longAtom);
        Add<IntAtom, LongVector, LongVector>(_intAtom, _longVector);
        Add<IntVector, LongAtom, LongVector>(_intVector, _longAtom);
        Add<IntVector, LongVector, LongVector>(_intVector, _longVector);
    }

    [Test]
    public void IntAddFloatReturnsCorrectTypes()
    {
        Add<IntAtom, FloatAtom, FloatAtom>(_intAtom, _floatAtom);
        Add<IntAtom, FloatVector, FloatVector>(_intAtom, _floatVector);
        Add<IntVector, FloatAtom, FloatVector>(_intVector, _floatAtom);
        Add<IntVector, FloatVector, FloatVector>(_intVector, _floatVector);
    }

    [Test]
    public void IntAddDoubleReturnsCorrectTypes()
    {
        Add<IntAtom, DoubleAtom, DoubleAtom>(_intAtom, _doubleAtom);
        Add<IntAtom, DoubleVector, DoubleVector>(_intAtom, _doubleVector);
        Add<IntVector, DoubleAtom, DoubleVector>(_intVector, _doubleAtom);
        Add<IntVector, DoubleVector, DoubleVector>(_intVector, _doubleVector);
    }

    [Test]
    public void IntAddTimestampReturnsCorrectTypes()
    {
        Add<IntAtom, TimestampAtom, TimestampAtom>(_intAtom, _timestampAtom);
        Add<IntAtom, TimestampVector, TimestampVector>(_intAtom, _timestampVector);
        Add<IntVector, TimestampAtom, TimestampVector>(_intVector, _timestampAtom);
        Add<IntVector, TimestampVector, TimestampVector>(_intVector, _timestampVector);
    }

    [Test]
    public void IntAddMonthReturnsCorrectTypes()
    {
        Add<IntAtom, MonthAtom, MonthAtom>(_intAtom, _monthAtom);
        Add<IntAtom, MonthVector, MonthVector>(_intAtom, _monthVector);
        Add<IntVector, MonthAtom, MonthVector>(_intVector, _monthAtom);
        Add<IntVector, MonthVector, MonthVector>(_intVector, _monthVector);
    }

    [Test]
    public void IntAddDateReturnsCorrectTypes()
    {
        Add<IntAtom, DateAtom, DateAtom>(_intAtom, _dateAtom);
        Add<IntAtom, DateVector, DateVector>(_intAtom, _dateVector);
        Add<IntVector, DateAtom, DateVector>(_intVector, _dateAtom);
        Add<IntVector, DateVector, DateVector>(_intVector, _dateVector);
    }

    [Test]
    public void IntAddTimespanReturnsCorrectTypes()
    {
        Add<IntAtom, TimespanAtom, TimespanAtom>(_intAtom, _timespanAtom);
        Add<IntAtom, TimespanVector, TimespanVector>(_intAtom, _timespanVector);
        Add<IntVector, TimespanAtom, TimespanVector>(_intVector, _timespanAtom);
        Add<IntVector, TimespanVector, TimespanVector>(_intVector, _timespanVector);
    }

    [Test]
    public void IntAddMinuteReturnsCorrectTypes()
    {
        Add<IntAtom, MinuteAtom, MinuteAtom>(_intAtom, _minuteAtom);
        Add<IntAtom, MinuteVector, MinuteVector>(_intAtom, _minuteVector);
        Add<IntVector, MinuteAtom, MinuteVector>(_intVector, _minuteAtom);
        Add<IntVector, MinuteVector, MinuteVector>(_intVector, _minuteVector);
    }

    [Test]
    public void IntAddSecondReturnsCorrectTypes()
    {
        Add<IntAtom, SecondAtom, SecondAtom>(_intAtom, _secondAtom);
        Add<IntAtom, SecondVector, SecondVector>(_intAtom, _secondVector);
        Add<IntVector, SecondAtom, SecondVector>(_intVector, _secondAtom);
        Add<IntVector, SecondVector, SecondVector>(_intVector, _secondVector);
    }

    [Test]
    public void LongAddByteReturnsCorrectTypes()
    {
        Add<LongAtom, ByteAtom, LongAtom>(_longAtom, _byteAtom);
        Add<LongAtom, ByteVector, LongVector>(_longAtom, _byteVector);
        Add<LongVector, ByteAtom, LongVector>(_longVector, _byteAtom);
        Add<LongVector, ByteVector, LongVector>(_longVector, _byteVector);
    }

    [Test]
    public void LongAddShortReturnsCorrectTypes()
    {
        Add<LongAtom, ShortAtom, LongAtom>(_longAtom, _shortAtom);
        Add<LongAtom, ShortVector, LongVector>(_longAtom, _shortVector);
        Add<LongVector, ShortAtom, LongVector>(_longVector, _shortAtom);
        Add<LongVector, ShortVector, LongVector>(_longVector, _shortVector);
    }

    [Test]
    public void LongAddIntReturnsCorrectTypes()
    {
        Add<LongAtom, IntAtom, LongAtom>(_longAtom, _intAtom);
        Add<LongAtom, IntVector, LongVector>(_longAtom, _intVector);
        Add<LongVector, IntAtom, LongVector>(_longVector, _intAtom);
        Add<LongVector, IntVector, LongVector>(_longVector, _intVector);
    }

    [Test]
    public void LongAddLongReturnsCorrectTypes()
    {
        Add<LongAtom, LongAtom, LongAtom>(_longAtom, _longAtom);
        Add<LongAtom, LongVector, LongVector>(_longAtom, _longVector);
        Add<LongVector, LongAtom, LongVector>(_longVector, _longAtom);
        Add<LongVector, LongVector, LongVector>(_longVector, _longVector);
    }

    [Test]
    public void LongAddFloatReturnsCorrectTypes()
    {
        Add<LongAtom, FloatAtom, FloatAtom>(_longAtom, _floatAtom);
        Add<LongAtom, FloatVector, FloatVector>(_longAtom, _floatVector);
        Add<LongVector, FloatAtom, FloatVector>(_longVector, _floatAtom);
        Add<LongVector, FloatVector, FloatVector>(_longVector, _floatVector);
    }

    [Test]
    public void LongAddDoubleReturnsCorrectTypes()
    {
        Add<LongAtom, DoubleAtom, DoubleAtom>(_longAtom, _doubleAtom);
        Add<LongAtom, DoubleVector, DoubleVector>(_longAtom, _doubleVector);
        Add<LongVector, DoubleAtom, DoubleVector>(_longVector, _doubleAtom);
        Add<LongVector, DoubleVector, DoubleVector>(_longVector, _doubleVector);
    }

    [Test]
    public void LongAddTimestampReturnsCorrectTypes()
    {
        Add<LongAtom, TimestampAtom, TimestampAtom>(_longAtom, _timestampAtom);
        Add<LongAtom, TimestampVector, TimestampVector>(_longAtom, _timestampVector);
        Add<LongVector, TimestampAtom, TimestampVector>(_longVector, _timestampAtom);
        Add<LongVector, TimestampVector, TimestampVector>(_longVector, _timestampVector);
    }

    [Test]
    public void LongAddMonthReturnsCorrectTypes()
    {
        Add<LongAtom, MonthAtom, MonthAtom>(_longAtom, _monthAtom);
        Add<LongAtom, MonthVector, MonthVector>(_longAtom, _monthVector);
        Add<LongVector, MonthAtom, MonthVector>(_longVector, _monthAtom);
        Add<LongVector, MonthVector, MonthVector>(_longVector, _monthVector);
    }

    [Test]
    public void LongAddDateReturnsCorrectTypes()
    {
        Add<LongAtom, DateAtom, DateAtom>(_longAtom, _dateAtom);
        Add<LongAtom, DateVector, DateVector>(_longAtom, _dateVector);
        Add<LongVector, DateAtom, DateVector>(_longVector, _dateAtom);
        Add<LongVector, DateVector, DateVector>(_longVector, _dateVector);
    }

    [Test]
    public void LongAddTimespanReturnsCorrectTypes()
    {
        Add<LongAtom, TimespanAtom, TimespanAtom>(_longAtom, _timespanAtom);
        Add<LongAtom, TimespanVector, TimespanVector>(_longAtom, _timespanVector);
        Add<LongVector, TimespanAtom, TimespanVector>(_longVector, _timespanAtom);
        Add<LongVector, TimespanVector, TimespanVector>(_longVector, _timespanVector);
    }

    [Test]
    public void LongAddMinuteReturnsCorrectTypes()
    {
        Add<LongAtom, MinuteAtom, MinuteAtom>(_longAtom, _minuteAtom);
        Add<LongAtom, MinuteVector, MinuteVector>(_longAtom, _minuteVector);
        Add<LongVector, MinuteAtom, MinuteVector>(_longVector, _minuteAtom);
        Add<LongVector, MinuteVector, MinuteVector>(_longVector, _minuteVector);
    }

    [Test]
    public void LongAddSecondReturnsCorrectTypes()
    {
        Add<LongAtom, SecondAtom, SecondAtom>(_longAtom, _secondAtom);
        Add<LongAtom, SecondVector, SecondVector>(_longAtom, _secondVector);
        Add<LongVector, SecondAtom, SecondVector>(_longVector, _secondAtom);
        Add<LongVector, SecondVector, SecondVector>(_longVector, _secondVector);
    }

    [Test]
    public void FloatAddByteReturnsCorrectTypes()
    {
        Add<FloatAtom, ByteAtom, FloatAtom>(_floatAtom, _byteAtom);
        Add<FloatAtom, ByteVector, FloatVector>(_floatAtom, _byteVector);
        Add<FloatVector, ByteAtom, FloatVector>(_floatVector, _byteAtom);
        Add<FloatVector, ByteVector, FloatVector>(_floatVector, _byteVector);
    }

    [Test]
    public void FloatAddShortReturnsCorrectTypes()
    {
        Add<FloatAtom, ShortAtom, FloatAtom>(_floatAtom, _shortAtom);
        Add<FloatAtom, ShortVector, FloatVector>(_floatAtom, _shortVector);
        Add<FloatVector, ShortAtom, FloatVector>(_floatVector, _shortAtom);
        Add<FloatVector, ShortVector, FloatVector>(_floatVector, _shortVector);
    }

    [Test]
    public void FloatAddIntReturnsCorrectTypes()
    {
        Add<FloatAtom, IntAtom, FloatAtom>(_floatAtom, _intAtom);
        Add<FloatAtom, IntVector, FloatVector>(_floatAtom, _intVector);
        Add<FloatVector, IntAtom, FloatVector>(_floatVector, _intAtom);
        Add<FloatVector, IntVector, FloatVector>(_floatVector, _intVector);
    }

    [Test]
    public void FloatAddLongReturnsCorrectTypes()
    {
        Add<FloatAtom, LongAtom, FloatAtom>(_floatAtom, _longAtom);
        Add<FloatAtom, LongVector, FloatVector>(_floatAtom, _longVector);
        Add<FloatVector, LongAtom, FloatVector>(_floatVector, _longAtom);
        Add<FloatVector, LongVector, FloatVector>(_floatVector, _longVector);
    }

    [Test]
    public void FloatAddFloatReturnsCorrectTypes()
    {
        Add<FloatAtom, FloatAtom, FloatAtom>(_floatAtom, _floatAtom);
        Add<FloatAtom, FloatVector, FloatVector>(_floatAtom, _floatVector);
        Add<FloatVector, FloatAtom, FloatVector>(_floatVector, _floatAtom);
        Add<FloatVector, FloatVector, FloatVector>(_floatVector, _floatVector);
    }

    [Test]
    public void FloatAddDoubleReturnsCorrectTypes()
    {
        Add<FloatAtom, DoubleAtom, DoubleAtom>(_floatAtom, _doubleAtom);
        Add<FloatAtom, DoubleVector, DoubleVector>(_floatAtom, _doubleVector);
        Add<FloatVector, DoubleAtom, DoubleVector>(_floatVector, _doubleAtom);
        Add<FloatVector, DoubleVector, DoubleVector>(_floatVector, _doubleVector);
    }

    [Test]
    public void FloatAddTimestampReturnsCorrectTypes()
    {
        Add<FloatAtom, TimestampAtom, TimestampAtom>(_floatAtom, _timestampAtom);
        Add<FloatAtom, TimestampVector, TimestampVector>(_floatAtom, _timestampVector);
        Add<FloatVector, TimestampAtom, TimestampVector>(_floatVector, _timestampAtom);
        Add<FloatVector, TimestampVector, TimestampVector>(_floatVector, _timestampVector);
    }

    [Test]
    public void FloatAddMonthReturnsCorrectTypes()
    {
        Add<FloatAtom, MonthAtom, MonthAtom>(_floatAtom, _monthAtom);
        Add<FloatAtom, MonthVector, MonthVector>(_floatAtom, _monthVector);
        Add<FloatVector, MonthAtom, MonthVector>(_floatVector, _monthAtom);
        Add<FloatVector, MonthVector, MonthVector>(_floatVector, _monthVector);
    }

    [Test]
    public void FloatAddDateReturnsCorrectTypes()
    {
        Add<FloatAtom, DateAtom, DateAtom>(_floatAtom, _dateAtom);
        Add<FloatAtom, DateVector, DateVector>(_floatAtom, _dateVector);
        Add<FloatVector, DateAtom, DateVector>(_floatVector, _dateAtom);
        Add<FloatVector, DateVector, DateVector>(_floatVector, _dateVector);
    }

    [Test]
    public void FloatAddTimespanReturnsCorrectTypes()
    {
        Add<FloatAtom, TimespanAtom, TimespanAtom>(_floatAtom, _timespanAtom);
        Add<FloatAtom, TimespanVector, TimespanVector>(_floatAtom, _timespanVector);
        Add<FloatVector, TimespanAtom, TimespanVector>(_floatVector, _timespanAtom);
        Add<FloatVector, TimespanVector, TimespanVector>(_floatVector, _timespanVector);
    }

    [Test]
    public void FloatAddMinuteReturnsCorrectTypes()
    {
        Add<FloatAtom, MinuteAtom, MinuteAtom>(_floatAtom, _minuteAtom);
        Add<FloatAtom, MinuteVector, MinuteVector>(_floatAtom, _minuteVector);
        Add<FloatVector, MinuteAtom, MinuteVector>(_floatVector, _minuteAtom);
        Add<FloatVector, MinuteVector, MinuteVector>(_floatVector, _minuteVector);
    }

    [Test]
    public void FloatAddSecondReturnsCorrectTypes()
    {
        Add<FloatAtom, SecondAtom, SecondAtom>(_floatAtom, _secondAtom);
        Add<FloatAtom, SecondVector, SecondVector>(_floatAtom, _secondVector);
        Add<FloatVector, SecondAtom, SecondVector>(_floatVector, _secondAtom);
        Add<FloatVector, SecondVector, SecondVector>(_floatVector, _secondVector);
    }

    [Test]
    public void DoubleAddByteReturnsCorrectTypes()
    {
        Add<DoubleAtom, ByteAtom, DoubleAtom>(_doubleAtom, _byteAtom);
        Add<DoubleAtom, ByteVector, DoubleVector>(_doubleAtom, _byteVector);
        Add<DoubleVector, ByteAtom, DoubleVector>(_doubleVector, _byteAtom);
        Add<DoubleVector, ByteVector, DoubleVector>(_doubleVector, _byteVector);
    }

    [Test]
    public void DoubleAddShortReturnsCorrectTypes()
    {
        Add<DoubleAtom, ShortAtom, DoubleAtom>(_doubleAtom, _shortAtom);
        Add<DoubleAtom, ShortVector, DoubleVector>(_doubleAtom, _shortVector);
        Add<DoubleVector, ShortAtom, DoubleVector>(_doubleVector, _shortAtom);
        Add<DoubleVector, ShortVector, DoubleVector>(_doubleVector, _shortVector);
    }

    [Test]
    public void DoubleAddIntReturnsCorrectTypes()
    {
        Add<DoubleAtom, IntAtom, DoubleAtom>(_doubleAtom, _intAtom);
        Add<DoubleAtom, IntVector, DoubleVector>(_doubleAtom, _intVector);
        Add<DoubleVector, IntAtom, DoubleVector>(_doubleVector, _intAtom);
        Add<DoubleVector, IntVector, DoubleVector>(_doubleVector, _intVector);
    }

    [Test]
    public void DoubleAddLongReturnsCorrectTypes()
    {
        Add<DoubleAtom, LongAtom, DoubleAtom>(_doubleAtom, _longAtom);
        Add<DoubleAtom, LongVector, DoubleVector>(_doubleAtom, _longVector);
        Add<DoubleVector, LongAtom, DoubleVector>(_doubleVector, _longAtom);
        Add<DoubleVector, LongVector, DoubleVector>(_doubleVector, _longVector);
    }

    [Test]
    public void DoubleAddFloatReturnsCorrectTypes()
    {
        Add<DoubleAtom, FloatAtom, DoubleAtom>(_doubleAtom, _floatAtom);
        Add<DoubleAtom, FloatVector, DoubleVector>(_doubleAtom, _floatVector);
        Add<DoubleVector, FloatAtom, DoubleVector>(_doubleVector, _floatAtom);
        Add<DoubleVector, FloatVector, DoubleVector>(_doubleVector, _floatVector);
    }

    [Test]
    public void DoubleAddDoubleReturnsCorrectTypes()
    {
        Add<DoubleAtom, DoubleAtom, DoubleAtom>(_doubleAtom, _doubleAtom);
        Add<DoubleAtom, DoubleVector, DoubleVector>(_doubleAtom, _doubleVector);
        Add<DoubleVector, DoubleAtom, DoubleVector>(_doubleVector, _doubleAtom);
        Add<DoubleVector, DoubleVector, DoubleVector>(_doubleVector, _doubleVector);
    }

    [Test]
    public void DoubleAddTimestampReturnsCorrectTypes()
    {
        Add<DoubleAtom, TimestampAtom, DoubleAtom>(_doubleAtom, _timestampAtom);
        Add<DoubleAtom, TimestampVector, DoubleVector>(_doubleAtom, _timestampVector);
        Add<DoubleVector, TimestampAtom, DoubleVector>(_doubleVector, _timestampAtom);
        Add<DoubleVector, TimestampVector, DoubleVector>(_doubleVector, _timestampVector);
    }

    [Test]
    public void DoubleAddMonthReturnsCorrectTypes()
    {
        Add<DoubleAtom, MonthAtom, DoubleAtom>(_doubleAtom, _monthAtom);
        Add<DoubleAtom, MonthVector, DoubleVector>(_doubleAtom, _monthVector);
        Add<DoubleVector, MonthAtom, DoubleVector>(_doubleVector, _monthAtom);
        Add<DoubleVector, MonthVector, DoubleVector>(_doubleVector, _monthVector);
    }

    [Test]
    public void DoubleAddTimespanReturnsCorrectTypes()
    {
        Add<DoubleAtom, TimespanAtom, DoubleAtom>(_doubleAtom, _timespanAtom);
        Add<DoubleAtom, TimespanVector, DoubleVector>(_doubleAtom, _timespanVector);
        Add<DoubleVector, TimespanAtom, DoubleVector>(_doubleVector, _timespanAtom);
        Add<DoubleVector, TimespanVector, DoubleVector>(_doubleVector, _timespanVector);
    }

    [Test]
    public void DoubleAddMinuteReturnsCorrectTypes()
    {
        Add<DoubleAtom, MinuteAtom, DoubleAtom>(_doubleAtom, _minuteAtom);
        Add<DoubleAtom, MinuteVector, DoubleVector>(_doubleAtom, _minuteVector);
        Add<DoubleVector, MinuteAtom, DoubleVector>(_doubleVector, _minuteAtom);
        Add<DoubleVector, MinuteVector, DoubleVector>(_doubleVector, _minuteVector);
    }

    [Test]
    public void DoubleAddSecondReturnsCorrectTypes()
    {
        Add<DoubleAtom, SecondAtom, DoubleAtom>(_doubleAtom, _secondAtom);
        Add<DoubleAtom, SecondVector, DoubleVector>(_doubleAtom, _secondVector);
        Add<DoubleVector, SecondAtom, DoubleVector>(_doubleVector, _secondAtom);
        Add<DoubleVector, SecondVector, DoubleVector>(_doubleVector, _secondVector);
    }

    [Test]
    public void TimestampAddByteReturnsCorrectTypes()
    {
        Add<TimestampAtom, ByteAtom, TimestampAtom>(_timestampAtom, _byteAtom);
        Add<TimestampAtom, ByteVector, TimestampVector>(_timestampAtom, _byteVector);
        Add<TimestampVector, ByteAtom, TimestampVector>(_timestampVector, _byteAtom);
        Add<TimestampVector, ByteVector, TimestampVector>(_timestampVector, _byteVector);
    }

    [Test]
    public void TimestampAddShortReturnsCorrectTypes()
    {
        Add<TimestampAtom, ShortAtom, TimestampAtom>(_timestampAtom, _shortAtom);
        Add<TimestampAtom, ShortVector, TimestampVector>(_timestampAtom, _shortVector);
        Add<TimestampVector, ShortAtom, TimestampVector>(_timestampVector, _shortAtom);
        Add<TimestampVector, ShortVector, TimestampVector>(_timestampVector, _shortVector);
    }

    [Test]
    public void TimestampAddIntReturnsCorrectTypes()
    {
        Add<TimestampAtom, IntAtom, TimestampAtom>(_timestampAtom, _intAtom);
        Add<TimestampAtom, IntVector, TimestampVector>(_timestampAtom, _intVector);
        Add<TimestampVector, IntAtom, TimestampVector>(_timestampVector, _intAtom);
        Add<TimestampVector, IntVector, TimestampVector>(_timestampVector, _intVector);
    }

    [Test]
    public void TimestampAddLongReturnsCorrectTypes()
    {
        Add<TimestampAtom, LongAtom, TimestampAtom>(_timestampAtom, _longAtom);
        Add<TimestampAtom, LongVector, TimestampVector>(_timestampAtom, _longVector);
        Add<TimestampVector, LongAtom, TimestampVector>(_timestampVector, _longAtom);
        Add<TimestampVector, LongVector, TimestampVector>(_timestampVector, _longVector);
    }

    [Test]
    public void TimestampAddFloatReturnsCorrectTypes()
    {
        Add<TimestampAtom, FloatAtom, TimestampAtom>(_timestampAtom, _floatAtom);
        Add<TimestampAtom, FloatVector, TimestampVector>(_timestampAtom, _floatVector);
        Add<TimestampVector, FloatAtom, TimestampVector>(_timestampVector, _floatAtom);
        Add<TimestampVector, FloatVector, TimestampVector>(_timestampVector, _floatVector);
    }

    [Test]
    public void TimestampAddDoubleReturnsCorrectTypes()
    {
        Add<TimestampAtom, DoubleAtom, DoubleAtom>(_timestampAtom, _doubleAtom);
        Add<TimestampAtom, DoubleVector, DoubleVector>(_timestampAtom, _doubleVector);
        Add<TimestampVector, DoubleAtom, DoubleVector>(_timestampVector, _doubleAtom);
        Add<TimestampVector, DoubleVector, DoubleVector>(_timestampVector, _doubleVector);
    }

    [Test]
    public void TimestampAddTimestampReturnsCorrectTypes()
    {
        Add<TimestampAtom, TimestampAtom, TimespanAtom>(_timestampAtom, _timestampAtom);
        Add<TimestampAtom, TimestampVector, TimespanVector>(_timestampAtom, _timestampVector);
        Add<TimestampVector, TimestampAtom, TimespanVector>(_timestampVector, _timestampAtom);
        Add<TimestampVector, TimestampVector, TimespanVector>(_timestampVector, _timestampVector);
    }

    [Test]
    public void TimestampAddTimespanReturnsCorrectTypes()
    {
        Add<TimestampAtom, TimespanAtom, TimestampAtom>(_timestampAtom, _timespanAtom);
        Add<TimestampAtom, TimespanVector, TimestampVector>(_timestampAtom, _timespanVector);
        Add<TimestampVector, TimespanAtom, TimestampVector>(_timestampVector, _timespanAtom);
        Add<TimestampVector, TimespanVector, TimestampVector>(_timestampVector, _timespanVector);
    }

    [Test]
    public void TimestampAddMinuteReturnsCorrectTypes()
    {
        Add<TimestampAtom, MinuteAtom, TimestampAtom>(_timestampAtom, _minuteAtom);
        Add<TimestampAtom, MinuteVector, TimestampVector>(_timestampAtom, _minuteVector);
        Add<TimestampVector, MinuteAtom, TimestampVector>(_timestampVector, _minuteAtom);
        Add<TimestampVector, MinuteVector, TimestampVector>(_timestampVector, _minuteVector);
    }

    [Test]
    public void TimestampAddSecondReturnsCorrectTypes()
    {
        Add<TimestampAtom, SecondAtom, TimestampAtom>(_timestampAtom, _secondAtom);
        Add<TimestampAtom, SecondVector, TimestampVector>(_timestampAtom, _secondVector);
        Add<TimestampVector, SecondAtom, TimestampVector>(_timestampVector, _secondAtom);
        Add<TimestampVector, SecondVector, TimestampVector>(_timestampVector, _secondVector);
    }

    [Test]
    public void MonthAddByteReturnsCorrectTypes()
    {
        Add<MonthAtom, ByteAtom, MonthAtom>(_monthAtom, _byteAtom);
        Add<MonthAtom, ByteVector, MonthVector>(_monthAtom, _byteVector);
        Add<MonthVector, ByteAtom, MonthVector>(_monthVector, _byteAtom);
        Add<MonthVector, ByteVector, MonthVector>(_monthVector, _byteVector);
    }

    [Test]
    public void MonthAddShortReturnsCorrectTypes()
    {
        Add<MonthAtom, ShortAtom, MonthAtom>(_monthAtom, _shortAtom);
        Add<MonthAtom, ShortVector, MonthVector>(_monthAtom, _shortVector);
        Add<MonthVector, ShortAtom, MonthVector>(_monthVector, _shortAtom);
        Add<MonthVector, ShortVector, MonthVector>(_monthVector, _shortVector);
    }

    [Test]
    public void MonthAddIntReturnsCorrectTypes()
    {
        Add<MonthAtom, IntAtom, MonthAtom>(_monthAtom, _intAtom);
        Add<MonthAtom, IntVector, MonthVector>(_monthAtom, _intVector);
        Add<MonthVector, IntAtom, MonthVector>(_monthVector, _intAtom);
        Add<MonthVector, IntVector, MonthVector>(_monthVector, _intVector);
    }

    [Test]
    public void MonthAddLongReturnsCorrectTypes()
    {
        Add<MonthAtom, LongAtom, MonthAtom>(_monthAtom, _longAtom);
        Add<MonthAtom, LongVector, MonthVector>(_monthAtom, _longVector);
        Add<MonthVector, LongAtom, MonthVector>(_monthVector, _longAtom);
        Add<MonthVector, LongVector, MonthVector>(_monthVector, _longVector);
    }

    [Test]
    public void MonthAddFloatReturnsCorrectTypes()
    {
        Add<MonthAtom, FloatAtom, MonthAtom>(_monthAtom, _floatAtom);
        Add<MonthAtom, FloatVector, MonthVector>(_monthAtom, _floatVector);
        Add<MonthVector, FloatAtom, MonthVector>(_monthVector, _floatAtom);
        Add<MonthVector, FloatVector, MonthVector>(_monthVector, _floatVector);
    }

    [Test]
    public void MonthAddDoubleReturnsCorrectTypes()
    {
        Add<MonthAtom, DoubleAtom, DoubleAtom>(_monthAtom, _doubleAtom);
        Add<MonthAtom, DoubleVector, DoubleVector>(_monthAtom, _doubleVector);
        Add<MonthVector, DoubleAtom, DoubleVector>(_monthVector, _doubleAtom);
        Add<MonthVector, DoubleVector, DoubleVector>(_monthVector, _doubleVector);
    }

    [Test]
    public void MonthAddMonthReturnsCorrectTypes()
    {
        Add<MonthAtom, MonthAtom, IntAtom>(_monthAtom, _monthAtom);
        Add<MonthAtom, MonthVector, IntVector>(_monthAtom, _monthVector);
        Add<MonthVector, MonthAtom, IntVector>(_monthVector, _monthAtom);
        Add<MonthVector, MonthVector, IntVector>(_monthVector, _monthVector);
    }

    [Test]
    public void MonthAddTimespanReturnsCorrectTypes()
    {
        Add<MonthAtom, TimespanAtom, TimestampAtom>(_monthAtom, _timespanAtom);
        Add<MonthAtom, TimespanVector, TimestampVector>(_monthAtom, _timespanVector);
        Add<MonthVector, TimespanAtom, TimestampVector>(_monthVector, _timespanAtom);
        Add<MonthVector, TimespanVector, TimestampVector>(_monthVector, _timespanVector);
    }

    [Test]
    public void MonthAddMinuteReturnsCorrectTypes()
    {
        Add<MonthAtom, MinuteAtom, TimestampAtom>(_monthAtom, _minuteAtom);
        Add<MonthAtom, MinuteVector, TimestampVector>(_monthAtom, _minuteVector);
        Add<MonthVector, MinuteAtom, TimestampVector>(_monthVector, _minuteAtom);
        Add<MonthVector, MinuteVector, TimestampVector>(_monthVector, _minuteVector);
    }

    [Test]
    public void MonthAddSecondReturnsCorrectTypes()
    {
        Add<MonthAtom, SecondAtom, TimestampAtom>(_monthAtom, _secondAtom);
        Add<MonthAtom, SecondVector, TimestampVector>(_monthAtom, _secondVector);
        Add<MonthVector, SecondAtom, TimestampVector>(_monthVector, _secondAtom);
        Add<MonthVector, SecondVector, TimestampVector>(_monthVector, _secondVector);
    }

    [Test]
    public void DateAddByteReturnsCorrectTypes()
    {
        Add<DateAtom, ByteAtom, DateAtom>(_dateAtom, _byteAtom);
        Add<DateAtom, ByteVector, DateVector>(_dateAtom, _byteVector);
        Add<DateVector, ByteAtom, DateVector>(_dateVector, _byteAtom);
        Add<DateVector, ByteVector, DateVector>(_dateVector, _byteVector);
    }

    [Test]
    public void DateAddShortReturnsCorrectTypes()
    {
        Add<DateAtom, ShortAtom, DateAtom>(_dateAtom, _shortAtom);
        Add<DateAtom, ShortVector, DateVector>(_dateAtom, _shortVector);
        Add<DateVector, ShortAtom, DateVector>(_dateVector, _shortAtom);
        Add<DateVector, ShortVector, DateVector>(_dateVector, _shortVector);
    }

    [Test]
    public void DateAddIntReturnsCorrectTypes()
    {
        Add<DateAtom, IntAtom, DateAtom>(_dateAtom, _intAtom);
        Add<DateAtom, IntVector, DateVector>(_dateAtom, _intVector);
        Add<DateVector, IntAtom, DateVector>(_dateVector, _intAtom);
        Add<DateVector, IntVector, DateVector>(_dateVector, _intVector);
    }

    [Test]
    public void DateAddLongReturnsCorrectTypes()
    {
        Add<DateAtom, LongAtom, DateAtom>(_dateAtom, _longAtom);
        Add<DateAtom, LongVector, DateVector>(_dateAtom, _longVector);
        Add<DateVector, LongAtom, DateVector>(_dateVector, _longAtom);
        Add<DateVector, LongVector, DateVector>(_dateVector, _longVector);
    }

    [Test]
    public void DateAddFloatReturnsCorrectTypes()
    {
        Add<DateAtom, FloatAtom, DateAtom>(_dateAtom, _floatAtom);
        Add<DateAtom, FloatVector, DateVector>(_dateAtom, _floatVector);
        Add<DateVector, FloatAtom, DateVector>(_dateVector, _floatAtom);
        Add<DateVector, FloatVector, DateVector>(_dateVector, _floatVector);
    }

    [Test]
    public void DateAddDateReturnsCorrectTypes()
    {
        Add<DateAtom, DateAtom, IntAtom>(_dateAtom, _dateAtom);
        Add<DateAtom, DateVector, IntVector>(_dateAtom, _dateVector);
        Add<DateVector, DateAtom, IntVector>(_dateVector, _dateAtom);
        Add<DateVector, DateVector, IntVector>(_dateVector, _dateVector);
    }

    [Test]
    public void DateAddTimespanReturnsCorrectTypes()
    {
        Add<DateAtom, TimespanAtom, TimestampAtom>(_dateAtom, _timespanAtom);
        Add<DateAtom, TimespanVector, TimestampVector>(_dateAtom, _timespanVector);
        Add<DateVector, TimespanAtom, TimestampVector>(_dateVector, _timespanAtom);
        Add<DateVector, TimespanVector, TimestampVector>(_dateVector, _timespanVector);
    }

    [Test]
    public void DateAddMinuteReturnsCorrectTypes()
    {
        Add<DateAtom, MinuteAtom, TimestampAtom>(_dateAtom, _minuteAtom);
        Add<DateAtom, MinuteVector, TimestampVector>(_dateAtom, _minuteVector);
        Add<DateVector, MinuteAtom, TimestampVector>(_dateVector, _minuteAtom);
        Add<DateVector, MinuteVector, TimestampVector>(_dateVector, _minuteVector);
    }

    [Test]
    public void DateAddSecondReturnsCorrectTypes()
    {
        Add<DateAtom, SecondAtom, TimestampAtom>(_dateAtom, _secondAtom);
        Add<DateAtom, SecondVector, TimestampVector>(_dateAtom, _secondVector);
        Add<DateVector, SecondAtom, TimestampVector>(_dateVector, _secondAtom);
        Add<DateVector, SecondVector, TimestampVector>(_dateVector, _secondVector);
    }

    [Test]
    public void TimespanAddByteReturnsCorrectTypes()
    {
        Add<TimespanAtom, ByteAtom, TimespanAtom>(_timespanAtom, _byteAtom);
        Add<TimespanAtom, ByteVector, TimespanVector>(_timespanAtom, _byteVector);
        Add<TimespanVector, ByteAtom, TimespanVector>(_timespanVector, _byteAtom);
        Add<TimespanVector, ByteVector, TimespanVector>(_timespanVector, _byteVector);
    }

    [Test]
    public void TimespanAddShortReturnsCorrectTypes()
    {
        Add<TimespanAtom, ShortAtom, TimespanAtom>(_timespanAtom, _shortAtom);
        Add<TimespanAtom, ShortVector, TimespanVector>(_timespanAtom, _shortVector);
        Add<TimespanVector, ShortAtom, TimespanVector>(_timespanVector, _shortAtom);
        Add<TimespanVector, ShortVector, TimespanVector>(_timespanVector, _shortVector);
    }

    [Test]
    public void TimespanAddIntReturnsCorrectTypes()
    {
        Add<TimespanAtom, IntAtom, TimespanAtom>(_timespanAtom, _intAtom);
        Add<TimespanAtom, IntVector, TimespanVector>(_timespanAtom, _intVector);
        Add<TimespanVector, IntAtom, TimespanVector>(_timespanVector, _intAtom);
        Add<TimespanVector, IntVector, TimespanVector>(_timespanVector, _intVector);
    }

    [Test]
    public void TimespanAddLongReturnsCorrectTypes()
    {
        Add<TimespanAtom, LongAtom, TimespanAtom>(_timespanAtom, _longAtom);
        Add<TimespanAtom, LongVector, TimespanVector>(_timespanAtom, _longVector);
        Add<TimespanVector, LongAtom, TimespanVector>(_timespanVector, _longAtom);
        Add<TimespanVector, LongVector, TimespanVector>(_timespanVector, _longVector);
    }

    [Test]
    public void TimespanAddFloatReturnsCorrectTypes()
    {
        Add<TimespanAtom, FloatAtom, TimespanAtom>(_timespanAtom, _floatAtom);
        Add<TimespanAtom, FloatVector, TimespanVector>(_timespanAtom, _floatVector);
        Add<TimespanVector, FloatAtom, TimespanVector>(_timespanVector, _floatAtom);
        Add<TimespanVector, FloatVector, TimespanVector>(_timespanVector, _floatVector);
    }

    [Test]
    public void TimespanAddDoubleReturnsCorrectTypes()
    {
        Add<TimespanAtom, DoubleAtom, DoubleAtom>(_timespanAtom, _doubleAtom);
        Add<TimespanAtom, DoubleVector, DoubleVector>(_timespanAtom, _doubleVector);
        Add<TimespanVector, DoubleAtom, DoubleVector>(_timespanVector, _doubleAtom);
        Add<TimespanVector, DoubleVector, DoubleVector>(_timespanVector, _doubleVector);
    }

    [Test]
    public void TimespanAddTimestampReturnsCorrectTypes()
    {
        Add<TimespanAtom, TimestampAtom, TimestampAtom>(_timespanAtom, _timestampAtom);
        Add<TimespanAtom, TimestampVector, TimestampVector>(_timespanAtom, _timestampVector);
        Add<TimespanVector, TimestampAtom, TimestampVector>(_timespanVector, _timestampAtom);
        Add<TimespanVector, TimestampVector, TimestampVector>(_timespanVector, _timestampVector);
    }

    [Test]
    public void TimespanAddMonthReturnsCorrectTypes()
    {
        Add<TimespanAtom, MonthAtom, TimestampAtom>(_timespanAtom, _monthAtom);
        Add<TimespanAtom, MonthVector, TimestampVector>(_timespanAtom, _monthVector);
        Add<TimespanVector, MonthAtom, TimestampVector>(_timespanVector, _monthAtom);
        Add<TimespanVector, MonthVector, TimestampVector>(_timespanVector, _monthVector);
    }

    [Test]
    public void TimespanAddDateReturnsCorrectTypes()
    {
        Add<TimespanAtom, DateAtom, TimestampAtom>(_timespanAtom, _dateAtom);
        Add<TimespanAtom, DateVector, TimestampVector>(_timespanAtom, _dateVector);
        Add<TimespanVector, DateAtom, TimestampVector>(_timespanVector, _dateAtom);
        Add<TimespanVector, DateVector, TimestampVector>(_timespanVector, _dateVector);
    }

    [Test]
    public void TimespanAddTimespanReturnsCorrectTypes()
    {
        Add<TimespanAtom, TimespanAtom, TimespanAtom>(_timespanAtom, _timespanAtom);
        Add<TimespanAtom, TimespanVector, TimespanVector>(_timespanAtom, _timespanVector);
        Add<TimespanVector, TimespanAtom, TimespanVector>(_timespanVector, _timespanAtom);
        Add<TimespanVector, TimespanVector, TimespanVector>(_timespanVector, _timespanVector);
    }

    [Test]
    public void TimespanAddMinuteReturnsCorrectTypes()
    {
        Add<TimespanAtom, MinuteAtom, TimespanAtom>(_timespanAtom, _minuteAtom);
        Add<TimespanAtom, MinuteVector, TimespanVector>(_timespanAtom, _minuteVector);
        Add<TimespanVector, MinuteAtom, TimespanVector>(_timespanVector, _minuteAtom);
        Add<TimespanVector, MinuteVector, TimespanVector>(_timespanVector, _minuteVector);
    }

    [Test]
    public void TimespanAddSecondReturnsCorrectTypes()
    {
        Add<TimespanAtom, SecondAtom, TimespanAtom>(_timespanAtom, _secondAtom);
        Add<TimespanAtom, SecondVector, TimespanVector>(_timespanAtom, _secondVector);
        Add<TimespanVector, SecondAtom, TimespanVector>(_timespanVector, _secondAtom);
        Add<TimespanVector, SecondVector, TimespanVector>(_timespanVector, _secondVector);
    }

    [Test]
    public void MinuteAddByteReturnsCorrectTypes()
    {
        Add<MinuteAtom, ByteAtom, MinuteAtom>(_minuteAtom, _byteAtom);
        Add<MinuteAtom, ByteVector, MinuteVector>(_minuteAtom, _byteVector);
        Add<MinuteVector, ByteAtom, MinuteVector>(_minuteVector, _byteAtom);
        Add<MinuteVector, ByteVector, MinuteVector>(_minuteVector, _byteVector);
    }

    [Test]
    public void MinuteAddShortReturnsCorrectTypes()
    {
        Add<MinuteAtom, ShortAtom, MinuteAtom>(_minuteAtom, _shortAtom);
        Add<MinuteAtom, ShortVector, MinuteVector>(_minuteAtom, _shortVector);
        Add<MinuteVector, ShortAtom, MinuteVector>(_minuteVector, _shortAtom);
        Add<MinuteVector, ShortVector, MinuteVector>(_minuteVector, _shortVector);
    }

    [Test]
    public void MinuteAddIntReturnsCorrectTypes()
    {
        Add<MinuteAtom, IntAtom, MinuteAtom>(_minuteAtom, _intAtom);
        Add<MinuteAtom, IntVector, MinuteVector>(_minuteAtom, _intVector);
        Add<MinuteVector, IntAtom, MinuteVector>(_minuteVector, _intAtom);
        Add<MinuteVector, IntVector, MinuteVector>(_minuteVector, _intVector);
    }

    [Test]
    public void MinuteAddLongReturnsCorrectTypes()
    {
        Add<MinuteAtom, LongAtom, MinuteAtom>(_minuteAtom, _longAtom);
        Add<MinuteAtom, LongVector, MinuteVector>(_minuteAtom, _longVector);
        Add<MinuteVector, LongAtom, MinuteVector>(_minuteVector, _longAtom);
        Add<MinuteVector, LongVector, MinuteVector>(_minuteVector, _longVector);
    }

    [Test]
    public void MinuteAddFloatReturnsCorrectTypes()
    {
        Add<MinuteAtom, FloatAtom, MinuteAtom>(_minuteAtom, _floatAtom);
        Add<MinuteAtom, FloatVector, MinuteVector>(_minuteAtom, _floatVector);
        Add<MinuteVector, FloatAtom, MinuteVector>(_minuteVector, _floatAtom);
        Add<MinuteVector, FloatVector, MinuteVector>(_minuteVector, _floatVector);
    }

    [Test]
    public void MinuteAddDoubleReturnsCorrectTypes()
    {
        Add<MinuteAtom, DoubleAtom, DoubleAtom>(_minuteAtom, _doubleAtom);
        Add<MinuteAtom, DoubleVector, DoubleVector>(_minuteAtom, _doubleVector);
        Add<MinuteVector, DoubleAtom, DoubleVector>(_minuteVector, _doubleAtom);
        Add<MinuteVector, DoubleVector, DoubleVector>(_minuteVector, _doubleVector);
    }

    [Test]
    public void MinuteAddTimestampReturnsCorrectTypes()
    {
        Add<MinuteAtom, TimestampAtom, TimestampAtom>(_minuteAtom, _timestampAtom);
        Add<MinuteAtom, TimestampVector, TimestampVector>(_minuteAtom, _timestampVector);
        Add<MinuteVector, TimestampAtom, TimestampVector>(_minuteVector, _timestampAtom);
        Add<MinuteVector, TimestampVector, TimestampVector>(_minuteVector, _timestampVector);
    }

    [Test]
    public void MinuteAddMonthReturnsCorrectTypes()
    {
        Add<MinuteAtom, MonthAtom, TimestampAtom>(_minuteAtom, _monthAtom);
        Add<MinuteAtom, MonthVector, TimestampVector>(_minuteAtom, _monthVector);
        Add<MinuteVector, MonthAtom, TimestampVector>(_minuteVector, _monthAtom);
        Add<MinuteVector, MonthVector, TimestampVector>(_minuteVector, _monthVector);
    }

    [Test]
    public void MinuteAddDateReturnsCorrectTypes()
    {
        Add<MinuteAtom, DateAtom, TimestampAtom>(_minuteAtom, _dateAtom);
        Add<MinuteAtom, DateVector, TimestampVector>(_minuteAtom, _dateVector);
        Add<MinuteVector, DateAtom, TimestampVector>(_minuteVector, _dateAtom);
        Add<MinuteVector, DateVector, TimestampVector>(_minuteVector, _dateVector);
    }

    [Test]
    public void MinuteAddTimespanReturnsCorrectTypes()
    {
        Add<MinuteAtom, TimespanAtom, TimespanAtom>(_minuteAtom, _timespanAtom);
        Add<MinuteAtom, TimespanVector, TimespanVector>(_minuteAtom, _timespanVector);
        Add<MinuteVector, TimespanAtom, TimespanVector>(_minuteVector, _timespanAtom);
        Add<MinuteVector, TimespanVector, TimespanVector>(_minuteVector, _timespanVector);
    }

    [Test]
    public void MinuteAddMinuteReturnsCorrectTypes()
    {
        Add<MinuteAtom, MinuteAtom, MinuteAtom>(_minuteAtom, _minuteAtom);
        Add<MinuteAtom, MinuteVector, MinuteVector>(_minuteAtom, _minuteVector);
        Add<MinuteVector, MinuteAtom, MinuteVector>(_minuteVector, _minuteAtom);
        Add<MinuteVector, MinuteVector, MinuteVector>(_minuteVector, _minuteVector);
    }

    [Test]
    public void MinuteAddSecondReturnsCorrectTypes()
    {
        Add<MinuteAtom, SecondAtom, SecondAtom>(_minuteAtom, _secondAtom);
        Add<MinuteAtom, SecondVector, SecondVector>(_minuteAtom, _secondVector);
        Add<MinuteVector, SecondAtom, SecondVector>(_minuteVector, _secondAtom);
        Add<MinuteVector, SecondVector, SecondVector>(_minuteVector, _secondVector);
    }

    [Test]
    public void SecondAddByteReturnsCorrectTypes()
    {
        Add<SecondAtom, ByteAtom, SecondAtom>(_secondAtom, _byteAtom);
        Add<SecondAtom, ByteVector, SecondVector>(_secondAtom, _byteVector);
        Add<SecondVector, ByteAtom, SecondVector>(_secondVector, _byteAtom);
        Add<SecondVector, ByteVector, SecondVector>(_secondVector, _byteVector);
    }

    [Test]
    public void SecondAddShortReturnsCorrectTypes()
    {
        Add<SecondAtom, ShortAtom, SecondAtom>(_secondAtom, _shortAtom);
        Add<SecondAtom, ShortVector, SecondVector>(_secondAtom, _shortVector);
        Add<SecondVector, ShortAtom, SecondVector>(_secondVector, _shortAtom);
        Add<SecondVector, ShortVector, SecondVector>(_secondVector, _shortVector);
    }

    [Test]
    public void SecondAddIntReturnsCorrectTypes()
    {
        Add<SecondAtom, IntAtom, SecondAtom>(_secondAtom, _intAtom);
        Add<SecondAtom, IntVector, SecondVector>(_secondAtom, _intVector);
        Add<SecondVector, IntAtom, SecondVector>(_secondVector, _intAtom);
        Add<SecondVector, IntVector, SecondVector>(_secondVector, _intVector);
    }

    [Test]
    public void SecondAddLongReturnsCorrectTypes()
    {
        Add<SecondAtom, LongAtom, SecondAtom>(_secondAtom, _longAtom);
        Add<SecondAtom, LongVector, SecondVector>(_secondAtom, _longVector);
        Add<SecondVector, LongAtom, SecondVector>(_secondVector, _longAtom);
        Add<SecondVector, LongVector, SecondVector>(_secondVector, _longVector);
    }

    [Test]
    public void SecondAddFloatReturnsCorrectTypes()
    {
        Add<SecondAtom, FloatAtom, SecondAtom>(_secondAtom, _floatAtom);
        Add<SecondAtom, FloatVector, SecondVector>(_secondAtom, _floatVector);
        Add<SecondVector, FloatAtom, SecondVector>(_secondVector, _floatAtom);
        Add<SecondVector, FloatVector, SecondVector>(_secondVector, _floatVector);
    }

    [Test]
    public void SecondAddDoubleReturnsCorrectTypes()
    {
        Add<SecondAtom, DoubleAtom, DoubleAtom>(_secondAtom, _doubleAtom);
        Add<SecondAtom, DoubleVector, DoubleVector>(_secondAtom, _doubleVector);
        Add<SecondVector, DoubleAtom, DoubleVector>(_secondVector, _doubleAtom);
        Add<SecondVector, DoubleVector, DoubleVector>(_secondVector, _doubleVector);
    }

    [Test]
    public void SecondAddTimestampReturnsCorrectTypes()
    {
        Add<SecondAtom, TimestampAtom, TimestampAtom>(_secondAtom, _timestampAtom);
        Add<SecondAtom, TimestampVector, TimestampVector>(_secondAtom, _timestampVector);
        Add<SecondVector, TimestampAtom, TimestampVector>(_secondVector, _timestampAtom);
        Add<SecondVector, TimestampVector, TimestampVector>(_secondVector, _timestampVector);
    }

    [Test]
    public void SecondAddMonthReturnsCorrectTypes()
    {
        Add<SecondAtom, MonthAtom, TimestampAtom>(_secondAtom, _monthAtom);
        Add<SecondAtom, MonthVector, TimestampVector>(_secondAtom, _monthVector);
        Add<SecondVector, MonthAtom, TimestampVector>(_secondVector, _monthAtom);
        Add<SecondVector, MonthVector, TimestampVector>(_secondVector, _monthVector);
    }

    [Test]
    public void SecondAddDateReturnsCorrectTypes()
    {
        Add<SecondAtom, DateAtom, TimestampAtom>(_secondAtom, _dateAtom);
        Add<SecondAtom, DateVector, TimestampVector>(_secondAtom, _dateVector);
        Add<SecondVector, DateAtom, TimestampVector>(_secondVector, _dateAtom);
        Add<SecondVector, DateVector, TimestampVector>(_secondVector, _dateVector);
    }

    [Test]
    public void SecondAddTimespanReturnsCorrectTypes()
    {
        Add<SecondAtom, TimespanAtom, TimespanAtom>(_secondAtom, _timespanAtom);
        Add<SecondAtom, TimespanVector, TimespanVector>(_secondAtom, _timespanVector);
        Add<SecondVector, TimespanAtom, TimespanVector>(_secondVector, _timespanAtom);
        Add<SecondVector, TimespanVector, TimespanVector>(_secondVector, _timespanVector);
    }

    [Test]
    public void SecondAddMinuteReturnsCorrectTypes()
    {
        Add<SecondAtom, MinuteAtom, SecondAtom>(_secondAtom, _minuteAtom);
        Add<SecondAtom, MinuteVector, SecondVector>(_secondAtom, _minuteVector);
        Add<SecondVector, MinuteAtom, SecondVector>(_secondVector, _minuteAtom);
        Add<SecondVector, MinuteVector, SecondVector>(_secondVector, _minuteVector);
    }

    [Test]
    public void SecondAddSecondReturnsCorrectTypes()
    {
        Add<SecondAtom, SecondAtom, SecondAtom>(_secondAtom, _secondAtom);
        Add<SecondAtom, SecondVector, SecondVector>(_secondAtom, _secondVector);
        Add<SecondVector, SecondAtom, SecondVector>(_secondVector, _secondAtom);
        Add<SecondVector, SecondVector, SecondVector>(_secondVector, _secondVector);
    }
}
