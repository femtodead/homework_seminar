// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// string UserInput(string text)
string UserInput(string text)
{
 Console.Write($"{text}: ");
 string numbers = Console.ReadLine();
 return numbers;
}

string[] ArrayNumbers(string BunchOfNumbers)
{
char[] separators = new char[] {',', ' '};
string[] array = BunchOfNumbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
return array;
}

void main()
{
Console.Clear();
string num = UserInput("Введите восемь цифр чере запятую и пробел");
Console.Write($"[{String.Join(",", ArrayNumbers(num))}]");
}

main();