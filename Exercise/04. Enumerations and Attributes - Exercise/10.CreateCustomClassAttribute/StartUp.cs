using System;
using System.Linq;

[Info("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
public class StartUp
{
    public static void Main()
    {
        string input = string.Empty;

        var attr = (InfoAttribute)typeof(StartUp).GetCustomAttributes(true).First();

        while ((input = Console.ReadLine()) != "END")
        {
            attr.PrintInfo(input);
        }
    }
}