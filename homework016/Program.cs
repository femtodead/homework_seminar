// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

void SumElOddPositions (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов стоящих на нечетных позиций равна: {sum}");
}

void main()
{
    int[] newArray = GetRandomArray (10, 0, 10);
    Console.WriteLine($"[{string.Join(" ", newArray)}]");
    SumElOddPositions (newArray);
}
main();