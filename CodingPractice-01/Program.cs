using System;

// 1. 단항 연산자
// Counter c = new Counter(5);
// Console.WriteLine(-c);
// c++;
// Console.WriteLine(c);

// public struct Counter
// {
//     public int Value;

//     public Counter(int value)
//     {
//         Value = value;
//     }

//     public static Counter operator -(Counter c)
//     {
//         return new Counter(-c.Value);
//     }

//     public static Counter operator ++(Counter c)
//     {
//         return new Counter(c.Value + 1);
//     }

//     public override string ToString()
//     {
//         return Value.ToString();
//     }
// }

// 2. 이항 연산자
// Fraction f1 = new Fraction(1, 2);
// Fraction f2 = new Fraction(1, 3);
// Console.WriteLine(f1 + f2);
// Console.WriteLine(f1 * f2);

// public struct Fraction
// {
//     public int Numerator;
//     public int Denominator;

//     public Fraction(int numerator, int denominator)
//     {
//         Numerator = numerator;
//         Denominator = denominator;
//     }

//     public static Fraction operator +(Fraction a, Fraction b)
//     {
//         int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
//         int den = a.Denominator * b.Denominator;
//         return new Fraction(num, den);
//     }

//     public static Fraction operator *(Fraction a, Fraction b)
//     {
//         return new Fraction(
//             a.Numerator * b.Numerator,
//             a.Denominator * b.Denominator
//         );
//     }

//     public override string ToString()
//     {
//         return $"{Numerator}/{Denominator}";
//     }
// }

// 3. 비교 연산자
// Money m1 = new Money(1000, "KRW");
// Money m2 = new Money(2000, "KRW");
// Console.WriteLine(m1 == m2); 
// Console.WriteLine(m1 < m2);  

// public struct Money
// {
//     public decimal Amount;
//     public string Currency;

//     public Money(decimal amount, string currency)
//     {
//         Amount = amount;
//         Currency = currency;
//     }

//     public static bool operator ==(Money a, Money b)
//     {
//         return a.Currency == b.Currency && a.Amount == b.Amount;
//     }

//     public static bool operator !=(Money a, Money b)
//     {
//         return !(a == b);
//     }

//     public static bool operator <(Money a, Money b)
//     {
//         if (a.Currency != b.Currency)
//         {
//             throw new InvalidOperationException("통화가 다릅니다.");
//         }
//         return a.Amount < b.Amount;
//     }

//     public static bool operator >(Money a, Money b)
//     {
//         if (a.Currency != b.Currency)
//         {
//             throw new InvalidOperationException("통화가 다릅니다.");
//         }
//         return a.Amount > b.Amount;
//     }

//     public override bool Equals(object obj)
//     {
//         if (obj is Money other)
//         {
//             return this == other;
//         }
//         return false;
//     }

//     public override int GetHashCode()
//     {
//         return HashCode.Combine(Amount, Currency);
//     }
// }

// 4. 복합 대입 연산자
// Vector2 v = new Vector2(1, 2);
// v += new Vector2(3, 4);
// Console.WriteLine(v);

// public struct Vector2
// {
//     public float X;
//     public float Y;

//     public Vector2(float x, float y)
//     {
//         X = x;
//         Y = y;
//     }

//     // + 연산자만 정의
//     public static Vector2 operator +(Vector2 a, Vector2 b)
//     {
//         return new Vector2(a.X + b.X, a.Y + b.Y);
//     }

//     public override string ToString()
//     {
//         return $"({X}, {Y})";
//     }
// }

// 5. 암시적 변환
// Celsius temp = 36.5;
// double value = temp;
// Console.WriteLine(value);

// public struct Celsius
// {
//     public double Degrees;

//     public Celsius(double degrees)
//     {
//         Degrees = degrees;
//     }

//     public static implicit operator double(Celsius c)
//     {
//         return c.Degrees;
//     }

//     public static implicit operator Celsius(double d)
//     {
//         return new Celsius(d);
//     }
// }