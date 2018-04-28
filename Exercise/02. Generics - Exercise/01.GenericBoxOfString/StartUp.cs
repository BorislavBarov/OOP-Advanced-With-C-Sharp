using System;

public class StartUp
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var input = Console.ReadLine();
            var box = new Box<string>(input);
            Console.WriteLine(box);
        }
    }
}