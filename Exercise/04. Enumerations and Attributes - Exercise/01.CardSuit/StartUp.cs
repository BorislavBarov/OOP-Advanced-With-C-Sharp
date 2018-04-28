using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();
        Console.WriteLine($"{input}:");

        foreach (var value in Enum.GetValues(typeof(Suit)))
        {
            Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
        }
    }
}