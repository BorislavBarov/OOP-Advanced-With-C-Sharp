using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());
        var listOfBoxes = new List<Box<int>>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = int.Parse(Console.ReadLine());
            var box = new Box<int>(input);
            listOfBoxes.Add(box);
        }

        var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SwapElements(listOfBoxes, indexes[0], indexes[1]);

        foreach (var box in listOfBoxes)
        {
            Console.WriteLine(box);
        }
    }

    private static void SwapElements<T>(List<Box<T>> listOfBoxes, int firstIndex, int secondIndex)
    {
        var tempBox = listOfBoxes[firstIndex];
        listOfBoxes[firstIndex] = listOfBoxes[secondIndex];
        listOfBoxes[secondIndex] = tempBox;
    }
}