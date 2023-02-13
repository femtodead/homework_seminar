// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] OrderInMatrix(int[,] matrix)
{
 int temp;
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,k] < matrix[i,k-1])
                {
                temp = matrix[i,k-1];
                matrix[i,k-1] = matrix[i,k];
                matrix[i,k] = temp;
                }  
            }
        }
    }
    return matrix;
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
    newArray = OrderInMatrix(newArray);
    Console.WriteLine("После сортировки");
    PrintArray(newArray);
}

main();