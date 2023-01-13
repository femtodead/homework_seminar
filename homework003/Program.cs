Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2 == 0)
{
    Console.WriteLine($"{number}->да");
}
else
{
    Console.WriteLine($"{number}->нет");
}
