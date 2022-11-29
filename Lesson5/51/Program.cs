// С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры
//массивы - это объекты
int[] Array(int n)
{
int[] t=new int[n];//создаем массив, то есть в t помещаем адрес массива
//заполнить массив
for(int i=0;i<n;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
    return t;
}

int Count(int[] t)
{
    int count=0;
    for(int i=0; i<t.Length; i++)
        if (t[i]>0) count++;
    return count;
}
void Print(int[] t)
{
    for(int i=0;i<t.Length;i++)
        System.Console.Write($"{t[i],5}");
}
System.Console.Write("Введите число N:");
int n=Convert.ToInt32(Console.ReadLine());
int[] a=Array(n);
Print(a);
Count(a);
System.Console.WriteLine();
System.Console.WriteLine($"Числа больше 0= {Count(a)}");
