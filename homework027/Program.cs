// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixProduct(int[,] matrix, int[,] matrix1)
{
    int[,] multiplication = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < multiplication.GetLength(0); i++)
    {
        for (int j = 0; j < multiplication.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                multiplication[i,j] += matrix[i,k]*matrix1[k,j];   
            }                              
        }
       
    }
    return multiplication;
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
    int[,] newMatrix = Create2DArray (3,4,0,10);
    PrintArray(newMatrix);
    Console.WriteLine();
    int[,] newMatrix1 = Create2DArray (4,3,0,10);
    PrintArray(newMatrix1);
    Console.WriteLine();
    int[,] newMatrix2 = MatrixProduct(newMatrix, newMatrix1);
    PrintArray(newMatrix2);
}

main();