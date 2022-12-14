/*90. Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
//Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
Пример:
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
cd
выходные данные:
1, 7, 0, 1
 
То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.
Какие ошибки могут возникнуть при обработке наборов данных?
*/
 int[] ArrayData(int n)
{
    int[] a=new int[n];
    for(int i=0;i<n;i++) 
        a[i]=int.Parse(Console.ReadLine());
    return a;
}

//int[] BinToDec(int[] a)
   
int[] ArrayInfo(int[] c)
{
    int[] b=new int[c.Length];
    for(int i=0;i<c.Length;i++)
        b[i]=Convert.ToInt32(Math.Log2(c[i]));
    return b;
}

void PrintArray(int n, int[] a, int[] b, int[] c)
{
    for(int i=0;i<n;i++)
        {
        System.Console.Write($"{a[i],4}");
        }
    System.Console.WriteLine();
    for(int i=0;i<n;i++)
        {
            System.Console.Write($"{b[i],4}");
        }
    System.Console.WriteLine();    
    for(int i=0;i<n;i++)
        {
            System.Console.Write($"{c[i],4}");
        }
    
}



int n=5;
Console.WriteLine("Вводите числа BIN");
int[] a=ArrayData(n);
int[] b=ArrayInfo(c);
//int[] c=BinToDec(a);
PrintArray(n, a, b, c);








