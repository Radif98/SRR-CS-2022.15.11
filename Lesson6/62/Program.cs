// В двумерном массиве n×k заменить четные элементы на противоположные по значению 
//(a[i,j]=-a[i,j]). Написать отдельную подпрограмму на вход которой подается массив, 
//а на выходе измененный массив.

int[,] Random2DArray(int n,int k)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
                a[i,j]=random.Next(10,30);
    return a;
}

void Change2DArray(int[,] a)
{
    for(int j=0;j<a.GetLength(1);j++)    
        for(int m=0;m<a.GetLength(0);m++)
            for(int i=0;i<a.GetLength(0)-1;i++)
                if (a[i,j]%2==0) 
                {
                   a[i,j]=-a[i,j];                 
                }
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

int[,] a=Random2DArray(5,5);
Print2DArray(a);
Change2DArray(a);
System.Console.WriteLine();
Print2DArray(a);