// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    double[] array1 = new double[size];
    double[] array2 = new double[size];
    for (int i = 0; i < size ; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array1[i] = new Random().NextDouble();
        array2[i] = Math.Round(array[i]+array1[i], 4);
    }
    return array2;
}

void DifferenceMinMax(double[] array)
{
    double difference = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }

    difference = max-min;
    Console.WriteLine($"Разница минимального и максимального элемента в массиве равна: {difference}");
}

void main()
{
    double[] newArray = GetRandomArray (10, -10, 10);
    Console.WriteLine($"[{string.Join(" ", newArray)}]");
    DifferenceMinMax (newArray);
}
main();

