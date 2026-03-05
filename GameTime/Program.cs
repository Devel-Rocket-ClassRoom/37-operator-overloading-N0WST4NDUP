using System;
using System.Diagnostics.CodeAnalysis;

GameTime t1 = new GameTime(1, 30, 45);
GameTime t2 = new GameTime(0, 45, 30);

Console.WriteLine($"시간1: {t1}");
Console.WriteLine($"시간2: {t2}");

GameTime sum = t1 + t2;
Console.WriteLine($"합계: {sum}");

GameTime diff = t2 - t1;
Console.WriteLine($"차이: {diff}");

Console.WriteLine($"시간1 == 시간2: {t1 == t2}");
Console.WriteLine($"시간1 != 시간2: {t1 != t2}");
Console.WriteLine($"시간1 > 시간2: {t1 > t2}");
Console.WriteLine($"시간1 < 시간2: {t1 < t2}");

GameTime t3 = t2 * 3;
Console.WriteLine($"시간2 x 3: {t3}");

GameTime t4 = new GameTime(0, 0, 3700);
Console.WriteLine($"3700초 정규화: {t4}");
Console.WriteLine($"시간1 총 초: {t1.GetTotalSeconds()}");
