// Вывести на экран числа от -N до N
Console.Write("введите число -N:");
double K=Convert.ToInt32(Console.ReadLine());
Console.Write("введите число N:");
double N=Convert.ToInt32(Console.ReadLine());
double i=K;
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
}
