// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int UserInput(string text)
{
 Console.Write($"{text}: ");
 int numbers = int.Parse(Console.ReadLine());
 return numbers;
}

void IntersectionPoint(double k1,double b1,double k2,double b2)
{
    if (k1==k2)
    {
        if (b1==b2) Console.Write("Прямые совпадают");
        else Console.Write("Прямые паралельны");
    }
    else
    {
    double x = (b2-b1)/(k1-k2) ; 
    double y = k2*x+b2    ;
    Console.Write($"Точка пересечения равна : ({x};{y}) ");
    }
}

void main()
{
    int k1 = UserInput("Введите переменную k1");
    int b1 = UserInput("Введите переменную b1");
    int k2 = UserInput("Введите переменную k2");
    int b2 = UserInput("Введите переменную b2");
    IntersectionPoint(k1,b1,k2,b2);
}
main();