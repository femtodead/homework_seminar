// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string UserInput(string text)
{
 Console.Write($"{text}: ");
 string numbers = Console.ReadLine();
 return numbers;
}

int[] ArrayNumbers(string BunchOfNumbers)
{
char[] separators = new char[] {',', ' '};
string[] array = BunchOfNumbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    newArray[i] = int.Parse(array[i]);
}
return newArray;
}

void NumberPositiveArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++; 
    }
    Console.Write($" чисел больше нуля в масеве {count} штук");
}

void main()
{
Console.Clear();
string num = UserInput("Введите цифры через запятую и пробел");
Console.Write($"[{String.Join(",", ArrayNumbers(num))}]");
NumberPositiveArray(ArrayNumbers(num));
}

main();