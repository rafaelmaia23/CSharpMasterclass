Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");

int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(@"What do you want to do with those numbers?
[A]dd
[S]ubtract
[M]ultiply
");

string operation = Console.ReadLine().ToLower();

switch (operation)
{
    case "a":
        Console.WriteLine($"{number1} + {number2} = {(number1 + number2)}");
        break;
    case "s":
        Console.WriteLine($"{number1} - {number2} = {(number1 - number2)}");
        break;
    case "m":
        Console.WriteLine($"{number1} * {number2} = {(number1 * number2)}");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
