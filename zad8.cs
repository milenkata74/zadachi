using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] counts = new int[6];
        int trials = 100000;

        for (int i = 0; i < trials; i++)
        {
            int roll = rand.Next(1, 7); // зар 1 до 6
            counts[roll - 1]++;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            double probability = (double)counts[i] / trials * 100;
            Console.WriteLine($"Число {i + 1}: {probability:F2}%");
        }
    }
}
