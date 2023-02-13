// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void SumLines(int[,] matrix)
{
    int ruw = 0;
    int sum = 0;
    int minSum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j]; 
            if (i == 0 && j == matrix.GetLength(1)-1) minSum = sum;                                   
        }
        if (sum < minSum && i > 0) 
        {
            minSum = sum;
            ruw = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Минимальная сумма находится в {ruw+1} строке и равна {minSum}");
}




int[,] Create2DArray (int lines, int column, int rangeMin, int rangeMax)
{
    int[,] array = new int[lines, column];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j]= new Random().Next(rangeMin, rangeMax+1); 
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

void main()
{
    int[,] newArray = Create2DArray (3,4,0,10);
    PrintArray(newArray);
    SumLines(newArray);
}

main();