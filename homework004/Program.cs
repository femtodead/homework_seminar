Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write($"{number}->");

for (int count = 1; count<=number; count++) 
{
 if (count%2 == 0) 
 {
   Console.Write($"{count} | ");
 }
}