// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
//Принять первые числа равными 0 и 1
int[] Array(int n)
{
int[] t=new int[n];
for(int i=0;i<2;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
        for(int j=2; j<n; j++)
            t[j]=t[j-2]+t[j-1];
    return t;
}

void Print(int[] t)
{
    for(int i=0;i<t.Length;i++)
        System.Console.Write($"{t[i],5}");
}

System.Console.Write("Введите размер массива N:");
int n=Convert.ToInt32(Console.ReadLine());
int[] a=Array(n);
Print(a);
