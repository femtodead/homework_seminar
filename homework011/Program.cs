// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

 // 2, 4 -> 16

Console.Clear();
int UserInput(string text)
{
 Console.Write($"{text}: ");
 int n1 = int.Parse(Console.ReadLine()!);
 return n1;
}

 int PowerUp(int number, int degree)
 {
 int power = 1;
    for (int i = 0; i<degree; i++)
    {
    power=power*number;
    }
 return power;
 } 
 
void main()
{
int a = UserInput("Введите число");
int b = UserInput("Введите степень");
Console.Write($"Результат: {PowerUp(a, b)}");
}

main();