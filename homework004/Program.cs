Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"{number}->");

for (int count = 0; count<number-1; count++) 
{
 if (count%2 == 0) 
 {
   Console.Write($"{count}");
 }
 else
 {
   Console.Write(",");
 }
}