// generate various tick-related values

foreach (var dt in new DateTimeOffset[] {
    DateTimeOffset.MinValue,
    DateTimeOffset.MaxValue,
    DateTimeOffset.UnixEpoch,
    new DateTimeOffset(int.MaxValue, TimeSpan.Zero),
    new (1970, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2000, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2010, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2020, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2021, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2022, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2023, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2024, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2025, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2027, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2028, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2029, 1, 1, 0, 0, 0, TimeSpan.Zero),
    new (2030, 1, 1, 0, 0, 0, TimeSpan.Zero),
    })
    Console.WriteLine($"{dt:o} => {dt.UtcTicks:n0}");

Console.WriteLine($"microsecond: {TimeSpan.TicksPerMicrosecond:n0}");
Console.WriteLine($"ms: {TimeSpan.TicksPerMillisecond:n0}");
Console.WriteLine($"sec: {TimeSpan.TicksPerSecond:n0}");
Console.WriteLine($"minute: {TimeSpan.TicksPerMinute:n0}");
Console.WriteLine($"hour: {TimeSpan.TicksPerHour:n0}");
Console.WriteLine($"day: {TimeSpan.TicksPerDay:n0}");
Console.WriteLine($"365days: {TimeSpan.TicksPerDay * 365:n0}");