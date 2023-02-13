// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArray (int lines, int column, int width, int rangeMin, int rangeMax)
{
    int[,,] array = new int[lines, column, width];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < width; k++)
            {
                array[i,j,k]= new Random().Next(rangeMin, rangeMax+1); 
            }
        }
    }
    return array;
}

int [,,] NonRecurringNumber ( int [,,] array3D)
{
    int count = 0;
    int[] arrayNumder = new int[array3D.GetLength(0)*array3D.GetLength(1)*array3D.GetLength(2)];
    
       for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                arrayNumder[count] = array3D[i,j,k];
                count++;
            }
        }
    }
    count = 0;
    Console.WriteLine(string.Join( ",", arrayNumder));
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                for (int n = 0; n < arrayNumder.Length; n++)
                {
                    if (arrayNumder[n] == array3D[i,j,k]) count++;
                    if (count > 1) 
                    {
                        array3D[i,j,k] = new Random().Next(10, 100);
                        arrayNumder[n] = array3D[i,j,k];
                        n = 0;
                        count = 0;
                    }
                }
                    count = 0;
            }
        }
    }
    return array3D;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 Console.Write($" {array[i,j,k]} ({i},{j},{k})\t "); 
            }
         Console.WriteLine();
        }
       Console.WriteLine();
    }
}

void main()
{
    int[,,] newMatrix = Create3DArray (2, 2, 2, 10, 99);
    PrintArray(newMatrix);
    NonRecurringNumber(newMatrix);
    PrintArray(newMatrix);
}

main();