using System.Text;

namespace SharpDB.Data.Extensions;

public static class TimeExtensions
{
    public static string ToTimestampString(this long nanoseconds)
    {
        var days = nanoseconds / 86_400_000_000_000 - (nanoseconds < 0 ? 1 : 0);
        var stringBuilder = new StringBuilder($"{((int)days).ToDateString()}D");

        nanoseconds -= days * 86_400_000_000_000;
        var hours = nanoseconds / 3_600_000_000_000;
        stringBuilder.Append($"{hours}:".PadLeft(3, '0'));

        nanoseconds -= hours * 3_600_000_000_000;
        var minutes = nanoseconds / 60_000_000_000;
        stringBuilder.Append($"{minutes}:".PadLeft(3, '0'));

        nanoseconds -= minutes * 60_000_000_000;
        var seconds = nanoseconds / 1_000_000_000;
        stringBuilder.Append($"{seconds}.".PadLeft(3, '0'));

        nanoseconds -= seconds * 1_000_000_000;
        stringBuilder.Append($"{nanoseconds}".PadLeft(9, '0'));

        return stringBuilder.ToString();
    }

    public static string ToMonthString(this int months)
    {
        months += 24000;
        var year = months / 12;
        var month = months - year * 12 + 1;
        return $"{year}.{$"{month}".PadLeft(2, '0')}";
    }

    public static string ToDateString(this int days)
    {
        days += 730425;
        var era = (days >= 0 ? days : days - 146096) / 146097;
        var doe = days - era * 146097;
        var yoe = (doe - doe / 1460 + doe / 36524 - doe / 146096) / 365;
        var y = yoe + era * 400;
        var doy = doe - (365 * yoe + yoe / 4 - yoe / 100);
        var mp = (5 * doy + 2) / 153;
        var d = doy - (153 * mp + 2) / 5 + 1;
        var m = mp < 10 ? mp + 3 : mp - 9;
        return $"{y + (m <= 2 ? 1 : 0)}.{$"{m}".PadLeft(2, '0')}.{$"{d}".PadLeft(2, '0')}";
    }

    public static string ToTimespanString(this long nanoseconds)
    {
        var stringBuilder = new StringBuilder(nanoseconds < 0 ? "-" : "");
        nanoseconds = Math.Abs(nanoseconds);

        var days = nanoseconds / 86_400_000_000_000;
        stringBuilder.Append($"{days}D");

        nanoseconds -= days * 86_400_000_000_000;
        var hours = nanoseconds / 3_600_000_000_000;
        stringBuilder.Append($"{hours}:".PadLeft(3, '0'));

        nanoseconds -= hours * 3_600_000_000_000;
        var minutes = nanoseconds / 60_000_000_000;
        stringBuilder.Append($"{minutes}:".PadLeft(3, '0'));

        nanoseconds -= minutes * 60_000_000_000;
        var seconds = nanoseconds / 1_000_000_000;
        stringBuilder.Append($"{seconds}.".PadLeft(3, '0'));

        nanoseconds -= seconds * 1_000_000_000;
        stringBuilder.Append($"{nanoseconds}".PadLeft(9, '0'));

        return stringBuilder.ToString();
    }

    public static string ToMinuteString(this int minutes)
    {
        var stringBuilder = new StringBuilder(minutes < 0 ? "-" : "");
        minutes = Math.Abs(minutes);

        var hours = minutes / 60;
        stringBuilder.Append($"{hours}:".PadLeft(3, '0'));

        minutes -= hours * 60;
        stringBuilder.Append($"{minutes}".PadLeft(2, '0'));

        return stringBuilder.ToString();
    }

    public static string ToSecondString(this int seconds)
    {
        var stringBuilder = new StringBuilder(seconds < 0 ? "-" : "");
        seconds = Math.Abs(seconds);

        var hours = seconds / 3600;
        stringBuilder.Append($"{hours}:".PadLeft(3, '0'));

        seconds -= hours * 3600;
        var minutes = seconds / 60;
        stringBuilder.Append($"{minutes}:".PadLeft(3, '0'));

        seconds -= minutes * 60;
        stringBuilder.Append($"{seconds}".PadLeft(2, '0'));

        return stringBuilder.ToString();
    }
}