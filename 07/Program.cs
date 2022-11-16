// Выяснить является ли число чётным.
Console.Write("введите число:");
int N=Convert.ToInt32(Console.ReadLine());
{
    if (N%2==0)
    {
        Console.Write($"{N} -число является четным");
    }
    else
    {
        Console.WriteLine($"{N} -ваше число нечетное");
 
    }
}