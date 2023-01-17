// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число обозначающие день недели: ");
int num = int.Parse(Console.ReadLine());

if ( num < 1 || num > 7)
{
   Console.WriteLine("Такого дня недели не существует");
}
else 
{
    if (num <= 6)
    {
        Console.WriteLine("Будни");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}
