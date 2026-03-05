using System;
using System.Diagnostics.CodeAnalysis;

struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int gold, int silver)
    {
        Gold = gold + silver / 100;
        Silver = silver % 100;
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b) => new GameCurrency(a.Gold + b.Gold, a.Silver + b.Silver);
    public static GameCurrency operator -(GameCurrency a, GameCurrency b) => new GameCurrency(0, Math.Max(0, a.GetTotalSilver() - b.GetTotalSilver()));
    public static bool operator ==(GameCurrency a, GameCurrency b) => a.Equals(b);
    public static bool operator !=(GameCurrency a, GameCurrency b) => !(a == b);
    public static bool operator <(GameCurrency a, GameCurrency b) => a.GetTotalSilver() < b.GetTotalSilver();
    public static bool operator >(GameCurrency a, GameCurrency b) => !(a < b);

    public override string ToString() => $"{Gold}G {Silver}S";

    public int GetTotalSilver() => Gold * 100 + Silver;

    public override bool Equals([NotNullWhen(true)] object obj) => obj is GameCurrency currency ? Gold == currency.Gold && Silver == currency.Silver : false;

    public override int GetHashCode() => base.GetHashCode();
}