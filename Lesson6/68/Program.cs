// Написать программу, которая обменивает элементы первой строки и последней строки
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

void ChangeColumns(int[,] a)
{
    int b;
    for(int i=0;i<a.GetLength(1);i++) 
        {
            for(int j=0;j<a.GetLength(0);j++)
                if(i==0)
                {
                    b=a[i,j];
                    a[i,j]=a[a.GetLength(1)-1,j];
                    a[a.GetLength(1)-1,j]=b;
                }
        }           
}


int[,] a=Random2DArray(5,7);
Print2DArray(a);
ChangeColumns(a);
System.Console.WriteLine();
Print2DArray(a);


