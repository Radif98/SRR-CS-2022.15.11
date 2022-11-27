// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=123,int min=0,int max=1000)

{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int Count(int[] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>11 & a[i]<100)
            count++;
    return count;
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine("количество элементов из отрезка [10,99]= " + Count(a));
