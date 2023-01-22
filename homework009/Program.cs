// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату x для первой точки: ");
int x = int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату y для первой точки: ");
int y = int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату z для первой точки: ");
int z = int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату x для второй точки: ");
int x1 = int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату y для второй точки: ");
int y1 = int.Parse(Console.ReadLine ()!);
Console.Write("Введите координату z для второй точки: ");
int z1 = int.Parse(Console.ReadLine ()!);

double distance = Math.Sqrt(Math.Pow(x-x1, 2)+Math.Pow(y-y1, 2)+Math.Pow(z-z1, 2));

Console.Write($"Растояние между точками: {Math.Round(distance, 2 , MidpointRounding.ToZero)} "); 
