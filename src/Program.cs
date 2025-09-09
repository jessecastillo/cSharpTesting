// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to .NET 9! Enjoy your stay!");

int num = -1;
bool valid = false;

string so = "By the way...";


while (!valid)
{
    Console.WriteLine("Enter  a number from 0 to 9:");

    try
    {
        var line = Console.ReadLine();
        num = int.Parse(line!);
        if (num < 0 || num > 9)
        {
            Console.WriteLine("Please enter 0-9 only.");
            continue;
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Thats's not a valid number. Please enter digits only.");
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("You didn't type anything!");
    }
}


int[] devNums = { 0, 2, 4, 6, 8 };

if (devNums.Contains(num))
{
    Console.WriteLine($"{so} you ARE a developer!");
}
else
{
    Console.WriteLine($"{so} you ARE NOT a developer! Sorry :(");
}

Console.WriteLine("The program has finished, you may press any key to exit :-)");
Console.ReadKey(true);