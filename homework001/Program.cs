Console.Write("Введите число a: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int second_number = int.Parse(Console.ReadLine());
int max = first_number;

if (first_number < second_number)
{
    max = second_number ;
}
Console.Write($"a={first_number};");
Console.Write($" b={second_number};");
Console.Write($" -> max={max};");