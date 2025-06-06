using System;
using static System.Math;

class Program
{
    static void Main()
    {
        Console.Write("Въведи две цели числа (n и k): ");
        var parts = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = parts[0], k = parts[1];

        long fact(int x)
        {
            long f = 1;
            for (int i = 2; i <= x; i++) f *= i;
            return f;
        }

        Console.WriteLine($"Пермутации: {fact(n)}");
        Console.WriteLine($"Комбинации: {fact(n) / (fact(k) * fact(n - k))}");
        Console.WriteLine($"Вариации: {fact(n) / fact(n - k)}");
    }
}
