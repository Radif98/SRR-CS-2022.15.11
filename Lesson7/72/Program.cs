// Показать натуральные числа от M до N, N и M заданы

void Loop(int N, int M)
{
    if (M<=N)
    {
        System.Console.Write(M+" ");
        Loop(N,M+1);
    }
}
int N=30;
int M=10;
Loop(N,M);
