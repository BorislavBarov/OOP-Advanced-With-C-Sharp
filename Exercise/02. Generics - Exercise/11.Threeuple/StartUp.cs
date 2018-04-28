using System;

public class StartUp
{
    public static void Main()
    {
        var inParams = Console.ReadLine().Split(' ');
        var names = $"{inParams[0]} {inParams[1]}";
        var address = inParams[2];
        var town = inParams[3];
        var namesAdressTown = new Threeuple<string, string, string>(names, address, town);
        Console.WriteLine(namesAdressTown);

        inParams = Console.ReadLine().Split(' ');
        var name = inParams[0];
        var liters = int.Parse(inParams[1]);
        var drink = inParams[2] == "drunk";
        var nameLitersDrink = new Threeuple<string, int, bool>(name, liters, drink);
        Console.WriteLine(nameLitersDrink);

        inParams = Console.ReadLine().Split(' ');
        name = inParams[0];
        var amount = double.Parse(inParams[1]);
        var bank = inParams[2];
        var nameAmountBank = new Threeuple<string, double, string>(name, amount, bank);
        Console.WriteLine(nameAmountBank);
    }
}