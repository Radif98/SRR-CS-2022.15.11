﻿// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int n;
do
{
    System.Console.Write("Введите число от 10 до 99: ");
    n=Convert.ToInt32(Console.ReadLine());
}
while(n<10 || n>99);
int d1=n/10;
int d2=n%10;
int max;
if (d1>d2) max=d1; else max=d2;
System.Console.WriteLine($"Наибольшая цифра чиcла = {max}");
