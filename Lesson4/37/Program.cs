// Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел
int[] RandomIntArray(int size=10,int min=100,int max=999)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int CountOdd(int[] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2!=0)
            count++;
    return count;
}

int CountOur(int[] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]%2==0)
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
System.Console.WriteLine("Количество нечетных чисел в массиве= " + CountOdd(a));
System.Console.WriteLine();
System.Console.WriteLine("Количество четных чисел в массиве= " + CountOur(a));