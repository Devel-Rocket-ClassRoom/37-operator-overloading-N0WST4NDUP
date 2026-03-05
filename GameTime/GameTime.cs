using System;
using System.Diagnostics.CodeAnalysis;

struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;

    public GameTime(int hour, int minute, int second)
    {
        minute += second / 60;
        second = second % 60;
        hour += minute / 60;
        minute = minute % 60;

        Hours = hour;
        Minutes = minute;
        Seconds = second;
    }

    public static GameTime operator +(GameTime a, GameTime b) => new GameTime(0, 0, a.GetTotalSeconds() + b.GetTotalSeconds());
    public static GameTime operator -(GameTime a, GameTime b) => new GameTime(0, 0, Math.Max(0, a.GetTotalSeconds() - b.GetTotalSeconds()));
    public static bool operator ==(GameTime a, GameTime b) => a.Equals(b);
    public static bool operator !=(GameTime a, GameTime b) => !(a == b);
    public static bool operator <(GameTime a, GameTime b) => a.GetTotalSeconds() < b.GetTotalSeconds();
    public static bool operator >(GameTime a, GameTime b) => !(a < b);
    public static GameTime operator *(GameTime now, int num) => new GameTime(0, 0, now.GetTotalSeconds() * num);

    public override string ToString() => $"{Hours}h {Minutes}m {Seconds}s";

    public int GetTotalSeconds() => Hours * 60 * 60 + Minutes * 60 + Seconds;

    public override bool Equals([NotNullWhen(true)] object obj)
    {
        return
            obj is GameTime time
            ?
            Hours == time.Hours && Minutes == time.Minutes && Seconds == time.Seconds
            :
            false;
    }

    public override int GetHashCode() => base.GetHashCode();
}