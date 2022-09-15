﻿namespace SharpDB.Data;

public enum DataType
{
    BooleanAtom = -1,
    BooleanVector = 1,
    GuidAtom = -2,
    GuidVector = 2,
    ByteAtom = -4,
    ByteVector = 4,
    ShortAtom = -5,
    ShortVector = 5,
    IntAtom = -6,
    IntVector = 6,
    LongAtom = -7,
    LongVector = 7,
    RealAtom = -8,
    RealVector = 8,
    FloatAtom = -9,
    FloatVector = 9,
    CharAtom = -10,
    CharVector = 10,
    SymbolAtom = -11,
    SymbolVector = 11,
    TimestampAtom = -12,
    TimestampVector = 12,
    MonthAtom = -13,
    MonthVector = 13,
    DateAtom = -14,
    DateVector = 14,
    TimespanAtom = -16,
    TimespanVector = 16,
    MinuteAtom = -17,
    MinuteVector = 17,
    SecondAtom = -18,
    SecondVector = 18,
}