// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
int UserInput(string text)
{
Console.Write($"{text}: ");
int height = int.Parse(Console.ReadLine()!);
return height;

}

void Tree(int count)
{
    
    string[] t = new string[2*count];
    for ( int i=0; i<2*count; i++)
    {
        t[i]= " ";
    }
    t[count]= "*";
    for ( int i=0; i<count; i++)
    {
        t[count-i] = "*";
        t[count+i] = "*";
        Console.WriteLine(String.Join("", t));
    }
}

void main()
{
Console.Clear();
int numder = UserInput("Введите высоту ёлочки");
Tree(numder);
}

main();