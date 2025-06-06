using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведи число: ");
        string number = Console.ReadLine();
        Console.Write("От коя бройна система (напр. 10): ");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("В коя бройна система (напр. 2): ");
        int toBase = int.Parse(Console.ReadLine());

        try
        {
            int decimalValue = Convert.ToInt32(number, fromBase);
            string result = Convert.ToString(decimalValue, toBase).ToUpper();
            Console.WriteLine($"Резултат: {result}");
        }
        catch
        {
            Console.WriteLine("Невалидно число или основа.");
        }
    }
}
