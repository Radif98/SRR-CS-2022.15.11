﻿//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет 
//(Вывести: NO).
int n=Convert.ToInt32(Console.ReadLine());
n=System.Math.Abs(n);

if (n>99)
{
    while (n>1000)
    {
        n=n/10;
    }
    System.Console.WriteLine(n%10);
}
else
{
    System.Console.WriteLine("NO");
}