using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());
        var listOfBoxes = new List<Box<string>>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = Console.ReadLine();
            var box = new Box<string>(input);
            listOfBoxes.Add(box);
        }

        var element = Console.ReadLine();
        var result = GetGreaterElementsCount(listOfBoxes, element);

        Console.WriteLine(result);
    }

    public static int GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
        where T : IComparable<T>
    {
        var result = listOfBoxes.Count(x => x.Value.CompareTo(element) > 0);
        return result;
    }
}