// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int ImputUser(string text)
{
    Console.Write($"{text}: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double[,] Create2DArray (int lines, int column, int rangeMin, int rangeMax)
{
    double[,] array = new double[lines, column];
    double[,] array2 = new double[lines, column];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2[i,j] = new Random().NextDouble();
            array[i,j]= new Random().Next(rangeMin, rangeMax+1);
            if (array[i,j]>= 0) array2[i,j] = Math.Round(array[i,j]+array2[i,j], 3);
            else array2[i,j] = Math.Round(array[i,j]-array2[i,j], 3);
        }
    }
    return array2;
}

void PrintArray(double[,] array)
{
       for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void main()
{
   double[,] newArray = Create2DArray(
        ImputUser("Введите количество строк"),
        ImputUser("Введите количество столбцов"),
        -10,
        10
        );
    PrintArray(newArray);
    
}

main();