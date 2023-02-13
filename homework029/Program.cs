// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] Create2DArray (int lines, int column, int rangeMin, int rangeMax)
{
    int[,] array = new int[lines, column];
    int count = 1;
   while (count < lines*column)
   {
        if (count < 4)
        {
            for (int j = 0; j < column ; j++)
            {
               array[lines-1,j]= new Random().Next(rangeMin, rangeMax+1); 
               count++;
            }
        }
        if (count >= 4 && count < 7)
        {
            for (int i = lines-2; i >= 0 ; i--)
            {
               array[i,column-1]= new Random().Next(rangeMin, rangeMax+1); 
               count++;
            }
        }
        if (count >= 7 && count < 10)
        {
            for (int j = column-2; j >= 0 ; j--)
            {
               array[0,j]= new Random().Next(rangeMin, rangeMax+1); 
               count++;
            }
        }
        if (count >= 10 && count < 12)
        {
            for (int i = 1; i <= lines-2 ; i++)
            {
               array[i,0]= new Random().Next(rangeMin, rangeMax+1); 
               count++;
            }
        }
        if (count >= 12 && count < 14)
        {
            for (int j = 1; j <= lines-1 ; j++)
            {
               array[2,j]= new Random().Next(rangeMin, rangeMax+1); 
               count+= 1;
            }
        }
        if (count >= 14 )
        {
            for (int j = 2; j > 0 ; j--)
            {
               array[1,j]= new Random().Next(rangeMin, rangeMax+1); 
               count+= 1;
            }
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
    int[,] newMatrix = Create2DArray (4,4,1,10);
    PrintArray(newMatrix);

}
main();