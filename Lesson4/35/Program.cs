// Написать программу замены элементов массива на противоположные
int[] RandomIntArray(int size=10,int min=0,int max=50)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
/*
int ElementReplacement(int[] a)
{
    for(int i; i<10; i++)
        a=a[i]*-1;
    return a;
}
*/
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();



