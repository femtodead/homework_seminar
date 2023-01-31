// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

void СheckingEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в масиве ровно: {count}");
}
void main()
{
    int[] newArray = GetRandomArray (10, 100, 999);
    Console.WriteLine($"[{string.Join(" ", newArray)}]");
    СheckingEvenNumbers (newArray);
}
main();