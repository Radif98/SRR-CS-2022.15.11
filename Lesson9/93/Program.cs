// Задача 93: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
/* Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
 */


 int[,] Random2DArray1(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

int[,] Random2DArray2(int n,int m,int min=0,int max=10)
{
    int[,] b=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                b[i,j]=random.Next(min,max+1);
    return b;
}

 int[,] Op2DArray(int[,] a, int[,] b)
{
    int[,] c=new int[a.GetLength(0),a.GetLength(1)];
    for(int i=0;i<a.GetLength(0);i++)
         for(int j=0;j<a.GetLength(1);j++)
                c[i,j]=a[i,j]*b[i,j];
    return c;
} 

void Print2DArray(int[,] a, int[,] b, int[,] c)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
        for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
    System.Console.WriteLine();
    for(int i=0;i<b.GetLength(0);i++)
        {
        for(int j=0;j<b.GetLength(1);j++)
        System.Console.Write($"{b[i,j],4}");
           System.Console.WriteLine();
        }
    System.Console.WriteLine();
    for(int i=0;i<c.GetLength(0);i++)
        {
        for(int j=0;j<c.GetLength(1);j++)
        System.Console.Write($"{c[i,j],4}");
           System.Console.WriteLine();
        }
    
}



int n=5;
int m=5;
int[,] a=Random2DArray1(n,m);
int[,] b=Random2DArray2(n,m);
int[,] c=Op2DArray(a,b);
Print2DArray(a,b,c);







