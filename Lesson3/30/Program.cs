// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите N:");
double N=Convert.ToInt32(Console.ReadLine());


double Op(double Number)
{
    double op=1;    
    for(int i = 1; i <= N; i++)
    {
        op=op*i;
    }
    return op;
}


System.Console.WriteLine(Op(N));