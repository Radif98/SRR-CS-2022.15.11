// Показать натуральные числа от 1 до N, N задано
void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.Write(i+" ");
        Loop(N,i+1);

    }    
}

int N=10;
Loop(N,1);