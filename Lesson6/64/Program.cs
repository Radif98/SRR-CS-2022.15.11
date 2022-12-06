// В двумерном массиве заменить элементы,
// у которых оба индекса чётные на их квадраты по значению.

int[,] Random2DArray(int n,int k)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
                a[i,j]=random.Next(0,10);
    return a;
}

void Change2DArray(int[,] a)
{
     for(int j=0;j<a.GetLength(1);j++)    
        for(int i=0;i<a.GetLength(0);i++)
            if (i%2==0 && j%2==0)
            {
                a[i,j]=Convert.ToInt32(Math.Pow(a[i,j],2)) ;
            }
}

void Print2DArray(int[,] a)
{
    for(int j=0;j<a.GetLength(0);j++)
        {
     for(int i=0;i<a.GetLength(1);i++)
        System.Console.Write($"{a[i,j],10}");
           System.Console.WriteLine();
        }
}

int[,] a=Random2DArray(5,5);
Print2DArray(a);
Change2DArray(a);
System.Console.WriteLine();
Print2DArray(a);