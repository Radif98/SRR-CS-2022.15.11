﻿// Задать массив из 8 целых элементов и вывести их на экран
// Для удобства выставил диапозон с 0 до 50 
int[] RandomIntArray(int size=8,int min=0,int max=50)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],7}");
}

int[] a=RandomIntArray();
Print(a);



