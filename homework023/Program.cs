// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int ImputUser(string text)
{
    Console.Write($"{text}: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintArray(int[,] array)
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

void PositionСheck(int[,] array, int position)
{
    int num = 0;
    int count = 0;
    if (array.GetLength(0)*array.GetLength(1)< position || position <= 0) Console.WriteLine($"{position}-го элемента в массиве несуществует");
    else
    {   for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if (count < position) 
                {
                num = array[i,j];
                count++;
                }
                else break;
            }
        }
    Console.WriteLine($"{position} элемент в массиве есть и равен {num}");
    }
}

void main()
{   
    int[,] newArray = Create2DArray(10,10,-10,10);
    PrintArray(newArray);
    PositionСheck(newArray, ImputUser("Введите позицию элемента массива"));
}
main();