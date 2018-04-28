using System;

public class StartUp
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = int.Parse(Console.ReadLine());
            var box = new Box<int>(input);
            Console.WriteLine(box);
        }
    }
}