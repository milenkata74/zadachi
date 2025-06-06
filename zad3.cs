using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведи 9 числа за 3x3 матрица:");
        double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

        if (input.Length != 9)
        {
            Console.WriteLine("Трябва точно 9 числа.");
            return;
        }

        double[,] m = new double[3, 3];
        for (int i = 0; i < 9; i++)
            m[i / 3, i % 3] = input[i];

        double det = m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                     m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                     m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        Console.WriteLine($"Детерминанта: {det:F2}");
    }
}
