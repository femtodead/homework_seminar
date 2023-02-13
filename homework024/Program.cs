// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] Create2DArray (int lines, int column, int rangeMin, int rangeMax)
{
    double[,] array = new double[lines, column];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j]= new Random().Next(rangeMin, rangeMax+1); 
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

void ArithmeticMeanColumns(double[,] array)
{
    double count = 0;
    double sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(0); j++)
            {
                count++;
                sum = sum+array[j,i];
                if (count%array.GetLength(0) == 0 && count != 0) 
                {
                    Console.WriteLine($"Среднее арефмитическое {count/array.GetLength(0)} столбца ровна {Math.Round(sum/array.GetLength(0), 3)}"); 
                    sum = 0;
                }
            }
        }
}   

void main()
{
    double[,] newArray = Create2DArray (3,4,0,10);
    PrintArray(newArray);
    ArithmeticMeanColumns(newArray);
}

main();