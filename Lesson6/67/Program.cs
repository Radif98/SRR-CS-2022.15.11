// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Random2DArray(int n,int m,int min=0,int max=100)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void SumColumns(int[,] a)
{
    double s=0;
    for(int j=0;j<a.GetLength(1);j++)
    {    
        for(int i=0;i<a.GetLength(0);i++)
            {
                s=s+a[i,j];
            } 
        System.Console.WriteLine(s/a.GetLength(0));
        s=0;
    }   

}

int[,] a=Random2DArray(5,6);
Print2DArray(a);
SumColumns(a);


