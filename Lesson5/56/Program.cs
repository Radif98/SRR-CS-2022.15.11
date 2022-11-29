// Написать программу копирования массива
int[] Array1(int n)
{
int[] a=new int[n];
for(int i=0;i<n;i++)
    a[i]=Convert.ToInt32(Console.ReadLine());
    return a;
}

int[] Array2(int n)
{
int[] b=new int[n];
for(int i=0;i<n;i++)
    b[i]=Convert.ToInt32(Console.ReadLine());
    return b;
}

int[] Copy(int n)
{
int[] c=new int[n];    
for(int i=0;i<n;i++) 
  c[i]=Array.Copy( Array1, Array1.GetLowerBound(i), Array2, Array2.GetLowerBound(i), n );
  return c;
}

void Print(int[] a, int[] b)
{
    for(int i=0;i<n;i++)
        System.Console.Write($"{a[i],5}");
        System.Console.Write($"{b[i],5}");
        System.Console.Write($"{c[i],5}");
}    
   

System.Console.Write("Введите размер массива N:");
int n=Convert.ToInt32(Console.ReadLine());
int[] a=Array1(n);
int[] b=Array1(n);
int[] c=Copy(n);
Print(a,b,c);
