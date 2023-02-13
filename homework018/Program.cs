// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.

// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

Console.Clear();

int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size ; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] SumElOddPositions (int[] array)
{   
    int num = 0;
    for (int i = 0; i < array.Length-i; i++)
    {
        for (int j = 0; j < array.Length-1; j++)
        {
        if (array[j] > array[j+1])
            {
                num = array[j+1];
                array[j+1] = array[j];
                array[j] = num;
            }
        }
    }
    return array;
}

void main()
{
    int[] newArray = GetRandomArray (9, -10, 10);
    Console.WriteLine($"До сортировки: [{string.Join(" ", newArray)}]");
    SumElOddPositions (newArray);
}
main();