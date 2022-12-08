// Показать натуральные числа от N до 1, N задано

void Loop(int N, int i)
{
    if (N>=i)
    {
        System.Console.Write(N+" ");
        Loop(N-1,i);
    }
}
int N=10;
int i=1;
Loop(N,i);