Console.Write("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int third_number = int.Parse(Console.ReadLine()!);
int max = first_number;

if (max < second_number)
{
    max = second_number ;
}
if (max < third_number)
{
    max = third_number ;
}
Console.Write($"{first_number},");
Console.Write($"{second_number},");
Console.Write($"{third_number},");
Console.Write($" -> {max};");