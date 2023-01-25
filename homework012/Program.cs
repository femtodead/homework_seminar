// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
int UserInput(string text)
{
 Console.Write($"{text}: ");
 int num = int.Parse(Console.ReadLine()!);
 return num;
}

int SumNumbers (int n)
{
    int sum = 0;
    if (n<0) n=n*-1;
    for (int i = 0; n > 0; i++)
    {
        sum=n%10+sum;
        n=n/10;
    }
    return sum;
}

void main()
{
int tally = UserInput("Введите число");
Console.WriteLine($"Сумма всех цифр в числе равна: {SumNumbers(tally)}");
}

main();

