// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Random2DArray(int n,int m,int min=0,int max=10)
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

void SumLine(int[,] a)
{
    int s=0;
    int k=0;
    int min=0;
    for(int i=0;i<a.GetLength(0);i++)
    {    
        for(int j=0;j<a.GetLength(1);j++)
            {
                s=s+a[i,j];
            }
        k++;
        System.Console.WriteLine($"{k}- {s}");
        if(i==0) min=s;
        if(s<min)
            {
                min=s;
            }
        s=0;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{min}");
}
int[,] a=Random2DArray(7,5);
Print2DArray(a);
System.Console.WriteLine();
SumLine(a);
