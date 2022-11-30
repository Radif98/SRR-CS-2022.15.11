// Написать программу копирования массива
int[] RandomIntArray(int size=10,int min=0,int max=50)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int[] Array2(int[] a)
{
int[] b=new int[a.Length];
for(int i=0;i<a.Length;i++)
    b[i]=a[i];
    return b;
}

void Print1(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}    

void Print2(int[] b)
{
    for(int i=0;i<b.Length;i++)
        System.Console.Write($"{b[i],5}");
} 

int[] a=RandomIntArray();
Print1(a);
int[] b=Array2(a);
System.Console.WriteLine();
Print2(b);
