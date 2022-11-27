﻿// Написать программу замены элементов массива на противоположные
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
void Change(int[] a)
    {
      for (int i = 0; i < a.Length; ++i)
         a[i] = -a[i];
    }
 
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray();
Console.Write("Исходный массив:");
      Print(a);
      Change(a);
      System.Console.WriteLine();
Console.Write("Измененный массив:");
      Print(a);

