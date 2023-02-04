// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

int[,] GetRandomArray (int size, int height, int minValue, int maxValue)
{
    int[,] array = new int[size, height];
    for (int i = 0; i < size ; i++)
    {
        for (int j = 0; j < height ; j++)
        {
        array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

string[,] ConvertArrayToString(int[,] array)
{
string[,] newArray = new string[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    newArray[i,j] = Convert.ToString(array[i,j]);
    }
}
return newArray;
}


void FillImage (string[,] array, int[] newArray )
{
    if (array[ aarray.GetLength(0), 0] != string.Empty;)
    {
        newArray[0]= int.Parse(array[ aarray.GetLength(0), 0])
        array[ row, col] = string.Empty;
        FillImage( row-1,  col+1 );
        FillImage( row,  col-1 );
        FillImage( row+1,  col );
        FillImage(row,  col+1 );
    }
}

void СonvertingToAOneDimensionalArray(string[,] array)
{
    int row = array.GetLength(0);
    int col = 0;
    int newArray = new int[array.GetLength(0)*array.GetLength(1)]
  wile (col < array.GetLength(1))
  {
    if(array[row, col] != string.Empty)
    {
        newArray[i] = int.Parse(array[row, col]);
        array[row, col] = string.Empty;
    }
    col++;
  }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i< matr.GetLength(0); i++ )
    {
        for (int j = 0;j<matr.GetLength(1); j++ ) 
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] newArray = GetRandomArray(4,4,1,99);
PrintArray(newArray);
ConvertArrayToString(newArray);
